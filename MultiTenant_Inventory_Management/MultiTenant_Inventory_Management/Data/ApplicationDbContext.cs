using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiTenant_Inventory_Management.Areas.Identity.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiTenant_Inventory_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext<SaasUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 

        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantAndUser> TenantAndUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
    }
}
