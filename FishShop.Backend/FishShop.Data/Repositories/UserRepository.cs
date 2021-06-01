using FishShop.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using FishShop.Core.Interfaces;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;


namespace FishShop.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _userCollection;
        
        public UserRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("DatabaseSettings").GetSection("ConnectionString").Value;
            var server = new MongoClient(connectionString);
            var db = server.GetDatabase(configuration.GetSection("DatabaseSettings").GetSection("DatabaseName").Value);
            _userCollection = db.GetCollection<User>("User");
        }

        public async Task<User> CreateUser(User user)
        {
            await _userCollection.InsertOneAsync(user);
            return user;

        }

        public Task<User> GetUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<User>> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
