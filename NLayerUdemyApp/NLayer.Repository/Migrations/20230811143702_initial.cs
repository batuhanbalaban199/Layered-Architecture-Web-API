using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    length = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    AmmoCap = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    BarrelLenght = table.Column<int>(type: "int", nullable: false),
                    Caliber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriggerSystem = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    AdditionalFeatures = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pistols" },
                    { 2, "SMGs" },
                    { 3, "Rifles" },
                    { 4, "MTs" },
                    { 5, "Sniper Rifles" },
                    { 6, "Mounted MGs" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Name", "Price", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2840), "Sar9 Sport", 150m, 20, null },
                    { 2, 1, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2850), "Sar9", 100m, 20, null },
                    { 3, 1, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2851), "Kılınç 2000 Mega", 100m, 20, null },
                    { 4, 1, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2851), "Kılınç 2000 Light", 100m, 20, null },
                    { 5, 2, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2852), "Sar109T", 250m, 30, null },
                    { 6, 3, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2853), "MPT 76 SH", 350m, 40, null },
                    { 7, 3, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2854), "Sar 15T", 375m, 40, null },
                    { 8, 4, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2854), "Sar 762 MT", 1000m, 40, null },
                    { 9, 5, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2855), "Bora 12 - JNG 90", 1500m, 5, null },
                    { 10, 6, new DateTime(2023, 8, 11, 17, 37, 2, 408, DateTimeKind.Local).AddTicks(2856), "Sarsılmaz 127 MT", 10000m, 10, null }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "AdditionalFeatures", "AmmoCap", "BarrelLenght", "Caliber", "Color", "Height", "ProductId", "TriggerSystem", "Weight", "Width", "length" },
                values: new object[,]
                {
                    { 1, "Polimer Gövde, Metal Şarjör", 19, 160, "9 x 19mm", "Black", 150, 1, "Çift Hareketli", 1500, 30, 200 },
                    { 2, "Polimer Gövde, Metal Şarjör", 15, 150, "9 x 19mm", "Black", 150, 2, "Çift Hareketli", 1500, 30, 200 },
                    { 3, "Polimer Gövde, Metal Şarjör", 15, 150, "9 x 19mm", "Black", 150, 3, "Çift Hareketli", 1500, 30, 200 },
                    { 4, "Polimer Gövde, Metal Şarjör", 15, 150, "9 x 19mm", "Black", 150, 4, "Çift Hareketli", 1500, 30, 200 },
                    { 5, "Polimer Gövde, Metal Şarjör", 30, 450, "9 x 19mm", "Black", 250, 5, "Çift Hareketli", 2500, 30, 600 },
                    { 6, "Polimer Gövde, Metal Şarjör", 30, 700, "7.62 x 39mm", "Black", 300, 6, "Çift Hareketli", 3500, 30, 900 },
                    { 7, "Polimer Gövde, Metal Şarjör", 30, 700, "7.62 x 39mm", "Black", 300, 7, "Çift Hareketli", 3500, 30, 900 },
                    { 8, "Polimer Gövde, Metal Şarjör", 100, 750, "7.62 x 39mm", "Black", 300, 8, "Çift Hareketli", 4500, 30, 1300 },
                    { 9, "Polimer Gövde, Metal Şarjör", 10, 860, "7.62 x 39mm", "Black", 300, 9, "Çift Hareketli", 12500, 30, 1000 },
                    { 10, "Polimer Gövde, Metal Şarjör", 250, 750, "7.62 x 39mm", "Black", 450, 10, "Çift Hareketli", 15000, 30, 1400 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
