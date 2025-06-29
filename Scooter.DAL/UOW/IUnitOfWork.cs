using ScooterDAL.Repositories.Interfaces;

namespace ScooterDAL.UOW
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IVehicleRepository Vehicles { get; }
        ITripRepository Trips { get; }
        IPaymentRepository Payments { get; }
        IFeedbackRepository Feedbacks { get; }

        Task<int> SaveAsync();
    }
}
