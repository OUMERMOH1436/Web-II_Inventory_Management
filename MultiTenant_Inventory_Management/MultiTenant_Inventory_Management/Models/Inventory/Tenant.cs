using MultiTenant_Inventory_Management.Areas.Identity.Data;
using MultiTenant_Inventory_Management.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class Tenant: IMustHaveTenant
    {
        // this class is dedicated to a Tenant Object that have the following properties you see below
        // this class will help us achieve the concept of multi-tenancy
        // TenantId is implemented from IMustHaveTenant interface class
        [Key]
        public int TenantId { get; set; }

        // ForeignKey
        [Required]
        [ForeignKey("SaasUsers")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Required]
        public string TenantName { get; set; }
        [Required]
        public string Industry { get; set; }
        [Required]
        public string BusinessLocation { get; set; }
        public string StateOrProvince { get; set; }

        //company address street1, street2 ...

        public byte[] Logo { get; set; }

        // primary contact {name, email, phone}

        public string PrimaryContactName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string PrimaryContactEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PrimaryContactPhone { get; set; }

        
        public string Currency { get; set; }
        public string Language { get; set; }

        // this will be a foreign key for packagetypes
        // public string packageType { get; set; }

        public string TimeZone { get; set; } // cuz we are thinking to make it international
        [Required]
        [DataType(DataType.Date)]
        public DateTime InventoryStartDate { get; set; }
        
        public DateTime FiscalYear { get; set; } //make it accept only year
        [DataType(DataType.Date)]
        public DateTime RegisteredDate { get; set; }
        public string DateFormat { get; set; } // set default value for this,
        public bool IsTenantActive { get; set; }

        // createdBy
       

        // the connectionstring is blank unless a client wants to have a specific database
        public string ConnectionString { get; set; }

        public virtual SaasUser SaasUsers { get; set; }

    }
    
    // the below class TenantSetting will have a default configuration which includes the DBProvider(MSSQL)
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
