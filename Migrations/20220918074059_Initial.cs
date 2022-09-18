using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Pet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdoptionImage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    urlImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionImage", x => new { x.id, x.nameImageFireBase, x.urlImageFireBase });
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementImage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    urlImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementImage", x => new { x.id, x.nameImageFireBase, x.urlImageFireBase });
                });

            migrationBuilder.CreateTable(
                name: "LostImage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    urlImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LostImage", x => new { x.id, x.nameImageFireBase, x.urlImageFireBase });
                });

            migrationBuilder.CreateTable(
                name: "ReproductionImage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    urlImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReproductionImage", x => new { x.id, x.nameImageFireBase, x.urlImageFireBase });
                });

            migrationBuilder.CreateTable(
                name: "RescueImage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    urlImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescueImage", x => new { x.id, x.nameImageFireBase, x.urlImageFireBase });
                });

            migrationBuilder.CreateTable(
                name: "SaleImage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    urlImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameImageFireBase = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleImage", x => new { x.id, x.nameImageFireBase, x.urlImageFireBase });
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adoption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoption_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneAnno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailAnno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    districAnno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcement_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lost_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reproduction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reproduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reproduction_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    userId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rescue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rescue_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    monthBirth = table.Column<int>(type: "int", nullable: false),
                    yearBirth = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adoption_userId",
                table: "Adoption",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcement_userId",
                table: "Announcement",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Lost_userId",
                table: "Lost",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Reproduction_userId",
                table: "Reproduction",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Rescue_userId",
                table: "Rescue",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_userId",
                table: "Sale",
                column: "userId");
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

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
