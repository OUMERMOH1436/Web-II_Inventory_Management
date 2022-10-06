using MultiTenant_Inventory_Management.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class Customer : IMustHaveTenant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string Company { get; set; }
        // primary contact {name, email, phone}
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }
        public string Receivables { get; set; }
        [Required]
        [ForeignKey("Tenants")]
        public int TenantId { get; set; }
        public virtual Tenant Tenants { get; set; }

    }
}
