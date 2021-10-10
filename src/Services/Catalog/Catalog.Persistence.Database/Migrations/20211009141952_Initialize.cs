using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 685m },
                    { 72, "Description for product 72", "Product 72", 966m },
                    { 71, "Description for product 71", "Product 71", 165m },
                    { 70, "Description for product 70", "Product 70", 768m },
                    { 69, "Description for product 69", "Product 69", 156m },
                    { 68, "Description for product 68", "Product 68", 878m },
                    { 67, "Description for product 67", "Product 67", 454m },
                    { 66, "Description for product 66", "Product 66", 333m },
                    { 65, "Description for product 65", "Product 65", 426m },
                    { 64, "Description for product 64", "Product 64", 983m },
                    { 63, "Description for product 63", "Product 63", 401m },
                    { 62, "Description for product 62", "Product 62", 169m },
                    { 61, "Description for product 61", "Product 61", 294m },
                    { 60, "Description for product 60", "Product 60", 841m },
                    { 59, "Description for product 59", "Product 59", 694m },
                    { 58, "Description for product 58", "Product 58", 608m },
                    { 57, "Description for product 57", "Product 57", 548m },
                    { 56, "Description for product 56", "Product 56", 785m },
                    { 55, "Description for product 55", "Product 55", 723m },
                    { 54, "Description for product 54", "Product 54", 469m },
                    { 53, "Description for product 53", "Product 53", 648m },
                    { 52, "Description for product 52", "Product 52", 319m },
                    { 73, "Description for product 73", "Product 73", 730m },
                    { 51, "Description for product 51", "Product 51", 556m },
                    { 74, "Description for product 74", "Product 74", 970m },
                    { 76, "Description for product 76", "Product 76", 974m },
                    { 97, "Description for product 97", "Product 97", 123m },
                    { 96, "Description for product 96", "Product 96", 426m },
                    { 95, "Description for product 95", "Product 95", 445m },
                    { 94, "Description for product 94", "Product 94", 886m },
                    { 93, "Description for product 93", "Product 93", 303m },
                    { 92, "Description for product 92", "Product 92", 382m },
                    { 91, "Description for product 91", "Product 91", 918m },
                    { 90, "Description for product 90", "Product 90", 642m },
                    { 89, "Description for product 89", "Product 89", 508m },
                    { 88, "Description for product 88", "Product 88", 867m },
                    { 87, "Description for product 87", "Product 87", 256m },
                    { 86, "Description for product 86", "Product 86", 514m },
                    { 85, "Description for product 85", "Product 85", 956m },
                    { 84, "Description for product 84", "Product 84", 367m },
                    { 83, "Description for product 83", "Product 83", 939m },
                    { 82, "Description for product 82", "Product 82", 950m }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 81, "Description for product 81", "Product 81", 613m },
                    { 80, "Description for product 80", "Product 80", 793m },
                    { 79, "Description for product 79", "Product 79", 570m },
                    { 78, "Description for product 78", "Product 78", 186m },
                    { 77, "Description for product 77", "Product 77", 904m },
                    { 75, "Description for product 75", "Product 75", 816m },
                    { 98, "Description for product 98", "Product 98", 112m },
                    { 50, "Description for product 50", "Product 50", 709m },
                    { 48, "Description for product 48", "Product 48", 246m },
                    { 22, "Description for product 22", "Product 22", 900m },
                    { 21, "Description for product 21", "Product 21", 399m },
                    { 20, "Description for product 20", "Product 20", 312m },
                    { 19, "Description for product 19", "Product 19", 609m },
                    { 18, "Description for product 18", "Product 18", 458m },
                    { 17, "Description for product 17", "Product 17", 864m },
                    { 16, "Description for product 16", "Product 16", 956m },
                    { 15, "Description for product 15", "Product 15", 235m },
                    { 14, "Description for product 14", "Product 14", 484m },
                    { 13, "Description for product 13", "Product 13", 110m },
                    { 12, "Description for product 12", "Product 12", 690m },
                    { 11, "Description for product 11", "Product 11", 139m },
                    { 10, "Description for product 10", "Product 10", 161m },
                    { 9, "Description for product 9", "Product 9", 497m },
                    { 8, "Description for product 8", "Product 8", 377m },
                    { 7, "Description for product 7", "Product 7", 600m },
                    { 6, "Description for product 6", "Product 6", 391m },
                    { 5, "Description for product 5", "Product 5", 206m },
                    { 4, "Description for product 4", "Product 4", 221m },
                    { 3, "Description for product 3", "Product 3", 761m },
                    { 2, "Description for product 2", "Product 2", 329m },
                    { 23, "Description for product 23", "Product 23", 781m },
                    { 49, "Description for product 49", "Product 49", 592m },
                    { 24, "Description for product 24", "Product 24", 252m },
                    { 26, "Description for product 26", "Product 26", 365m },
                    { 47, "Description for product 47", "Product 47", 751m },
                    { 46, "Description for product 46", "Product 46", 733m },
                    { 45, "Description for product 45", "Product 45", 682m },
                    { 44, "Description for product 44", "Product 44", 694m },
                    { 43, "Description for product 43", "Product 43", 995m },
                    { 42, "Description for product 42", "Product 42", 425m },
                    { 41, "Description for product 41", "Product 41", 495m },
                    { 40, "Description for product 40", "Product 40", 639m }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 39, "Description for product 39", "Product 39", 727m },
                    { 38, "Description for product 38", "Product 38", 898m },
                    { 37, "Description for product 37", "Product 37", 890m },
                    { 36, "Description for product 36", "Product 36", 466m },
                    { 35, "Description for product 35", "Product 35", 427m },
                    { 34, "Description for product 34", "Product 34", 231m },
                    { 33, "Description for product 33", "Product 33", 336m },
                    { 32, "Description for product 32", "Product 32", 805m },
                    { 31, "Description for product 31", "Product 31", 734m },
                    { 30, "Description for product 30", "Product 30", 513m },
                    { 29, "Description for product 29", "Product 29", 976m },
                    { 28, "Description for product 28", "Product 28", 531m },
                    { 27, "Description for product 27", "Product 27", 197m },
                    { 25, "Description for product 25", "Product 25", 526m },
                    { 99, "Description for product 99", "Product 99", 367m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "catalog");
        }
    }
}
