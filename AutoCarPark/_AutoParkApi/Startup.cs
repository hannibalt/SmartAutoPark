using _Business.Abstract;
using _Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace _AutoParkApi
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddScoped<IVehicleTypeService, VehicleTypesManager>();
            services.AddScoped<IVehicleTypesDal, EfVehicleTypesDal>();
            services.AddScoped<ICarParksService, CarParksManager>();
            services.AddScoped<ICarParksDal, EfCarParksDal>();
            services.AddScoped<ILogsService, LogsManager>();
            services.AddScoped<ILogsDal, EfLogsDal>();
            services.AddScoped<IModeratorsService, ModeratorsManager>();
            services.AddScoped<IModeratorsDal, EfModeratorsDal>();
            services.AddScoped<IPaymentsService, PaymentsManager>();
            services.AddScoped<IPaymentsDal, EfPaymentsDal>();
            services.AddScoped<IPaymentTypeService, PaymentsTypeManager>();
            services.AddScoped<IPaymentTypeDal, EfPaymentTypeDal>();
            services.AddScoped<IUsersService, UsersManager>();
            services.AddScoped<IUsersDal, EfUsersDal>();
            services.AddScoped<IVehicleTypeService, VehicleTypesManager>();
            services.AddScoped<IVehicleTypesDal, EfVehicleTypesDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AI AutoPark Swagger");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
