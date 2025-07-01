using Scooter.DAL.Pagination;
using ScooterDAL.Entities;

namespace ScooterDAL.Repositories.Interfaces
{
    public interface ITripRepository:IGenericRepository<Trip>
    {
        Task<IEnumerable<Trip>> GetTripsWithDetailsAsync();
        Task<IEnumerable<Trip>> GetUserTripsAsync(int userId);

        // В интерфейсе ITripRepository
        Task<PagedResult<Trip>> GetPagedAsync(int pageNumber, int pageSize);

        Task<int> CountAsync();
    }
}
