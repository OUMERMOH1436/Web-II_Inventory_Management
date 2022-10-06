using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using MultiTenant_Inventory_Management.Models.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Controllers
{
    // Nothing complicated here. Just a simple controller that uses the IProductService
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductService _service;
        private readonly BusinessDbContext _context;
        public ProductsController(IProductService service,BusinessDbContext context)
        {
            _service = service;
            _context = context;
        }
        // GET: ProductsController
        public async Task<ActionResult> Index(string search = "")
        {
            ViewBag.search = search;
            var data = _context.Products.Where(temp => temp.Name.Contains(search)).
                Include(Category => Category.Category)
                .Include(Brand => Brand.Brand).ToList();


            var data2 = await _service.GetAllAsync();
            return View(data);
        }

        // GET: ProductsController/Details/{id}
        public ActionResult Details(int id)
        {
            var data = _context.Products.Where(temp => temp.Id.Equals(id))
               .Include(Category => Category.Category)
               .Include(Brand => Brand.Brand)
               .Include(Tenant => Tenant.Tenants)
               .Include(ProductTax => ProductTax.ProductTax).FirstOrDefault();

            Product product = _service.GetByIdAsync(id);
            return View(data);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            List<ProductTax> productTax = _context.ProductTax.ToList();
            List<SelectListItem> SalesTax = new List<SelectListItem>();
                foreach (var tax in productTax)
                {
                SalesTax.Add(
                        new SelectListItem { Value = tax.Id.ToString(), Text = tax.TaxName + " (" + tax.TaxRate + "%)" }
                    );
                }
            ViewBag.SalesTax = SalesTax;

            List<Brand> Brand = _context.Brand.ToList();
            List<SelectListItem> BrandId = new List<SelectListItem>();
            foreach (var Bid in Brand)
            {
                BrandId.Add(
                        new SelectListItem { Value = Bid.Id.ToString(), Text = Bid.BrandName }
                    );
            }
            ViewBag.BrandId = BrandId;

            List<Category> Category = _context.Category.ToList();
            List<SelectListItem> CategoryId = new List<SelectListItem>();
            foreach (var Cid in Category)
            {
                CategoryId.Add(
                        new SelectListItem { Value = Cid.Id.ToString(), Text = Cid.Name }
                    );
            }
            ViewBag.CategoryId = CategoryId;


            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        public async Task<ActionResult> Create(Product product)
        {
            try
            {
                var data =  await _service.CreateAsync(product);
                return RedirectToAction("Create","Products");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/{id}
        public ActionResult Edit(int id)
        {
            var data = _context.Products.Where(temp => temp.Id.Equals(id))
               .Include(Category => Category.Category)
               .Include(Brand => Brand.Brand)
               .Include(Tenant => Tenant.Tenants)
               .Include(ProductTax => ProductTax.ProductTax).FirstOrDefault();

            Product product = _service.GetByIdAsync(id);


            List<ProductTax> productTax = _context.ProductTax.ToList();
            List<SelectListItem> SalesTax = new List<SelectListItem>();
            foreach (var tax in productTax)
            {
                SalesTax.Add(
                        new SelectListItem { Value = tax.Id.ToString(), Text = tax.TaxName + " (" + tax.TaxRate + "%)" }
                    );
            }
            ViewBag.SalesTax = SalesTax;

            List<Brand> Brand = _context.Brand.ToList();
            List<SelectListItem> BrandId = new List<SelectListItem>();
            foreach (var Bid in Brand)
            {
                BrandId.Add(
                        new SelectListItem { Value = Bid.Id.ToString(), Text = Bid.BrandName }
                    );
            }
            ViewBag.BrandId = BrandId;

            List<Category> Category = _context.Category.ToList();
            List<SelectListItem> CategoryId = new List<SelectListItem>();
            foreach (var Cid in Category)
            {
                CategoryId.Add(
                        new SelectListItem { Value = Cid.Id.ToString(), Text = Cid.Name }
                    );
            }
            ViewBag.CategoryId = CategoryId;

            return View(product);
        }

        // POST: ProductsController/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Product product)
        {
            try
            {
                await _service.UpdateAsync(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: ProductsController/Delete/{id}
        public ActionResult Delete(int id)
        {
            var data = _context.Products.Where(temp => temp.Id.Equals(id))
               .Include(Category => Category.Category)
               .Include(Brand => Brand.Brand)
               .Include(Tenant => Tenant.Tenants)
               .Include(ProductTax => ProductTax.ProductTax).FirstOrDefault();

            Product product = _service.GetByIdAsync(id);
            return View(data);
        }

        // POST: ProductsController/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Product product)
        {
            try
            {
                await _service.DeleteByIdAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public int getTenant()
        {
            int tenantId = 0;
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["TenantId"] == null)
                {
                    tenantId = 0;
                }
                else
                {
                    tenantId = Int32.Parse(settings["TenantId"].Value);
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error Writing app settings");
            }
            return tenantId;
        }
    }
}
