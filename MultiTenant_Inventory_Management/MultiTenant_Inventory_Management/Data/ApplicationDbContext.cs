using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiTenant_Inventory_Management.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiTenant_Inventory_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext<SaasUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
