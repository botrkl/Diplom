using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.DTOs;
using OnlineStore.BLL.Services.Interfaces;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public UserController(IMapper mapper, IUserService userService, IAuthService authService)
        {
            _mapper = mapper;
            _userService = userService;
            _authService = authService;
        }

        [HttpGet("getme"), Authorize]
        public async Task<IActionResult> RegisterUser()
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var email = _authService.GetEmailFromJwtToken(token);
            var userModel = await _userService.GetUserByEmail(email);
            var mappedUser = _mapper.Map<UserDto>(userModel);

            return Ok(Results.Json(mappedUser));
        }
    }
}