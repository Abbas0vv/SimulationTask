using First_Simulation.Database;
using First_Simulation.Database.Repositories;
using Microsoft.EntityFrameworkCore;

namespace First_Simulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();


            builder.Services.AddScoped<DoctorRepository>();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


            builder.Configuration.GetConnectionString("Default");

            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "Admin",
                pattern: "{area:exists}/{controller=AdminDashboard}/{action=Index}/{id?}"
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );


            app.Run();
        }
    }
}
