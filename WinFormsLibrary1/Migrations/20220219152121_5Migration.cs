using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class _5Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Npart",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropColumn(
                name: "Npart",
                table: "CehSortEggs");

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "PartiyaEggs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateForm",
                table: "CehSortEggs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "CehSortEggs",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "PartiyaEggs");

            migrationBuilder.DropColumn(
                name: "DateForm",
                table: "CehSortEggs");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "CehSortEggs");

            migrationBuilder.AddColumn<int>(
                name: "Npart",
                table: "PartiyaTovarnEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Npart",
                table: "CehSortEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
