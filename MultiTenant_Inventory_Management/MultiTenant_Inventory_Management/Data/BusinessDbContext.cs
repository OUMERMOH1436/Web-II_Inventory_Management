using Microsoft.EntityFrameworkCore;
using MultiTenant_Inventory_Management.Contracts;
using MultiTenant_Inventory_Management.Models.Inventory;
using MultiTenant_Inventory_Management.Models.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Data
{
    public class BusinessDbContext: DbContext
    {
        public int TenantId { get; set; }
        private readonly ITenantService _tenantService;
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options, ITenantService tenantService)
            : base(options)
        {
            _tenantService = tenantService;

            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["TenantId"] == null)
                {

                }
                else
                {
                    TenantId = _tenantService.GetTenant().TenantId;
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error Reading appsettings");
            }
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<ProductTax> ProductTax { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Vendor> Vendor { get; set; }

        // this is part where we define the global query filter for DBContext.
        // Everytime a new request is passed to the Dbcontext,
        // the BusinessDbContext will be smart enough to work with the data that is relevant
        // to the current tenant only.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<Product>().HasQueryFilter(a => a.TenantId == TenantId);
            modelBuilder.Entity<Brand>().HasQueryFilter(a => a.TenantId == TenantId);
            modelBuilder.Entity<ProductTax>().HasQueryFilter(a => a.TenantId == TenantId);
            modelBuilder.Entity<Customer>().HasQueryFilter(a => a.TenantId == TenantId);
            modelBuilder.Entity<Vendor>().HasQueryFilter(a => a.TenantId == TenantId);
        }

        // Here, everytime a new instance of BusinessDbContext is invoked, the connection string is pulled 
        // the tenantsettings and set to EFCore Context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var tenantConnectionString = _tenantService.GetConnectionString();// tenant connectionstring
            if (!string.IsNullOrEmpty(tenantConnectionString))
            {
                var DbProvider = _tenantService.GetDatabaseProvider(); // default connection string
                if (DbProvider.ToLower() == "mssql")
                {
                    optionsBuilder.UseSqlServer(_tenantService.GetConnectionString());
                }
            }
        }

        // Finally, we override the savechanges method. in this method,
        // whenever there is a modification of the Entity of the type IMustHaveTenant,
        // TenantId is written to the entity during the Save process
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<IMustHaveTenant>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Entity.TenantId = TenantId;
                        break;

                }
            }
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<IMustHaveTenant>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Entity.TenantId = TenantId;
                        break;

                }
            }
            var result = base.SaveChanges();
            return result;
        }
    }
}
