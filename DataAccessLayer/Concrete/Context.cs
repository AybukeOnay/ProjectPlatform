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
            optionsBuilder.UseSqlServer("server=77.245.159.10\\MSSQLSERVER2019;database=ProjeBelirlemePlatformuDb;user=admindb1;password=12345aA*");

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Mesaj>()
        //        .HasOne(x => x.gondericiUser)
        //        .WithMany(y => y.OgrenciGonderici)
        //        .HasForeignKey(z => z.GondericiID)
        //        .OnDelete(DeleteBehavior.ClientSetNull);

        //    modelBuilder.Entity<Mesaj>()
        //        .HasOne(x => x.aliciUser)
        //        .WithMany(y => y.OgrenciAlici)
        //        .HasForeignKey(z => z.AliciID)
        //        .OnDelete(DeleteBehavior.ClientSetNull);
        //}

        public DbSet<CalismaAlani> CalismaAlanlari { get; set; }
        public DbSet<Dosya> Dosyalar { get; set; }
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
