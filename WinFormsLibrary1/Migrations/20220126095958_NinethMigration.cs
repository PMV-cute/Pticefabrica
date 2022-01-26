using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class NinethMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateP",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "DatePostupleniya",
                table: "Incubator");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePostEggs",
                table: "PartiyaEggsRodClass",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<double>(
                name: "max",
                table: "Incubator",
                type: "double precision",
                nullable: false,
                defaultValue: 1000.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldDefaultValue: 10000.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePost",
                table: "Incubator",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DaysBeforeHatching",
                table: "Incubator",
                type: "integer",
                nullable: false,
                defaultValue: 21);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePostEggs",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropColumn(
                name: "DatePost",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "DaysBeforeHatching",
                table: "Incubator");

            migrationBuilder.AddColumn<string>(
                name: "DateP",
                table: "Reproductor",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "max",
                table: "Incubator",
                type: "double precision",
                nullable: false,
                defaultValue: 10000.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldDefaultValue: 1000.0);

            migrationBuilder.AddColumn<string>(
                name: "DatePostupleniya",
                table: "Incubator",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
