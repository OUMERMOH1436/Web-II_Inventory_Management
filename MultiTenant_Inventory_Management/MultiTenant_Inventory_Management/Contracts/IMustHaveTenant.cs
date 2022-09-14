using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Contracts
{
    // all the entity classes that implement this interfaec will have a TenantId.
    // it is important to have this interface
    public interface IMustHaveTenant
    {
        public int TenantId { get; set; }
    }
}
