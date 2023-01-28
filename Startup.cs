using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using REGISTROASISTENCIA.Models;
using REGISTROASISTENCIA.services;

namespace REGISTROASISTENCIA
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
            services.AddControllersWithViews();
            services.AddDbContext<registroDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("conexion")));
            services.AddScoped<Sregistro, Iregistro>();
            //services.AddScoped<db>();
            services.AddTransient<db>();
            //services.AddSingleton<db>();
            services.AddSession();
            services.AddRazorPages().AddRazorRuntimeCompilation();

         

            //    services.AddLocalization(options => options.ResourcesPath = "Resources");

            //    services.AddMvc()
            //      .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            //      .AddDataAnnotationsLocalization();


            //    services.Configure<RequestLocalizationOptions>(options =>
            //    {
            //        var supportedCultures = new[]
            //        {
            //    new CultureInfo("en-PE"),
            //    new CultureInfo("fr"),
            //    new CultureInfo("es")
            //};
            //        options.DefaultRequestCulture = new RequestCulture(culture: "en-PE", uiCulture: "en-PE");
            //        options.SupportedCultures = supportedCultures;
            //        options.SupportedUICultures = supportedCultures;
            //    });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                     //pattern: "{controller=registrogeneral}/{action=Index}/{id?}");
                     pattern: "{controller=RegistrarAsistencia}/{action=Index}/{id?}");
            });
        }
    }
}
