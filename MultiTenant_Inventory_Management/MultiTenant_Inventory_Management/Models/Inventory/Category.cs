using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
