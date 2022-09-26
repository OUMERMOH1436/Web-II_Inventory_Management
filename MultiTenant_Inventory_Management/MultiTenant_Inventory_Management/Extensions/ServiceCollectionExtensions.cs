using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAndMigrateTenantDatabase(this IServiceCollection services, IConfiguration config)
        {
            var options = services.GetOptions<TenantSettings>(nameof(TenantSettings));
            var defaultConnectionString = options.Defaults?.ConnectionString;
            var defaultDbProvider = options.Defaults?.DBProvider;
            if (defaultDbProvider.ToLower() == "mssql")
            {
                // registers BusinessDbContext using the SQLServer Package
                services.AddDbContext<BusinessDbContext>(m => m.UseSqlServer(e => e.MigrationsAssembly(typeof(BusinessDbContext).Assembly.FullName)));
            }

            // we extract the DBContext Service, set it's connection
            // to the conntection string and finally perform migration
            string connectionString;
            connectionString = defaultConnectionString;
            using var scope = services.BuildServiceProvider().CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<BusinessDbContext>();
            dbContext.Database.SetConnectionString(connectionString);
            dbContext.Database.Migrate();
            return services;
        }

        // This is a generic method to get the configuration from appsettings.json in a static file
        public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : new()
        {
            using var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var section = configuration.GetSection(sectionName);
            var options = new T();
            section.Bind(options);
            return options;
        }
        
    }
}
