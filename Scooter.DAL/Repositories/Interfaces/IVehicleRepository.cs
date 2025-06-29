using ScooterDAL.Entities;

namespace ScooterDAL.Repositories.Interfaces
{
    public interface IVehicleRepository:IGenericRepository<Vehicle>
    {
        Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync();
        Task<Vehicle?> GetByRegistrationNumberAsync(string regNumber);
    }
}
