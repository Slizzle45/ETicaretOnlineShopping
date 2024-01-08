using ETicaret.Core.ETicaretDatabase;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Configurations
{
    public class MenularConfiguration :  IEntityTypeConfiguration<Menular>
    {
        public void Configure(EntityTypeBuilder<Menular> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id).UseIdentityColumn();
            builder.Property(k => k.MenuAdi).IsRequired().HasMaxLength(100);
            builder.Property(k => k.Aciklama).IsRequired(false);
            //builder.Property(k => k.MenuSirasi).IsRequired(false);
            //-----------------------
            //builder.HasMany(k => k.AltMenu).WithOne(k => k.UstMenu).HasForeignKey(k => k.UstMenuId);
            builder.HasOne(k => k.UstMenu).WithMany(k => k.AltMenu).HasForeignKey(k => k.UstMenuId);
            //Performans için tercih edilmedi
            //builder.HasOne(k => k.ErisimAlanlari).WithOne(k => k.Menular).HasForeignKey<ErisimAlanlari>(k => k.Id);


        }
    }
}
