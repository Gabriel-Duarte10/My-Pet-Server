using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Pet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adoption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    namePet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionImage",
                columns: table => new
                {
                    idAdoption = table.Column<int>(type: "int", nullable: false),
                    urlImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionImage", x => new { x.idAdoption, x.nameImageAzure, x.urlImageAzure });
                });

            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameAnno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneAnno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailAnno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    districAnno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementImage",
                columns: table => new
                {
                    idAnnouncement = table.Column<int>(type: "int", nullable: false),
                    urlImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementImage", x => new { x.idAnnouncement, x.nameImageAzure, x.urlImageAzure });
                });

            migrationBuilder.CreateTable(
                name: "Lost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    namePet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LostImage",
                columns: table => new
                {
                    idLost = table.Column<int>(type: "int", nullable: false),
                    urlImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LostImage", x => new { x.idLost, x.nameImageAzure, x.urlImageAzure });
                });

            migrationBuilder.CreateTable(
                name: "Reproduction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    namePet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reproduction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReproductionImage",
                columns: table => new
                {
                    idReproduction = table.Column<int>(type: "int", nullable: false),
                    urlImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReproductionImage", x => new { x.idReproduction, x.nameImageAzure, x.urlImageAzure });
                });

            migrationBuilder.CreateTable(
                name: "Rescue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    road = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rescue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RescueImage",
                columns: table => new
                {
                    idRescue = table.Column<int>(type: "int", nullable: false),
                    urlImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescueImage", x => new { x.idRescue, x.nameImageAzure, x.urlImageAzure });
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    namePet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleImage",
                columns: table => new
                {
                    idSale = table.Column<int>(type: "int", nullable: false),
                    urlImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageAzure = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleImage", x => new { x.idSale, x.nameImageAzure, x.urlImageAzure });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adoption");

            migrationBuilder.DropTable(
                name: "AdoptionImage");

            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "AnnouncementImage");

            migrationBuilder.DropTable(
                name: "Lost");

            migrationBuilder.DropTable(
                name: "LostImage");

            migrationBuilder.DropTable(
                name: "Reproduction");

            migrationBuilder.DropTable(
                name: "ReproductionImage");

            migrationBuilder.DropTable(
                name: "Rescue");

            migrationBuilder.DropTable(
                name: "RescueImage");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "SaleImage");
        }
    }
}
