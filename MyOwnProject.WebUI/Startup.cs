using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyOwnProject.Business.Abstract;
using MyOwnProject.Business.Concrete;
using MyOwnProject.DataAccess.Abstract;
using MyOwnProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnProject.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSingleton<IAboutDal, EfAboutDal>();
            services.AddSingleton<IAboutService, AboutManager>();

            services.AddSingleton<IContactDal, EfContactDal>();
            services.AddSingleton<IContactService, ContactManager>();

            services.AddSingleton<IPortfolioDal, EfPortfolioDal>();
            services.AddSingleton<IPortfolioService, PortfolioManager>();

            services.AddSingleton<IExperienceDal, EfExperienceDal>();
            services.AddSingleton<IExperienceService, ExperienceManager>();

            services.AddSingleton<IExperienceTwoDal, EfExperienceTwoDal>();
            services.AddSingleton<IExperienceTwoService, ExperienceTwoManager>();

            services.AddSingleton<IServiceDal, EfServiceDal>();
            services.AddSingleton<IServiceService, ServiceManager>();

            services.AddSingleton<ISkillDal, EfSkillDal>();
            services.AddSingleton<ISkillService, SkillManager>();

            services.AddSingleton<ISkillTwoDal, EfSkillTwoDal>();
            services.AddSingleton<ISkillTwoService, SkillTwoManager>();

            services.AddSingleton<ISocialMediaDal, EfSocialMediaDal>();
            services.AddSingleton<ISocialMediaService, SocialMediaManager>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // KSoft_Ahk_start
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "areas",
                             pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name: "default",
                            pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //KSoft_Ahk_end    
        }
    }
}
