using System;
using System.IO;
using System.Net.Mime;
using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Tutorial.Portal.DbContext;
using Tutorial.Portal.EntityModel;
using Tutorial.Portal.Service;
using Tutorial.Portal.ViewModel;

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
            //在给定程序集中搜索Profile类的派生类，添加映射。
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

            //app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/node_modules",
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "node_modules"))
            });

            app.UseMvc(configureRoutes =>
            {
                configureRoutes.MapRoute("Default", "{Controller=Home}/{Action=Index}/{Id?}");
            });
        }
    }
}
