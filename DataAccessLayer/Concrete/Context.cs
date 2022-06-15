using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MIEKQO8;database=ProjeBelirlemePlatformuDb;integrated security=true;");

        }
        public DbSet<CalismaAlani> CalismaAlanlari { get; set; }
        public DbSet<CalismaDosya> CalismaDosyalari { get; set; }
        public DbSet<Mesaj> Mesajlar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgretimElemani> OgretimElemanlari { get; set; }
        public DbSet<OgretimElemaniCalismaAlani> OgretimElemaniCalismaAlanlari { get; set; }
        public DbSet<Proje> Projeler { get; set; }
        public DbSet<ResimDosyasi> ResimDosyalari { get; set; }
        public DbSet<Bildirim> Bildirimler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}
