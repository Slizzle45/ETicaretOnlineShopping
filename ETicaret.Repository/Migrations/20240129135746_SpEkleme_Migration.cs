using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SpEklemeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE PROCEDURE Sp_GetMusteriAdresBilgileri
        AS
        BEGIN
            SELECT    
                a.Id AS AdresId, a.AdresBasligi, a.Adres, a.PostaKodu, a.AktifMi, a.EklenmeTarih, a.GuncellenmeTarih,
                m.Adi + ' ' + m.Soyadi AS MusteriAdiSoyadi, m.Id AS MusteriId, 
                il.IlAdi,  ilce.IlceAdi   
            FROM Adresler a  
            INNER JOIN Musteriler m ON a.MusteriId = m.Id    
            INNER JOIN Ilceler ilce ON a.IlceKodu = ilce.IlceKodu    
            INNER JOIN Iller il ON ilce.IlKodu = il.IlKodu
        END
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE Sp_GetMusteriAdresBilgileri");
        }
    }
}
