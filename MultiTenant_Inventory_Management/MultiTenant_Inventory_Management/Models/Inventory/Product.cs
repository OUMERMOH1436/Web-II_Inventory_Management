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
        [Required]
        [Display(Name = "Part Number")]
        public string PartNumber { get; set; }
        public string ISBN { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        public string SKU { get; set; }
        [Display(Name = "UoM")]
        public string Unit { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        [Display(Name = "Product Image")]
        public byte[] ProductImage { get; set; }
        [Display(Name = "Returnable")]
        public bool ReturnableItem { get; set; }
        [Display(Name = "Active")]
        public bool isActive { get; set; }

        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Brand")]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Selling Price")]
        public float SellingPrice { get; set; }
        [ForeignKey("ProductTax")]
        [Display(Name = "Tax on Sell")]
        public int SalesTax { get; set; }
        [Display(Name = "Tax on Buy")]
        public float Tax { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Cost of Product")]
        public float CostPrice { get; set; } 
        [Required]
        [ForeignKey("Tenants")]
        public int TenantId { get; set; }

        public virtual Tenant Tenants { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ProductTax ProductTax { get; set; }
        public virtual Category Category { get; set; }
    }
}
