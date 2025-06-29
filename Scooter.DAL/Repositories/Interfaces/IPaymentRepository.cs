using ScooterDAL.Entities;

namespace ScooterDAL.Repositories.Interfaces
{
    public interface IPaymentRepository:IGenericRepository<Payment>
    {
        Task<IEnumerable<Payment>> GetUserPaymentsAsync(int userId);
        Task<decimal> GetUserTotalPaidAsync(int userId);
    }
}
