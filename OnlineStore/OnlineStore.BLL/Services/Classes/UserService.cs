using AutoMapper;
using OnlineStore.BLL.Exceptions;
using OnlineStore.BLL.Models;
using OnlineStore.BLL.Services.Interfaces;
using OnlineStore.DAL.Repositories.Interfaces;
using System.Text.RegularExpressions;

namespace OnlineStore.BLL.Services.Classes
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserModel?> GetUserByEmail(string email)
        {
            if (!IsValidEmail(email))
            {
                throw new InvalidEmailAddressException(email);
            }

            var userEntity = await _userRepository.GetUserByEmail(email);
            var userModel = _mapper.Map<UserModel>(userEntity);
            return userModel;
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-z0-9._%+\-]+@[a-z0-9.\-]+\.[a-z]{2,4}$";
            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
        }
    }
}