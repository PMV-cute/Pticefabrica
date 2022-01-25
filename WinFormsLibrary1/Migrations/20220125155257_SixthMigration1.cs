using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class SixthMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pfeed",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "Pwater",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "Npart",
                table: "PartiyaEggsRodClass");

            migrationBuilder.AlterColumn<string>(
                name: "DateP",
                table: "Reproductor",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<int>(
                name: "feed",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "water",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "feed",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "water",
                table: "Reproductor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateP",
                table: "Reproductor",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<bool>(
                name: "Pfeed",
                table: "Reproductor",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Pwater",
                table: "Reproductor",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Npart",
                table: "PartiyaEggsRodClass",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
