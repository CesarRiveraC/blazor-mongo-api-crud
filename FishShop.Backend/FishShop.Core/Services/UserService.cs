using FishShop.Core.Entities;
using FishShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FishShop.Core.Dtos;
using FishShop.Core.Dtos.Responses;

namespace FishShop.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;


        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GlobalResponse> CreateUser(CreateUserRequest user)
        {
            var newUser = new User
            {
                Name = "Nombre",
                SurName = "Apellido",
                Email = "test@gmail.com",
                Password = "test123",
            };

            var result = await _unitOfWork.UserRepository.CreateUser(newUser);
            return new GlobalResponse(result);
        }

        public Task<User> GetUser()
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}
