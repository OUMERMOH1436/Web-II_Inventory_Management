using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class TenantInvitation
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Role { get; set; }
        public bool ActivateIntegration { get; set; }
    }
}
