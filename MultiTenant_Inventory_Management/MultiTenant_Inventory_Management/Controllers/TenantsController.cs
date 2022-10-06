using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultiTenant_Inventory_Management.Data;
using MultiTenant_Inventory_Management.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MultiTenant_Inventory_Management.Controllers
{
    [Authorize]
    public class TenantsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int tenantId;

        public TenantsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: TenantsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TenantsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TenantsController/Create
        public ActionResult Create()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<SelectListItem> ls = new()
            {
                new SelectListItem { Value = "1", Text = userId }
            };
            ViewBag.UserId = ls;
            return View();
        }

        // POST: TenantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tenant tenant)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            TenantAndUser tenantAndUser = new TenantAndUser();
            try
            {
                tenant.UserId = userId;
                _context.Tenants.Add(tenant);
                _context.SaveChanges();
                _context.Entry(tenant).GetDatabaseValues();
                tenantId = tenant.TenantId;

                tenantAndUser.TenantId = tenantId;
                tenantAndUser.UserId = userId;
                tenantAndUser.DateOfIntegration = DateTime.Today;
                tenantAndUser.Role = "Owner";
                tenantAndUser.InvitedBy = userId;
                tenantAndUser.DateOfInvite = DateTime.Today;
                tenantAndUser.AcceptInvite = true;
                tenantAndUser.IsIntegrationActive = true;
                _context.TenantAndUsers.Add(tenantAndUser);
                _context.SaveChanges();

                // change the tenant Id value to current tenant in app settings
                setTenant(tenantId);

                return RedirectToAction("Index","Products");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Invite()
        {
            List<SelectListItem> ls = new()
            {
                new SelectListItem { Value = "Owner", Text = "Owner" },
                new SelectListItem { Value = "employee", Text = "employee" }
            };
            ViewBag.Roles = ls;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Invite(TenantInvitation tenantInvitation)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            TenantAndUser tenantAndUser = new TenantAndUser();
            try
            {
                var user = _context.Users.Where(a => a.Email == tenantInvitation.Email).FirstOrDefault();
                
                if(user == null) { return Content("Tenant Not Found"); }
                tenantAndUser.TenantId = getTenant();
                tenantAndUser.UserId = user.Id;
                tenantAndUser.DateOfIntegration = DateTime.Today;
                tenantAndUser.Role = tenantInvitation.Role;
                tenantAndUser.InvitedBy = userId;
                tenantAndUser.DateOfInvite = DateTime.Today;
                tenantAndUser.AcceptInvite = true;
                tenantAndUser.IsIntegrationActive = tenantInvitation.ActivateIntegration;
                _context.TenantAndUsers.Add(tenantAndUser);
                _context.SaveChanges();
                return RedirectToAction("Index","Products");
            }
            catch
            {
                return View();
            }
        } 

        // GET: TenantsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TenantsController/Edit/5
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

        // GET: TenantsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TenantsController/Delete/5
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
        public void setTenant(int id)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["TenantId"] == null)
                {
                    settings.Add("TenantId", id.ToString());
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
        }
        public int getTenant()
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["TenantId"] == null)
                {
                    
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
