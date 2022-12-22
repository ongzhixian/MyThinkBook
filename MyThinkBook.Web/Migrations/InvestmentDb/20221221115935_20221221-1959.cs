using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyThinkBook.Web.Migrations.InvestmentDb
{
    /// <inheritdoc />
    public partial class _202212211959 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_instrument_isin",
                table: "instrument",
                column: "isin",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_instrument_isin",
                table: "instrument");
        }
    }
}
