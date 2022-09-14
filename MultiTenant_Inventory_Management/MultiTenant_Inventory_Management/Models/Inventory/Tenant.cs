using MultiTenant_Inventory_Management.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class Tenant: IMustHaveTenant
    {
        // this class is dedicated to a Tenant Object that have the following properties you see below
        // this class will help us achieve the concept of multi-tenancy
        // TenantId is implemented from IMustHaveTenant interface class
        public int TenantId { get; set; }
        public string TenantName { get; set; }
        public string Industry { get; set; }
        public string BusinessLocation { get; set; }
        public string StateOrProvince { get; set; }

        //company address street1, street2 ...

        public byte[] Logo { get; set; }

        // primary contact {name, email, phone}
        public string Currency { get; set; }
        public string Language { get; set; }

        // this will be a foreign key for packagetypes
        // public string packageType { get; set; }

        public string TimeZone { get; set; } // cuz we are thinking to make it international
        public DateTime InventoryStartDate { get; set; }
        public string FiscalYear { get; set; } //make it accept only year
        public DateTime RegisteredDate { get; set; }
        public string DateFormat { get; set; } // set default value for this,
        public bool IsActive { get; set; }
     // public int createdById { get; set; }

        // the connectionstring is blank unless a client wants to have a specific database
        public string ConnectionString { get; set; }
    }
    
    // the below class TenantSetting will have a default configuration which incluides the DBProvider(MSSQL)
    // and a Connection string to the default database

    public class TenantSettings
    {
        public Configuration Defaults { get; set; }
        public List<Tenant> Tenants { get; set; }

    }
    public class Configuration
    {
        public string DBProvider { get; set; }
        public string ConnectionString { get; set; }
    }
}
