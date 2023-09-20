using Microsoft.EntityFrameworkCore;
using Triumph_Tales.Data;

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
            var app = builder.Build();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}