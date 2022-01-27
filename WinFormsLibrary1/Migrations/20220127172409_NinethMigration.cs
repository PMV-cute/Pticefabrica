using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WinFormsLibrary1.Migrations
{
    public partial class NinethMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartiyaBr");

            migrationBuilder.DropTable(
                name: "PartiyaNes");

            migrationBuilder.DropColumn(
                name: "DateP",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "feed",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "water",
                table: "Reproductor");

            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "Ptichnic");

            migrationBuilder.DropColumn(
                name: "Pfeed",
                table: "Ptichnic");

            migrationBuilder.DropColumn(
                name: "Pwater",
                table: "Ptichnic");

            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "KolvoN",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "KolvoN",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "KolvoB",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "KolvoN",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "DatePostupleniya",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "max",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "time",
                table: "Incubator");

            migrationBuilder.RenameColumn(
                name: "KolvoN",
                table: "Ptichnic",
                newName: "Kolvo");

            migrationBuilder.RenameColumn(
                name: "Npart",
                table: "PartiyaVzrosloyChicken",
                newName: "Kolvo");

            migrationBuilder.RenameColumn(
                name: "Npart",
                table: "PartiyaRemontnayaVzrosloyChicken",
                newName: "Kolvo");

            migrationBuilder.RenameColumn(
                name: "Npart",
                table: "PartiyaMolodnyaka",
                newName: "Kolvo");

            migrationBuilder.AlterColumn<int>(
                name: "KolvoB",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 1300,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateGrow",
                table: "Ptichnic",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePost",
                table: "Ptichnic",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "Ptichnic",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeChicken",
                table: "Ptichnic",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TypeChiсken",
                table: "PartiyaVzrosloyChicken",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "CoPrID",
                table: "PartiyaVzrosloyChicken",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateForm",
                table: "PartiyaVzrosloyChicken",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UPKID",
                table: "PartiyaVzrosloyChicken",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeChiсken",
                table: "PartiyaRemontnayaVzrosloyChicken",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataForm",
                table: "PartiyaMolodnyaka",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "PartiyaMolodnyaka",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeChicken",
                table: "PartiyaMolodnyaka",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePostEggs",
                table: "PartiyaEggsRodClass",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "PartiyaEggsRodClass",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePost",
                table: "Incubator",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DayOfBorn",
                table: "Incubator",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "FreeOrNotFree",
                table: "Incubator",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaVzrosloyChicken_CoPrID",
                table: "PartiyaVzrosloyChicken",
                column: "CoPrID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaVzrosloyChicken_UPKID",
                table: "PartiyaVzrosloyChicken",
                column: "UPKID");

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaVzrosloyChicken_ComplexProizvodstvaEggs_CoPrID",
                table: "PartiyaVzrosloyChicken",
                column: "CoPrID",
                principalTable: "ComplexProizvodstvaEggs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiyaVzrosloyChicken_UPK_UPKID",
                table: "PartiyaVzrosloyChicken",
                column: "UPKID",
                principalTable: "UPK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaVzrosloyChicken_ComplexProizvodstvaEggs_CoPrID",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiyaVzrosloyChicken_UPK_UPKID",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaVzrosloyChicken_CoPrID",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropIndex(
                name: "IX_PartiyaVzrosloyChicken_UPKID",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "DateGrow",
                table: "Ptichnic");

            migrationBuilder.DropColumn(
                name: "DatePost",
                table: "Ptichnic");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "Ptichnic");

            migrationBuilder.DropColumn(
                name: "TypeChicken",
                table: "Ptichnic");

            migrationBuilder.DropColumn(
                name: "CoPrID",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "DateForm",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "UPKID",
                table: "PartiyaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "TypeChiсken",
                table: "PartiyaRemontnayaVzrosloyChicken");

            migrationBuilder.DropColumn(
                name: "DataForm",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "TypeChicken",
                table: "PartiyaMolodnyaka");

            migrationBuilder.DropColumn(
                name: "DatePostEggs",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "PartiyaEggsRodClass");

            migrationBuilder.DropColumn(
                name: "DatePost",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "DayOfBorn",
                table: "Incubator");

            migrationBuilder.DropColumn(
                name: "FreeOrNotFree",
                table: "Incubator");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "Ptichnic",
                newName: "KolvoN");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "PartiyaVzrosloyChicken",
                newName: "Npart");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "PartiyaRemontnayaVzrosloyChicken",
                newName: "Npart");

            migrationBuilder.RenameColumn(
                name: "Kolvo",
                table: "PartiyaMolodnyaka",
                newName: "Npart");

            migrationBuilder.AlterColumn<int>(
                name: "KolvoB",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1300);

            migrationBuilder.AddColumn<string>(
                name: "DateP",
                table: "Reproductor",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "feed",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "water",
                table: "Reproductor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "Ptichnic",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Pfeed",
                table: "Ptichnic",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Pwater",
                table: "Ptichnic",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "TypeChiсken",
                table: "PartiyaVzrosloyChicken",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "PartiyaVzrosloyChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoN",
                table: "PartiyaVzrosloyChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "PartiyaRemontnayaVzrosloyChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoN",
                table: "PartiyaRemontnayaVzrosloyChicken",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoB",
                table: "PartiyaMolodnyaka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KolvoN",
                table: "PartiyaMolodnyaka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DatePostupleniya",
                table: "Incubator",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "max",
                table: "Incubator",
                type: "double precision",
                nullable: false,
                defaultValue: 10000.0);

            migrationBuilder.AddColumn<int>(
                name: "time",
                table: "Incubator",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartiyaBr",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    PaVzChID = table.Column<int>(type: "integer", nullable: false),
                    PartiyaVzrosloyChickenID = table.Column<int>(type: "integer", nullable: true),
                    TypeChiсken = table.Column<string>(type: "text", nullable: false),
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
                name: "PartiyaNes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoPrID = table.Column<int>(type: "integer", nullable: false),
                    Kolvo = table.Column<int>(type: "integer", nullable: false),
                    Npart = table.Column<int>(type: "integer", nullable: false),
                    PaVzChID = table.Column<int>(type: "integer", nullable: false),
                    PartiyaVzrosloyChickenID = table.Column<int>(type: "integer", nullable: true),
                    TypeChiсken = table.Column<string>(type: "text", nullable: false)
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
                name: "IX_PartiyaBr_PartiyaVzrosloyChickenID",
                table: "PartiyaBr",
                column: "PartiyaVzrosloyChickenID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaBr_UPKID",
                table: "PartiyaBr",
                column: "UPKID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaNes_CoPrID",
                table: "PartiyaNes",
                column: "CoPrID");

            migrationBuilder.CreateIndex(
                name: "IX_PartiyaNes_PartiyaVzrosloyChickenID",
                table: "PartiyaNes",
                column: "PartiyaVzrosloyChickenID");
        }
    }
}
