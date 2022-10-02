using MultiTenant_Inventory_Management.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class Brand : IMustHaveTenant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        [ForeignKey("Tenants")]
        public int TenantId { get; set; }

        public virtual Tenant Tenants { get; set; }
    }
}
