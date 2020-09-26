﻿// <auto-generated />
using System;
using EFCore.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.API.Migrations
{
    [DbContext(typeof(HeroiContexto))]
    partial class HeroiContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("EFCore.API.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeroiId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EFCore.API.Models.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descicao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EFCore.API.Models.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("EFCore.API.Models.HeroiBatalha", b =>
                {
                    b.Property<int>("BatalhaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeroiId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BatalhaId", "HeroiId");

                    b.HasIndex("HeroiId");

                    b.ToTable("HeroisBatalhas");
                });

            modelBuilder.Entity("EFCore.API.Models.IdentidadeSecreta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeroiId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeReal")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId")
                        .IsUnique();

                    b.ToTable("IdentidadesSecretas");
                });

            modelBuilder.Entity("EFCore.API.Models.Arma", b =>
                {
                    b.HasOne("EFCore.API.Models.Heroi", "Heroi")
                        .WithMany("Armas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.API.Models.HeroiBatalha", b =>
                {
                    b.HasOne("EFCore.API.Models.Batalha", "Batralha")
                        .WithMany("HeroiBatalhas")
                        .HasForeignKey("BatalhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.API.Models.Heroi", "Heroi")
                        .WithMany("HeroiBatalhas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.API.Models.IdentidadeSecreta", b =>
                {
                    b.HasOne("EFCore.API.Models.Heroi", "Heroi")
                        .WithOne("Identidade")
                        .HasForeignKey("EFCore.API.Models.IdentidadeSecreta", "HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}