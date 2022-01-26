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
                name: "feed",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "water",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "Npart",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "DatePostupleniya",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "time",
                table: "Incubator");

            migrationBuilder.AlterColumn<int>(
                name: "KolvoB",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 1300,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePostEggs",
                table: "PartiyaEggsRodClass",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "PartiyaEggsRodClass",
                type: "boolean",
                nullable: false,
                defaultValue: true);

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

            migrationBuilder.AddColumn<DateTime>(
                name: "DayOfBorn",
                table: "Incubator",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "Incubator",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "ReadyOrNotReady",
                table: "Incubator",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePostEggs",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropColumn(
                name: "DatePost",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "DayOfBorn",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "ReadyOrNotReady",
                table: "Incubator");

            migrationBuilder.AlterColumn<int>(
                name: "KolvoB",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1300);

            migrationBuilder.AddColumn<string>(
                name: "DateP",
                table: "Reproductor",
                type: "text",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<int>(
                name: "Npart",
                table: "PartiyaMolodnyaka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "time",
                table: "Incubator",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
