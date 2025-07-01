using AutoMapper;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using ScooterDAL.Entities;
using ScooterDAL.UOW;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UserService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
    {
        var users = await _unitOfWork.Users.GetAllAsync();
        return _mapper.Map<IEnumerable<UserDTO>>(users);
    }

    public async Task<UserDTO> GetUserByIdAsync(int id)
    {
        var user = await _unitOfWork.Users.GetByIdAsync(id);
        return _mapper.Map<UserDTO>(user);
    }

    public async Task CreateUserAsync(UserDTO userDto)
    {
        var user = _mapper.Map<User>(userDto);
        await _unitOfWork.Users.AddAsync(user);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateUserAsync(UserDTO userDto)
    {
        var user = _mapper.Map<User>(userDto);
        _unitOfWork.Users.Update(user);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteUserAsync(int id)
    {
        var user = await _unitOfWork.Users.GetByIdAsync(id);
        if (user != null)
        {
            _unitOfWork.Users.Remove(user);
            await _unitOfWork.SaveAsync();
        }
    }
}
