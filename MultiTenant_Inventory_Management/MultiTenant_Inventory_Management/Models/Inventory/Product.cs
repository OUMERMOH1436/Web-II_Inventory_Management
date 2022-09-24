using MultiTenant_Inventory_Management.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class Product : BaseEntity, IMustHaveTenant
    {
        public Product(string name, string description, int rate)
        {
            Name = name;
            Description = description;
            Rate = rate;
        }
        protected Product()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }

        [Required]
        [ForeignKey("Tenants")]
        public int TenantId { get; set; }

        public virtual Tenant Tenants { get; set; }
    }
}
