using Microsoft.EntityFrameworkCore;
using ScooterDAL.Data;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScooterDAL.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ScooterDbContext _context;

        public VehicleRepository(ScooterDbContext context)
        {
            _context = context;
        }

        // Реализация методов из IGenericRepository<Vehicle>
        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<Vehicle?> GetByIdAsync(int id)
        {
            return await _context.Vehicles.FindAsync(id);
        }

        public async Task AddAsync(Vehicle entity)
        {
            await _context.Vehicles.AddAsync(entity);
        }

        public void Update(Vehicle entity)
        {
            _context.Vehicles.Update(entity);
        }

        public void Remove(Vehicle entity)
        {
            _context.Vehicles.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        // Специфічні методи IVehicleRepository

        public async Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync()
        {
            return await _context.Vehicles
                .Where(v => v.IsAvailable)
                .ToListAsync();
        }

        public async Task<Vehicle?> GetByRegistrationNumberAsync(string regNumber)
        {
            return await _context.Vehicles
                .FirstOrDefaultAsync(v => v.RegistrationNumber == regNumber);
        }
    }
}
