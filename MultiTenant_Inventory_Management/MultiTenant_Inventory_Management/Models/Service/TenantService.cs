using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Service
{
    public class TenantService : ITenantService
    {
        private readonly ApplicationDbContext _context;
        private HttpContext _httpContext;
        private Tenant _currentTenant;
        private readonly IConfiguration configuration;

        public TenantService(IHttpContextAccessor contextAccessor,
            ApplicationDbContext context,IConfiguration config)
        {
            _context = context;
            _httpContext = contextAccessor.HttpContext;
            configuration = config;

            // we set the tenant using the SetTenant() method

                    SetTenant();                 
        }
        private void SetTenant()
        {
            // we read tenant id from appsetting we set in AvailableTenantController
            // in the appsettings of the application.
            // if the matching tenant is not found, it throws an exception. 
            // if the found tenant doesn't have a connection string defined,
            // we simply take the default connection string and attach it to the-
            // connection string property of the current tenant, as simple as that.
            var id = "";
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["TenantId"] == null)
                {

                }
                else
                {
                    id = settings["TenantId"].Value;
                    int tid = Int32.Parse(id);
                    _currentTenant = _context.Tenants.Find(tid);
                    if (_currentTenant == null) throw new Exception("Invalid Tenant!");
                    if (string.IsNullOrEmpty(_currentTenant.ConnectionString))
                    {
                        // SetDefaultConnectionStringToCurrentTenant();
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error Reading appsettings");
            }
        }
        private void SetDefaultConnectionStringToCurrentTenant()
        {
            //_currentTenant.ConnectionString = "";
        }
        public string GetConnectionString()
        {
            var data = configuration.GetConnectionString("DefaultConnection");
            return data;
        }
        public string GetDatabaseProvider()
        {
            return "mssql";
        }
        public Tenant GetTenant()
        {
            return _currentTenant;
        }
        public Tenant Add(Tenant tenant)
        {
            _context.Tenants.Add(tenant);
            _context.SaveChanges();
            return tenant;
        }
        public Tenant Update(Tenant tenant)
        {
            _context.Tenants.Update(tenant);
            _context.SaveChanges();
            return tenant;
        }
        public List<Tenant> GetTenants(String userId)
        {
            List<TenantAndUser> tenantAndUsers = _context.TenantAndUsers.Where(a => a.UserId == userId).ToList();
            List<Tenant> tenants = new List<Tenant>();
            foreach(var ten in tenantAndUsers)
            {
                tenants.Add(_context.Tenants.Where(a => a.TenantId == ten.TenantId).FirstOrDefault());
            }

           return tenants;
        }
    }
}

