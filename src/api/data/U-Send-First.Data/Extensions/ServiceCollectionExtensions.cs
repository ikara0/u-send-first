using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using U_Send_First.Common;
using U_Send_First.Data.Context;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetSection($"{nameof(Settings)}:Database");
        var settings = section.Get<Settings.DatabaseConfiguration>();
        services.AddDbContext<USendFirstDbContext>(builder =>
        {
            builder.UseSqlServer(settings.ConnectionString);
        });
        services.AddScoped<DbContext, USendFirstDbContext>();

        return services;
    }
}