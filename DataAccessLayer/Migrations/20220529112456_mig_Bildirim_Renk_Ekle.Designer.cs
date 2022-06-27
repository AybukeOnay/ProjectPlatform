﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220529112456_mig_Bildirim_Renk_Ekle")]
    partial class mig_Bildirim_Renk_Ekle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Bildirim", b =>
                {
                    b.Property<int>("BildirimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BildirimDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BildirimDurum")
                        .HasColumnType("bit");

                    b.Property<string>("BildirimRenk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BildirimSembol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BildirimTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("BildirimTur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BildirimID");

                    b.ToTable("Bildirimler");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CalismaAlani", b =>
                {
                    b.Property<int>("CalismaAlaniID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CalismaAlaniTanim")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CalismaAlaniID");

                    b.ToTable("CalismaAlanlari");
                });

            //modelBuilder.Entity("EntityLayer.Concrete.CalismaDosya", b =>
            //    {
            //        b.Property<int>("CalismaDosyaID")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("int")
            //            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            //        b.Property<string>("CalismaDosyaAd")
            //            .HasMaxLength(50)
            //            .HasColumnType("nvarchar(50)");

            //        b.Property<string>("CalismaDosyaTur")
            //            .HasMaxLength(50)
            //            .HasColumnType("nvarchar(50)");

            //        b.Property<string>("CalismaDosyaVeri")
            //            .HasMaxLength(100)
            //            .HasColumnType("nvarchar(100)");

            //        b.Property<int>("ProjeID")
            //            .HasColumnType("int");

            //        b.HasKey("CalismaDosyaID");

            //        b.HasIndex("ProjeID");

            //        b.ToTable("CalismaDosyalari");
            //    });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AliciMail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GondericiMail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MesajIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajKonu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.ToTable("Mesajlar");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OgrenciAd")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OgrenciCinsiyet")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("OgrenciDogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OgrenciDurum")
                        .HasColumnType("bit");

                    b.Property<string>("OgrenciMail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("OgrenciResim")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("OgrenciSifre")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OgrenciSoyad")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OgrenciTelefon")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("OgrenciID");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OgretimElemani", b =>
                {
                    b.Property<int>("OgretimElemaniID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OgretimElemaniAd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OgretimElemaniCinsiyet")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("OgretimElemaniDurum")
                        .HasColumnType("bit");

                    b.Property<string>("OgretimElemaniMail")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OgretimElemaniOzgecmis")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OgretimElemaniResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretimElemaniSifre")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OgretimElemaniSoyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OgretimElemaniUnvan")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("OgretimElemaniID");

                    b.ToTable("OgretimElemanlari");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OgretimElemaniCalismaAlani", b =>
                {
                    b.Property<int>("OgretimElemaniCalismaAlaniID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalismaAlaniID")
                        .HasColumnType("int");

                    b.Property<int>("OgretimElemaniID")
                        .HasColumnType("int");

                    b.HasKey("OgretimElemaniCalismaAlaniID");

                    b.HasIndex("CalismaAlaniID");

                    b.HasIndex("OgretimElemaniID");

                    b.ToTable("OgretimElemaniCalismaAlanlari");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Proje", b =>
                {
                    b.Property<int>("ProjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalismaAlaniID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.Property<int>("OgretimElemaniID")
                        .HasColumnType("int");

                    b.Property<string>("ProjeAciklama")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ProjeAd")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ProjeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjeTur")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProjeID");

                    b.HasIndex("CalismaAlaniID");

                    b.HasIndex("OgrenciID");

                    b.HasIndex("OgretimElemaniID");

                    b.ToTable("Projeler");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ResimDosyasi", b =>
                {
                    b.Property<int>("ResimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ResimAd")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResimYolu")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ResimID");

                    b.ToTable("ResimDosyalari");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CalismaDosya", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Proje", "Proje")
                        .WithMany()
                        .HasForeignKey("ProjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proje");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OgretimElemaniCalismaAlani", b =>
                {
                    b.HasOne("EntityLayer.Concrete.CalismaAlani", "CalismaAlani")
                        .WithMany()
                        .HasForeignKey("CalismaAlaniID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.OgretimElemani", "OgretimElemani")
                        .WithMany()
                        .HasForeignKey("OgretimElemaniID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalismaAlani");

                    b.Navigation("OgretimElemani");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Proje", b =>
                {
                    b.HasOne("EntityLayer.Concrete.CalismaAlani", "CalismaAlani")
                        .WithMany()
                        .HasForeignKey("CalismaAlaniID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Ogrenci", "Ogrenci")
                        .WithMany()
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.OgretimElemani", "OgretimElemani")
                        .WithMany()
                        .HasForeignKey("OgretimElemaniID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalismaAlani");

                    b.Navigation("Ogrenci");

                    b.Navigation("OgretimElemani");
                });
#pragma warning restore 612, 618
        }
    }
}
