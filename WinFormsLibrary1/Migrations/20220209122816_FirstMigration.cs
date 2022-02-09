using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CehProizvMelanja",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CehProizvMelanja", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CehSortEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    Npart = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CehSortEggs", x => x.ID);
                });

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
                name: "ComplexProizvodstvaEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kolvo = table.Column<string>(type: "text", nullable: false),
                    Pfeed = table.Column<bool>(type: "boolean", nullable: false),
                    Pwater = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplexProizvodstvaEggs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Incubator",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KolvoEggs = table.Column<int>(type: "integer", nullable: false),
                    DatePost = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DayOfBorn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FreeOrNotFree = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incubator", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LogPas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogPas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ptichnic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    TypeChicken = table.Column<string>(type: "text", nullable: false),
                    DatePost = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateGrow = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FreeOrNotFree = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ptichnic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reproductor",
                columns: table => new
                {
                    RepID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KolvoB = table.Column<int>(type: "integer", nullable: false, defaultValue: 200),
                    KolvoN = table.Column<int>(type: "integer", nullable: false, defaultValue: 1000)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reproductor", x => x.RepID);
                });

            migrationBuilder.CreateTable(
                name: "UPK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KolvoB = table.Column<int>(type: "integer", nullable: false),
                    FreeOrNotFree = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPK", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Melanj",
                columns: table => new
                {
                    Ntari = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeMelanga = table.Column<string>(type: "text", nullable: false),
                    DateRosliva = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CehPrMID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Melanj", x => x.Ntari);
                    table.ForeignKey(
                        name: "FK_Melanj_CehProizvMelanja_CehPrMID",
                        column: x => x.CehPrMID,
                        principalTable: "CehProizvMelanja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Othodi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kolvo = table.Column<string>(type: "text", nullable: true),
                    CehPrMID3 = table.Column<int>(type: "integer", nullable: true),
                    CePerOID2 = table.Column<int>(type: "integer", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "OtbrakovkaEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kolvo = table.Column<int>(type: "integer", nullable: false),
                    CehSortID3 = table.Column<int>(type: "integer", nullable: true),
                    CehPrMID2 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtbrakovkaEggs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OtbrakovkaEggs_CehProizvMelanja_CehPrMID2",
                        column: x => x.CehPrMID2,
                        principalTable: "CehProizvMelanja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtbrakovkaEggs_CehSortEggs_CehSortID3",
                        column: x => x.CehSortID3,
                        principalTable: "CehSortEggs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaTovarnEggs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    DateUp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CehSortID2 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaTovarnEggs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaTovarnEggs_CehSortEggs_CehSortID2",
                        column: x => x.CehSortID2,
                        principalTable: "CehSortEggs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NegodnayaChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KolvoB = table.Column<int>(type: "integer", nullable: false),
                    KolvoN = table.Column<int>(type: "integer", nullable: false),
                    CePerOID = table.Column<int>(type: "integer", nullable: true),
                    CoPrID3 = table.Column<int>(type: "integer", nullable: true)
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
                name: "PartiyaMolodnyaka",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataForm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FreeOrNotFree = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TypeChicken = table.Column<string>(type: "text", nullable: false),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    IncID = table.Column<int>(type: "integer", nullable: true),
                    PtID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaMolodnyaka", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaMolodnyaka_Incubator_IncID",
                        column: x => x.IncID,
                        principalTable: "Incubator",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartiyaMolodnyaka_Ptichnic_PtID",
                        column: x => x.PtID,
                        principalTable: "Ptichnic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaEggsRodClass",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    DatePostEggs = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FreeOrNotFree = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    RepID = table.Column<int>(type: "integer", nullable: true),
                    IncID2 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaEggsRodClass", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaEggsRodClass_Incubator_IncID2",
                        column: x => x.IncID2,
                        principalTable: "Incubator",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartiyaEggsRodClass_Reproductor_RepID",
                        column: x => x.RepID,
                        principalTable: "Reproductor",
                        principalColumn: "RepID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fabrikat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeFabr = table.Column<string>(type: "text", nullable: false),
                    DateUp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UPKID2 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabrikat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fabrikat_UPK_UPKID2",
                        column: x => x.UPKID2,
                        principalTable: "UPK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Otbrakovka",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    CePerOID3 = table.Column<int>(type: "integer", nullable: true),
                    UPKID3 = table.Column<int>(type: "integer", nullable: true)
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
                name: "PartiyaVzrosloyChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeChiсken = table.Column<string>(type: "text", nullable: true),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    DateForm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FreeOrNotFree = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    PtID2 = table.Column<int>(type: "integer", nullable: true),
                    CoPrID = table.Column<int>(type: "integer", nullable: true),
                    UPKID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiyaVzrosloyChicken", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartiyaVzrosloyChicken_ComplexProizvodstvaEggs_CoPrID",
                        column: x => x.CoPrID,
                        principalTable: "ComplexProizvodstvaEggs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartiyaVzrosloyChicken_Ptichnic_PtID2",
                        column: x => x.PtID2,
                        principalTable: "Ptichnic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartiyaVzrosloyChicken_UPK_UPKID",
                        column: x => x.UPKID,
                        principalTable: "UPK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartiyaRemontnayaVzrosloyChicken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeChiсken = table.Column<string>(type: "text", nullable: true),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    PaVzChID = table.Column<int>(type: "integer", nullable: false),
                    RepID2 = table.Column<int>(type: "integer", nullable: true)
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
                name: "IX_Fabrikat_UPKID2",
                table: "Fabrikat",
                column: "UPKID2");

            migrationBuilder.CreateIndex(
                name: "IX_Melanj_CehPrMID",
                table: "Melanj",
                column: "CehPrMID");

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
                name: "IX_OtbrakovkaEggs_CehPrMID2",
                table: "OtbrakovkaEggs",
                column: "CehPrMID2");

            migrationBuilder.CreateIndex(
                name: "IX_OtbrakovkaEggs_CehSortID3",
                table: "OtbrakovkaEggs",
                column: "CehSortID3");

            migrationBuilder.CreateIndex(
                name: "IX_Othodi_CehPrMID3",
                table: "Othodi",
                column: "CehPrMID3");

            migrationBuilder.CreateIndex(
                name: "IX_Othodi_CePerOID2",
                table: "Othodi",
                column: "CePerOID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggs_CehSortID",
                table: "PartiyaEggs",
                column: "CehSortID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggs_CoPrID2",
                table: "PartiyaEggs",
                column: "CoPrID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggsRodClass_IncID2",
                table: "PartiyaEggsRodClass",
                column: "IncID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaEggsRodClass_RepID",
                table: "PartiyaEggsRodClass",
                column: "RepID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaMolodnyaka_IncID",
                table: "PartiyaMolodnyaka",
                column: "IncID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaMolodnyaka_PtID",
                table: "PartiyaMolodnyaka",
                column: "PtID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_PaVzChID",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "PaVzChID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaRemontnayaVzrosloyChicken_RepID2",
                table: "PartiyaRemontnayaVzrosloyChicken",
                column: "RepID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaTovarnEggs_CehSortID2",
                table: "PartiyaTovarnEggs",
                column: "CehSortID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaVzrosloyChicken_CoPrID",
                table: "PartiyaVzrosloyChicken",
                column: "CoPrID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaVzrosloyChicken_PtID2",
                table: "PartiyaVzrosloyChicken",
                column: "PtID2");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaVzrosloyChicken_UPKID",
                table: "PartiyaVzrosloyChicken",
                column: "UPKID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chicken");

            migrationBuilder.DropTable(
                name: "Fabrikat");

            migrationBuilder.DropTable(
                name: "LogPas");

            migrationBuilder.DropTable(
                name: "Melanj");

            migrationBuilder.DropTable(
                name: "NegodnayaChicken");

            migrationBuilder.DropTable(
                name: "Otbrakovka");

            migrationBuilder.DropTable(
                name: "OtbrakovkaEggs");

            migrationBuilder.DropTable(
                name: "Othodi");

            migrationBuilder.DropTable(
                name: "PartiyaEggs");

            migrationBuilder.DropTable(
                name: "PartiyaEggsRodClass");

            migrationBuilder.DropTable(
                name: "PartiyaMolodnyaka");

            migrationBuilder.DropTable(
                name: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropTable(
                name: "PartiyaTovarnEggs");

            migrationBuilder.DropTable(
                name: "CehPererabotkiOthodov");

            migrationBuilder.DropTable(
                name: "CehProizvMelanja");

            migrationBuilder.DropTable(
                name: "Incubator");

            migrationBuilder.DropTable(
                name: "PartiyaVzrosloyChicken");

            migrationBuilder.DropTable(
                name: "Reproductor");

            migrationBuilder.DropTable(
                name: "CehSortEggs");

            migrationBuilder.DropTable(
                name: "ComplexProizvodstvaEggs");

            migrationBuilder.DropTable(
                name: "Ptichnic");

            migrationBuilder.DropTable(
                name: "UPK");
        }
    }
}
