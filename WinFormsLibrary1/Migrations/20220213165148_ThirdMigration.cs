using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Npart",
                table: "PartiyaEggs");

            migrationBuilder.AddColumn<int>(
                name: "maxB",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 200);

            migrationBuilder.AddColumn<int>(
                name: "maxN",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 1000);

            migrationBuilder.AddColumn<int>(
                name: "Cikl",
                table: "ComplexProizvodstvaEggs",
                type: "integer",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "maxB",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "maxN",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "Cikl",
                table: "ComplexProizvodstvaEggs");

            migrationBuilder.AddColumn<int>(
                name: "Npart",
                table: "PartiyaEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
