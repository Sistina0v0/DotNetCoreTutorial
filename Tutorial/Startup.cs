using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tutorial.Portal.DbContext;
using Tutorial.Portal.EntityModel;
using Tutorial.Portal.Service;

namespace Tutorial.Portal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ICommonService<User>, CommonService<User>>();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Tutorial"));
            });

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(configureRoutes =>
            {
                configureRoutes.MapRoute("Default", "{Controller=Home}/{Action=Index}/{Id?}");
            });
        }
    }
}
