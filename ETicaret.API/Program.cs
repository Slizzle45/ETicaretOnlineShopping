
using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using ETicaret.Repository;
using ETicaret.Repository.Repositories;
using ETicaret.Repository.UntiOfWork;
using ETicaret.Service.Services;
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

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddSwaggerDocument();//Swager için eklendi

            #region DB işlemleri

            builder.Services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    //option.MigrationsAssembly("ETicaret.Repository");//Hangi katmanda DB tanımlı ise o katman yazılır. Bunu yerine Assembly Reflection yapısı ile AppDbContext'in olduğu katmanı bulup ismini çekebiliriz
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                });
            });
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            //**********************
            app.UseOpenApi();//Swager da API çalıştırmak için eklendi
            app.UseSwaggerUi();//Swageri run eder
            //**********************
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
