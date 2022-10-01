using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MultiTenant_Inventory_Management.Areas.Identity.Data;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using MultiTenant_Inventory_Management.Models.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Controllers
{
    [Authorize]
    public class AvailableTenantController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int tenantId;
        public AvailableTenantController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: AvailableTenantController

        public ActionResult Index()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            List<Tenant> tenants = new List<Tenant>();
            List<TenantAndUser> tenantAndUsers = _context.TenantAndUsers.Where(a => a.UserId == userId).ToList();
            foreach (var ten in tenantAndUsers)
            {
                tenants.Add(_context.Tenants.Where(a => a.TenantId == ten.TenantId).FirstOrDefault());
            }
            return View(tenants);
        }

        // GET: AvailableTenantController/Details/5
        public ActionResult Details(int id)
        {
            tenantId = id;
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if(settings["TenantId"] == null)
                {
                    settings.Add("TenantId",id.ToString());
                }
                else
                {
                    settings["TenantId"].Value = id.ToString();
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error Writing app settings");
            }
            return RedirectToAction("Index", "Products");
        }

        // GET: AvailableTenantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AvailableTenantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AvailableTenantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AvailableTenantController/Edit/5
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

        // GET: AvailableTenantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AvailableTenantController/Delete/5
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
    }
}
