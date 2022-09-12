using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ViewResult Register()
        {
            return View();
        }
    }
    public class ResiterViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string DisplayName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.EmailAddress), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
