using Microsoft.EntityFrameworkCore;
using MvcDewiCRUD.DAL;

namespace MvcDewiCRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DewiDbContext>(options =>
            {
                options.UseSqlServer("Server = localhost\\SQLEXPRESS02; Database = MvcDewiCrud; Trusted_Connection = True;TrustServerCertificate=True;");
            });
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=index}");



            app.Run();
        }
    }
}
