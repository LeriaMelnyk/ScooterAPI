using Microsoft.EntityFrameworkCore;
using ScooterDAL.Data;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.Repositories
{
    public class FeedbackRepository : GenericRepository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(ScooterDbContext context) : base(context) { }
            // Усі фідбеки з деталями
            public async Task<IEnumerable<Feedback>> GetAllWithDetailsAsync()
            {
                return await _context.Feedbacks
                                     .Include(f => f.User)
                                     .Include(f => f.Trip)
                                     .ToListAsync();
            }

            // Середній рейтинг
            public async Task<double> GetAverageRatingAsync()
            {
                return await _context.Feedbacks.AverageAsync(f => f.Rating);
            }

            // Усі фідбеки для конкретної поїздки
            public async Task<IEnumerable<Feedback>> GetTripFeedbacksAsync(int tripId)
            {
                return await _context.Feedbacks
                                     .Where(f => f.TripId == tripId)
                                     .Include(f => f.User)
                                     .ToListAsync();
            }
        
    }
}
