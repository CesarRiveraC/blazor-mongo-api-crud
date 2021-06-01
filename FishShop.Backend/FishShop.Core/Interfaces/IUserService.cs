using FishShop.Core.Dtos;
using FishShop.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using FishShop.Core.Dtos.Responses;

namespace FishShop.Core.Interfaces
{
    public interface IUserService
    {
        Task<GlobalResponse> CreateUser(CreateUserRequest user);
        Task<User> GetUser();
        Task<List<User>> GetUsers();
        Task<bool> UpdateUser();
        Task<bool> DeleteUser();
    }
}
