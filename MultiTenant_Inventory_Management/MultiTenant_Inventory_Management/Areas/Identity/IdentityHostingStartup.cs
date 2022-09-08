using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MultiTenant_Inventory_Management.Areas.Identity.Data;
using MultiTenant_Inventory_Management.Data;

[assembly: HostingStartup(typeof(MultiTenant_Inventory_Management.Areas.Identity.IdentityHostingStartup))]
namespace MultiTenant_Inventory_Management.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}