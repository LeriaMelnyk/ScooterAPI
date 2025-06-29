using Microsoft.EntityFrameworkCore;
using ScooterDAL.Data;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ScooterDbContext context) : base(context) { }

        public async Task<IEnumerable<Payment>> GetUserPaymentsAsync(int userId)
        {
            return await _context.Payments
                                 .Where(p => p.UserId == userId)
                                 .Include(p => p.Trip)
                                 .ToListAsync();
        }

        // Загальна сума, сплачена користувачем
        public async Task<decimal> GetUserTotalPaidAsync(int userId)
        {
            return await _context.Payments
                                 .Where(p => p.UserId == userId)
                                 .SumAsync(p => p.Amount);
        }
    }
}
