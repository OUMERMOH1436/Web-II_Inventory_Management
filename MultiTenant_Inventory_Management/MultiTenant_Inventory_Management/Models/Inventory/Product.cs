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
        public Product()
        {

        }
        public string PartNumber { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Unit { get; set; }
        public byte[] ProductImage { get; set; }
        public bool ReturnableItem { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [DataType(DataType.Currency)]
        public float SellingPrice { get; set; }
        [ForeignKey("ProductTax")]
        public int SalesTax { get; set; }
        public float Tax { get; set; }

        [DataType(DataType.Currency)]
        public float CostPrice { get; set; } 
        [Required]
        [ForeignKey("Tenants")]
        public int TenantId { get; set; }

        public virtual Tenant Tenants { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ProductTax ProductTax { get; set; }
    }
}
