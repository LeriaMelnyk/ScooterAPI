using Microsoft.EntityFrameworkCore;
using Scooter.DAL.Pagination;
using ScooterDAL.Data;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.Repositories
{

    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(ScooterDbContext context) : base(context) { }

        public async Task<IEnumerable<Trip>> GetTripsWithDetailsAsync()
        {
            return await _context.Trips
                                 .Include(t => t.User)
                                 .Include(t => t.Vehicle)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Trip>> GetUserTripsAsync(int userId)
        {
            return await _context.Trips
                                 .Where(t => t.UserId == userId)
                                 .Include(t => t.Vehicle)
                                 .ToListAsync();
        }

        public async Task<PagedResult<Trip>> GetPagedAsync(int pageNumber, int pageSize)
        {
            var query = _context.Trips.AsQueryable();

            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<Trip>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<int> CountAsync()
        {
            return await _context.Trips.CountAsync();
        }

    }
}
