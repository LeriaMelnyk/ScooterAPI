using AutoMapper;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using ScooterDAL.UOW;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scooter.BLL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FeedbackDTO>> GetAllFeedbacksAsync()
        {
            var feedbacks = await _unitOfWork.Feedbacks.GetAllAsync();
            return _mapper.Map<IEnumerable<FeedbackDTO>>(feedbacks);
        }

        public async Task<FeedbackDTO> GetFeedbackByIdAsync(int id)
        {
            var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(id);
            return _mapper.Map<FeedbackDTO>(feedback);
        }

        public async Task CreateFeedbackAsync(FeedbackDTO feedbackDto)
        {
            var feedback = _mapper.Map<ScooterDAL.Entities.Feedback>(feedbackDto);
            await _unitOfWork.Feedbacks.AddAsync(feedback);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateFeedbackAsync(FeedbackDTO feedbackDto)
        {
            var feedback = _mapper.Map<ScooterDAL.Entities.Feedback>(feedbackDto);
            _unitOfWork.Feedbacks.Update(feedback);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteFeedbackAsync(int id)
        {
            var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(id);
            if (feedback != null)
            {
                _unitOfWork.Feedbacks.Remove(feedback);
                await _unitOfWork.SaveAsync();
            }
        }

        public async Task<IEnumerable<FeedbackDTO>> GetAllWithDetailsAsync()
        {
            var feedbacks = await _unitOfWork.Feedbacks.GetAllWithDetailsAsync();
            return _mapper.Map<IEnumerable<FeedbackDTO>>(feedbacks);
        }

        public async Task<double> GetAverageRatingAsync()
        {
            return await _unitOfWork.Feedbacks.GetAverageRatingAsync();
        }

        public async Task<IEnumerable<FeedbackDTO>> GetTripFeedbacksAsync(int tripId)
        {
            var feedbacks = await _unitOfWork.Feedbacks.GetTripFeedbacksAsync(tripId);
            return _mapper.Map<IEnumerable<FeedbackDTO>>(feedbacks);
        }
    }
}
