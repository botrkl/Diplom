using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.DTOs;
using OnlineStore.BLL.Models;
using OnlineStore.BLL.Services.Interfaces;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AuthController(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterDataDto registerData)
        {
            var userModel = _mapper.Map<UserModel>(registerData);
            var user = await _authService.Register(userModel);

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginDataDto loginData)
        {
            var userModel = _mapper.Map<UserModel>(loginData);
            var jwtBearer = await _authService.Login(userModel);

            return Ok(Results.Json(new
            {
                token = jwtBearer,
            }));
        }
    }
}