using Scooter.BLL.DTO;
using ScooterDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooter.BLL.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync();
        Task<PaymentDTO> GetPaymentByIdAsync(int id);
        Task CreatePaymentAsync(PaymentDTO paymentDto);
        Task UpdatePaymentAsync(PaymentDTO paymentDto);
        Task DeletePaymentAsync(int id);

        Task<IEnumerable<PaymentDTO>> GetUserPaymentsAsync(int userId);
        Task<decimal> GetUserTotalPaidAsync(int userId);
    }
}
