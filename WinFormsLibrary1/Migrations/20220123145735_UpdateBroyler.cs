using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class UpdateBroyler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Broyler");

            migrationBuilder.CreateTable(
                name: "Incubator",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NIncubator = table.Column<int>(type: "integer", maxLength: 10, nullable: false),
                    TypeChiсken = table.Column<string>(type: "text", nullable: false),
                    DatePostupleniya = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incubator", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NegodnayaChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeChiсken = table.Column<string>(type: "text", nullable: false),
                    kolvo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NegodnayaChicken", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incubator");

            migrationBuilder.DropTable(
                name: "NegodnayaChicken");

            migrationBuilder.CreateTable(
                name: "Broyler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeChiсken = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Broyler", x => x.ID);
                });
        }
    }
}
