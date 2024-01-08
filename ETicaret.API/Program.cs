
using ETicaret.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ETicaret.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            #region DB işlemleri

            builder.Services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    //option.MigrationsAssembly("ETicaret.Repository");//Hangi katmanda DB tanımlı ise o katmöan yazılır. Bunu yerine Assembly Reflection yapısı ile AppDbContext'in olduğu katmanı bulup ismini çekebiliriz
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                });
            });
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
