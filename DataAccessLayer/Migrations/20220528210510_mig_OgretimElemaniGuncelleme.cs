using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_OgretimElemaniGuncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OgretimElemaniOzgecmis",
                table: "OgretimElemanlari",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OgretimElemaniResim",
                table: "OgretimElemanlari",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OgretimElemaniOzgecmis",
                table: "OgretimElemanlari");

            migrationBuilder.DropColumn(
                name: "OgretimElemaniResim",
                table: "OgretimElemanlari");
        }
    }
}
