using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsLibrary1.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "NegodnayaChicken");

            migrationBuilder.DropColumn(
                name: "TypeFabr",
                table: "Fabrikat");

            migrationBuilder.DropColumn(
                name: "Kolvo",
                table: "ComplexProizvodstvaEggs");

            migrationBuilder.RenameColumn(
                name: "KolvoN",
                table: "NegodnayaChicken",
                newName: "Kolvo");

            migrationBuilder.AlterColumn<bool>(
                name: "FreeOrNotFree",
                table: "UPK",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dateform",
                table: "UPK",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateForm",
                table: "PartiyaEggs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<bool>(
                name: "Pwater",
                table: "ComplexProizvodstvaEggs",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "Pfeed",
                table: "ComplexProizvodstvaEggs",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateForm",
                table: "ComplexProizvodstvaEggs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "ComplexProizvodstvaEggs",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "KolvoN",
                table: "ComplexProizvodstvaEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dateform",
                table: "UPK");

            migrationBuilder.DropColumn(
                name: "DateForm",
                table: "PartiyaEggs");

            migrationBuilder.DropColumn(
                name: "DateForm",
                table: "ComplexProizvodstvaEggs");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "ComplexProizvodstvaEggs");

            migrationBuilder.DropColumn(
                name: "KolvoN",
                table: "ComplexProizvodstvaEggs");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "NegodnayaChicken",
                newName: "KolvoN");

            migrationBuilder.AlterColumn<bool>(
                name: "FreeOrNotFree",
                table: "UPK",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "NegodnayaChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeFabr",
                table: "Fabrikat",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Pwater",
                table: "ComplexProizvodstvaEggs",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Pfeed",
                table: "ComplexProizvodstvaEggs",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Kolvo",
                table: "ComplexProizvodstvaEggs",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
