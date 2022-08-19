﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using My_Pet.Data.Context;

namespace My_Pet.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("My_Pet.Models.Adoption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("monthBirth")
                        .HasColumnType("int");

                    b.Property<string>("namePet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Adoption");
                });

            modelBuilder.Entity("My_Pet.Models.AdoptionImage", b =>
                {
                    b.Property<int>("idAdoption")
                        .HasColumnType("int");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(900)");

                    b.HasKey("idAdoption", "image");

                    b.ToTable("AdoptionImage");
                });

            modelBuilder.Entity("My_Pet.Models.Lost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("monthBirth")
                        .HasColumnType("int");

                    b.Property<string>("namePet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lost");
                });

            modelBuilder.Entity("My_Pet.Models.LostImage", b =>
                {
                    b.Property<int>("idLost")
                        .HasColumnType("int");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(900)");

                    b.HasKey("idLost", "image");

                    b.ToTable("LostImage");
                });

            modelBuilder.Entity("My_Pet.Models.Reproduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("monthBirth")
                        .HasColumnType("int");

                    b.Property<string>("namePet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reproduction");
                });

            modelBuilder.Entity("My_Pet.Models.ReproductionImage", b =>
                {
                    b.Property<int>("idReproduction")
                        .HasColumnType("int");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(900)");

                    b.HasKey("idReproduction", "image");

                    b.ToTable("ReproductionImage");
                });

            modelBuilder.Entity("My_Pet.Models.Rescue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("road")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rescue");
                });

            modelBuilder.Entity("My_Pet.Models.RescueImage", b =>
                {
                    b.Property<int>("idRescue")
                        .HasColumnType("int");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(900)");

                    b.HasKey("idRescue", "image");

                    b.ToTable("RescueImage");
                });

            modelBuilder.Entity("My_Pet.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("monthBirth")
                        .HasColumnType("int");

                    b.Property<string>("namePet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("My_Pet.Models.SaleImage", b =>
                {
                    b.Property<int>("idSale")
                        .HasColumnType("int");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(900)");

                    b.HasKey("idSale", "image");

                    b.ToTable("SaleImage");
                });
#pragma warning restore 612, 618
        }
    }
}
