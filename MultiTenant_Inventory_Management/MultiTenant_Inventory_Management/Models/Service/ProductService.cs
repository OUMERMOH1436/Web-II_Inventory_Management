using Microsoft.EntityFrameworkCore;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Models.Service
{
    // This is very straightforward usage of DBContext to perform sone simple CRUD operations.
    // so no need for documentation
    public class ProductService : IProductService
    {
        private readonly BusinessDbContext _context;
        public ProductService(BusinessDbContext context)
        {
            _context = context;
        }
        public async Task<Product> CreateAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> DeleteByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            return await DeleteProducAsync(product);
        }
        public async Task<Product> DeleteProducAsync(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public Product GetByIdAsync(int id)
        {
            return _context.Products.Find(id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
