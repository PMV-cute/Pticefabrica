using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class _6migration : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "OtbrakovkaEggs",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "OtbrakovkaEggs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categori",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropColumn(
                name: "Kolvo",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "OtbrakovkaEggs");

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
