using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using hackathon.Models;
using Microsoft.EntityFrameworkCore;

namespace hackathon
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
            => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SzkolyNysaContext>(options =>
                    options.UseSqlite("Data Source=Szkoly.db"));

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "ranking",
                    template: "ranking",
                    defaults: new { controller = "Home", action = "Ranking" });

                routes.MapRoute(
                    name: "about",
                    template: "onas",
                    defaults: new { controller = "Schools", action = "About" });

                routes.MapRoute(
                    name: "przedszkole",
                    template: "przedszkole/{i}",
                    defaults: new { controller = "Schools", action = "Przedszkole" });

                routes.MapRoute(
                    name: "podstawowa",
                    template: "podstawowa/{i}",
                    defaults: new { controller = "Schools", action = "SzkolaPodstawowa" });

                routes.MapRoute(
                    name: "srednia",
                    template: "srednia/{i}",
                    defaults: new { controller = "Schools", action = "SzkolaSrednia" });

                routes.MapRoute(
                    name: "podstawowe",
                    template: "podstawowe",
                    defaults: new { controller = "Schools", action = "SzkolyPodstawowe" });

                routes.MapRoute(
                    name: "przedszkola",
                    template: "przedszkola",
                    defaults: new { controller = "Schools", action = "Przedszkola" });

                routes.MapRoute(
                    name: "srednie",
                    template: "srednie",
                    defaults: new { controller = "Schools", action = "SzkolySrednie" });

                routes.MapRoute(
                    name: "wyzsza",
                    template: "wyzsza",
                    defaults: new { controller = "Schools", action = "SzkolyWyzsze" });
            });
        }
    }
}
