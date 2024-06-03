using AutoMapper;
using OnlineStore.BLL.Models;
using OnlineStore.BLL.Services.Interfaces;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.BLL.Services.Classes
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IMapper mapper, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;
        }

        public async Task AddReview(ReviewModel model)
        {
            var mapped = _mapper.Map<Review>(model);
            await _reviewRepository.AddAsync(mapped);
        }
    }
}