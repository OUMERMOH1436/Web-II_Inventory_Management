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
    public class Tenant : IMustHaveTenant
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
        [Display(Name = "Organization Name")]
        public string TenantName { get; set; }
        [Required]
        [Display(Name ="Industry")]
        public string Industry { get; set; }
        [Required]
        [Display(Name = "Business Location")]
        public string BusinessLocation { get; set; }
        [Display(Name = "State/Province")]
        public string StateOrProvince { get; set; }

        //company address street1, street2 ...

        public byte[] Logo { get; set; }

        // primary contact {name, email, phone}
        [Display(Name = "Primary Contact Name")]
        public string PrimaryContactName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Primary Contact Email")]
        public string PrimaryContactEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Primary Contact Phone")]
        public string PrimaryContactPhone { get; set; }

        
        public string Currency { get; set; }
        public string Language { get; set; }

        // this will be a foreign key for packagetypes
        // public string packageType { get; set; }
        [Display(Name = "Time Zone")]
        public string TimeZone { get; set; } // cuz we are thinking to make it international
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Inventory Start Date")]
        public DateTime InventoryStartDate { get; set; }
        [Display(Name = "Fiscal Year")]
        public DateTime FiscalYear { get; set; } //make it accept only year
        [DataType(DataType.Date)]
        [Display(Name = "Registered Date")]
        public DateTime RegisteredDate { get; set; }
        [Display(Name = "Date Format")]
        public string DateFormat { get; set; } // set default value for this,
        [Display(Name = "Active")]
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
