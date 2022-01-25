using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KolvoN",
                table: "Incubator",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "KolvoB",
                table: "Incubator",
                newName: "KolvoEggs");

            migrationBuilder.AlterColumn<string>(
                name: "DatePostupleniya",
                table: "Incubator",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<double>(
                name: "max",
                table: "Incubator",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "max",
                table: "Incubator");

            migrationBuilder.RenameColumn(
                name: "time",
                table: "Incubator",
                newName: "KolvoN");

            migrationBuilder.RenameColumn(
                name: "KolvoEggs",
                table: "Incubator",
                newName: "KolvoB");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatePostupleniya",
                table: "Incubator",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
