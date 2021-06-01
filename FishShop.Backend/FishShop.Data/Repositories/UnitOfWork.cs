using FishShop.Core.Entities;
using FishShop.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace FishShop.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly IMongoDatabase _databaseContext;
        private IConfiguration config;

        private IUserRepository _userRepository;

        public UnitOfWork(IConfiguration config)
        {
            this.config = config;
        }

        public IUserRepository UserRepository => _userRepository ?? new UserRepository(config);


        public void Dispose()
        {
            
        }
    }
}
