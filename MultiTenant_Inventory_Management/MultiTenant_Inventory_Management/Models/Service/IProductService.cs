using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Service
{
    public interface IProductService
    {
        Task<Product> CreateAsync(Product product);
        Product GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> DeleteByIdAsync(int id);
        Task<Product> UpdateAsync(Product product);
    }
}
