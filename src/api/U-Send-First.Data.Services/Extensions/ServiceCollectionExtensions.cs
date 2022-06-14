using U_Send_First.Data.Services.Abstractions;
using U_Send_First.Data.Services.Concretes;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddDataServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}