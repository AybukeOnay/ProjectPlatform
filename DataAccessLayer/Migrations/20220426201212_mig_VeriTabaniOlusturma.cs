using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_VeriTabaniOlusturma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalismaAlanlari",
                columns: table => new
                {
                    CalismaAlaniID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalismaAlaniTanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaAlanlari", x => x.CalismaAlaniID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlar",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GondericiMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AliciMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MesajKonu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MesajIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlar", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OgrenciSoyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OgrenciCinsiyet = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    OgrenciDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OgrenciMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OgrenciSifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OgrenciDurum = table.Column<bool>(type: "bit", nullable: false),
                    OgrenciResim = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "OgretimElemanlari",
                columns: table => new
                {
                    OgretimElemaniID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretimElemaniAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OgretimElemaniSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OgretimElemaniUnvan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OgretimElemaniCinsiyet = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    OgretimElemaniMail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OgretimElemaniSifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OgretimElemaniDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimElemanlari", x => x.OgretimElemaniID);
                });

            migrationBuilder.CreateTable(
                name: "ResimDosyalari",
                columns: table => new
                {
                    ResimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ResimYolu = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResimDosyalari", x => x.ResimID);
                });

            migrationBuilder.CreateTable(
                name: "OgretimElemaniCalismaAlanlari",
                columns: table => new
                {
                    OgretimElemaniCalismaAlaniID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretimElemaniID = table.Column<int>(type: "int", nullable: false),
                    CalismaAlaniID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimElemaniCalismaAlanlari", x => x.OgretimElemaniCalismaAlaniID);
                    table.ForeignKey(
                        name: "FK_OgretimElemaniCalismaAlanlari_CalismaAlanlari_CalismaAlaniID",
                        column: x => x.CalismaAlaniID,
                        principalTable: "CalismaAlanlari",
                        principalColumn: "CalismaAlaniID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretimElemaniCalismaAlanlari_OgretimElemanlari_OgretimElemaniID",
                        column: x => x.OgretimElemaniID,
                        principalTable: "OgretimElemanlari",
                        principalColumn: "OgretimElemaniID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projeler",
                columns: table => new
                {
                    ProjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalismaAlaniID = table.Column<int>(type: "int", nullable: false),
                    OgretimElemaniID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false),
                    ProjeTur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjeAciklama = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeler", x => x.ProjeID);
                    table.ForeignKey(
                        name: "FK_Projeler_CalismaAlanlari_CalismaAlaniID",
                        column: x => x.CalismaAlaniID,
                        principalTable: "CalismaAlanlari",
                        principalColumn: "CalismaAlaniID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projeler_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projeler_OgretimElemanlari_OgretimElemaniID",
                        column: x => x.OgretimElemaniID,
                        principalTable: "OgretimElemanlari",
                        principalColumn: "OgretimElemaniID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalismaDosyalari",
                columns: table => new
                {
                    CalismaDosyaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeID = table.Column<int>(type: "int", nullable: false),
                    CalismaDosyaAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CalismaDosyaTur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CalismaDosyaVeri = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaDosyalari", x => x.CalismaDosyaID);
                    table.ForeignKey(
                        name: "FK_CalismaDosyalari_Projeler_ProjeID",
                        column: x => x.ProjeID,
                        principalTable: "Projeler",
                        principalColumn: "ProjeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalismaDosyalari_ProjeID",
                table: "CalismaDosyalari",
                column: "ProjeID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimElemaniCalismaAlanlari_CalismaAlaniID",
                table: "OgretimElemaniCalismaAlanlari",
                column: "CalismaAlaniID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimElemaniCalismaAlanlari_OgretimElemaniID",
                table: "OgretimElemaniCalismaAlanlari",
                column: "OgretimElemaniID");

            migrationBuilder.CreateIndex(
                name: "IX_Projeler_CalismaAlaniID",
                table: "Projeler",
                column: "CalismaAlaniID");

            migrationBuilder.CreateIndex(
                name: "IX_Projeler_OgrenciID",
                table: "Projeler",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Projeler_OgretimElemaniID",
                table: "Projeler",
                column: "OgretimElemaniID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalismaDosyalari");

            migrationBuilder.DropTable(
                name: "Mesajlar");

            migrationBuilder.DropTable(
                name: "OgretimElemaniCalismaAlanlari");

            migrationBuilder.DropTable(
                name: "ResimDosyalari");

            migrationBuilder.DropTable(
                name: "Projeler");

            migrationBuilder.DropTable(
                name: "CalismaAlanlari");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "OgretimElemanlari");
        }
    }
}
