using ScooterDAL.Entities;
using System.Threading.Tasks;

namespace ScooterDAL.Repositories.Interfaces
{
    public interface IFeedbackRepository:IGenericRepository<Feedback>
    {
        Task<IEnumerable<Feedback>> GetAllWithDetailsAsync();
        Task<double> GetAverageRatingAsync();
        Task<IEnumerable<Feedback>> GetTripFeedbacksAsync(int tripId);
    }
}
