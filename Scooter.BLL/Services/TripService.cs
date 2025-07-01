using AutoMapper;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using ScooterDAL.Entities;
using ScooterDAL.UOW;
using System.Collections.Generic;
using System.Threading.Tasks;

public class TripService : ITripService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public TripService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TripDTO>> GetAllTripsWithDetailsAsync()
    {
        var trips = await _unitOfWork.Trips.GetTripsWithDetailsAsync();
        return _mapper.Map<IEnumerable<TripDTO>>(trips);
    }

    public async Task<IEnumerable<TripDTO>> GetUserTripsAsync(int userId)
    {
        var trips = await _unitOfWork.Trips.GetUserTripsAsync(userId);
        return _mapper.Map<IEnumerable<TripDTO>>(trips);
    }

    public async Task<TripDTO> GetTripByIdAsync(int id)
    {
        var trip = await _unitOfWork.Trips.GetByIdAsync(id);
        return _mapper.Map<TripDTO>(trip);
    }

    public async Task CreateTripAsync(TripDTO tripDto)
    {
        var trip = _mapper.Map<Trip>(tripDto);
        await _unitOfWork.Trips.AddAsync(trip);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateTripAsync(TripDTO tripDto)
    {
        var trip = _mapper.Map<Trip>(tripDto);
        _unitOfWork.Trips.Update(trip);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteTripAsync(int id)
    {
        var trip = await _unitOfWork.Trips.GetByIdAsync(id);
        if (trip != null)
        {
            _unitOfWork.Trips.Remove(trip);
            await _unitOfWork.SaveAsync();
        }
    }
}
