using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class _8Migration : Migration
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
                name: "CehPererabotkiOthodov");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
