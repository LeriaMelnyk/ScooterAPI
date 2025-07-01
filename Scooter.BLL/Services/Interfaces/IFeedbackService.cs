using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scooter.BLL.DTO;
using ScooterDAL.Entities;

namespace Scooter.BLL.Services.Interfaces
{
    public interface IFeedbackService
    {
        Task<IEnumerable<FeedbackDTO>> GetAllFeedbacksAsync();
        Task<FeedbackDTO> GetFeedbackByIdAsync(int id);
        Task CreateFeedbackAsync(FeedbackDTO feedbackDto);
        Task UpdateFeedbackAsync(FeedbackDTO feedbackDto);
        Task DeleteFeedbackAsync(int id);

        // Специфічні методи
        Task<IEnumerable<FeedbackDTO>> GetAllWithDetailsAsync();
        Task<double> GetAverageRatingAsync();
        Task<IEnumerable<FeedbackDTO>> GetTripFeedbacksAsync(int tripId);
    }
}
