using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Areas.Identity.Data
{
        public class SaasUser : IdentityUser
        {
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
            public string FirstName { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
            public string LastName { get; set; }
            public string DisplayName { get; set; }
            public byte[] ImageData { get; set; }
            public string ContentType { get; set; }
            public string FullName
            {
                get
                {
                    return $"{FirstName} {LastName}";
                }
            }

        }
}
