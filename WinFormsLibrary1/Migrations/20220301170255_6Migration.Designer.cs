// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WinFormsLibrary1;

namespace WinFormsLibrary1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220301170255_6Migration")]
    partial class _6Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WinFormsLibrary1.Entity.CehProizvMelanja", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("ID");

                    b.ToTable("CehProizvMelanja");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.CehSortEggs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateForm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .HasColumnType("boolean");

                    b.Property<int>("Kolvo")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("CehSortEggs");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Chicken", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("TypeChiсken")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("ID");

                    b.ToTable("Chicken");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.ComplexProizvodstvaEggs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cikl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("CiklMax")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(10);

                    b.Property<DateTime>("DateForm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("KolvoN")
                        .HasColumnType("integer");

                    b.Property<bool>("Pfeed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("Pwater")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.HasKey("ID");

                    b.ToTable("ComplexProizvodstvaEggs");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Fabrikat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateUp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UPKID2")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UPKID2");

                    b.ToTable("Fabrikat");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Incubator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DatePost")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DayOfBorn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("KolvoEggs")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Incubator");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.LogPas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("LogPas");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Melanj", b =>
                {
                    b.Property<int>("Ntari")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CehPrMID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateRosliva")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TypeMelanga")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Ntari");

                    b.HasIndex("CehPrMID");

                    b.ToTable("Melanj");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.OtbrakovkaEggs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CehPrMID2")
                        .HasColumnType("integer");

                    b.Property<int?>("CehSortID3")
                        .HasColumnType("integer");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("kolvo")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("CehPrMID2");

                    b.HasIndex("CehSortID3");

                    b.ToTable("OtbrakovkaEggs");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaEggs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CehSortID")
                        .HasColumnType("integer");

                    b.Property<int?>("CoPrID2")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateForm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("Kolvo")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("CehSortID");

                    b.HasIndex("CoPrID2");

                    b.ToTable("PartiyaEggs");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaEggsRodClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DatePostEggs")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int?>("IncID2")
                        .HasColumnType("integer");

                    b.Property<int>("Kolvo")
                        .HasColumnType("integer");

                    b.Property<int?>("RepID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("IncID2");

                    b.HasIndex("RepID");

                    b.ToTable("PartiyaEggsRodClass");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaMolodnyaka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DataForm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int?>("IncID")
                        .HasColumnType("integer");

                    b.Property<int>("Kolvo")
                        .HasColumnType("integer");

                    b.Property<int?>("PtID")
                        .HasColumnType("integer");

                    b.Property<string>("TypeChicken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("IncID");

                    b.HasIndex("PtID");

                    b.ToTable("PartiyaMolodnyaka");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaTovarnEggs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Categori")
                        .HasColumnType("integer");

                    b.Property<int?>("CehSortID2")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateUp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Kolvo")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("CehSortID2");

                    b.ToTable("PartiyaTovarnEggs");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaVzrosloyChicken", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CoPrID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateForm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("Kolvo")
                        .HasColumnType("integer");

                    b.Property<int?>("PtID2")
                        .HasColumnType("integer");

                    b.Property<string>("TypeChiсken")
                        .HasColumnType("text");

                    b.Property<int?>("UPKID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("CoPrID");

                    b.HasIndex("PtID2");

                    b.HasIndex("UPKID");

                    b.ToTable("PartiyaVzrosloyChicken");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Ptichnic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateGrow")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DatePost")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("Kolvo")
                        .HasColumnType("integer");

                    b.Property<string>("TypeChicken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Ptichnic");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Reproductor", b =>
                {
                    b.Property<int>("RepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("KolvoB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("KolvoN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("maxB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(200);

                    b.Property<int>("maxN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1000);

                    b.HasKey("RepID");

                    b.ToTable("Reproductor");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.UPK", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Dateform")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("FreeOrNotFree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("KolvoB")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("UPK");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Fabrikat", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.UPK", null)
                        .WithMany("Fabrikats")
                        .HasForeignKey("UPKID2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Melanj", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.CehProizvMelanja", null)
                        .WithMany("Melanjs")
                        .HasForeignKey("CehPrMID");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.OtbrakovkaEggs", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.CehProizvMelanja", null)
                        .WithMany("OtbrakovkaEggses")
                        .HasForeignKey("CehPrMID2");

                    b.HasOne("WinFormsLibrary1.Entity.CehSortEggs", null)
                        .WithMany("OtbrakovkaEggses")
                        .HasForeignKey("CehSortID3");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaEggs", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.CehSortEggs", null)
                        .WithMany("PartiyaEggses")
                        .HasForeignKey("CehSortID");

                    b.HasOne("WinFormsLibrary1.Entity.ComplexProizvodstvaEggs", null)
                        .WithMany("PartiyaEggses")
                        .HasForeignKey("CoPrID2");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaEggsRodClass", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.Incubator", "Incubator")
                        .WithMany("PartiyaEggsRodClass")
                        .HasForeignKey("IncID2");

                    b.HasOne("WinFormsLibrary1.Entity.Reproductor", null)
                        .WithMany("PartiyaEggsRodClasses")
                        .HasForeignKey("RepID");

                    b.Navigation("Incubator");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaMolodnyaka", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.Incubator", null)
                        .WithMany("PartiyaMolodnyakas")
                        .HasForeignKey("IncID");

                    b.HasOne("WinFormsLibrary1.Entity.Ptichnic", null)
                        .WithMany("PartiyaMolodnyakas")
                        .HasForeignKey("PtID");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaTovarnEggs", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.CehSortEggs", null)
                        .WithMany("PartiyaTovarnEggses")
                        .HasForeignKey("CehSortID2");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.PartiyaVzrosloyChicken", b =>
                {
                    b.HasOne("WinFormsLibrary1.Entity.ComplexProizvodstvaEggs", null)
                        .WithMany("PartiyaVzrosloyChickens")
                        .HasForeignKey("CoPrID");

                    b.HasOne("WinFormsLibrary1.Entity.Ptichnic", null)
                        .WithMany("PartiyaVzrosloyChickens")
                        .HasForeignKey("PtID2");

                    b.HasOne("WinFormsLibrary1.Entity.UPK", null)
                        .WithMany("PartiyaVzrosloyChickens")
                        .HasForeignKey("UPKID");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.CehProizvMelanja", b =>
                {
                    b.Navigation("Melanjs");

                    b.Navigation("OtbrakovkaEggses");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.CehSortEggs", b =>
                {
                    b.Navigation("OtbrakovkaEggses");

                    b.Navigation("PartiyaEggses");

                    b.Navigation("PartiyaTovarnEggses");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.ComplexProizvodstvaEggs", b =>
                {
                    b.Navigation("PartiyaEggses");

                    b.Navigation("PartiyaVzrosloyChickens");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Incubator", b =>
                {
                    b.Navigation("PartiyaEggsRodClass");

                    b.Navigation("PartiyaMolodnyakas");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Ptichnic", b =>
                {
                    b.Navigation("PartiyaMolodnyakas");

                    b.Navigation("PartiyaVzrosloyChickens");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Reproductor", b =>
                {
                    b.Navigation("PartiyaEggsRodClasses");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.UPK", b =>
                {
                    b.Navigation("Fabrikats");

                    b.Navigation("PartiyaVzrosloyChickens");
                });
#pragma warning restore 612, 618
        }
    }
}
