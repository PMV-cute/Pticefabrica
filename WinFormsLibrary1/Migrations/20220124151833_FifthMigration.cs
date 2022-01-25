using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "PartiyaEggsRodClass");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Reproductor",
                newName: "RepID");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "PartiyaVzrosloyChicken",
                newName: "KolvoN");

            migrationBuilder.RenameColumn(
                name: "KolvoN",
                table: "PartiyaEggsRodClass",
                newName: "Kolvo");

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "PartiyaVzrosloyChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PtID2",
                table: "PartiyaVzrosloyChicken",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CehSortID2",
                table: "PartiyaTovarnEggs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaVzChID",
                table: "PartiyaRemontnayaVzrosloyChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IncID",
                table: "PartiyaMolodnyaka",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PtID",
                table: "PartiyaMolodnyaka",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IncID2",
                table: "PartiyaEggsRodClass",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RepID",
                table: "PartiyaEggsRodClass",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CePerOID2",
                table: "Othodi",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CehPrMID3",
                table: "Othodi",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CehPrMID2",
                table: "OtbrakovkaEggs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CehSortID3",
                table: "OtbrakovkaEggs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CePerOID3",
                table: "Otbrakovka",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UPKID3",
                table: "Otbrakovka",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CePerOID",
                table: "NegodnayaChicken",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoPrID3",
                table: "NegodnayaChicken",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CehPrMID",
                table: "Melanj",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UPKID2",
                table: "Fabrikat",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartiyaBr",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    TypeChiсken = table.Column<string>(type: "text", nullable: false),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    PaVzChID = table.Column<int>(type: "integer", nullable: false),
                    PartiyaVzrosloyChickenID = table.Column<int>(type: "integer", nullable: true),
                    UPKID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaBr", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaBr_PartiyaVzrosloyChicken_PartiyaVzrosloyChickenID",
                        column: x => x.PartiyaVzrosloyChickenID,
                        principalTable: "PartiyaVzrosloyChicken",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartiyaBr_UPK_UPKID",
                        column: x => x.UPKID,
                        principalTable: "UPK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    CoPrID2 = table.Column<int>(type: "integer", nullable: true),
                    CehSortID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaEggs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaEggs_CehSortEggs_CehSortID",
                        column: x => x.CehSortID,
                        principalTable: "CehSortEggs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartiyaEggs_ComplexProizvodstvaEggs_CoPrID2",
                        column: x => x.CoPrID2,
                        principalTable: "ComplexProizvodstvaEggs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaNes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    TypeChiсken = table.Column<string>(type: "text", nullable: false),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    PaVzChID = table.Column<int>(type: "integer", nullable: false),
                    PartiyaVzrosloyChickenID = table.Column<int>(type: "integer", nullable: true),
                    CoPrID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaNes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaNes_ComplexProizvodstvaEggs_CoPrID",
                        column: x => x.CoPrID,
                        principalTable: "ComplexProizvodstvaEggs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiyaNes_PartiyaVzrosloyChicken_PartiyaVzrosloyChickenID",
                        column: x => x.PartiyaVzrosloyChickenID,
                        principalTable: "PartiyaVzrosloyChicken",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaVzrosloyChicken_PtID2",
                table: "PartiyaVzrosloyChicken",
                column: "PtID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaTovarnEggs_CehSortID2",
                table: "PartiyaTovarnEggs",
                column: "CehSortID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_PaVzChID",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "PaVzChID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "RepID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaMolodnyaka_IncID",
                table: "PartiyaMolodnyaka",
                column: "IncID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaMolodnyaka_PtID",
                table: "PartiyaMolodnyaka",
                column: "PtID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggsRodClass_IncID2",
                table: "PartiyaEggsRodClass",
                column: "IncID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggsRodClass_RepID",
                table: "PartiyaEggsRodClass",
                column: "RepID");

            migrationBuilder.CreateIndex(
                name: "IX_Othodi_CehPrMID3",
                table: "Othodi",
                column: "CehPrMID3");

            migrationBuilder.CreateIndex(
                name: "IX_Othodi_CePerOID2",
                table: "Othodi",
                column: "CePerOID2");

            migrationBuilder.CreateIndex(
                name: "IX_OtbrakovkaEggs_CehPrMID2",
                table: "OtbrakovkaEggs",
                column: "CehPrMID2");

            migrationBuilder.CreateIndex(
                name: "IX_OtbrakovkaEggs_CehSortID3",
                table: "OtbrakovkaEggs",
                column: "CehSortID3");

            migrationBuilder.CreateIndex(
                name: "IX_Otbrakovka_CePerOID3",
                table: "Otbrakovka",
                column: "CePerOID3");

            migrationBuilder.CreateIndex(
                name: "IX_Otbrakovka_UPKID3",
                table: "Otbrakovka",
                column: "UPKID3");

            migrationBuilder.CreateIndex(
                name: "IX_NegodnayaChicken_CePerOID",
                table: "NegodnayaChicken",
                column: "CePerOID");

            migrationBuilder.CreateIndex(
                name: "IX_NegodnayaChicken_CoPrID3",
                table: "NegodnayaChicken",
                column: "CoPrID3");

            migrationBuilder.CreateIndex(
                name: "IX_Melanj_CehPrMID",
                table: "Melanj",
                column: "CehPrMID");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrikat_UPKID2",
                table: "Fabrikat",
                column: "UPKID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaBr_PartiyaVzrosloyChickenID",
                table: "PartiyaBr",
                column: "PartiyaVzrosloyChickenID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaBr_UPKID",
                table: "PartiyaBr",
                column: "UPKID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggs_CehSortID",
                table: "PartiyaEggs",
                column: "CehSortID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggs_CoPrID2",
                table: "PartiyaEggs",
                column: "CoPrID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaNes_CoPrID",
                table: "PartiyaNes",
                column: "CoPrID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaNes_PartiyaVzrosloyChickenID",
                table: "PartiyaNes",
                column: "PartiyaVzrosloyChickenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Fabrikat_UPK_UPKID2",
                table: "Fabrikat",
                column: "UPKID2",
                principalTable: "UPK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Melanj_CehProizvMelanja_CehPrMID",
                table: "Melanj",
                column: "CehPrMID",
                principalTable: "CehProizvMelanja",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NegodnayaChicken_CehPererabotkiOthodov_CePerOID",
                table: "NegodnayaChicken",
                column: "CePerOID",
                principalTable: "CehPererabotkiOthodov",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NegodnayaChicken_ComplexProizvodstvaEggs_CoPrID3",
                table: "NegodnayaChicken",
                column: "CoPrID3",
                principalTable: "ComplexProizvodstvaEggs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Otbrakovka_CehPererabotkiOthodov_CePerOID3",
                table: "Otbrakovka",
                column: "CePerOID3",
                principalTable: "CehPererabotkiOthodov",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Otbrakovka_UPK_UPKID3",
                table: "Otbrakovka",
                column: "UPKID3",
                principalTable: "UPK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtbrakovkaEggs_CehProizvMelanja_CehPrMID2",
                table: "OtbrakovkaEggs",
                column: "CehPrMID2",
                principalTable: "CehProizvMelanja",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtbrakovkaEggs_CehSortEggs_CehSortID3",
                table: "OtbrakovkaEggs",
                column: "CehSortID3",
                principalTable: "CehSortEggs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Othodi_CehPererabotkiOthodov_CePerOID2",
                table: "Othodi",
                column: "CePerOID2",
                principalTable: "CehPererabotkiOthodov",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Othodi_CehProizvMelanja_CehPrMID3",
                table: "Othodi",
                column: "CehPrMID3",
                principalTable: "CehProizvMelanja",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaEggsRodClass_Incubator_IncID2",
                table: "PartiyaEggsRodClass",
                column: "IncID2",
                principalTable: "Incubator",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaEggsRodClass_Reproductor_RepID",
                table: "PartiyaEggsRodClass",
                column: "RepID",
                principalTable: "Reproductor",
                principalColumn: "RepID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaMolodnyaka_Incubator_IncID",
                table: "PartiyaMolodnyaka",
                column: "IncID",
                principalTable: "Incubator",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaMolodnyaka_Ptichnic_PtID",
                table: "PartiyaMolodnyaka",
                column: "PtID",
                principalTable: "Ptichnic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaRemontnayaVzrosloyChicken_PartiyaVzrosloyChicken_PaV~",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "PaVzChID",
                principalTable: "PartiyaVzrosloyChicken",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaRemontnayaVzrosloyChicken_Reproductor_RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "RepID2",
                principalTable: "Reproductor",
                principalColumn: "RepID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaTovarnEggs_CehSortEggs_CehSortID2",
                table: "PartiyaTovarnEggs",
                column: "CehSortID2",
                principalTable: "CehSortEggs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaVzrosloyChicken_Ptichnic_PtID2",
                table: "PartiyaVzrosloyChicken",
                column: "PtID2",
                principalTable: "Ptichnic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fabrikat_UPK_UPKID2",
                table: "Fabrikat");

            migrationBuilder.DropForeignKey(
                name: "FK_Melanj_CehProizvMelanja_CehPrMID",
                table: "Melanj");

            migrationBuilder.DropForeignKey(
                name: "FK_NegodnayaChicken_CehPererabotkiOthodov_CePerOID",
                table: "NegodnayaChicken");

            migrationBuilder.DropForeignKey(
                name: "FK_NegodnayaChicken_ComplexProizvodstvaEggs_CoPrID3",
                table: "NegodnayaChicken");

            migrationBuilder.DropForeignKey(
                name: "FK_Otbrakovka_CehPererabotkiOthodov_CePerOID3",
                table: "Otbrakovka");

            migrationBuilder.DropForeignKey(
                name: "FK_Otbrakovka_UPK_UPKID3",
                table: "Otbrakovka");

            migrationBuilder.DropForeignKey(
                name: "FK_OtbrakovkaEggs_CehProizvMelanja_CehPrMID2",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropForeignKey(
                name: "FK_OtbrakovkaEggs_CehSortEggs_CehSortID3",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropForeignKey(
                name: "FK_Othodi_CehPererabotkiOthodov_CePerOID2",
                table: "Othodi");

            migrationBuilder.DropForeignKey(
                name: "FK_Othodi_CehProizvMelanja_CehPrMID3",
                table: "Othodi");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaEggsRodClass_Incubator_IncID2",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaEggsRodClass_Reproductor_RepID",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaMolodnyaka_Incubator_IncID",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaMolodnyaka_Ptichnic_PtID",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaRemontnayaVzrosloyChicken_PartiyaVzrosloyChicken_PaV~",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaRemontnayaVzrosloyChicken_Reproductor_RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaTovarnEggs_CehSortEggs_CehSortID2",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaVzrosloyChicken_Ptichnic_PtID2",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropTable(
                name: "PartiyaBr");

            migrationBuilder.DropTable(
                name: "PartiyaEggs");

            migrationBuilder.DropTable(
                name: "PartiyaNes");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaVzrosloyChicken_PtID2",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaTovarnEggs_CehSortID2",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_PaVzChID",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaMolodnyaka_IncID",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaMolodnyaka_PtID",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaEggsRodClass_IncID2",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaEggsRodClass_RepID",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropIndex(
                name: "IX_Othodi_CehPrMID3",
                table: "Othodi");

            migrationBuilder.DropIndex(
                name: "IX_Othodi_CePerOID2",
                table: "Othodi");

            migrationBuilder.DropIndex(
                name: "IX_OtbrakovkaEggs_CehPrMID2",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropIndex(
                name: "IX_OtbrakovkaEggs_CehSortID3",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropIndex(
                name: "IX_Otbrakovka_CePerOID3",
                table: "Otbrakovka");

            migrationBuilder.DropIndex(
                name: "IX_Otbrakovka_UPKID3",
                table: "Otbrakovka");

            migrationBuilder.DropIndex(
                name: "IX_NegodnayaChicken_CePerOID",
                table: "NegodnayaChicken");

            migrationBuilder.DropIndex(
                name: "IX_NegodnayaChicken_CoPrID3",
                table: "NegodnayaChicken");

            migrationBuilder.DropIndex(
                name: "IX_Melanj_CehPrMID",
                table: "Melanj");

            migrationBuilder.DropIndex(
                name: "IX_Fabrikat_UPKID2",
                table: "Fabrikat");

            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "PtID2",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "CehSortID2",
                table: "PartiyaTovarnEggs");

            migrationBuilder.DropColumn(
                name: "PaVzChID",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "IncID",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "PtID",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "IncID2",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropColumn(
                name: "RepID",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropColumn(
                name: "CePerOID2",
                table: "Othodi");

            migrationBuilder.DropColumn(
                name: "CehPrMID3",
                table: "Othodi");

            migrationBuilder.DropColumn(
                name: "CehPrMID2",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropColumn(
                name: "CehSortID3",
                table: "OtbrakovkaEggs");

            migrationBuilder.DropColumn(
                name: "CePerOID3",
                table: "Otbrakovka");

            migrationBuilder.DropColumn(
                name: "UPKID3",
                table: "Otbrakovka");

            migrationBuilder.DropColumn(
                name: "CePerOID",
                table: "NegodnayaChicken");

            migrationBuilder.DropColumn(
                name: "CoPrID3",
                table: "NegodnayaChicken");

            migrationBuilder.DropColumn(
                name: "CehPrMID",
                table: "Melanj");

            migrationBuilder.DropColumn(
                name: "UPKID2",
                table: "Fabrikat");

            migrationBuilder.RenameColumn(
                name: "RepID",
                table: "Reproductor",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "KolvoN",
                table: "PartiyaVzrosloyChicken",
                newName: "Kolvo");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "PartiyaEggsRodClass",
                newName: "KolvoN");

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "PartiyaEggsRodClass",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
