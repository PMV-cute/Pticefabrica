using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeChiсken",
                table: "NegodnayaChicken");

            migrationBuilder.DropColumn(
                name: "NIncubator",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "TypeChiсken",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "Nfabricata",
                table: "Fabrikat");

            migrationBuilder.DropColumn(
                name: "NIncubator",
                table: "ComplexProizvodstvaEggs");

            migrationBuilder.DropColumn(
                name: "NCeha",
                table: "CehSortEggs");

            migrationBuilder.DropColumn(
                name: "Nceha",
                table: "CehPererabotkiOthodov");

            migrationBuilder.RenameColumn(
                name: "kolvo",
                table: "NegodnayaChicken",
                newName: "KolvoN");

            migrationBuilder.RenameColumn(
                name: "Nceha",
                table: "CehProizvMelanja",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "NegodnayaChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "Incubator",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoN",
                table: "Incubator",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kolvo",
                table: "CehSortEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Npart",
                table: "CehSortEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Chicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeChiсken = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chicken", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Otbrakovka",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Weight = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otbrakovka", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OtbrakovkaEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kolvo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtbrakovkaEggs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Othodi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kolvo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Othodi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaEggsRodClass",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    KolvoB = table.Column<int>(type: "integer", nullable: false),
                    KolvoN = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaEggsRodClass", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaMolodnyaka",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    KolvoB = table.Column<int>(type: "integer", nullable: false),
                    KolvoN = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaMolodnyaka", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaRemontnayaVzrosloyChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    KolvoB = table.Column<int>(type: "integer", nullable: false),
                    KolvoN = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaRemontnayaVzrosloyChicken", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaTovarnEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    DateUp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaTovarnEggs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaVzrosloyChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    TypeChiсken = table.Column<string>(type: "text", nullable: false),
                    Kolvo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaVzrosloyChicken", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ptichnic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KolvoB = table.Column<int>(type: "integer", nullable: false),
                    KolvoN = table.Column<int>(type: "integer", nullable: false),
                    Pfeed = table.Column<bool>(type: "boolean", nullable: false),
                    Pwater = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ptichnic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reproductor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KolvoB = table.Column<int>(type: "integer", nullable: false),
                    KolvoN = table.Column<int>(type: "integer", nullable: false),
                    DateP = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Pfeed = table.Column<bool>(type: "boolean", nullable: false),
                    Pwater = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reproductor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UPK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KolvoB = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPK", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chicken");

            migrationBuilder.DropTable(
                name: "Otbrakovka");

            migrationBuilder.DropTable(
                name: "OtbrakovkaEggs");

            migrationBuilder.DropTable(
                name: "Othodi");

            migrationBuilder.DropTable(
                name: "PartiyaEggsRodClass");

            migrationBuilder.DropTable(
                name: "PartiyaMolodnyaka");

            migrationBuilder.DropTable(
                name: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropTable(
                name: "PartiyaTovarnEggs");

            migrationBuilder.DropTable(
                name: "PartiyaVzrosloyChicken");

            migrationBuilder.DropTable(
                name: "Ptichnic");

            migrationBuilder.DropTable(
                name: "Reproductor");

            migrationBuilder.DropTable(
                name: "UPK");

            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "NegodnayaChicken");

            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "KolvoN",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "Kolvo",
                table: "CehSortEggs");

            migrationBuilder.DropColumn(
                name: "Npart",
                table: "CehSortEggs");

            migrationBuilder.RenameColumn(
                name: "KolvoN",
                table: "NegodnayaChicken",
                newName: "kolvo");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CehProizvMelanja",
                newName: "Nceha");

            migrationBuilder.AddColumn<string>(
                name: "TypeChiсken",
                table: "NegodnayaChicken",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NIncubator",
                table: "Incubator",
                type: "integer",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeChiсken",
                table: "Incubator",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Nfabricata",
                table: "Fabrikat",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NIncubator",
                table: "ComplexProizvodstvaEggs",
                type: "integer",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NCeha",
                table: "CehSortEggs",
                type: "integer",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nceha",
                table: "CehPererabotkiOthodov",
                type: "integer",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }
    }
}
