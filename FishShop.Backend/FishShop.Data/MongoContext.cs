using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace FishShop.Infrastructure
{
    public static class MongoContext
    {
        public static IServiceCollection AddMongoContext(this IServiceCollection services, IConfiguration configuration)
        {
            //Mongo Connection
            var connectionString = configuration.GetSection("DatabaseSettings").GetSection("ConnectionString").Value;
            var server = new MongoClient(connectionString);
            services.AddTransient<IMongoDatabase>(c => server.GetDatabase(configuration.GetSection("DatabaseSettings").GetSection("DatabaseName").Value));
            var X = server.GetDatabase(configuration.GetSection("DatabaseSettings").GetSection("DatabaseName").Value);
            return services;
        }

    }
}
