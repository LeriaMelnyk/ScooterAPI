using Scooter.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooter.BLL.Services.Interfaces
{
    public interface IVehicleService
    {
        // CRUD
        Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync();
        Task<VehicleDTO> GetVehicleByIdAsync(int id);
        Task CreateVehicleAsync(VehicleDTO vehicleDto);
        Task UpdateVehicleAsync(VehicleDTO vehicleDto);
        Task DeleteVehicleAsync(int id);

        Task<IEnumerable<VehicleDTO>> GetAvailableVehiclesAsync();
        Task<VehicleDTO?> GetByRegistrationNumberAsync(string regNumber);
    }

}
