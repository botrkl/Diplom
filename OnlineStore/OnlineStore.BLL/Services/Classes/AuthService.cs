using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using OnlineStore.BLL.Exceptions;
using OnlineStore.BLL.Extensions;
using OnlineStore.BLL.Models;
using OnlineStore.BLL.Services.Interfaces;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.BLL.Services.Classes
{
    public class AuthService : IAuthService
    {
        private readonly IHashService _hashService;
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AuthService(IHashService hashService, IUserService userService, IUserRepository userRepository, IMapper mapper)
        {
            _hashService = hashService;
            _userRepository = userRepository;
            _mapper = mapper;
            _userService = userService;
        }

        public async Task<UserModel> Register(UserModel user)
        {
            try
            {
                await CheckUserExists(user.Email);
                throw new UserAlreadyExistsException();
            }
            catch (UserIsNotExistsException)
            {
                user.Password = _hashService.HashPassword(user.Password);
                var userEntity = _mapper.Map<User>(user);
                var resultUser = await _userRepository.AddAsync(userEntity);

                return _mapper.Map<UserModel>(resultUser);
            }
        }

        public async Task<string> Login(UserModel user)
        {
            var receivedUser = await CheckUserExists(user.Email);
            CheckPasswordValid(user.Password, receivedUser.Password);

            return GenerateToken(user);
        }

        public string GetEmailFromJwtToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);

            return jwtSecurityToken.Claims.First(claim => claim.Type == "sub").Value;
        }

        private async Task<UserModel> CheckUserExists(string email)
        {
            var receivedUser = await _userService.GetUserByEmail(email);
            if (receivedUser == null)
                throw new UserIsNotExistsException();

            return receivedUser;
        }

        private void CheckPasswordValid(string enteredPassword, string savedPassword)
        {
            var result = _hashService.VerifyPassword(enteredPassword, savedPassword);
            if (!result)
                throw new InvalidPasswordException();
        }

        private string GenerateToken(UserModel user)
        {
            var token = new JwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.Audience,
                claims: new List<Claim>
                {
                new ("userId", user.Id.ToString()),
                new ("user", user.Email),
                new (JwtRegisteredClaimNames.Sub, user.Email),
                },
                expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(300)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}