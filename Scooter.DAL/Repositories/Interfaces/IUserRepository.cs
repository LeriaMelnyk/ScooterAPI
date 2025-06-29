using ScooterDAL.Entities;

namespace ScooterDAL.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<IEnumerable<Trip>> GetUserTripsAsync(int userId);

    }
}
