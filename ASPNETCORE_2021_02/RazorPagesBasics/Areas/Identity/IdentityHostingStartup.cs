using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesBasics.Data;

[assembly: HostingStartup(typeof(RazorPagesBasics.Areas.Identity.IdentityHostingStartup))]
namespace RazorPagesBasics.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RazorPagesBasicsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RazorPagesBasicsContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<RazorPagesBasicsContext>();
            });
        }
    }
}