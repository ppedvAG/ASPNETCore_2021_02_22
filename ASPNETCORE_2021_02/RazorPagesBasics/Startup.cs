using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPagesBasics.Pages.Modul003;
using RazorPagesBasics.Services;
using System;
using Westwind.AspNetCore.LiveReload;

namespace RazorPagesBasics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddLiveReload(config =>
            //{
            //    // optional - use config instead
            //    //config.LiveReloadEnabled = true;
            //    //config.FolderToMonitor = Path.GetFullname(Path.Combine(Env.ContentRootPath,"..")) ;
            //});


            services.AddRazorPages()
                //.AddRazorRuntimeCompilation()
                .AddRazorPagesOptions(options => {
                    //options.RootDirectory = "/Content"; //Anstatt Page-Verzeichnis, liegen die RazorPages im Verzeichnis Content 
                    options.Conventions.AddPageRoute("/index", "{*url}");
                    options.Conventions.AddPageRoute("/Modul004/BlogOverviewSample2", "Search/{year}/{month}/{day}/{title}");
                    
                });

            //services.AddRazorPages().WithRazorPagesRoot("/Content"); //Weitere Variante -> //Anstatt Page-Verzeichnis, liegen die RazorPages im Verzeichnis Content 

            services.AddTransient<IUserService, UserService>();
            
            
            services.AddSession(options =>
            {
                //https://docs.microsoft.com/de-de/aspnet/core/fundamentals/app-state?view=aspnetcore-5.0
                options.IdleTimeout = TimeSpan.FromSeconds(10); //TimeOut
                //options.Cookie.HttpOnly = true;
                //options.Cookie.IsEssential = true;
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseLiveReload();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            
            //gobaler Speicher - hier hinterlegen wir unseren Datenpfad zum Verzeichnis Images
            AppDomain.CurrentDomain.SetData("BildVerzeichnis", env.WebRootPath);



            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapWhen(context => context.Request.Path.ToString().Contains("imagegen"), subapp =>
            {
                subapp.UseThumbNailGen();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
