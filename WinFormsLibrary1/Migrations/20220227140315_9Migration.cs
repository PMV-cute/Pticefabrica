using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class _9Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartiyaRemontnayaVzrosloyChicken");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
