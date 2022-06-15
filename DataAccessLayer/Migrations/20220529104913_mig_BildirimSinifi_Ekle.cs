using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_BildirimSinifi_Ekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bildirimler",
                columns: table => new
                {
                    BildirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BildirimTur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimSembol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimDetay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BildirimDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bildirimler", x => x.BildirimID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bildirimler");
        }
    }
}
