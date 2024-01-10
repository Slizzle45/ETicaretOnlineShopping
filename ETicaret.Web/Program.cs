using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using ETicaret.Repository.Repositories;
using ETicaret.Repository.UntiOfWork;
using ETicaret.Service.Services;
namespace ETicaret.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region E Ticaret Service'leri

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IUrunlerRepository, UrunlerRepository>();
            builder.Services.AddScoped<IMenulerRepository, MenulerRepository>();

            //Urunler,Kategoriler, Yorumlar, Fotograflar,...

            // Urunler, Kategoriler
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if(!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
