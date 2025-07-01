using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scooter.BLL.DTO;
using Scooter.DAL.Pagination;
using ScooterDAL.Entities;

namespace Scooter.BLL.Services.Interfaces
{


    public interface ITripService
    {
        Task<IEnumerable<TripDTO>> GetAllTripsWithDetailsAsync();
        Task<IEnumerable<TripDTO>> GetUserTripsAsync(int userId);
        Task<TripDTO> GetTripByIdAsync(int id);
        Task CreateTripAsync(TripDTO tripDto);
        Task UpdateTripAsync(TripDTO tripDto);
        Task DeleteTripAsync(int id);
        Task<PagedResult<TripDTO>> GetTripsAsync(int pageNumber, int pageSize);
    }


}
