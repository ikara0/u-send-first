using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace U_Send_First.Data.Context;

public class DesignTimeContext : IDesignTimeDbContextFactory<USendFirstDbContext>
{
    public USendFirstDbContext CreateDbContext(string[] args)
    {
        var connectionString = new ConfigurationBuilder()
                                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                                .AddJsonFile("appsettings.json", false, true).Build().GetSection("MigrationConnectionString").Value;

        var optionBuilder = new DbContextOptionsBuilder<USendFirstDbContext>();
        optionBuilder.UseSqlServer(connectionString);
        return new USendFirstDbContext(optionBuilder.Options);
    }
}