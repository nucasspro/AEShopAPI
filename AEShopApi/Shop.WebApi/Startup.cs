using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Domain;
using Shop.Domain.Repositories.Implements;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using Shop.Service.Implements;
using System;

namespace Shop.WebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<AeDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            Console.WriteLine(Configuration.GetConnectionString("DefaultConnection"));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped<IDbFactory, DbFactory>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}