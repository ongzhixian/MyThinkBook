using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyThinkBook.Web.Migrations.WmsDb
{
    /// <inheritdoc />
    public partial class _202212281653 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "client",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { "1", "Stroman, Glover and Hane" },
                    { "10", "Zemlak and Sons" },
                    { "11", "Shanahan Group" },
                    { "12", "Mueller Group" },
                    { "13", "Howe - Satterfield" },
                    { "14", "Champlin, Ullrich and Muller" },
                    { "15", "Beatty, Hane and Corwin" },
                    { "16", "Daugherty Group" },
                    { "17", "Lockman - Mayert" },
                    { "18", "Rogahn Inc" },
                    { "19", "Ziemann, Bayer and Bosco" },
                    { "2", "Adams, Wehner and Dach" },
                    { "20", "Mosciski - Harris" },
                    { "21", "Gibson Inc" },
                    { "22", "Ankunding Group" },
                    { "23", "Kihn - Rodriguez" },
                    { "24", "Thiel - Braun" },
                    { "25", "Collins Inc" },
                    { "26", "Halvorson Inc" },
                    { "27", "Smitham - Bayer" },
                    { "28", "Leffler, Friesen and Schinner" },
                    { "3", "Hirthe, Breitenberg and Nienow" },
                    { "4", "Johns and Sons" },
                    { "5", "Tromp, Boehm and Leuschke" },
                    { "6", "Schuster Inc" },
                    { "7", "Pouros Inc" },
                    { "8", "Rowe, Bartell and Dare" },
                    { "9", "Grady - Purdy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: "9");
        }
    }
}
