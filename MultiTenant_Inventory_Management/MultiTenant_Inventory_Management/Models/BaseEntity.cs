using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models
{
    // Entities will inherit this abstract class to obtain the ID field
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
