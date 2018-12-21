using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using Shop.Domain;
using Shop.Domain.Repositories.Implements;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using Shop.Service.Implements;
using Shop.Service.Interfaces;
using Shop.ViewModel.ViewModels;
using Shop.WebApi.ValidationModels;
using Swashbuckle.AspNetCore.Swagger;

namespace Shop.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel
                .Debug()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                //.ReadFrom.Configuration(Configuration.GetSection("pathFormat")).CreateLogger();
                .WriteTo.RollingFile("./Loggings/log-{Date}.txt").CreateLogger();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            #region Dependency Injection for Fluent Validators

            services.AddSingleton<IValidator<ProductViewModel>, ProductValidator>();
            services.AddSingleton<IValidator<CategoryViewModel>, CategoryValidator>();

            #endregion Dependency Injection for Fluent Validators

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddFluentValidation();
            services.AddDbContext<AeDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region Dependency Injection for Repositories

            services.AddScoped<ICategoryRepository, CategoryRepository>();

            //services.AddScoped<IDiscountRepository, DiscountRepository>();
            //services.AddScoped<IFeedbackRepository, FeedbackRepository>();
            //services.AddScoped<IFooterRepository, FooterRepository>();
            //services.AddScoped<IMenuRepository, MenuRepository>();
            //services.AddScoped<IMenuTypeRepository, MenuTypeRepository>();
            //services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            //services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddScoped<IPaymentRepository, PaymentRepository>();
            //services.AddScoped<IPostCategoryRepository, PostCategoryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            //services.AddScoped<IPostTagRepository, PostTagRepository>();
            //services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IShippingProviderRepository, ShippingProviderRepository>();
            //services.AddScoped<IShippingRepository, ShippingRepository>();
            //services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            #endregion Dependency Injection for Repositories

            #region Dependency Injection for Services

            services.AddScoped<ICategoryService, CategoryService>();

            //services.AddScoped<IDiscountService, DiscountService>();
            //services.AddScoped<IFeedbackService, FeedbackService>();
            //services.AddScoped<IFooterService, FooterService>();
            //services.AddScoped<IMenuService, MenuService>();
            //services.AddScoped<IMenuTypeService, MenuTypeService>();
            //services.AddScoped<IOrderDetailService, OrderDetailService>();
            //services.AddScoped<IOrderService, OrderService>();
            //services.AddScoped<IPaymentService, PaymentService>();
            //services.AddScoped<IPostCategoryService, PostCategoryService>();
            services.AddScoped<IPostService, PostService>();
            //services.AddScoped<IPostTagService, PostTagService>();
            //services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<IShippingProviderService, ShippingProviderService>();
            //services.AddScoped<IShippingService, ShippingService>();
            //services.AddScoped<ITagService, TagService>();
            services.AddScoped<IUserService, UserService>();

            #endregion Dependency Injection for Services

            #region Authentication by JWT

            //services
            //    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
            //        TokenValidationParameters parameters = new TokenValidationParameters()
            //        {
            //            ValidateIssuer = true,
            //            ValidateAudience = true,
            //            ValidateLifetime = true,
            //            ValidateIssuerSigningKey = true,
            //            ValidIssuer = Configuration["Jwt:Issuer"],
            //            ValidAudience = Configuration["Jwt:Issuer"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
            //        };

            //        options.TokenValidationParameters = parameters;
            //    });

            #endregion Authentication by JWT

            services.AddAutoMapper();

            #region Swagger

            services.AddSwaggerGen(
                c =>
                {
                    c.SwaggerDoc("v1", new Info { Title = "Core API", Description = "Swagger Core API" });
                }
                );

            #endregion Swagger

            #region Cors

            services.AddCors(options =>
            {
                options.AddPolicy("AllowMyOrigin",
                    builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

                options.AddPolicy("Localhost",
                    builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
                // options.AddPolicy("AllowMyOrigin",
                // builder => builder.AllowAnyOrigin());
            });

            services.AddCors();

            #endregion Cors
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();
            loggerFactory.AddSerilog();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //app.UseCors();
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Core API"); });
            //app.UseAuthentication();
            app.UseCors("Localhost");
            app.UseMvc();
        }
    }
}