using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_dosyaIliski : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjeID",
                table: "Dosyalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dosyalar_ProjeID",
                table: "Dosyalar",
                column: "ProjeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dosyalar_Projeler_ProjeID",
                table: "Dosyalar",
                column: "ProjeID",
                principalTable: "Projeler",
                principalColumn: "ProjeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dosyalar_Projeler_ProjeID",
                table: "Dosyalar");

            migrationBuilder.DropIndex(
                name: "IX_Dosyalar_ProjeID",
                table: "Dosyalar");

            migrationBuilder.DropColumn(
                name: "ProjeID",
                table: "Dosyalar");
        }
    }
}
