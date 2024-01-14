using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using ETicaret.Repository;
using ETicaret.Repository.Repositories;
using ETicaret.Repository.UntiOfWork;
using ETicaret.Service.Mapping;
using ETicaret.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
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
            builder.Services.AddScoped<IUrunlerService, UrunlerService>();
            builder.Services.AddScoped<IKategoriService, KategorilerService>();
            builder.Services.AddAutoMapper(typeof(MapProfile));

            //Urunler,Kategoriler, Yorumlar, Fotograflar,...

            // Urunler, Kategoriler
            #endregion

            #region DB iþlemleri

            builder.Services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    //option.MigrationsAssembly("ETicaret.Repository");//Hangi katmanda DB tanýmlý
                    //ise o katman yazýlýr. Bunu yerine
                    //Assembly Reflection yapýsý ile AppDbContext'in
                    //olduðu katmaný bulup ismini çekebiliriz
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                });
            });
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


            app.UseEndpoints(endpoints =>
            {
                //Admin Panel için Route yönlendirmesi
                endpoints.MapAreaControllerRoute(
                 name: "AdminDefaultRoute",
                 areaName: "AdminPanel",
                 pattern: "AdminPanel/{controller=AdminAnasayfa}/{action=AdminAnasayfaIndex}/{id?}"
                 //http://localhost:5012/admin => þeklinde roue verildiðinde Controller ve action da yazýlanlar çýkacaktýr
                 );

                app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            app.Run();
        }
    }
}
