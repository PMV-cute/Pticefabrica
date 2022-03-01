using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class _6Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NegodnayaChicken");

            migrationBuilder.DropTable(
                name: "Otbrakovka");

            migrationBuilder.DropTable(
                name: "Othodi");

            migrationBuilder.DropTable(
                name: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropTable(
                name: "CehPererabotkiOthodov");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropColumn(
                name: "Npart",
                table: "CehSortEggs");

            migrationBuilder.RenameColumn(
                name: "Npart",
                table: "PartiyaTovarnEggs",
                newName: "Kolvo");

            migrationBuilder.AddColumn<int>(
                name: "Categori",
                table: "PartiyaTovarnEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "PartiyaEggs",
                type: "boolean",
                nullable: false,
                defaultValue: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "Cikl",
                table: "ComplexProizvodstvaEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "CiklMax",
                table: "ComplexProizvodstvaEggs",
                type: "integer",
                nullable: false,
                defaultValue: 10);

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
                name: "Categori",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "PartiyaEggs");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropColumn(
                name: "CiklMax",
                table: "ComplexProizvodstvaEggs");

            migrationBuilder.DropColumn(
                name: "DateForm",
                table: "CehSortEggs");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "CehSortEggs");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "PartiyaTovarnEggs",
                newName: "Npart");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "PartiyaTovarnEggs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Cikl",
                table: "ComplexProizvodstvaEggs",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Npart",
                table: "CehSortEggs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CehPererabotkiOthodov",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NormsPererab = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CehPererabotkiOthodov", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaRemontnayaVzrosloyChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    PaVzChID = table.Column<int>(type: "integer", nullable: false),
                    RepID2 = table.Column<int>(type: "integer", nullable: true),
                    TypeChiсken = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaRemontnayaVzrosloyChicken", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaRemontnayaVzrosloyChicken_PartiyaVzrosloyChicken_PaV~",
                        column: x => x.PaVzChID,
                        principalTable: "PartiyaVzrosloyChicken",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiyaRemontnayaVzrosloyChicken_Reproductor_RepID2",
                        column: x => x.RepID2,
                        principalTable: "Reproductor",
                        principalColumn: "RepID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NegodnayaChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CePerOID = table.Column<int>(type: "integer", nullable: true),
                    CoPrID3 = table.Column<int>(type: "integer", nullable: true),
                    Kolvo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NegodnayaChicken", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NegodnayaChicken_CehPererabotkiOthodov_CePerOID",
                        column: x => x.CePerOID,
                        principalTable: "CehPererabotkiOthodov",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NegodnayaChicken_ComplexProizvodstvaEggs_CoPrID3",
                        column: x => x.CoPrID3,
                        principalTable: "ComplexProizvodstvaEggs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Otbrakovka",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CePerOID3 = table.Column<int>(type: "integer", nullable: true),
                    UPKID3 = table.Column<int>(type: "integer", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otbrakovka", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Otbrakovka_CehPererabotkiOthodov_CePerOID3",
                        column: x => x.CePerOID3,
                        principalTable: "CehPererabotkiOthodov",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Otbrakovka_UPK_UPKID3",
                        column: x => x.UPKID3,
                        principalTable: "UPK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Othodi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CePerOID2 = table.Column<int>(type: "integer", nullable: true),
                    CehPrMID3 = table.Column<int>(type: "integer", nullable: true),
                    kolvo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Othodi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Othodi_CehPererabotkiOthodov_CePerOID2",
                        column: x => x.CePerOID2,
                        principalTable: "CehPererabotkiOthodov",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Othodi_CehProizvMelanja_CehPrMID3",
                        column: x => x.CehPrMID3,
                        principalTable: "CehProizvMelanja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NegodnayaChicken_CePerOID",
                table: "NegodnayaChicken",
                column: "CePerOID");

            migrationBuilder.CreateIndex(
                name: "IX_NegodnayaChicken_CoPrID3",
                table: "NegodnayaChicken",
                column: "CoPrID3");

            migrationBuilder.CreateIndex(
                name: "IX_Otbrakovka_CePerOID3",
                table: "Otbrakovka",
                column: "CePerOID3");

            migrationBuilder.CreateIndex(
                name: "IX_Otbrakovka_UPKID3",
                table: "Otbrakovka",
                column: "UPKID3");

            migrationBuilder.CreateIndex(
                name: "IX_Othodi_CehPrMID3",
                table: "Othodi",
                column: "CehPrMID3");

            migrationBuilder.CreateIndex(
                name: "IX_Othodi_CePerOID2",
                table: "Othodi",
                column: "CePerOID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_PaVzChID",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "PaVzChID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "RepID2");
        }
    }
}
