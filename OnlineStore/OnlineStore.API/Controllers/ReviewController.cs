using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.DTOs;
using OnlineStore.BLL.Models;
using OnlineStore.BLL.Services.Interfaces;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IReviewService _reviewService;
        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public ReviewController(IMapper mapper, IReviewService reviewService, IAuthService authService, IUserService userService)
        {
            _mapper = mapper;
            _reviewService = reviewService;
            _authService = authService;
            _userService = userService;
        }

        [HttpPut("add"), Authorize]
        public async Task<IActionResult> AddReview([FromBody] ReviewDto reviewDto)
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var email = _authService.GetEmailFromJwtToken(token);
            var userModel = await _userService.GetUserByEmail(email);

            var mapped = _mapper.Map<ReviewModel>(reviewDto);
            mapped.UserId = userModel!.Id;

            await _reviewService.AddReview(mapped);
            return Ok();
        }
    }
}