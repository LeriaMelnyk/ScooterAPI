using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using ScooterDAL.Entities;
using ScooterDAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scooter.BLL.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return vehicles.Select(MapToDTO);
        }

        public async Task<VehicleDTO> GetVehicleByIdAsync(int id)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(id);
            if (vehicle == null)
                return null!;
            return MapToDTO(vehicle);
        }

        public async Task CreateVehicleAsync(VehicleDTO vehicleDto)
        {
            var vehicle = MapToEntity(vehicleDto);
            await _vehicleRepository.AddAsync(vehicle);
            await _vehicleRepository.SaveChangesAsync();
        }

        public async Task UpdateVehicleAsync(VehicleDTO vehicleDto)
        {
            var existingVehicle = await _vehicleRepository.GetByIdAsync(vehicleDto.Id);
            if (existingVehicle == null)
                throw new KeyNotFoundException($"Vehicle with Id {vehicleDto.Id} not found");

            existingVehicle.Model = vehicleDto.Model;
            existingVehicle.RegistrationNumber = vehicleDto.RegistrationNumber;
            existingVehicle.IsAvailable = vehicleDto.IsAvailable;

            _vehicleRepository.Update(existingVehicle);
            await _vehicleRepository.SaveChangesAsync();
        }

        public async Task DeleteVehicleAsync(int id)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(id);
            if (vehicle == null)
                throw new KeyNotFoundException($"Vehicle with Id {id} not found");

            _vehicleRepository.Remove(vehicle);
            await _vehicleRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<VehicleDTO>> GetAvailableVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAvailableVehiclesAsync();
            return vehicles.Select(MapToDTO);
        }

        public async Task<VehicleDTO?> GetByRegistrationNumberAsync(string regNumber)
        {
            var vehicle = await _vehicleRepository.GetByRegistrationNumberAsync(regNumber);
            if (vehicle == null)
                return null;
            return MapToDTO(vehicle);
        }

        // Приватные методы для маппинга

        private static VehicleDTO MapToDTO(Vehicle vehicle) => new VehicleDTO
        {
            Id = vehicle.Id,
            Model = vehicle.Model,
            RegistrationNumber = vehicle.RegistrationNumber,
            IsAvailable = vehicle.IsAvailable
        };

        private static Vehicle MapToEntity(VehicleDTO dto) => new Vehicle
        {
            Id = dto.Id,
            Model = dto.Model,
            RegistrationNumber = dto.RegistrationNumber,
            IsAvailable = dto.IsAvailable
        };
    }
}
