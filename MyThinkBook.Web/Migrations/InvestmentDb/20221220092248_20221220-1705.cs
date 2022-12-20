using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyThinkBook.Web.Migrations.InvestmentDb
{
    /// <inheritdoc />
    public partial class _202212201705 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "instrument",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("instrument_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "portfolio",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("portfolio_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "position",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quantity = table.Column<decimal>(type: "TEXT", nullable: false),
                    price = table.Column<decimal>(type: "TEXT", nullable: false),
                    portfolioid = table.Column<int>(name: "portfolio_id", type: "INTEGER", nullable: false),
                    instrumentid = table.Column<int>(name: "instrument_id", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("position_pk", x => x.id);
                    table.ForeignKey(
                        name: "portfolio__position_fk",
                        column: x => x.portfolioid,
                        principalTable: "portfolio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "position__instrument_fk",
                        column: x => x.instrumentid,
                        principalTable: "instrument",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "instrument",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Stock 1" },
                    { 2, "Stock 2" },
                    { 3, "Stock 3" },
                    { 4, "Stock 4" },
                    { 5, "Stock 5" },
                    { 6, "Stock 6" },
                    { 7, "Stock 7" },
                    { 8, "Stock 8" },
                    { 9, "Stock 9" },
                    { 10, "Stock 10" },
                    { 11, "Stock 11" },
                    { 12, "Stock 12" },
                    { 13, "Stock 13" },
                    { 14, "Stock 14" },
                    { 15, "Stock 15" },
                    { 16, "Stock 16" },
                    { 17, "Stock 17" },
                    { 18, "Stock 18" },
                    { 19, "Stock 19" },
                    { 20, "Stock 20" },
                    { 21, "Stock 21" },
                    { 22, "Stock 22" },
                    { 23, "Stock 23" },
                    { 24, "Stock 24" },
                    { 25, "Stock 25" },
                    { 26, "Stock 26" },
                    { 27, "Stock 27" },
                    { 28, "Stock 28" },
                    { 29, "Stock 29" },
                    { 30, "Stock 30" }
                });

            migrationBuilder.InsertData(
                table: "portfolio",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Portfolio 1" },
                    { 2, "Portfolio 2" },
                    { 3, "Portfolio 3" },
                    { 4, "Portfolio 4" },
                    { 5, "Portfolio 5" },
                    { 6, "Portfolio 6" },
                    { 7, "Portfolio 7" },
                    { 8, "Portfolio 8" },
                    { 9, "Portfolio 9" },
                    { 10, "Portfolio 10" }
                });

            migrationBuilder.InsertData(
                table: "position",
                columns: new[] { "id", "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[,]
                {
                    { 1, 26, 1, 274.59m, 587829m },
                    { 2, 24, 1, 362.44m, 5126m },
                    { 3, 12, 2, 331.10m, 589915m },
                    { 4, 20, 2, 6.44m, 357208m },
                    { 5, 9, 2, 333.11m, 88359m },
                    { 6, 14, 2, 95.56m, 567796m },
                    { 7, 17, 3, 132.53m, 126930m },
                    { 8, 9, 3, 95.58m, 581265m },
                    { 9, 8, 3, 103.48m, 466054m },
                    { 10, 13, 4, 201.86m, 946508m },
                    { 11, 2, 4, 311.84m, 126378m },
                    { 12, 12, 5, 255.98m, 43448m },
                    { 13, 30, 5, 335.75m, 351988m },
                    { 14, 27, 5, 394.05m, 11064m },
                    { 15, 28, 5, 62.28m, 639469m },
                    { 16, 25, 6, 191.89m, 457567m },
                    { 17, 7, 6, 343.56m, 599048m },
                    { 18, 5, 6, 135.62m, 329285m },
                    { 19, 18, 6, 332.54m, 666386m },
                    { 20, 17, 7, 123.69m, 999736m },
                    { 21, 27, 7, 244.34m, 443524m },
                    { 22, 4, 7, 207.99m, 92144m },
                    { 23, 29, 8, 82.27m, 842202m },
                    { 24, 25, 8, 233.99m, 30847m },
                    { 25, 9, 9, 273.73m, 899852m },
                    { 26, 8, 9, 43.66m, 386897m },
                    { 27, 3, 9, 119.64m, 678619m },
                    { 28, 28, 9, 310.15m, 228857m },
                    { 29, 8, 9, 125.26m, 106273m },
                    { 30, 27, 10, 100.40m, 222843m },
                    { 31, 3, 10, 323.47m, 151914m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_position_instrument_id",
                table: "position",
                column: "instrument_id");

            migrationBuilder.CreateIndex(
                name: "IX_position_portfolio_id",
                table: "position",
                column: "portfolio_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "position");

            migrationBuilder.DropTable(
                name: "portfolio");

            migrationBuilder.DropTable(
                name: "instrument");
        }
    }
}
