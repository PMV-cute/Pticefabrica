using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class _6Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "PartiyaTovarnEggs");

            migrationBuilder.AddColumn<int>(
                name: "Categori",
                table: "PartiyaTovarnEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kolvo",
                table: "PartiyaTovarnEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "FreeOrNotFree",
                table: "PartiyaEggs",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categori",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropColumn(
                name: "Kolvo",
                table: "PartiyaTovarnEggs");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "PartiyaTovarnEggs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "FreeOrNotFree",
                table: "PartiyaEggs",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);
        }
    }
}
