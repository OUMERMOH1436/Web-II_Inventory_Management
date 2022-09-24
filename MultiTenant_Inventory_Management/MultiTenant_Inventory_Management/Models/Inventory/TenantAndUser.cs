using MultiTenant_Inventory_Management.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Inventory
{
    public class TenantAndUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TenantId { get; set; }
        [Required]
        [StringLength(450)]
        [ForeignKey("SaasUsers")]
        public string UserId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfIntegration { get; set; }
        public string Role { get; set; }

        [StringLength(450)]
        [ForeignKey("AccessProvider")]
        public string InvitedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfInvite { get; set; }
        public bool AcceptInvite { get; set; }
        public bool IsIntegrationActive { get; set; }

        //   public virtual Tenant Tenants { get; set; }
        public virtual SaasUser SaasUsers { get; set; }
        public virtual SaasUser AccessProvider { get; set; }
    }
}
