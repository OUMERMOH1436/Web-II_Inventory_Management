using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Service
{
    public class TenantService : ITenantService
    {
        private readonly TenantSettings _tenantSettings;
        private readonly ApplicationDbContext _context;
        private HttpContext _httpContext;
        private Tenant _currentTenant;
        private string _currentUser;
        public TenantService(IOptions<TenantSettings> tenantSettings, IHttpContextAccessor contextAccessor)
        {
            _tenantSettings = tenantSettings.Value;
            _httpContext = contextAccessor.HttpContext;

            // what the if statement below is going to do is
            // first it check if HTTP conect is not null,
            // then we try to read tenant key from the header of the request.
            // if a tenant value is found, we set the tenant using the SetTenant(string tenantId) method
            if (_httpContext != null)
            {
                if (_httpContext.Request.Headers.TryGetValue("tenant", out var TenantId))
                {
                    SetTenant(TenantId);                    
                }
                else
                {
                    throw new Exception("Invalid Tenant!");
                }
            }
        }
        private void SetTenant(string tenantId)
        {
            // here we take in tenant from the request header and compare it against the data we already set
            // in the appsettings of the application.
            // if the matching tenant is not found, it throws an exception. 
            // if the found tenant doesn't have a connection string defined,
            // we simply take the default connection string and attach it to the-
            // connection string property of the current tenant, as simple as that.

            int tid = Int32.Parse(tenantId);
            _currentTenant = _tenantSettings.Tenants.Where(a => a.TenantId == tid).FirstOrDefault();
            if (_currentTenant == null) throw new Exception("Invalid Tenant!");
            if (string.IsNullOrEmpty(_currentTenant.ConnectionString))
            {
                SetDefaultConnectionStringToCurrentTenant();
            }

        }
        private void SetDefaultConnectionStringToCurrentTenant()
        {
            _currentTenant.ConnectionString = _tenantSettings.Defaults.ConnectionString;
        }
        public string GetConnectionString()
        {
            return _currentTenant?.ConnectionString;
        }

        public string GetDatabaseProvider()
        {
            return _tenantSettings.Defaults?.DBProvider;
        }

        public Tenant GetTenant()
        {
            return _currentTenant;
        }

        public string Add(Tenant tenant)
        {
            _context.Tenants.Add(tenant);
            _context.SaveChanges();
            return _currentUser;
        }

        public string Update(Tenant tenant)
        {
            _context.Tenants.Update(tenant);
            _context.SaveChanges();
            return _currentUser;
        }

    }
}

