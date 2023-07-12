﻿// <auto-generated />
using System;
using EleccionsM2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EleccionsM2.Migrations
{
    [DbContext(typeof(EleccionsMContext))]
    [Migration("20230712071505_cambiopcyclases5")]
    partial class cambiopcyclases5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EleccionsM2.Models.Candidat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long?>("PartitMunicipiID")
                        .HasColumnType("bigint");

                    b.Property<string>("nomCandidat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PartitMunicipiID");

                    b.ToTable("Candidats");
                });

            modelBuilder.Entity("EleccionsM2.Models.Municipi", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("nomMunicipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroRegidors")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Municipis");
                });

            modelBuilder.Entity("EleccionsM2.Models.PartitMunicipi", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long?>("MunicipiID")
                        .HasColumnType("bigint");

                    b.Property<string>("nomPartit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MunicipiID");

                    b.ToTable("PartitsPolitics");
                });

            modelBuilder.Entity("EleccionsM2.Models.ResultatsTaula", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<int>("votsBlanc")
                        .HasColumnType("int");

                    b.Property<int>("votsNul")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ResultatsTaules");
                });

            modelBuilder.Entity("EleccionsM2.Models.TaulaElectoral", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long?>("MunicipiID")
                        .HasColumnType("bigint");

                    b.Property<int>("censTaula")
                        .HasColumnType("int");

                    b.Property<string>("nomTaula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("resultatsTaulaID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("MunicipiID");

                    b.HasIndex("resultatsTaulaID");

                    b.ToTable("TaulesElectorals");
                });

            modelBuilder.Entity("EleccionsM2.Models.VotsPerLlista", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long?>("ResultatsTaulaID")
                        .HasColumnType("bigint");

                    b.Property<int>("numeroVotsLlista")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ResultatsTaulaID");

                    b.ToTable("VotsPerLlista");
                });

            modelBuilder.Entity("EleccionsM2.Models.Candidat", b =>
                {
                    b.HasOne("EleccionsM2.Models.PartitMunicipi", null)
                        .WithMany("candidats")
                        .HasForeignKey("PartitMunicipiID");
                });

            modelBuilder.Entity("EleccionsM2.Models.PartitMunicipi", b =>
                {
                    b.HasOne("EleccionsM2.Models.Municipi", null)
                        .WithMany("llistaPartits")
                        .HasForeignKey("MunicipiID");
                });

            modelBuilder.Entity("EleccionsM2.Models.TaulaElectoral", b =>
                {
                    b.HasOne("EleccionsM2.Models.Municipi", null)
                        .WithMany("taulesElectorals")
                        .HasForeignKey("MunicipiID");

                    b.HasOne("EleccionsM2.Models.ResultatsTaula", "resultatsTaula")
                        .WithMany()
                        .HasForeignKey("resultatsTaulaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resultatsTaula");
                });

            modelBuilder.Entity("EleccionsM2.Models.VotsPerLlista", b =>
                {
                    b.HasOne("EleccionsM2.Models.ResultatsTaula", null)
                        .WithMany("votsLlista")
                        .HasForeignKey("ResultatsTaulaID");
                });

            modelBuilder.Entity("EleccionsM2.Models.Municipi", b =>
                {
                    b.Navigation("llistaPartits");

                    b.Navigation("taulesElectorals");
                });

            modelBuilder.Entity("EleccionsM2.Models.PartitMunicipi", b =>
                {
                    b.Navigation("candidats");
                });

            modelBuilder.Entity("EleccionsM2.Models.ResultatsTaula", b =>
                {
                    b.Navigation("votsLlista");
                });
#pragma warning restore 612, 618
        }
    }
}
