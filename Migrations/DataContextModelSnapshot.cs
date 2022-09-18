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

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Adoption");
                });

            modelBuilder.Entity("My_Pet.Models.AdoptionImage", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("nameImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("urlImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id", "nameImageFireBase", "urlImageFireBase");

                    b.ToTable("AdoptionImage");
                });

            modelBuilder.Entity("My_Pet.Models.Announcement", b =>
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

                    b.Property<string>("districAnno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailAnno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneAnno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Announcement");
                });

            modelBuilder.Entity("My_Pet.Models.AnnouncementImage", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("nameImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("urlImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id", "nameImageFireBase", "urlImageFireBase");

                    b.ToTable("AnnouncementImage");
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

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Lost");
                });

            modelBuilder.Entity("My_Pet.Models.LostImage", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("nameImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("urlImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id", "nameImageFireBase", "urlImageFireBase");

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

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Reproduction");
                });

            modelBuilder.Entity("My_Pet.Models.ReproductionImage", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("nameImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("urlImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id", "nameImageFireBase", "urlImageFireBase");

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

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Rescue");
                });

            modelBuilder.Entity("My_Pet.Models.RescueImage", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("nameImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("urlImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id", "nameImageFireBase", "urlImageFireBase");

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

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("yearBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("My_Pet.Models.SaleImage", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("nameImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("urlImageFireBase")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id", "nameImageFireBase", "urlImageFireBase");

                    b.ToTable("SaleImage");
                });

            modelBuilder.Entity("My_Pet.Models.User", b =>
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

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("My_Pet.Models.Adoption", b =>
                {
                    b.HasOne("My_Pet.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("My_Pet.Models.Announcement", b =>
                {
                    b.HasOne("My_Pet.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("My_Pet.Models.Lost", b =>
                {
                    b.HasOne("My_Pet.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("My_Pet.Models.Reproduction", b =>
                {
                    b.HasOne("My_Pet.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("My_Pet.Models.Rescue", b =>
                {
                    b.HasOne("My_Pet.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("My_Pet.Models.Sale", b =>
                {
                    b.HasOne("My_Pet.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
