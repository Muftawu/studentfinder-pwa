using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using api.application;

namespace api.infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistentServices (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<UserDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IDataRepository, DataRepository>();

        return services;
    }
}
