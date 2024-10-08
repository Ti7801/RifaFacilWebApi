﻿// <auto-generated />
using System;
using BibliotecaData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibliotecaData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240908142508_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BibliotecaBusiness.Models.Afiliado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("RifaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Afiliado", (string)null);
                });

            modelBuilder.Entity("BibliotecaBusiness.Models.Bilhete", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("AfiliadoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("RifaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("AfiliadoId");

                    b.HasIndex("RifaId");

                    b.ToTable("Bilhete", (string)null);
                });

            modelBuilder.Entity("BibliotecaBusiness.Models.Rifa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DataSorteio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Premio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("RifadorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<float>("ValorBilhete")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("RifadorId");

                    b.ToTable("Rifa", (string)null);
                });

            modelBuilder.Entity("BibliotecaBusiness.Models.Rifador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Rifador", (string)null);
                });

            modelBuilder.Entity("BibliotecaBusiness.Models.Bilhete", b =>
                {
                    b.HasOne("BibliotecaBusiness.Models.Afiliado", null)
                        .WithMany()
                        .HasForeignKey("AfiliadoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BibliotecaBusiness.Models.Rifa", null)
                        .WithMany()
                        .HasForeignKey("RifaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BibliotecaBusiness.Models.Rifa", b =>
                {
                    b.HasOne("BibliotecaBusiness.Models.Rifador", null)
                        .WithMany()
                        .HasForeignKey("RifadorId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
