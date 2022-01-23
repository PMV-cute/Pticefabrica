using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CehSortEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NCeha = table.Column<int>(type: "integer", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CehSortEggs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ComplexProizvodstvaEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NIncubator = table.Column<int>(type: "integer", maxLength: 10, nullable: false),
                    Kolvo = table.Column<string>(type: "text", nullable: false),
                    Pfeed = table.Column<bool>(type: "boolean", nullable: false),
                    Pwater = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplexProizvodstvaEggs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fabrikat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nfabricata = table.Column<int>(type: "integer", nullable: false),
                    TypeFabr = table.Column<string>(type: "text", nullable: false),
                    DateUp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabrikat", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CehSortEggs");

            migrationBuilder.DropTable(
                name: "ComplexProizvodstvaEggs");

            migrationBuilder.DropTable(
                name: "Fabrikat");
        }
    }
}
