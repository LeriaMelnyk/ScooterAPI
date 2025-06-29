using Microsoft.EntityFrameworkCore;
using ScooterDAL.Data;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(ScooterDbContext context) : base(context) { }

        // Усі доступні транспортні засоби
        public async Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync()
        {
            return await _context.Vehicles
                                 .Where(v => v.IsAvailable)
                                 .ToListAsync();
        }

        // Пошук за номером
        public async Task<Vehicle?> GetByRegistrationNumberAsync(string regNumber)
        {
            return await _context.Vehicles
                                 .FirstOrDefaultAsync(v => v.RegistrationNumber == regNumber);
        }
    }
}
