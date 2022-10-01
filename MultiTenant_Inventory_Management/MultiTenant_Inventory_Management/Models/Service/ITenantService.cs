using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Service
{
    public interface ITenantService
    {
        public string GetDatabaseProvider();
        public string GetConnectionString();
        public Tenant GetTenant();
        public List<Tenant> GetTenants(String UserId);
        public Tenant Add(Tenant tenant);
        public Tenant Update(Tenant tenant);
    }
}
