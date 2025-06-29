using Microsoft.EntityFrameworkCore;
using ScooterDAL.Data;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.Repositories
{

    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(ScooterDbContext context) : base(context) { }

        // Всі поїздки з користувачами і транспортом
        public async Task<IEnumerable<Trip>> GetTripsWithDetailsAsync()
        {
            return await _context.Trips
                                 .Include(t => t.User)
                                 .Include(t => t.Vehicle)
                                 .ToListAsync();
        }

        // Поїздки конкретного користувача
        public async Task<IEnumerable<Trip>> GetUserTripsAsync(int userId)
        {
            return await _context.Trips
                                 .Where(t => t.UserId == userId)
                                 .Include(t => t.Vehicle)
                                 .ToListAsync();
        }
    }
}
