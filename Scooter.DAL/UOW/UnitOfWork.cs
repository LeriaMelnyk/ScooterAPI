using ScooterDAL.Data;
using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ScooterDbContext _context;

        public IUserRepository Users { get; }
        public IVehicleRepository Vehicles { get; }
        public ITripRepository Trips { get; }
        public IPaymentRepository Payments { get; }
        public IFeedbackRepository Feedbacks { get; }

        public UnitOfWork(ScooterDbContext context,
                          IUserRepository users,
                          IVehicleRepository vehicles,
                          ITripRepository trips,
                          IPaymentRepository payments,
                          IFeedbackRepository feedbacks)
        {
            _context = context;
            Users = users;
            Vehicles = vehicles;
            Trips = trips;
            Payments = payments;
            Feedbacks = feedbacks;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
