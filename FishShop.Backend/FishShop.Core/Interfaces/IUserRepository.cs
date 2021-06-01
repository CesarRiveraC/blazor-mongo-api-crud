using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishShop.Core.Dtos.Responses;
using FishShop.Core.Entities;

namespace FishShop.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);

        Task<User> GetUser();

        Task<List<User>> GetUsers();

        Task<bool> UpdateUser();

        Task<bool> DeleteUser();

    }
}
