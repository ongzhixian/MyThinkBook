using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyThinkBook.Web.Migrations.InvestmentDb
{
    /// <inheritdoc />
    public partial class _202212212015 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_instrument_isin",
                table: "instrument");

            migrationBuilder.CreateIndex(
                name: "IX_instrument_code",
                table: "instrument",
                column: "code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_instrument_code",
                table: "instrument");

            migrationBuilder.CreateIndex(
                name: "IX_instrument_isin",
                table: "instrument",
                column: "isin",
                unique: true);
        }
    }
}
