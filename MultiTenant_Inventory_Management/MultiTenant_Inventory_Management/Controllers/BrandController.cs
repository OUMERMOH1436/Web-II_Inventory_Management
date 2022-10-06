using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Controllers
{
    [Authorize]
    public class BrandController : Controller
    {
        BusinessDbContext _context;
        public BrandController(BusinessDbContext context)
        {
            _context = context;
        }
        // GET: BrandController
        public ActionResult Index()
        {
            var brand = _context.Brand.ToList();
            return View(brand);
        }

        // GET: BrandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand brand)
        {
            try
            {
                brand.TenantId = getTenant();
                _context.Brand.Add(brand);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrandController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
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
