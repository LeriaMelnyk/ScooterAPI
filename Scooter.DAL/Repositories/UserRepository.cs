using Microsoft.EntityFrameworkCore;
using ScooterDAL.Data;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ScooterDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Trip>> GetUserTripsAsync(int userId)
        {
            return await _context.Trips
                .Where(t => t.UserId == userId)
                .ToListAsync();
        }

    }
}
