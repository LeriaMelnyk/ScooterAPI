using AutoMapper;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using ScooterDAL.Entities;
using ScooterDAL.UOW;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scooter.BLL.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync()
        {
            var payments = await _unitOfWork.Payments.GetAllAsync();
            return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
        }

        public async Task<PaymentDTO> GetPaymentByIdAsync(int id)
        {
            var payment = await _unitOfWork.Payments.GetByIdAsync(id);
            return _mapper.Map<PaymentDTO>(payment);
        }

        public async Task CreatePaymentAsync(PaymentDTO paymentDto)
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            await _unitOfWork.Payments.AddAsync(payment);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdatePaymentAsync(PaymentDTO paymentDto)
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            _unitOfWork.Payments.Update(payment);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeletePaymentAsync(int id)
        {
            var payment = await _unitOfWork.Payments.GetByIdAsync(id);
            if (payment != null)
            {
                _unitOfWork.Payments.Remove(payment);
                await _unitOfWork.SaveAsync();
            }
        }

        public async Task<IEnumerable<PaymentDTO>> GetUserPaymentsAsync(int userId)
        {
            var payments = await _unitOfWork.Payments.GetUserPaymentsAsync(userId);
            return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
        }

        public async Task<decimal> GetUserTotalPaidAsync(int userId)
        {
            return await _unitOfWork.Payments.GetUserTotalPaidAsync(userId);
        }
    }
}
