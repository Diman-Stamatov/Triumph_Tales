using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Triumph_Tales.Data;
using Triumph_Tales.Repository;
using Triumph_Tales.Repository.Interface;
using Triumph_Tales.Services;
using Triumph_Tales.Services.Interface;

namespace Triumph_Tales
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<TriumphTalesDB>(options=>
            {
                string connectionString = @"Server=.;Database=TriumphTales;Trusted_Connection=True;TrustServerCertificate=True";
                options.UseSqlServer(connectionString);
                options.EnableSensitiveDataLogging();
            });

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "TriumphTalesAPI", Version = "v1" });
            });

            builder.Services.AddScoped<IStoriesRepository, StoriesRepository>();
            builder.Services.AddScoped<IStoriesServices, StoriesServices>();

            var app = builder.Build();
            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Triumph Tales API V1");
                options.RoutePrefix = "api/swagger";
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}