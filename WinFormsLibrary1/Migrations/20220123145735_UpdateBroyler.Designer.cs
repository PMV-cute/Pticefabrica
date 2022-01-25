﻿// <auto-generated />
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
    [Migration("20220123145735_UpdateBroyler")]
    partial class UpdateBroyler
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WinFormsLibrary1.Entity.CehPererabotkiOthodov", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Nceha")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<string>("NormsPererab")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("ID");

                    b.ToTable("CehPererabotkiOthodov");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.CehProizvMelanja", b =>
                {
                    b.Property<int>("Nceha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("Nceha");

                    b.ToTable("CehProizvMelanja");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.CehSortEggs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("NCeha")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("CehSortEggs");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.ComplexProizvodstvaEggs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Kolvo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NIncubator")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<bool>("Pfeed")
                        .HasColumnType("boolean");

                    b.Property<bool>("Pwater")
                        .HasColumnType("boolean");

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

                    b.Property<int>("Nfabricata")
                        .HasColumnType("integer");

                    b.Property<string>("TypeFabr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Fabrikat");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.Incubator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DatePostupleniya")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("NIncubator")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<string>("TypeChiсken")
                        .IsRequired()
                        .HasColumnType("text");

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

                    b.Property<DateTime>("DateRosliva")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TypeMelanga")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Ntari");

                    b.ToTable("Melanj");
                });

            modelBuilder.Entity("WinFormsLibrary1.Entity.NegodnayaChicken", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("TypeChiсken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("kolvo")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("NegodnayaChicken");
                });
#pragma warning restore 612, 618
        }
    }
}