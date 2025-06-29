using ScooterDAL.Entities;

namespace ScooterDAL.Repositories.Interfaces
{
    public interface ITripRepository:IGenericRepository<Trip>
    {
        Task<IEnumerable<Trip>> GetTripsWithDetailsAsync();
        Task<IEnumerable<Trip>> GetUserTripsAsync(int userId);
    }
}
