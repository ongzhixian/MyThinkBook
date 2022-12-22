using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyThinkBook.Web.Migrations.InvestmentDb
{
    /// <inheritdoc />
    public partial class _202212221608 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1035);

            migrationBuilder.AddColumn<DateTime>(
                name: "trade_date",
                table: "position",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 64.08m, 6462m, new DateTime(2021, 8, 8, 10, 26, 20, 666, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 367.04m, 9456m, new DateTime(2022, 9, 3, 4, 0, 31, 963, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 15.11m, 6069m, new DateTime(2019, 10, 22, 21, 42, 2, 893, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 313.52m, 7368m, new DateTime(2019, 11, 6, 4, 58, 17, 237, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 266.39m, 3679m, new DateTime(2020, 5, 25, 13, 21, 31, 125, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 374.40m, 8273m, new DateTime(2022, 3, 13, 6, 14, 10, 109, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 221.48m, 9868m, new DateTime(2022, 6, 15, 19, 48, 29, 308, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 82.31m, 3685m, new DateTime(2020, 6, 7, 3, 2, 50, 63, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 7.02m, 4252m, new DateTime(2019, 1, 28, 22, 9, 48, 483, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 362.33m, 6177m, new DateTime(2022, 1, 8, 17, 37, 9, 464, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 299.71m, 2941m, new DateTime(2018, 12, 24, 17, 43, 54, 761, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 172.47m, 8418m, new DateTime(2019, 12, 20, 13, 8, 9, 263, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 17.36m, 5810m, new DateTime(2022, 1, 17, 6, 47, 55, 845, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 87.35m, 8580m, new DateTime(2019, 11, 6, 21, 53, 13, 832, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 223.17m, 370m, new DateTime(2020, 2, 23, 23, 38, 57, 149, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 56.75m, 3765m, new DateTime(2021, 5, 28, 3, 42, 6, 627, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 62.16m, 7036m, new DateTime(2021, 5, 18, 11, 55, 12, 230, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 13.09m, 7320m, new DateTime(2019, 11, 7, 0, 4, 13, 152, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 363.16m, 4494m, new DateTime(2022, 1, 26, 14, 41, 58, 781, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 116.59m, 3853m, new DateTime(2021, 2, 10, 14, 23, 2, 370, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 24.44m, 3217m, new DateTime(2022, 8, 2, 22, 31, 53, 2, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 48.06m, 5577m, new DateTime(2021, 6, 13, 15, 53, 47, 974, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 85.13m, 3020m, new DateTime(2020, 12, 25, 15, 14, 40, 994, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 251.72m, 562m, new DateTime(2019, 9, 16, 11, 7, 27, 585, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 21.35m, 805m, new DateTime(2021, 9, 12, 14, 0, 0, 735, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 180.89m, 7391m, new DateTime(2022, 9, 15, 9, 21, 14, 479, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 222.67m, 3728m, new DateTime(2022, 12, 7, 1, 13, 28, 306, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 97.30m, 4461m, new DateTime(2021, 9, 27, 14, 49, 55, 36, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 118.92m, 5366m, new DateTime(2021, 11, 27, 10, 13, 33, 182, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 8.15m, 1174m, new DateTime(2022, 8, 26, 9, 0, 56, 954, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 89.35m, 1678m, new DateTime(2022, 11, 1, 0, 39, 57, 429, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 256.08m, 9735m, new DateTime(2020, 11, 25, 2, 56, 28, 949, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 303.41m, 7628m, new DateTime(2019, 9, 18, 4, 39, 42, 872, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 196.39m, 6067m, new DateTime(2021, 8, 30, 5, 13, 42, 900, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "price", "quantity", "trade_date" },
                values: new object[] { 124.86m, 2192m, new DateTime(2019, 7, 9, 7, 17, 54, 814, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 357.83m, 7082m, new DateTime(2018, 12, 26, 1, 13, 48, 378, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 316.17m, 5671m, new DateTime(2022, 10, 5, 6, 45, 11, 141, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 27.45m, 5773m, new DateTime(2019, 12, 21, 5, 34, 44, 688, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 260.98m, 9046m, new DateTime(2022, 10, 5, 18, 56, 40, 742, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 132.23m, 9648m, new DateTime(2020, 11, 30, 3, 36, 20, 542, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 239.25m, 3825m, new DateTime(2020, 1, 25, 4, 45, 52, 553, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 128.66m, 8486m, new DateTime(2020, 3, 30, 10, 26, 27, 624, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 77.31m, 9356m, new DateTime(2022, 10, 21, 23, 45, 29, 79, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 60.71m, 131m, new DateTime(2019, 10, 13, 15, 42, 57, 39, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 173.67m, 1726m, new DateTime(2021, 11, 30, 8, 23, 13, 994, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 171.79m, 3609m, new DateTime(2022, 3, 29, 18, 16, 21, 813, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 3, 170.37m, 3475m, new DateTime(2020, 10, 13, 20, 51, 37, 100, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 3, 359.93m, 8469m, new DateTime(2020, 8, 24, 13, 29, 27, 965, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 3, 248.90m, 2946m, new DateTime(2021, 11, 18, 18, 52, 44, 615, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 3, 83.42m, 3808m, new DateTime(2021, 8, 4, 2, 53, 30, 375, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 326.62m, 2501m, new DateTime(2022, 6, 22, 4, 53, 4, 351, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 21.00m, 4182m, new DateTime(2022, 3, 10, 8, 59, 39, 350, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 140.95m, 6462m, new DateTime(2021, 9, 8, 22, 31, 15, 679, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 3, 149.71m, 8554m, new DateTime(2021, 6, 25, 12, 40, 21, 485, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 3, 54.92m, 8556m, new DateTime(2021, 7, 22, 10, 38, 8, 950, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 3, 184.68m, 7160m, new DateTime(2019, 5, 24, 10, 21, 12, 938, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 3, 210.50m, 9873m, new DateTime(2021, 10, 22, 13, 47, 57, 385, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 3, 367.70m, 2297m, new DateTime(2020, 11, 10, 18, 33, 50, 104, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 3, 24.06m, 7158m, new DateTime(2022, 1, 26, 4, 50, 24, 991, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 3, 199.50m, 8619m, new DateTime(2020, 7, 11, 14, 51, 51, 105, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 3, 252.23m, 6738m, new DateTime(2021, 10, 23, 18, 16, 0, 28, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 204.20m, 3742m, new DateTime(2020, 12, 29, 23, 9, 44, 19, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 3, 301.61m, 6762m, new DateTime(2019, 4, 26, 3, 46, 27, 441, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 3, 139.58m, 7034m, new DateTime(2022, 1, 6, 21, 16, 20, 267, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 3, 36.99m, 7292m, new DateTime(2019, 11, 5, 20, 32, 43, 738, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 3, 91.04m, 3410m, new DateTime(2019, 6, 5, 6, 50, 19, 449, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 3, 122.88m, 5653m, new DateTime(2020, 1, 30, 10, 9, 50, 52, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 3, 135.20m, 2681m, new DateTime(2019, 10, 16, 9, 5, 41, 952, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 3, 86.90m, 101m, new DateTime(2021, 7, 19, 14, 39, 30, 44, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 3, 238.38m, 5259m, new DateTime(2022, 8, 22, 16, 42, 33, 778, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 320.55m, 1150m, new DateTime(2021, 1, 23, 9, 44, 37, 748, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 3, 220.58m, 4329m, new DateTime(2021, 2, 6, 3, 47, 4, 161, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 3, 132.56m, 6489m, new DateTime(2021, 7, 6, 10, 35, 15, 617, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 3, 99.83m, 2952m, new DateTime(2019, 11, 23, 3, 5, 44, 425, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 373.53m, 2233m, new DateTime(2020, 11, 8, 4, 50, 37, 221, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 261.96m, 6265m, new DateTime(2019, 7, 31, 1, 22, 51, 318, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 96.48m, 1438m, new DateTime(2021, 12, 8, 20, 0, 30, 883, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 105.14m, 3356m, new DateTime(2022, 6, 26, 20, 6, 38, 223, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 312.71m, 7341m, new DateTime(2022, 4, 23, 11, 7, 18, 950, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 119.28m, 6347m, new DateTime(2021, 6, 29, 14, 13, 8, 491, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 61.19m, 3015m, new DateTime(2019, 11, 9, 11, 31, 10, 769, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 28.36m, 7264m, new DateTime(2021, 3, 3, 21, 41, 50, 652, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 221.80m, 7822m, new DateTime(2021, 12, 9, 10, 27, 37, 73, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 4, 251.88m, 8626m, new DateTime(2020, 4, 30, 13, 3, 12, 528, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 4, 84.48m, 5234m, new DateTime(2022, 5, 22, 3, 5, 59, 507, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 4, 98.06m, 501m, new DateTime(2021, 9, 24, 5, 58, 37, 38, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 4, 241.96m, 7563m, new DateTime(2022, 9, 13, 6, 15, 18, 501, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 4, 30.72m, 4286m, new DateTime(2021, 2, 9, 4, 23, 36, 187, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 4, 113.80m, 9238m, new DateTime(2019, 4, 19, 22, 46, 12, 165, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 4, 354.41m, 7258m, new DateTime(2021, 2, 1, 5, 16, 32, 79, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 4, 91.28m, 4920m, new DateTime(2022, 9, 16, 6, 31, 52, 578, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 4, 188.63m, 9557m, new DateTime(2019, 11, 15, 14, 29, 7, 403, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 340.82m, 3928m, new DateTime(2021, 10, 13, 9, 24, 22, 464, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 295.91m, 7026m, new DateTime(2022, 12, 16, 2, 41, 11, 814, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 279.09m, 8636m, new DateTime(2019, 8, 21, 14, 2, 55, 407, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 334.57m, 2930m, new DateTime(2020, 12, 4, 16, 26, 13, 297, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "instrument_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 295.55m, 3927m, new DateTime(2020, 5, 10, 16, 23, 56, 59, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 6, 253.51m, 4295m, new DateTime(2022, 12, 6, 0, 0, 46, 105, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 6, 325.91m, 8258m, new DateTime(2022, 1, 27, 12, 25, 18, 742, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 6, 114.18m, 1222m, new DateTime(2020, 10, 23, 10, 13, 59, 417, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 7, 89.89m, 457m, new DateTime(2022, 4, 20, 11, 8, 7, 934, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 7, 217.87m, 2311m, new DateTime(2019, 4, 26, 12, 13, 54, 563, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 7, 76.32m, 8621m, new DateTime(2020, 6, 4, 7, 22, 30, 883, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 7, 156.70m, 2089m, new DateTime(2020, 10, 3, 6, 14, 33, 493, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 7, 293.07m, 5729m, new DateTime(2022, 6, 28, 14, 14, 5, 556, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 7, 385.18m, 2936m, new DateTime(2022, 11, 10, 21, 8, 32, 428, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 7, 350.31m, 7814m, new DateTime(2019, 12, 25, 14, 19, 26, 243, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 7, 299.79m, 3005m, new DateTime(2022, 5, 17, 2, 52, 44, 454, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 7, 47.85m, 674m, new DateTime(2019, 9, 10, 2, 41, 16, 801, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 7, 189.37m, 1853m, new DateTime(2021, 1, 16, 7, 24, 3, 444, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 7, 150.19m, 5749m, new DateTime(2022, 11, 1, 11, 47, 44, 645, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 7, 268.56m, 2653m, new DateTime(2021, 3, 13, 19, 59, 39, 277, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 7, 168.45m, 2715m, new DateTime(2021, 4, 12, 1, 58, 10, 159, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 7, 170.69m, 5764m, new DateTime(2020, 10, 7, 17, 19, 24, 26, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 7, 291.89m, 139m, new DateTime(2022, 9, 6, 14, 51, 44, 884, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 7, 141.92m, 6225m, new DateTime(2021, 8, 1, 7, 55, 25, 933, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 7, 238.29m, 7776m, new DateTime(2022, 7, 12, 4, 52, 28, 321, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 7, 62.42m, 5944m, new DateTime(2022, 8, 22, 14, 38, 56, 723, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 7, 276.92m, 2250m, new DateTime(2022, 8, 3, 15, 34, 48, 71, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 8, 196.62m, 7769m, new DateTime(2021, 5, 17, 13, 10, 11, 736, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 8, 354.53m, 5057m, new DateTime(2021, 12, 19, 0, 19, 15, 637, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 8, 100.31m, 8630m, new DateTime(2022, 2, 27, 12, 48, 41, 606, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 8, 192.04m, 7293m, new DateTime(2022, 1, 12, 17, 13, 26, 456, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 8, 167.10m, 1752m, new DateTime(2021, 8, 17, 16, 14, 36, 995, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 8, 267.79m, 4566m, new DateTime(2022, 11, 8, 21, 22, 28, 752, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 8, 333.65m, 5442m, new DateTime(2022, 4, 12, 11, 54, 4, 603, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 8, 134.44m, 4537m, new DateTime(2021, 1, 26, 19, 59, 58, 887, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 8, 269.71m, 9697m, new DateTime(2019, 2, 8, 10, 26, 45, 641, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 8, 39.15m, 364m, new DateTime(2022, 1, 7, 19, 49, 43, 447, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 8, 363.21m, 4754m, new DateTime(2021, 2, 8, 4, 41, 25, 727, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 8, 339.39m, 8651m, new DateTime(2021, 8, 4, 10, 15, 58, 109, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 8, 304.14m, 5010m, new DateTime(2020, 4, 10, 8, 0, 40, 838, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 8, 353.16m, 2481m, new DateTime(2021, 11, 15, 12, 30, 35, 377, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 8, 373.91m, 8288m, new DateTime(2022, 7, 20, 17, 34, 20, 145, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 8, 159.90m, 7780m, new DateTime(2020, 4, 22, 4, 15, 23, 333, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 8, 266.52m, 3746m, new DateTime(2020, 11, 12, 9, 7, 0, 472, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 8, 84.50m, 2570m, new DateTime(2022, 10, 6, 0, 47, 24, 377, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 8, 300.36m, 3053m, new DateTime(2022, 9, 9, 13, 6, 29, 651, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 8, 127.62m, 7573m, new DateTime(2020, 10, 19, 19, 51, 0, 244, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 8, 174.63m, 9702m, new DateTime(2020, 3, 17, 10, 3, 16, 689, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 8, 242.53m, 2912m, new DateTime(2020, 3, 21, 18, 47, 55, 305, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 8, 50.16m, 7275m, new DateTime(2022, 8, 17, 21, 27, 23, 843, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 8, 180.94m, 3890m, new DateTime(2022, 8, 10, 1, 32, 56, 238, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 8, 155.22m, 1605m, new DateTime(2022, 9, 8, 15, 46, 35, 311, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 8, 324.42m, 5862m, new DateTime(2022, 3, 7, 20, 47, 24, 541, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 8, 391.63m, 4552m, new DateTime(2021, 10, 29, 16, 22, 3, 626, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 8, 162.70m, 3295m, new DateTime(2021, 1, 5, 9, 39, 21, 689, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 8, 9.48m, 6282m, new DateTime(2020, 12, 7, 21, 1, 2, 884, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 8, 27.85m, 4245m, new DateTime(2021, 8, 12, 0, 22, 7, 502, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 8, 72.52m, 9393m, new DateTime(2019, 12, 4, 0, 12, 35, 250, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 8, 87.92m, 7996m, new DateTime(2022, 6, 21, 1, 54, 46, 13, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 8, 195.69m, 683m, new DateTime(2019, 8, 2, 17, 58, 1, 21, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 8, 45.60m, 3464m, new DateTime(2021, 7, 2, 11, 6, 10, 544, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 8, 277.40m, 195m, new DateTime(2022, 5, 3, 19, 56, 27, 975, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 8, 95.36m, 6321m, new DateTime(2021, 10, 2, 22, 17, 11, 898, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 360.83m, 7743m, new DateTime(2021, 9, 11, 19, 1, 43, 838, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 9, 261.61m, 3572m, new DateTime(2019, 12, 17, 3, 7, 27, 247, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 9, 104.59m, 2224m, new DateTime(2022, 5, 27, 3, 13, 52, 971, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 9, 196.17m, 3062m, new DateTime(2021, 1, 17, 0, 44, 45, 264, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 9, 173.09m, 1383m, new DateTime(2021, 10, 24, 0, 48, 5, 557, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 68.82m, 9829m, new DateTime(2022, 12, 2, 7, 23, 18, 412, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 9, 133.07m, 5422m, new DateTime(2019, 4, 30, 10, 21, 52, 189, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 9, 54.69m, 9386m, new DateTime(2019, 8, 30, 2, 29, 55, 1, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 9, 142.36m, 186m, new DateTime(2021, 4, 24, 23, 40, 1, 574, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 9, 38.24m, 3334m, new DateTime(2019, 12, 22, 14, 40, 27, 402, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 9, 90.76m, 3135m, new DateTime(2019, 8, 21, 0, 58, 55, 460, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 9, 271.14m, 7094m, new DateTime(2019, 7, 26, 16, 49, 32, 676, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 9, 6.76m, 167m, new DateTime(2022, 2, 28, 5, 15, 53, 5, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 9, 122.94m, 9298m, new DateTime(2019, 10, 3, 7, 1, 48, 605, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 9, 180.45m, 9553m, new DateTime(2020, 1, 18, 9, 19, 44, 916, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 9, 103.19m, 9279m, new DateTime(2022, 11, 23, 21, 39, 15, 269, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 10, 189.94m, 9877m, new DateTime(2020, 9, 29, 7, 14, 46, 784, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 10, 385.58m, 4868m, new DateTime(2020, 8, 7, 17, 28, 57, 334, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 10, 283.22m, 100m, new DateTime(2020, 1, 31, 6, 50, 6, 188, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 10, 82.93m, 6639m, new DateTime(2022, 10, 18, 7, 9, 53, 540, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 11, 369.49m, 8235m, new DateTime(2020, 11, 19, 12, 12, 2, 299, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 11, 281.54m, 4912m, new DateTime(2019, 5, 22, 2, 13, 1, 966, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 11, 350.92m, 7973m, new DateTime(2022, 4, 27, 5, 48, 22, 170, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 11, 21.14m, 9084m, new DateTime(2020, 3, 21, 16, 43, 0, 248, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 11, 287.84m, 3017m, new DateTime(2022, 10, 17, 15, 16, 51, 174, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 11, 210.51m, 6141m, new DateTime(2019, 11, 30, 7, 25, 44, 674, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 11, 371.72m, 913m, new DateTime(2021, 2, 15, 0, 37, 35, 519, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 11, 118.45m, 6902m, new DateTime(2022, 11, 6, 15, 25, 46, 373, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 11, 162.54m, 4050m, new DateTime(2021, 7, 20, 22, 52, 52, 463, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 11, 264.48m, 4497m, new DateTime(2021, 11, 5, 21, 2, 7, 878, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 11, 172.37m, 3861m, new DateTime(2019, 11, 23, 1, 44, 6, 354, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 11, 14.77m, 1676m, new DateTime(2022, 8, 17, 17, 40, 6, 154, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 11, 399.81m, 7408m, new DateTime(2020, 5, 7, 0, 29, 20, 605, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 11, 342.19m, 6604m, new DateTime(2021, 1, 11, 0, 10, 51, 965, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 11, 70.17m, 8742m, new DateTime(2021, 10, 15, 4, 39, 34, 477, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 11, 213.85m, 1137m, new DateTime(2020, 9, 29, 23, 41, 29, 439, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 11, 209.00m, 6362m, new DateTime(2020, 12, 20, 19, 50, 34, 922, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 11, 295.33m, 6199m, new DateTime(2020, 12, 18, 5, 1, 50, 28, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 11, 173.80m, 2252m, new DateTime(2020, 6, 8, 20, 41, 55, 286, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 11, 385.50m, 8402m, new DateTime(2022, 4, 2, 16, 15, 14, 720, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 11, 376.63m, 8383m, new DateTime(2022, 10, 14, 2, 13, 30, 688, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 11, 303.43m, 9292m, new DateTime(2020, 3, 23, 2, 25, 43, 223, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 11, 55.92m, 4977m, new DateTime(2020, 10, 18, 23, 29, 13, 711, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 11, 377.88m, 8469m, new DateTime(2021, 11, 21, 22, 20, 37, 547, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 11, 75.01m, 9532m, new DateTime(2019, 8, 3, 23, 25, 11, 544, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 12, 17.24m, 5938m, new DateTime(2019, 12, 30, 4, 28, 49, 163, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 12, 108.34m, 7341m, new DateTime(2021, 5, 19, 8, 41, 51, 615, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 12, 183.75m, 7341m, new DateTime(2021, 2, 4, 13, 53, 13, 776, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 288.37m, 7696m, new DateTime(2019, 6, 30, 9, 4, 50, 308, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 12, 229.39m, 7912m, new DateTime(2022, 1, 5, 17, 7, 28, 197, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 12, 4.99m, 7480m, new DateTime(2019, 9, 7, 18, 52, 9, 406, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 12, 315.77m, 3368m, new DateTime(2021, 8, 29, 6, 9, 17, 374, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 12, 91.94m, 5436m, new DateTime(2019, 11, 27, 9, 13, 42, 82, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 12, 121.73m, 6685m, new DateTime(2020, 12, 8, 11, 13, 4, 910, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 12, 116.32m, 2997m, new DateTime(2019, 5, 16, 16, 26, 37, 788, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 12, 30.66m, 4799m, new DateTime(2021, 1, 7, 6, 55, 21, 938, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 12, 160.88m, 5045m, new DateTime(2020, 4, 3, 18, 28, 2, 539, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 12, 242.89m, 5072m, new DateTime(2022, 1, 28, 22, 1, 49, 48, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 326.30m, 5838m, new DateTime(2020, 7, 9, 22, 34, 8, 964, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 12, 269.02m, 5665m, new DateTime(2020, 8, 27, 16, 17, 28, 820, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 12, 183.14m, 9962m, new DateTime(2019, 3, 16, 14, 11, 7, 921, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 12, 160.57m, 8068m, new DateTime(2020, 12, 17, 0, 23, 24, 193, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 12, 105.79m, 4785m, new DateTime(2021, 2, 11, 18, 12, 1, 548, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 12, 154.86m, 3816m, new DateTime(2020, 12, 21, 23, 37, 50, 175, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 12, 319.75m, 2562m, new DateTime(2020, 4, 16, 0, 59, 45, 767, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 12, 20.35m, 7136m, new DateTime(2019, 4, 4, 20, 1, 28, 601, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 12, 16.99m, 736m, new DateTime(2019, 3, 30, 20, 17, 9, 516, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 12, 267.21m, 3100m, new DateTime(2019, 7, 29, 21, 37, 46, 970, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 102.53m, 2283m, new DateTime(2020, 6, 28, 11, 3, 44, 265, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 12, 103.83m, 1523m, new DateTime(2022, 11, 26, 2, 49, 57, 75, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 12, 245.77m, 2038m, new DateTime(2022, 7, 30, 4, 1, 3, 628, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 13, 95.85m, 6668m, new DateTime(2020, 5, 4, 6, 35, 8, 600, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 13, 133.06m, 3350m, new DateTime(2021, 2, 7, 21, 31, 46, 844, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 13, 93.49m, 1476m, new DateTime(2019, 8, 9, 20, 36, 49, 233, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 13, 176.24m, 9977m, new DateTime(2022, 3, 18, 6, 11, 36, 501, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 13, 65.47m, 3614m, new DateTime(2021, 2, 3, 15, 0, 28, 974, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 13, 112.55m, 3333m, new DateTime(2019, 4, 12, 13, 46, 56, 269, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 13, 211.44m, 3364m, new DateTime(2019, 5, 28, 4, 56, 30, 0, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 13, 293.69m, 7324m, new DateTime(2019, 4, 12, 11, 15, 27, 728, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 13, 110.35m, 354m, new DateTime(2021, 10, 14, 2, 36, 8, 440, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 13, 153.66m, 7382m, new DateTime(2019, 10, 7, 10, 41, 2, 718, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 14, 33.51m, 7807m, new DateTime(2020, 9, 3, 6, 6, 59, 204, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 14, 59.27m, 8286m, new DateTime(2020, 10, 17, 8, 18, 45, 36, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 14, 336.49m, 6330m, new DateTime(2022, 7, 15, 1, 43, 37, 985, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 14, 133.52m, 3223m, new DateTime(2019, 3, 13, 1, 54, 55, 723, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 14, 55.88m, 3081m, new DateTime(2022, 7, 5, 0, 6, 31, 562, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 14, 45.99m, 8407m, new DateTime(2021, 8, 13, 0, 11, 22, 770, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 14, 67.07m, 6537m, new DateTime(2022, 6, 9, 3, 25, 9, 252, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 14, 294.11m, 9628m, new DateTime(2022, 10, 27, 13, 58, 17, 411, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 14, 140.19m, 4751m, new DateTime(2022, 3, 24, 19, 30, 57, 324, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 14, 139.77m, 1072m, new DateTime(2022, 3, 8, 6, 31, 19, 901, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 14, 325.87m, 1808m, new DateTime(2021, 6, 13, 11, 34, 33, 332, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 14, 141.64m, 6489m, new DateTime(2019, 5, 28, 9, 40, 4, 459, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 14, 274.52m, 267m, new DateTime(2019, 3, 17, 12, 21, 19, 646, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 14, 398.51m, 1822m, new DateTime(2021, 12, 29, 15, 2, 8, 519, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 15, 358.01m, 8892m, new DateTime(2020, 4, 9, 1, 13, 55, 449, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 15, 59.84m, 7823m, new DateTime(2021, 4, 14, 13, 48, 22, 934, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 15, 190.57m, 2724m, new DateTime(2019, 7, 2, 18, 49, 24, 0, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 15, 8.41m, 1939m, new DateTime(2019, 11, 3, 3, 8, 45, 820, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 15, 67.80m, 4252m, new DateTime(2020, 6, 8, 9, 49, 53, 792, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 15, 196.15m, 5176m, new DateTime(2022, 12, 4, 13, 53, 2, 815, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 15, 9.57m, 7839m, new DateTime(2021, 2, 25, 7, 2, 38, 34, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 15, 6.11m, 7300m, new DateTime(2021, 10, 10, 0, 48, 15, 978, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 15, 209.31m, 8834m, new DateTime(2020, 7, 10, 10, 9, 18, 451, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 15, 383.63m, 8431m, new DateTime(2021, 2, 28, 19, 30, 38, 891, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 15, 10.66m, 2136m, new DateTime(2020, 4, 22, 12, 22, 1, 602, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 15, 63.98m, 7460m, new DateTime(2019, 6, 19, 20, 28, 6, 371, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 15, 244.54m, 4861m, new DateTime(2020, 4, 22, 6, 13, 9, 879, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 15, 261.69m, 7140m, new DateTime(2019, 8, 29, 16, 46, 53, 308, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 15, 83.16m, 6010m, new DateTime(2021, 5, 18, 16, 24, 14, 797, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 15, 238.18m, 8718m, new DateTime(2019, 12, 10, 7, 37, 34, 69, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 15, 142.19m, 115m, new DateTime(2021, 12, 19, 0, 52, 8, 785, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 15, 200.65m, 8104m, new DateTime(2020, 4, 26, 22, 48, 38, 986, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 15, 143.89m, 7772m, new DateTime(2021, 2, 17, 21, 26, 4, 66, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 15, 168.75m, 1177m, new DateTime(2021, 1, 7, 21, 29, 16, 712, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 15, 244.38m, 1985m, new DateTime(2020, 6, 24, 4, 11, 59, 644, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 15, 258.23m, 2657m, new DateTime(2022, 7, 4, 21, 41, 33, 325, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 15, 324.60m, 3652m, new DateTime(2022, 1, 22, 4, 40, 25, 594, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 15, 253.88m, 3251m, new DateTime(2020, 6, 7, 0, 56, 56, 520, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 15, 52.06m, 8841m, new DateTime(2020, 7, 12, 16, 43, 54, 582, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 15, 67.77m, 2635m, new DateTime(2021, 6, 1, 9, 50, 40, 23, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 15, 118.29m, 8190m, new DateTime(2019, 1, 19, 23, 47, 54, 71, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 16, 116.79m, 6779m, new DateTime(2019, 8, 3, 16, 55, 24, 797, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 227.71m, 265m, new DateTime(2020, 12, 30, 22, 28, 47, 669, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 16, 397.59m, 341m, new DateTime(2019, 11, 16, 1, 23, 24, 35, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 16, 122.64m, 6761m, new DateTime(2021, 3, 1, 20, 38, 11, 788, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 16, 57.71m, 1659m, new DateTime(2020, 5, 25, 6, 16, 46, 851, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 16, 242.61m, 2035m, new DateTime(2020, 9, 22, 18, 6, 33, 944, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 16, 147.75m, 3290m, new DateTime(2020, 10, 17, 22, 55, 49, 436, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 16, 120.55m, 8402m, new DateTime(2019, 12, 20, 16, 39, 28, 711, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 16, 153.53m, 5530m, new DateTime(2020, 8, 11, 11, 22, 54, 441, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 16, 57.50m, 6826m, new DateTime(2020, 11, 21, 16, 58, 11, 534, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 16, 334.55m, 5403m, new DateTime(2022, 9, 17, 20, 57, 28, 455, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 16, 374.99m, 5237m, new DateTime(2022, 6, 9, 22, 18, 57, 640, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 16, 135.16m, 8624m, new DateTime(2019, 7, 11, 14, 24, 2, 564, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 16, 316.67m, 9135m, new DateTime(2022, 5, 14, 20, 14, 1, 975, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 16, 253.13m, 3162m, new DateTime(2022, 9, 12, 17, 17, 12, 1, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 17, 374.70m, 5139m, new DateTime(2020, 10, 17, 5, 9, 19, 982, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 17, 361.60m, 7683m, new DateTime(2022, 11, 9, 9, 23, 5, 889, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 17, 385.98m, 4818m, new DateTime(2020, 6, 28, 21, 35, 22, 417, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 17, 11.45m, 848m, new DateTime(2019, 8, 12, 15, 2, 6, 229, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 17, 11.26m, 8484m, new DateTime(2019, 12, 27, 10, 2, 4, 525, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 17, 356.31m, 1689m, new DateTime(2019, 11, 2, 10, 19, 15, 458, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 17, 271.58m, 8143m, new DateTime(2020, 5, 31, 17, 22, 53, 217, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 17, 85.40m, 6189m, new DateTime(2020, 1, 19, 11, 52, 55, 415, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 301,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 17, 208.64m, 6561m, new DateTime(2019, 2, 4, 16, 10, 30, 393, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 302,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 17, 42.64m, 1426m, new DateTime(2019, 5, 18, 17, 10, 2, 128, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 303,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 17, 97.48m, 2997m, new DateTime(2022, 11, 3, 15, 40, 23, 342, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 304,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 17, 125.20m, 6473m, new DateTime(2021, 6, 28, 2, 40, 34, 212, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 305,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 17, 129.54m, 2987m, new DateTime(2019, 12, 1, 1, 8, 47, 926, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 306,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 17, 345.88m, 7889m, new DateTime(2020, 7, 20, 0, 10, 9, 24, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 307,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 17, 34.82m, 4399m, new DateTime(2020, 7, 2, 0, 34, 6, 567, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 308,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 17, 224.20m, 1549m, new DateTime(2022, 8, 16, 7, 6, 19, 240, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 309,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 17, 19.37m, 9181m, new DateTime(2021, 11, 30, 10, 0, 7, 456, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 310,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 17, 184.61m, 9995m, new DateTime(2020, 10, 2, 12, 5, 27, 500, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 311,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 17, 141.20m, 2801m, new DateTime(2020, 1, 2, 19, 41, 29, 395, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 312,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 17, 53.26m, 5110m, new DateTime(2019, 4, 20, 8, 3, 29, 281, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 313,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 17, 396.95m, 8427m, new DateTime(2020, 12, 20, 8, 36, 23, 811, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 314,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 17, 177.09m, 7516m, new DateTime(2021, 10, 20, 16, 35, 19, 342, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 315,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 17, 163.85m, 1445m, new DateTime(2019, 10, 28, 1, 3, 4, 74, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 316,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 17, 266.33m, 8883m, new DateTime(2022, 10, 11, 19, 45, 50, 431, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 317,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 17, 48.62m, 2439m, new DateTime(2020, 1, 16, 8, 44, 51, 851, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 318,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 17, 113.43m, 1321m, new DateTime(2020, 8, 1, 8, 51, 20, 874, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 319,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 18, 134.01m, 7226m, new DateTime(2020, 2, 20, 12, 58, 23, 821, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 320,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 45.86m, 4711m, new DateTime(2021, 6, 26, 9, 53, 48, 403, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 321,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 18, 99.43m, 7187m, new DateTime(2022, 8, 15, 5, 8, 7, 974, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 322,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 18, 206.86m, 7154m, new DateTime(2022, 6, 30, 11, 21, 37, 60, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 323,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 18, 168.31m, 4056m, new DateTime(2019, 7, 10, 21, 33, 8, 28, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 324,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 18, 342.25m, 5681m, new DateTime(2018, 12, 29, 20, 27, 1, 484, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 325,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 18, 273.31m, 7610m, new DateTime(2021, 2, 12, 9, 1, 4, 776, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 326,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 18, 151.77m, 4044m, new DateTime(2020, 4, 7, 14, 43, 37, 559, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 327,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 18, 233.91m, 6119m, new DateTime(2022, 1, 25, 2, 50, 56, 723, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 328,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 18, 166.87m, 7501m, new DateTime(2022, 7, 17, 22, 15, 48, 482, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 329,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 384.26m, 1701m, new DateTime(2021, 10, 16, 14, 53, 50, 11, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 330,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 18, 245.72m, 7357m, new DateTime(2021, 4, 20, 12, 42, 25, 841, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 331,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 294.17m, 9782m, new DateTime(2020, 7, 24, 2, 40, 33, 623, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 332,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 18, 334.70m, 1823m, new DateTime(2019, 7, 11, 14, 46, 7, 303, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 333,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 18, 388.48m, 7282m, new DateTime(2019, 7, 8, 11, 45, 53, 983, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 334,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 18, 250.89m, 7284m, new DateTime(2019, 11, 4, 7, 40, 39, 177, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 335,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 18, 370.92m, 6904m, new DateTime(2021, 8, 15, 21, 0, 7, 834, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 336,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 18, 147.84m, 4918m, new DateTime(2022, 6, 17, 9, 50, 29, 160, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 337,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 18, 118.97m, 7517m, new DateTime(2019, 1, 15, 3, 5, 57, 938, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 338,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 18, 76.61m, 6870m, new DateTime(2020, 7, 24, 8, 19, 53, 405, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 339,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 18, 313.54m, 1672m, new DateTime(2022, 5, 24, 11, 23, 20, 490, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 340,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 18, 279.06m, 6576m, new DateTime(2020, 4, 27, 2, 59, 37, 168, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 341,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 18, 66.68m, 4439m, new DateTime(2019, 11, 21, 5, 10, 50, 292, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 342,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 18, 354.84m, 8037m, new DateTime(2019, 11, 14, 4, 4, 27, 444, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 343,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 18, 333.52m, 2776m, new DateTime(2020, 10, 31, 6, 43, 17, 438, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 344,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 18, 158.53m, 1104m, new DateTime(2019, 10, 2, 5, 33, 15, 276, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 345,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 18, 296.16m, 6233m, new DateTime(2020, 7, 14, 11, 33, 36, 417, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 346,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 18, 217.31m, 130m, new DateTime(2019, 6, 18, 8, 31, 7, 338, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 347,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 18, 188.00m, 2475m, new DateTime(2020, 10, 30, 12, 32, 23, 876, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 348,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 18, 11.61m, 9280m, new DateTime(2019, 3, 16, 21, 7, 52, 311, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 349,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 18, 296.31m, 8754m, new DateTime(2019, 1, 5, 15, 17, 24, 334, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 350,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 18, 136.16m, 9857m, new DateTime(2021, 9, 8, 0, 18, 3, 439, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 351,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 18, 119.80m, 7283m, new DateTime(2019, 7, 11, 17, 49, 29, 681, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 352,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 18, 370.19m, 4639m, new DateTime(2019, 7, 29, 2, 44, 0, 228, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 353,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 19, 18.60m, 980m, new DateTime(2020, 4, 22, 15, 12, 30, 252, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 354,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 19, 307.67m, 1827m, new DateTime(2020, 8, 21, 22, 39, 27, 480, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 355,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 19, 215.10m, 8479m, new DateTime(2019, 1, 15, 4, 42, 47, 167, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 356,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 19, 243.66m, 6313m, new DateTime(2021, 12, 4, 7, 19, 23, 157, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 357,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 19, 372.73m, 7431m, new DateTime(2022, 5, 18, 2, 51, 11, 673, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 358,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 19, 250.12m, 7965m, new DateTime(2020, 2, 27, 16, 7, 5, 957, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 359,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 19, 61.94m, 2583m, new DateTime(2020, 9, 29, 0, 21, 56, 400, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 360,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 19, 31.92m, 3369m, new DateTime(2022, 2, 19, 21, 35, 8, 284, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 361,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 19, 110.99m, 8618m, new DateTime(2021, 4, 10, 19, 53, 42, 153, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 362,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 19, 163.30m, 7717m, new DateTime(2019, 1, 17, 6, 51, 24, 656, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 363,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 19, 135.96m, 7963m, new DateTime(2019, 2, 2, 6, 0, 24, 116, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 364,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 19, 240.38m, 8505m, new DateTime(2019, 10, 7, 17, 24, 3, 475, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 365,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 19, 280.65m, 981m, new DateTime(2020, 3, 20, 4, 56, 50, 741, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 366,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 19, 24.82m, 6855m, new DateTime(2018, 12, 31, 23, 17, 1, 43, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 367,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 19, 143.36m, 7657m, new DateTime(2021, 2, 11, 21, 36, 13, 74, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 368,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 19, 275.07m, 726m, new DateTime(2022, 11, 20, 21, 11, 14, 223, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 369,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 19, 363.35m, 2297m, new DateTime(2019, 11, 25, 7, 30, 51, 406, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 370,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 19, 105.26m, 7721m, new DateTime(2021, 7, 26, 9, 47, 37, 177, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 371,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 19, 156.53m, 2396m, new DateTime(2021, 8, 22, 1, 56, 55, 321, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 372,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 19, 191.96m, 4902m, new DateTime(2021, 2, 24, 2, 33, 47, 250, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 373,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 19, 7.29m, 642m, new DateTime(2020, 5, 15, 17, 18, 12, 374, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 374,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 19, 129.07m, 3658m, new DateTime(2020, 6, 16, 5, 20, 18, 333, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 375,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 19, 150.13m, 4094m, new DateTime(2019, 10, 9, 18, 29, 19, 857, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 376,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 19, 271.51m, 832m, new DateTime(2021, 4, 28, 20, 56, 28, 693, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 377,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 19, 148.76m, 6877m, new DateTime(2022, 7, 18, 18, 7, 58, 78, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 378,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 19, 298.64m, 2060m, new DateTime(2019, 3, 19, 0, 30, 11, 924, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 379,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 19, 154.33m, 3274m, new DateTime(2019, 8, 31, 7, 39, 20, 361, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 380,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 19, 166.97m, 1581m, new DateTime(2021, 10, 21, 4, 25, 10, 950, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 381,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 19, 273.07m, 6517m, new DateTime(2021, 11, 1, 15, 11, 53, 681, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 382,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 19, 10.71m, 5710m, new DateTime(2022, 10, 14, 6, 25, 5, 843, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 383,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 19, 240.87m, 1739m, new DateTime(2019, 5, 16, 7, 3, 38, 41, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 384,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 104.64m, 9679m, new DateTime(2022, 10, 22, 0, 4, 10, 203, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 385,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 20, 308.89m, 8045m, new DateTime(2021, 1, 18, 3, 43, 18, 710, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 386,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 20, 181.69m, 7699m, new DateTime(2019, 5, 20, 1, 33, 27, 341, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 387,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 20, 124.14m, 2995m, new DateTime(2022, 8, 4, 10, 4, 39, 861, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 388,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 20, 260.77m, 4554m, new DateTime(2020, 9, 26, 13, 40, 38, 312, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 389,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 20, 305.96m, 9350m, new DateTime(2021, 5, 25, 13, 28, 21, 906, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 390,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 20, 216.74m, 8621m, new DateTime(2020, 2, 17, 21, 54, 37, 585, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 391,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 20, 310.33m, 6823m, new DateTime(2019, 2, 17, 19, 43, 4, 150, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 392,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 20, 314.43m, 5285m, new DateTime(2019, 10, 14, 14, 25, 4, 308, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 393,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 20, 324.61m, 2156m, new DateTime(2022, 6, 23, 17, 9, 20, 952, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 394,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 20, 155.14m, 8659m, new DateTime(2020, 5, 25, 8, 28, 10, 859, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 395,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 20, 380.64m, 6616m, new DateTime(2022, 1, 22, 1, 25, 15, 262, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 396,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 20, 137.35m, 4399m, new DateTime(2020, 2, 11, 0, 3, 42, 291, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 397,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 20, 1.68m, 9614m, new DateTime(2019, 3, 5, 12, 39, 3, 69, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 398,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 20, 337.33m, 8689m, new DateTime(2022, 2, 28, 17, 1, 11, 519, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 399,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 20, 62.42m, 1203m, new DateTime(2021, 12, 5, 1, 19, 25, 489, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 400,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 21, 229.32m, 5162m, new DateTime(2019, 7, 20, 23, 16, 26, 885, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 401,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 21, 141.26m, 8521m, new DateTime(2019, 2, 25, 16, 1, 44, 283, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 402,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 21, 212.34m, 3497m, new DateTime(2021, 10, 4, 13, 19, 54, 325, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 403,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 21, 22.07m, 1714m, new DateTime(2019, 6, 10, 13, 17, 20, 187, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 404,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 21, 211.10m, 9450m, new DateTime(2021, 11, 28, 8, 28, 49, 98, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 405,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 21, 334.72m, 6502m, new DateTime(2022, 9, 26, 13, 50, 14, 875, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 406,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 21, 103.49m, 1583m, new DateTime(2020, 4, 6, 13, 55, 51, 972, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 407,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 21, 213.61m, 943m, new DateTime(2022, 3, 19, 15, 25, 51, 959, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 408,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 21, 149.81m, 8893m, new DateTime(2022, 4, 22, 14, 32, 58, 379, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 409,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 21, 304.32m, 7696m, new DateTime(2021, 6, 16, 14, 5, 0, 544, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 410,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 21, 258.81m, 860m, new DateTime(2019, 1, 5, 23, 42, 52, 778, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 411,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 21, 128.49m, 5642m, new DateTime(2021, 2, 1, 1, 27, 27, 469, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 412,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 21, 398.16m, 7143m, new DateTime(2019, 10, 25, 5, 54, 15, 396, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 413,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 21, 373.16m, 8830m, new DateTime(2020, 6, 19, 3, 4, 59, 653, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 414,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 21, 331.85m, 597m, new DateTime(2020, 4, 10, 14, 31, 48, 998, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 415,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 21, 179.98m, 9868m, new DateTime(2020, 8, 7, 5, 20, 46, 471, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 416,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 21, 153.00m, 8207m, new DateTime(2019, 9, 25, 18, 15, 39, 766, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 417,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 21, 212.47m, 9069m, new DateTime(2019, 10, 25, 8, 48, 42, 636, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 418,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 21, 139.54m, 9434m, new DateTime(2022, 3, 28, 9, 59, 27, 962, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 419,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 21, 20.96m, 2264m, new DateTime(2022, 12, 21, 21, 37, 33, 311, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 420,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 21, 230.27m, 5567m, new DateTime(2019, 8, 27, 14, 3, 23, 582, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 421,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 21, 34.27m, 3722m, new DateTime(2022, 8, 13, 11, 52, 29, 665, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 422,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 21, 189.29m, 1719m, new DateTime(2019, 2, 25, 16, 45, 21, 666, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 423,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 21, 395.98m, 9550m, new DateTime(2019, 3, 23, 2, 35, 39, 969, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 424,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 21, 323.18m, 4330m, new DateTime(2020, 6, 17, 20, 9, 14, 128, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 425,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 21, 365.89m, 3308m, new DateTime(2022, 4, 5, 7, 23, 56, 270, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 426,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 21, 393.06m, 5013m, new DateTime(2022, 4, 1, 11, 51, 46, 995, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 427,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 84.33m, 9504m, new DateTime(2020, 11, 1, 13, 22, 52, 494, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 428,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 21, 390.15m, 7142m, new DateTime(2022, 12, 22, 9, 34, 49, 712, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 429,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 21, 52.47m, 9700m, new DateTime(2021, 4, 29, 12, 48, 31, 161, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 430,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 21, 16.95m, 1048m, new DateTime(2020, 1, 12, 23, 5, 14, 911, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 431,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 21, 224.85m, 2089m, new DateTime(2021, 3, 28, 12, 41, 37, 190, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 432,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 21, 142.48m, 3503m, new DateTime(2019, 3, 1, 10, 5, 16, 88, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 433,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 21, 375.63m, 4030m, new DateTime(2021, 5, 1, 0, 39, 41, 861, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 434,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 21, 119.61m, 6935m, new DateTime(2020, 6, 3, 23, 37, 38, 15, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 435,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 21, 300.46m, 4049m, new DateTime(2021, 6, 10, 16, 27, 56, 500, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 436,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 21, 132.21m, 254m, new DateTime(2019, 2, 26, 19, 6, 52, 28, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 437,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 21, 236.92m, 9489m, new DateTime(2019, 1, 22, 1, 36, 22, 855, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 438,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 21, 367.05m, 3694m, new DateTime(2021, 10, 12, 17, 58, 1, 871, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 439,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 21, 180.61m, 2951m, new DateTime(2021, 11, 2, 15, 24, 2, 593, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 440,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 22, 77.16m, 7341m, new DateTime(2019, 12, 18, 16, 54, 40, 804, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 441,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 22, 241.67m, 547m, new DateTime(2020, 6, 6, 22, 13, 41, 319, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 442,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 22, 288.96m, 4097m, new DateTime(2021, 2, 5, 7, 45, 40, 970, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 443,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 22, 135.33m, 705m, new DateTime(2020, 10, 31, 8, 13, 53, 645, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 444,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 22, 167.96m, 6750m, new DateTime(2022, 11, 2, 9, 0, 15, 427, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 445,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 22, 2.79m, 2580m, new DateTime(2021, 8, 21, 4, 41, 9, 212, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 446,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 22, 20.17m, 2820m, new DateTime(2020, 3, 10, 14, 8, 7, 853, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 447,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 22, 140.51m, 2299m, new DateTime(2019, 7, 21, 8, 13, 52, 576, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 448,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 22, 252.52m, 6617m, new DateTime(2021, 9, 15, 21, 36, 58, 227, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 449,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 22, 128.30m, 4161m, new DateTime(2020, 9, 25, 23, 38, 43, 431, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 450,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 22, 204.52m, 4596m, new DateTime(2020, 1, 27, 12, 1, 0, 439, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 451,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 22, 305.39m, 9860m, new DateTime(2019, 7, 1, 5, 18, 34, 372, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 452,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 22, 100.61m, 7405m, new DateTime(2020, 8, 26, 3, 58, 1, 654, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 453,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 22, 240.74m, 1173m, new DateTime(2022, 11, 6, 8, 56, 34, 777, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 454,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 22, 359.76m, 4440m, new DateTime(2020, 1, 25, 12, 0, 35, 333, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 455,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 22, 366.74m, 1324m, new DateTime(2018, 12, 26, 20, 0, 34, 487, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 456,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 142.94m, 4866m, new DateTime(2022, 10, 4, 14, 3, 50, 187, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 457,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 22, 314.42m, 6725m, new DateTime(2021, 4, 2, 9, 15, 27, 795, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 458,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 22, 59.44m, 4536m, new DateTime(2021, 7, 25, 9, 8, 30, 564, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 459,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 22, 353.26m, 4652m, new DateTime(2020, 1, 5, 20, 53, 48, 795, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 460,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 22, 359.60m, 7486m, new DateTime(2020, 12, 4, 19, 21, 56, 952, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 461,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 22, 84.22m, 7360m, new DateTime(2019, 1, 31, 19, 13, 11, 907, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 462,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 22, 376.22m, 1367m, new DateTime(2022, 9, 29, 18, 35, 35, 590, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 463,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 22, 389.31m, 9585m, new DateTime(2020, 12, 6, 1, 4, 17, 516, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 464,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 22, 196.72m, 2705m, new DateTime(2020, 10, 28, 6, 33, 42, 878, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 465,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 22, 348.61m, 8868m, new DateTime(2020, 6, 14, 22, 57, 13, 907, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 466,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 22, 106.18m, 6291m, new DateTime(2019, 3, 2, 5, 56, 35, 779, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 467,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 22, 304.98m, 7235m, new DateTime(2019, 2, 16, 6, 34, 26, 79, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 468,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 22, 339.75m, 1970m, new DateTime(2020, 10, 2, 1, 35, 21, 281, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 469,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 22, 110.48m, 8007m, new DateTime(2022, 1, 28, 2, 52, 37, 453, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 470,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 22, 328.07m, 1559m, new DateTime(2021, 11, 18, 23, 31, 59, 30, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 471,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 22, 46.15m, 6676m, new DateTime(2020, 1, 22, 20, 38, 14, 29, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 472,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 22, 137.67m, 5490m, new DateTime(2021, 1, 27, 21, 47, 48, 667, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 473,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 22, 32.93m, 4998m, new DateTime(2019, 2, 5, 14, 21, 18, 387, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 474,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 22, 67.04m, 9873m, new DateTime(2019, 6, 23, 10, 24, 42, 348, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 475,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 22, 99.31m, 6287m, new DateTime(2021, 2, 4, 9, 31, 33, 828, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 476,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 22, 226.73m, 6764m, new DateTime(2021, 7, 5, 16, 6, 44, 240, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 477,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 22, 151.46m, 7249m, new DateTime(2022, 7, 16, 5, 59, 55, 379, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 478,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 23, 193.63m, 1240m, new DateTime(2022, 4, 18, 15, 43, 49, 616, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 479,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 23, 115.95m, 1908m, new DateTime(2020, 9, 13, 0, 12, 47, 223, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 480,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 23, 167.56m, 1176m, new DateTime(2019, 7, 1, 23, 39, 33, 903, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 481,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 23, 25.23m, 3049m, new DateTime(2021, 11, 1, 20, 31, 15, 161, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 482,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 23, 95.82m, 3823m, new DateTime(2022, 1, 31, 1, 50, 53, 549, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 483,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 23, 259.52m, 8525m, new DateTime(2019, 4, 7, 21, 41, 54, 769, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 484,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 23, 23.20m, 9371m, new DateTime(2021, 1, 15, 20, 59, 36, 449, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 485,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 23, 301.30m, 2925m, new DateTime(2019, 10, 23, 21, 9, 4, 137, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 486,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 23, 319.99m, 4935m, new DateTime(2020, 7, 23, 15, 4, 22, 123, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 487,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 23, 123.23m, 5645m, new DateTime(2020, 8, 2, 2, 46, 52, 815, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 488,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 23, 240.66m, 8364m, new DateTime(2019, 6, 19, 19, 5, 54, 973, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 489,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 23, 33.55m, 9588m, new DateTime(2019, 8, 29, 14, 36, 41, 130, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 490,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 23, 354.61m, 2209m, new DateTime(2020, 12, 14, 20, 8, 55, 689, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 491,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 23, 25.54m, 1144m, new DateTime(2022, 6, 1, 21, 49, 55, 359, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 492,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 23, 233.56m, 5859m, new DateTime(2021, 2, 7, 22, 47, 48, 455, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 493,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 23, 288.74m, 1977m, new DateTime(2022, 6, 20, 0, 13, 15, 546, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 494,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 23, 310.02m, 2575m, new DateTime(2021, 7, 20, 10, 11, 20, 297, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 495,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 23, 205.17m, 6843m, new DateTime(2020, 12, 24, 9, 35, 47, 927, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 496,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 23, 302.58m, 4387m, new DateTime(2022, 9, 11, 17, 29, 42, 69, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 497,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 23, 29.76m, 1403m, new DateTime(2021, 12, 21, 20, 41, 49, 555, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 498,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 23, 237.80m, 6835m, new DateTime(2019, 7, 22, 16, 19, 3, 118, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 499,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 23, 12.13m, 4125m, new DateTime(2021, 5, 18, 11, 22, 53, 0, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 500,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 23, 364.98m, 4859m, new DateTime(2021, 4, 7, 21, 29, 37, 794, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 501,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 271.30m, 6775m, new DateTime(2019, 1, 24, 19, 45, 9, 515, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 502,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 23, 64.89m, 268m, new DateTime(2022, 7, 9, 15, 25, 39, 309, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 503,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 23, 350.82m, 2925m, new DateTime(2022, 3, 28, 23, 28, 35, 985, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 504,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 23, 111.24m, 2313m, new DateTime(2020, 3, 2, 22, 15, 29, 243, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 505,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 23, 28.26m, 9693m, new DateTime(2021, 7, 29, 19, 7, 26, 161, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 506,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 23, 311.10m, 676m, new DateTime(2020, 12, 8, 0, 57, 39, 166, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 507,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 23, 74.59m, 1517m, new DateTime(2020, 8, 3, 18, 3, 20, 522, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 508,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 23, 148.30m, 2835m, new DateTime(2022, 2, 1, 1, 7, 39, 652, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 509,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 23, 274.45m, 5012m, new DateTime(2019, 11, 25, 6, 24, 50, 827, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 510,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 23, 391.54m, 773m, new DateTime(2019, 12, 14, 15, 43, 51, 483, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 511,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 23, 136.96m, 4983m, new DateTime(2019, 2, 2, 4, 15, 47, 111, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 512,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 23, 350.75m, 7719m, new DateTime(2019, 10, 5, 13, 4, 35, 895, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 513,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 23, 60.25m, 3283m, new DateTime(2022, 6, 15, 7, 17, 51, 899, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 514,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 23, 202.81m, 5809m, new DateTime(2021, 4, 29, 0, 59, 18, 55, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 515,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 23, 37.58m, 2384m, new DateTime(2019, 5, 22, 1, 54, 28, 192, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 516,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 23, 143.30m, 2185m, new DateTime(2019, 8, 24, 4, 59, 34, 780, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 517,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 23, 22.91m, 8604m, new DateTime(2019, 4, 24, 1, 11, 2, 598, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 518,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 24, 113.36m, 9511m, new DateTime(2019, 6, 14, 20, 46, 59, 147, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 519,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 24, 7.55m, 3703m, new DateTime(2019, 8, 20, 17, 57, 24, 515, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 520,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 24, 330.75m, 6466m, new DateTime(2022, 2, 22, 3, 45, 18, 368, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 521,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 24, 360.35m, 8210m, new DateTime(2022, 12, 9, 17, 44, 41, 771, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 522,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 24, 77.71m, 6091m, new DateTime(2019, 5, 1, 6, 50, 3, 267, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 523,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 24, 210.42m, 5034m, new DateTime(2019, 11, 29, 4, 6, 40, 304, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 524,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 24, 304.62m, 4066m, new DateTime(2022, 12, 10, 10, 3, 27, 715, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 525,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 24, 377.88m, 6566m, new DateTime(2021, 3, 29, 19, 22, 47, 59, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 526,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 24, 100.56m, 6409m, new DateTime(2020, 4, 15, 17, 11, 11, 2, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 527,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 24, 231.41m, 4730m, new DateTime(2019, 7, 5, 2, 57, 47, 316, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 528,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 24, 276.03m, 2096m, new DateTime(2021, 1, 6, 16, 33, 11, 769, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 529,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 24, 329.68m, 7067m, new DateTime(2021, 11, 30, 4, 20, 17, 933, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 530,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 24, 2.98m, 7819m, new DateTime(2021, 2, 24, 11, 24, 10, 192, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 531,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 24, 309.01m, 2225m, new DateTime(2019, 7, 11, 8, 18, 38, 749, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 532,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 24, 392.74m, 3121m, new DateTime(2021, 4, 9, 13, 28, 13, 302, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 533,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 24, 114.42m, 8809m, new DateTime(2020, 7, 24, 15, 38, 54, 55, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 534,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 24, 238.48m, 1205m, new DateTime(2020, 3, 7, 5, 26, 45, 420, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 535,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 24, 105.10m, 5345m, new DateTime(2020, 9, 11, 9, 17, 19, 479, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 536,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 200.92m, 9797m, new DateTime(2022, 11, 12, 4, 16, 1, 910, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 537,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 24, 284.75m, 9377m, new DateTime(2019, 9, 27, 11, 41, 18, 167, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 538,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 24, 272.57m, 3758m, new DateTime(2020, 8, 31, 18, 51, 55, 126, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 539,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 24, 340.98m, 6938m, new DateTime(2020, 5, 19, 13, 17, 28, 462, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 540,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 25, 225.11m, 9455m, new DateTime(2019, 7, 4, 15, 43, 15, 808, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 541,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 25, 244.22m, 6135m, new DateTime(2022, 5, 27, 11, 20, 11, 373, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 542,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 25, 62.25m, 8903m, new DateTime(2022, 6, 8, 18, 11, 13, 461, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 543,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 25, 370.54m, 8235m, new DateTime(2021, 3, 1, 21, 46, 26, 798, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 544,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 25, 353.33m, 2338m, new DateTime(2020, 9, 23, 12, 40, 35, 963, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 545,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 25, 195.97m, 5774m, new DateTime(2022, 2, 22, 16, 50, 6, 633, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 546,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 25, 94.16m, 8587m, new DateTime(2020, 4, 7, 4, 43, 21, 974, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 547,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 25, 4.09m, 9071m, new DateTime(2020, 6, 13, 23, 5, 59, 667, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 548,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 25, 281.27m, 5110m, new DateTime(2022, 6, 3, 9, 13, 14, 397, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 549,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 25, 353.92m, 9581m, new DateTime(2020, 3, 6, 2, 48, 23, 679, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 550,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 25, 270.07m, 6507m, new DateTime(2019, 5, 30, 4, 48, 17, 954, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 551,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 25, 50.74m, 2039m, new DateTime(2020, 9, 28, 22, 40, 0, 102, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 552,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 25, 35.68m, 1431m, new DateTime(2019, 12, 16, 10, 2, 42, 376, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 553,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 25, 263.53m, 7456m, new DateTime(2019, 2, 5, 21, 45, 12, 528, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 554,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 25, 323.62m, 9679m, new DateTime(2021, 2, 23, 22, 4, 27, 168, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 555,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 25, 115.31m, 4163m, new DateTime(2021, 6, 21, 2, 16, 13, 817, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 556,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 25, 388.09m, 8949m, new DateTime(2019, 6, 13, 18, 4, 56, 508, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 557,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 25, 328.03m, 3479m, new DateTime(2022, 7, 1, 8, 28, 25, 798, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 558,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 25, 329.02m, 5179m, new DateTime(2021, 8, 10, 13, 29, 19, 70, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 25, 15.52m, 4463m, new DateTime(2019, 5, 19, 14, 2, 56, 710, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 25, 178.44m, 6888m, new DateTime(2020, 1, 17, 4, 11, 1, 351, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 25, 116.93m, 5477m, new DateTime(2019, 9, 12, 14, 30, 18, 41, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 25, 52.23m, 4142m, new DateTime(2019, 8, 1, 13, 13, 51, 791, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 25, 397.50m, 6027m, new DateTime(2022, 5, 18, 19, 6, 25, 655, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 25, 67.37m, 4513m, new DateTime(2021, 7, 13, 15, 27, 13, 760, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 25, 171.95m, 1867m, new DateTime(2022, 1, 26, 19, 17, 15, 723, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 25, 50.05m, 4884m, new DateTime(2021, 9, 18, 14, 51, 56, 833, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 25, 158.73m, 1068m, new DateTime(2019, 4, 17, 2, 13, 19, 759, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 25, 221.68m, 3340m, new DateTime(2019, 4, 2, 2, 53, 30, 101, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 25, 164.26m, 7922m, new DateTime(2019, 2, 10, 18, 36, 4, 741, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 25, 40.10m, 5790m, new DateTime(2020, 7, 24, 4, 36, 19, 788, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 25, 182.34m, 971m, new DateTime(2022, 2, 14, 11, 41, 7, 263, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 572,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 25, 80.56m, 3476m, new DateTime(2020, 11, 23, 21, 14, 55, 58, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 573,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 25, 102.95m, 3789m, new DateTime(2021, 11, 16, 16, 21, 50, 633, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 574,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 25, 73.40m, 413m, new DateTime(2021, 12, 11, 20, 34, 54, 652, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 575,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 26, 300.35m, 4795m, new DateTime(2019, 8, 21, 5, 43, 6, 423, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 576,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 26, 328.91m, 8023m, new DateTime(2022, 7, 10, 19, 35, 28, 221, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 577,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 26, 228.65m, 5202m, new DateTime(2021, 10, 5, 13, 9, 48, 330, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 578,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 26, 260.73m, 697m, new DateTime(2019, 8, 30, 23, 27, 16, 271, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 579,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 26, 91.50m, 2080m, new DateTime(2020, 2, 8, 9, 23, 38, 899, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 580,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 26, 232.40m, 9371m, new DateTime(2021, 6, 15, 11, 3, 52, 213, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 581,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 26, 223.87m, 7436m, new DateTime(2019, 3, 16, 18, 57, 5, 394, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 582,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 26, 373.67m, 4389m, new DateTime(2018, 12, 24, 6, 36, 50, 163, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 583,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 26, 307.70m, 9189m, new DateTime(2022, 9, 6, 20, 41, 30, 856, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 584,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 26, 40.96m, 7009m, new DateTime(2021, 8, 1, 15, 21, 12, 229, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 585,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 26, 87.21m, 7003m, new DateTime(2020, 6, 11, 8, 32, 42, 919, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 586,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 26, 179.14m, 4220m, new DateTime(2020, 6, 16, 22, 35, 7, 646, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 587,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 26, 216.34m, 4789m, new DateTime(2020, 7, 22, 9, 26, 52, 582, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 588,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 26, 17.05m, 3142m, new DateTime(2019, 2, 26, 22, 49, 14, 522, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 589,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 26, 29.17m, 8533m, new DateTime(2019, 5, 25, 23, 24, 20, 546, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 590,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 26, 19.63m, 7525m, new DateTime(2022, 1, 3, 12, 3, 39, 90, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 591,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 26, 385.46m, 9622m, new DateTime(2020, 8, 25, 8, 34, 15, 520, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 592,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 27, 8.81m, 7354m, new DateTime(2020, 10, 9, 10, 25, 29, 696, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 593,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 27, 273.40m, 4021m, new DateTime(2019, 3, 21, 16, 42, 7, 822, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 594,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 27, 210.95m, 2769m, new DateTime(2019, 12, 16, 16, 16, 1, 316, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 595,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 27, 210.56m, 4725m, new DateTime(2021, 12, 27, 18, 24, 22, 713, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 596,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 27, 306.56m, 6575m, new DateTime(2022, 7, 26, 0, 28, 12, 236, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 597,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 27, 198.86m, 2140m, new DateTime(2019, 6, 29, 18, 20, 25, 702, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 598,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 27, 353.14m, 555m, new DateTime(2020, 1, 23, 10, 37, 33, 83, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 599,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 27, 267.12m, 2519m, new DateTime(2021, 8, 4, 4, 17, 58, 558, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 600,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 27, 22.59m, 303m, new DateTime(2020, 10, 29, 17, 55, 46, 677, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 601,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 27, 7.21m, 7343m, new DateTime(2020, 11, 22, 17, 53, 30, 203, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 602,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 27, 56.90m, 1858m, new DateTime(2021, 7, 18, 8, 7, 44, 0, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 603,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 27, 398.15m, 863m, new DateTime(2020, 10, 18, 7, 24, 47, 257, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 604,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 28, 123.81m, 4841m, new DateTime(2019, 1, 25, 22, 11, 20, 615, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 605,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 28, 138.40m, 4269m, new DateTime(2022, 11, 5, 20, 22, 2, 10, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 606,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 28, 357.32m, 3777m, new DateTime(2021, 5, 28, 14, 6, 55, 256, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 607,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 28, 204.45m, 3807m, new DateTime(2022, 11, 5, 18, 11, 7, 98, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 608,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 28, 91.10m, 7604m, new DateTime(2022, 9, 6, 4, 38, 35, 394, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 609,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 28, 148.91m, 3796m, new DateTime(2019, 11, 2, 19, 6, 33, 887, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 610,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 28, 277.48m, 5251m, new DateTime(2019, 7, 23, 0, 7, 42, 352, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 611,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 28, 260.87m, 920m, new DateTime(2019, 4, 27, 18, 55, 3, 670, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 612,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 148.40m, 1378m, new DateTime(2020, 7, 29, 12, 25, 32, 394, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 613,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 28, 202.30m, 2623m, new DateTime(2021, 7, 15, 21, 49, 48, 535, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 614,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 28, 52.03m, 5089m, new DateTime(2020, 2, 19, 18, 10, 38, 639, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 615,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 28, 130.83m, 4036m, new DateTime(2022, 6, 26, 16, 11, 26, 234, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 616,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 28, 188.86m, 9797m, new DateTime(2020, 6, 14, 23, 9, 10, 913, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 617,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 28, 295.13m, 8711m, new DateTime(2019, 11, 24, 7, 35, 12, 125, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 618,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 28, 137.89m, 6725m, new DateTime(2022, 7, 17, 15, 4, 48, 70, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 619,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 28, 129.95m, 2855m, new DateTime(2020, 1, 23, 18, 50, 27, 489, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 620,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 28, 365.61m, 8439m, new DateTime(2020, 2, 4, 13, 8, 15, 929, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 621,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 28, 98.14m, 7470m, new DateTime(2022, 12, 15, 6, 40, 35, 530, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 622,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 28, 281.63m, 6301m, new DateTime(2021, 12, 17, 5, 43, 16, 555, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 623,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 28, 206.87m, 203m, new DateTime(2021, 12, 29, 0, 31, 19, 258, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 624,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 28, 174.88m, 8909m, new DateTime(2022, 3, 12, 21, 8, 1, 625, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 625,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 29, 292.22m, 2882m, new DateTime(2021, 8, 24, 4, 21, 38, 694, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 626,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 29, 276.26m, 6607m, new DateTime(2019, 11, 29, 4, 22, 5, 747, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 627,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 29, 173.10m, 8724m, new DateTime(2019, 1, 2, 4, 25, 15, 396, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 628,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 29, 112.75m, 6437m, new DateTime(2019, 9, 13, 18, 10, 13, 792, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 629,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 29, 354.40m, 8000m, new DateTime(2021, 4, 14, 12, 46, 26, 942, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 630,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 29, 58.12m, 748m, new DateTime(2020, 5, 13, 20, 54, 26, 718, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 631,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 29, 39.98m, 3641m, new DateTime(2021, 2, 23, 3, 40, 10, 134, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 632,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 29, 335.50m, 3236m, new DateTime(2019, 6, 7, 4, 9, 43, 845, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 633,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 29, 155.74m, 7002m, new DateTime(2021, 6, 2, 4, 23, 34, 34, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 634,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 29, 96.28m, 5159m, new DateTime(2022, 3, 28, 22, 11, 30, 657, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 635,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 105.03m, 9077m, new DateTime(2020, 10, 4, 22, 5, 2, 945, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 636,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 29, 171.34m, 1084m, new DateTime(2021, 11, 20, 6, 23, 28, 36, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 637,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 29, 309.23m, 9735m, new DateTime(2022, 1, 12, 0, 47, 8, 255, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 638,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 29, 384.01m, 2059m, new DateTime(2020, 10, 10, 0, 31, 59, 847, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 639,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 374.07m, 5678m, new DateTime(2022, 6, 4, 5, 14, 55, 870, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 640,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 29, 11.28m, 5412m, new DateTime(2020, 9, 26, 2, 57, 8, 504, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 641,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 29, 316.88m, 5928m, new DateTime(2022, 11, 4, 16, 50, 45, 410, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 642,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 29, 120.63m, 7215m, new DateTime(2021, 12, 19, 2, 46, 3, 972, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 643,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 29, 73.84m, 8005m, new DateTime(2020, 9, 26, 14, 34, 42, 121, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 644,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 29, 357.87m, 3940m, new DateTime(2019, 10, 3, 22, 50, 24, 402, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 645,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 29, 367.04m, 7300m, new DateTime(2019, 4, 2, 19, 18, 50, 111, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 646,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 117.71m, 7491m, new DateTime(2020, 10, 18, 12, 5, 35, 603, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 647,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 29, 169.97m, 1298m, new DateTime(2020, 1, 10, 11, 46, 34, 461, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 648,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 29, 211.50m, 8319m, new DateTime(2020, 9, 2, 2, 41, 26, 883, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 649,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 29, 289.23m, 5888m, new DateTime(2019, 6, 14, 9, 24, 23, 581, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 650,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 30, 207.35m, 1269m, new DateTime(2021, 10, 2, 4, 47, 21, 656, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 651,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 30, 300.85m, 5371m, new DateTime(2019, 7, 13, 12, 3, 6, 628, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 652,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 30, 300.22m, 4674m, new DateTime(2022, 2, 12, 1, 42, 2, 562, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 653,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 30, 333.06m, 4829m, new DateTime(2020, 8, 30, 18, 35, 48, 506, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 654,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 30, 115.21m, 1404m, new DateTime(2022, 7, 10, 13, 38, 45, 201, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 655,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 30, 53.37m, 3901m, new DateTime(2020, 7, 28, 6, 1, 5, 792, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 656,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 30, 291.86m, 3419m, new DateTime(2020, 4, 4, 3, 57, 37, 411, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 657,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 30, 88.78m, 8655m, new DateTime(2022, 4, 24, 17, 27, 40, 27, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 658,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 30, 250.44m, 591m, new DateTime(2022, 2, 17, 3, 4, 53, 976, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 659,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 30, 273.55m, 2469m, new DateTime(2021, 5, 16, 22, 29, 1, 870, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 660,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 30, 209.53m, 1839m, new DateTime(2020, 10, 23, 6, 32, 44, 171, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 661,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 30, 399.35m, 9519m, new DateTime(2020, 4, 12, 15, 18, 56, 705, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 662,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 30, 307.46m, 4038m, new DateTime(2020, 3, 11, 18, 35, 58, 858, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 663,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 31, 368.69m, 7101m, new DateTime(2021, 6, 5, 6, 46, 53, 617, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 664,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 31, 210.80m, 9941m, new DateTime(2022, 2, 1, 9, 42, 49, 260, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 665,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 31, 140.83m, 8512m, new DateTime(2021, 1, 19, 14, 6, 56, 70, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 666,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 31, 211.64m, 4632m, new DateTime(2022, 8, 21, 8, 20, 12, 696, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 667,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 31, 349.59m, 2267m, new DateTime(2022, 1, 30, 20, 11, 53, 636, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 668,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 31, 170.49m, 7577m, new DateTime(2022, 9, 8, 5, 55, 8, 929, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 669,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 31, 291.41m, 6254m, new DateTime(2021, 1, 31, 15, 10, 58, 712, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 670,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 31, 307.35m, 5798m, new DateTime(2021, 6, 20, 14, 54, 17, 163, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 671,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 31, 329.85m, 2370m, new DateTime(2019, 11, 28, 0, 11, 56, 27, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 672,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 31, 72.13m, 6261m, new DateTime(2020, 2, 28, 16, 6, 53, 0, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 673,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 31, 25.12m, 4164m, new DateTime(2022, 5, 6, 22, 12, 0, 371, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 674,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 31, 236.05m, 4227m, new DateTime(2022, 4, 15, 2, 32, 41, 355, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 675,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 31, 189.45m, 5049m, new DateTime(2021, 2, 3, 8, 5, 36, 209, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 676,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 31, 146.23m, 142m, new DateTime(2019, 5, 25, 23, 2, 35, 852, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 677,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 31, 206.30m, 695m, new DateTime(2021, 11, 5, 2, 36, 8, 156, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 678,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 31, 171.38m, 1970m, new DateTime(2021, 11, 28, 16, 36, 30, 321, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 679,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 31, 190.53m, 2618m, new DateTime(2022, 8, 24, 22, 2, 16, 897, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 680,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 31, 60.43m, 1936m, new DateTime(2020, 6, 9, 22, 9, 38, 830, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 681,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 32, 264.98m, 2984m, new DateTime(2020, 6, 17, 10, 48, 38, 453, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 682,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 32, 23.12m, 6923m, new DateTime(2022, 7, 31, 6, 21, 20, 692, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 683,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 33, 42.21m, 8778m, new DateTime(2019, 7, 5, 18, 1, 23, 437, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 684,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 33, 346.29m, 7651m, new DateTime(2022, 3, 2, 23, 21, 57, 786, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 685,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 33, 44.02m, 6470m, new DateTime(2022, 9, 25, 20, 59, 4, 175, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 686,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 33, 393.41m, 9686m, new DateTime(2019, 1, 22, 9, 53, 30, 606, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 687,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 33, 376.79m, 9186m, new DateTime(2021, 12, 31, 4, 36, 25, 115, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 688,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 33, 141.03m, 2921m, new DateTime(2019, 7, 15, 5, 40, 2, 181, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 689,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 33, 285.43m, 2732m, new DateTime(2022, 6, 3, 20, 10, 43, 828, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 690,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 33, 149.01m, 1917m, new DateTime(2019, 3, 24, 19, 43, 21, 157, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 691,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 33, 129.65m, 416m, new DateTime(2020, 9, 14, 6, 43, 25, 84, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 692,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 33, 22.00m, 4980m, new DateTime(2019, 10, 8, 11, 29, 46, 323, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 693,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 34, 202.68m, 1341m, new DateTime(2021, 3, 18, 2, 44, 57, 593, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 694,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 34, 129.90m, 6530m, new DateTime(2021, 2, 14, 17, 40, 36, 729, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 695,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 34, 308.77m, 8562m, new DateTime(2020, 10, 25, 18, 29, 22, 664, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 696,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 34, 233.01m, 3805m, new DateTime(2021, 10, 12, 14, 43, 48, 733, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 697,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 34, 374.38m, 4563m, new DateTime(2022, 1, 18, 6, 37, 3, 532, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 698,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 34, 350.74m, 2629m, new DateTime(2022, 4, 28, 12, 1, 35, 148, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 699,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 34, 378.83m, 202m, new DateTime(2020, 5, 18, 22, 16, 15, 885, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 700,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 34, 300.65m, 3603m, new DateTime(2021, 3, 29, 23, 48, 56, 517, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 701,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 34, 168.10m, 7470m, new DateTime(2022, 1, 21, 5, 29, 36, 819, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 702,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 34, 270.52m, 3850m, new DateTime(2019, 8, 5, 10, 31, 34, 678, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 703,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 34, 159.65m, 340m, new DateTime(2021, 6, 1, 3, 29, 49, 180, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 704,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 34, 108.42m, 3520m, new DateTime(2020, 7, 29, 16, 18, 28, 131, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 705,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 34, 228.43m, 345m, new DateTime(2020, 1, 5, 3, 39, 16, 882, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 706,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 34, 330.81m, 6657m, new DateTime(2022, 7, 4, 23, 30, 44, 14, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 707,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 34, 337.80m, 2406m, new DateTime(2021, 12, 24, 3, 34, 54, 230, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 708,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 34, 98.77m, 6803m, new DateTime(2020, 3, 1, 5, 20, 48, 722, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 709,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 34, 353.70m, 9071m, new DateTime(2022, 7, 24, 0, 0, 0, 113, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 710,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 34, 272.37m, 4276m, new DateTime(2019, 2, 25, 18, 8, 54, 712, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 711,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 34, 264.35m, 3262m, new DateTime(2019, 11, 15, 20, 56, 38, 957, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 712,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 34, 269.49m, 5523m, new DateTime(2019, 7, 18, 6, 45, 10, 13, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 713,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 34, 362.07m, 2963m, new DateTime(2020, 1, 4, 21, 46, 8, 647, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 714,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 34, 299.59m, 7118m, new DateTime(2019, 11, 3, 10, 53, 43, 41, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 715,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 34, 364.40m, 2408m, new DateTime(2019, 4, 21, 15, 35, 23, 693, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 716,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 34, 365.60m, 2309m, new DateTime(2020, 11, 1, 11, 37, 20, 942, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 717,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 34, 90.73m, 2201m, new DateTime(2019, 11, 10, 5, 30, 55, 821, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 718,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 34, 281.20m, 7180m, new DateTime(2021, 2, 16, 8, 7, 4, 920, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 719,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 34, 107.43m, 7200m, new DateTime(2021, 8, 6, 1, 42, 46, 775, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 720,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 34, 131.76m, 6909m, new DateTime(2022, 12, 19, 6, 14, 21, 457, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 721,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 34, 284.76m, 5455m, new DateTime(2020, 9, 25, 10, 59, 20, 288, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 722,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 34, 161.22m, 8384m, new DateTime(2019, 11, 20, 12, 31, 46, 532, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 723,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 34, 254.80m, 3236m, new DateTime(2022, 5, 6, 3, 19, 51, 911, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 724,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 34, 127.91m, 769m, new DateTime(2020, 12, 6, 0, 14, 39, 926, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 725,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 34, 144.44m, 9479m, new DateTime(2021, 5, 9, 1, 42, 15, 792, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 726,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 34, 336.79m, 9797m, new DateTime(2021, 9, 6, 19, 35, 38, 839, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 727,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 34, 26.34m, 5900m, new DateTime(2020, 8, 17, 3, 39, 32, 114, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 34, 226.38m, 9514m, new DateTime(2021, 3, 16, 16, 18, 49, 873, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 729,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 34, 21.93m, 2177m, new DateTime(2019, 5, 9, 20, 8, 36, 426, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 730,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 34, 376.25m, 5054m, new DateTime(2020, 12, 4, 16, 26, 32, 285, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 731,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 34, 214.71m, 8316m, new DateTime(2019, 9, 25, 6, 41, 47, 870, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 732,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 34, 323.39m, 9802m, new DateTime(2022, 8, 29, 1, 24, 25, 112, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 733,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 35, 22.93m, 3978m, new DateTime(2020, 2, 12, 16, 24, 29, 474, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 734,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 35, 232.62m, 3842m, new DateTime(2020, 3, 31, 4, 13, 13, 363, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 735,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 35, 75.33m, 8281m, new DateTime(2020, 3, 26, 9, 43, 35, 962, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 736,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 35, 83.52m, 9532m, new DateTime(2021, 8, 20, 8, 16, 30, 863, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 737,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 35, 121.19m, 8186m, new DateTime(2021, 5, 8, 9, 15, 3, 511, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 738,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 35, 362.14m, 498m, new DateTime(2021, 9, 4, 18, 7, 56, 557, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 739,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 35, 197.70m, 8366m, new DateTime(2021, 4, 22, 5, 8, 11, 43, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 740,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 35, 243.16m, 9472m, new DateTime(2020, 3, 9, 15, 5, 8, 677, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 741,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 35, 291.30m, 6708m, new DateTime(2019, 10, 30, 15, 54, 0, 461, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 742,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 35, 90.12m, 9026m, new DateTime(2020, 12, 7, 16, 20, 1, 961, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 743,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 35, 330.82m, 3013m, new DateTime(2021, 2, 1, 4, 8, 42, 53, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 744,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 35, 190.82m, 1773m, new DateTime(2019, 12, 16, 18, 34, 22, 255, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 745,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 35, 269.54m, 3989m, new DateTime(2021, 8, 29, 7, 4, 1, 860, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 746,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 35, 30.83m, 2692m, new DateTime(2020, 12, 12, 6, 1, 30, 338, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 747,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 35, 364.55m, 575m, new DateTime(2021, 1, 10, 16, 15, 40, 138, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 748,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 35, 2.02m, 1452m, new DateTime(2019, 6, 8, 16, 1, 34, 751, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 749,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 36, 267.30m, 9870m, new DateTime(2021, 5, 4, 23, 36, 51, 686, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 750,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 36, 202.25m, 2495m, new DateTime(2020, 5, 20, 10, 37, 6, 226, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 751,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 36, 12.99m, 5478m, new DateTime(2021, 2, 4, 21, 33, 49, 540, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 752,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 36, 100.00m, 2601m, new DateTime(2022, 1, 19, 1, 42, 45, 222, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 753,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 36, 122.26m, 1239m, new DateTime(2020, 7, 6, 1, 47, 28, 13, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 754,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 36, 210.30m, 2783m, new DateTime(2021, 3, 14, 6, 59, 29, 960, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 755,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 36, 185.27m, 817m, new DateTime(2022, 10, 5, 21, 42, 30, 655, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 756,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 36, 134.78m, 9473m, new DateTime(2021, 6, 20, 21, 32, 18, 609, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 757,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 36, 138.97m, 4600m, new DateTime(2022, 8, 16, 0, 44, 33, 437, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 758,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 37, 61.22m, 6843m, new DateTime(2020, 5, 13, 23, 22, 35, 111, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 759,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 37, 287.73m, 470m, new DateTime(2020, 9, 11, 9, 37, 44, 174, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 760,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 37, 318.35m, 2630m, new DateTime(2021, 2, 17, 11, 17, 43, 189, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 761,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 37, 9.61m, 2765m, new DateTime(2021, 1, 8, 23, 33, 49, 407, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 762,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 37, 55.79m, 7779m, new DateTime(2021, 2, 11, 10, 58, 8, 264, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 763,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 37, 230.48m, 1802m, new DateTime(2022, 9, 4, 11, 49, 22, 458, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 764,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 37, 209.50m, 2250m, new DateTime(2020, 12, 1, 20, 30, 16, 157, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 765,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 37, 310.80m, 1342m, new DateTime(2020, 1, 9, 0, 45, 32, 800, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 766,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 37, 385.49m, 5554m, new DateTime(2022, 9, 17, 5, 48, 57, 728, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 767,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 37, 349.77m, 1139m, new DateTime(2022, 5, 13, 3, 28, 21, 413, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 768,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 37, 237.38m, 5525m, new DateTime(2019, 10, 2, 4, 5, 31, 62, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 769,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 37, 355.50m, 3341m, new DateTime(2020, 4, 22, 23, 39, 52, 731, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 770,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 37, 249.63m, 5971m, new DateTime(2021, 9, 20, 7, 47, 40, 250, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 771,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 37, 293.69m, 7226m, new DateTime(2022, 2, 21, 2, 22, 46, 481, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 772,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 37, 262.24m, 3770m, new DateTime(2022, 7, 20, 19, 18, 8, 952, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 773,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 37, 123.26m, 5155m, new DateTime(2020, 11, 30, 11, 42, 31, 950, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 774,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 37, 239.22m, 8896m, new DateTime(2021, 1, 21, 16, 46, 16, 977, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 775,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 37, 218.71m, 5917m, new DateTime(2021, 10, 2, 3, 58, 8, 48, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 776,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 37, 262.88m, 9046m, new DateTime(2019, 5, 15, 12, 45, 48, 490, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 777,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 37, 46.35m, 7606m, new DateTime(2020, 8, 28, 1, 19, 19, 848, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 778,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 37, 357.79m, 8465m, new DateTime(2021, 8, 29, 10, 42, 40, 340, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 779,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 37, 279.66m, 1065m, new DateTime(2020, 12, 18, 16, 58, 44, 799, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 780,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 37, 131.84m, 4886m, new DateTime(2019, 9, 15, 11, 28, 40, 272, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 781,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 37, 287.81m, 5264m, new DateTime(2021, 3, 4, 18, 49, 48, 458, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 782,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 37, 135.79m, 2646m, new DateTime(2022, 1, 3, 17, 35, 56, 651, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 783,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 37, 149.40m, 9521m, new DateTime(2020, 1, 20, 13, 56, 54, 488, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 784,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 37, 311.18m, 2706m, new DateTime(2022, 10, 14, 8, 9, 31, 622, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 785,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 37, 360.36m, 2147m, new DateTime(2022, 9, 20, 22, 45, 13, 127, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 786,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 37, 10.49m, 4735m, new DateTime(2021, 12, 12, 0, 24, 20, 601, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 787,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 37, 333.31m, 1696m, new DateTime(2020, 7, 5, 1, 11, 41, 666, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 788,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 37, 48.67m, 2583m, new DateTime(2022, 3, 19, 22, 13, 46, 501, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 789,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 37, 363.90m, 7658m, new DateTime(2021, 12, 8, 6, 13, 27, 941, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 790,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 37, 114.77m, 3674m, new DateTime(2022, 3, 27, 15, 52, 53, 506, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 791,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 38, 151.44m, 4615m, new DateTime(2021, 8, 19, 3, 50, 24, 430, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 792,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 38, 96.39m, 1067m, new DateTime(2022, 4, 21, 0, 30, 46, 420, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 793,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 38, 244.60m, 2898m, new DateTime(2021, 5, 26, 15, 20, 17, 331, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 794,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 38, 392.82m, 5298m, new DateTime(2019, 1, 20, 16, 55, 11, 68, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 795,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 38, 33.05m, 6820m, new DateTime(2022, 10, 12, 1, 55, 34, 646, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 796,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 38, 192.32m, 5919m, new DateTime(2019, 2, 24, 13, 47, 38, 244, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 797,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 38, 114.31m, 4717m, new DateTime(2020, 10, 10, 9, 33, 37, 178, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 798,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 38, 281.25m, 1288m, new DateTime(2021, 5, 20, 20, 59, 55, 610, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 799,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 38, 368.62m, 9281m, new DateTime(2020, 8, 29, 15, 18, 44, 989, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 800,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 38, 179.87m, 2047m, new DateTime(2020, 5, 21, 19, 54, 41, 244, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 801,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 38, 318.80m, 708m, new DateTime(2020, 8, 7, 2, 47, 45, 58, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 802,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 38, 112.54m, 2469m, new DateTime(2020, 12, 9, 2, 49, 42, 878, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 803,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 38, 55.19m, 8831m, new DateTime(2019, 4, 7, 13, 17, 24, 108, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 804,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 38, 186.17m, 8990m, new DateTime(2022, 2, 26, 10, 3, 52, 620, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 805,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 38, 369.37m, 5494m, new DateTime(2019, 1, 25, 21, 41, 58, 608, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 806,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 38, 369.10m, 8864m, new DateTime(2019, 9, 20, 19, 49, 0, 750, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 807,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 38, 2.76m, 6919m, new DateTime(2020, 8, 26, 19, 46, 49, 207, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 808,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 39, 341.04m, 8526m, new DateTime(2019, 2, 4, 17, 40, 5, 588, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 809,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 39, 358.02m, 8321m, new DateTime(2022, 11, 28, 2, 51, 11, 911, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 810,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 39, 124.89m, 3299m, new DateTime(2020, 12, 5, 13, 42, 45, 257, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 811,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 39, 206.70m, 4319m, new DateTime(2022, 10, 17, 0, 14, 47, 400, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 39, 272.48m, 7196m, new DateTime(2022, 11, 23, 5, 3, 5, 265, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 813,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 39, 41.62m, 452m, new DateTime(2022, 4, 13, 5, 24, 18, 654, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 814,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 39, 283.67m, 2573m, new DateTime(2019, 12, 27, 22, 42, 8, 934, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 815,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 39, 328.20m, 3939m, new DateTime(2020, 11, 18, 15, 53, 53, 314, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 816,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 39, 383.11m, 6383m, new DateTime(2022, 1, 25, 4, 30, 13, 22, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 817,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 39, 76.02m, 4571m, new DateTime(2021, 11, 3, 9, 6, 7, 6, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 818,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 39, 186.61m, 9570m, new DateTime(2020, 9, 11, 22, 39, 37, 979, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 819,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 39, 307.46m, 5197m, new DateTime(2020, 7, 10, 10, 13, 39, 909, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 820,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 39, 224.50m, 2964m, new DateTime(2021, 5, 6, 23, 49, 20, 733, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 821,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 39, 172.65m, 5934m, new DateTime(2021, 9, 5, 7, 16, 15, 375, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 822,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 39, 194.10m, 5829m, new DateTime(2019, 12, 23, 20, 1, 58, 116, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 823,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 39, 108.08m, 7583m, new DateTime(2022, 6, 27, 9, 38, 9, 261, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 824,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 39, 384.01m, 848m, new DateTime(2020, 12, 17, 14, 2, 22, 552, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 825,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 39, 280.54m, 4898m, new DateTime(2021, 2, 6, 3, 49, 32, 466, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 826,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 39, 357.73m, 6167m, new DateTime(2020, 11, 10, 1, 2, 5, 417, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 827,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 39, 264.63m, 8813m, new DateTime(2020, 9, 10, 7, 16, 27, 331, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 828,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 39, 292.99m, 2568m, new DateTime(2021, 1, 17, 21, 35, 4, 137, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 829,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 39, 364.44m, 8496m, new DateTime(2019, 8, 31, 10, 30, 20, 988, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 830,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 39, 113.29m, 332m, new DateTime(2022, 2, 26, 22, 51, 29, 521, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 831,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 39, 378.23m, 4268m, new DateTime(2019, 2, 7, 19, 59, 2, 539, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 832,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 39, 287.69m, 3482m, new DateTime(2020, 3, 22, 4, 13, 26, 414, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 833,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 40, 368.98m, 9906m, new DateTime(2021, 7, 18, 21, 9, 42, 508, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 834,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 40, 284.71m, 4487m, new DateTime(2019, 1, 3, 19, 44, 49, 790, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 835,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 40, 347.83m, 3701m, new DateTime(2022, 2, 13, 23, 32, 25, 12, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 836,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 40, 349.19m, 2924m, new DateTime(2021, 12, 19, 0, 43, 39, 570, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 837,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 40, 262.36m, 3028m, new DateTime(2022, 11, 1, 19, 11, 21, 213, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 838,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 40, 178.57m, 2144m, new DateTime(2021, 9, 7, 16, 30, 57, 904, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 839,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 40, 44.02m, 6047m, new DateTime(2018, 12, 28, 19, 18, 37, 391, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 840,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 40, 92.26m, 5333m, new DateTime(2022, 8, 26, 17, 39, 48, 578, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 841,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 40, 50.70m, 6799m, new DateTime(2022, 6, 25, 3, 5, 17, 878, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 842,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 40, 334.55m, 6483m, new DateTime(2019, 9, 26, 22, 23, 10, 368, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 843,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 40, 396.45m, 9429m, new DateTime(2022, 3, 5, 17, 53, 17, 517, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 844,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 40, 286.44m, 7889m, new DateTime(2021, 4, 29, 11, 50, 45, 164, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 845,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 40, 261.70m, 7913m, new DateTime(2022, 9, 7, 7, 30, 20, 491, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 846,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 40, 93.80m, 3787m, new DateTime(2022, 9, 20, 21, 56, 16, 918, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 847,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 40, 237.58m, 7217m, new DateTime(2020, 10, 16, 15, 19, 59, 669, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 848,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 40, 246.19m, 531m, new DateTime(2021, 8, 19, 17, 47, 45, 687, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 849,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 40, 317.97m, 7106m, new DateTime(2022, 6, 8, 7, 48, 45, 908, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 850,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 40, 86.61m, 6177m, new DateTime(2022, 5, 1, 19, 59, 17, 83, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 851,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 40, 385.98m, 2576m, new DateTime(2021, 2, 18, 19, 30, 36, 570, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 852,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 40, 316.66m, 7875m, new DateTime(2022, 2, 11, 0, 40, 39, 454, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 853,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 40, 238.26m, 9723m, new DateTime(2019, 6, 8, 4, 11, 11, 284, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 854,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 40, 40.13m, 1910m, new DateTime(2019, 6, 22, 22, 28, 38, 836, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 855,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 40, 285.57m, 9741m, new DateTime(2021, 3, 13, 20, 38, 7, 476, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 856,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 41, 63.32m, 788m, new DateTime(2021, 3, 12, 10, 36, 9, 874, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 857,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 41, 282.08m, 5293m, new DateTime(2021, 9, 30, 23, 26, 17, 749, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 858,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 41, 184.09m, 9752m, new DateTime(2022, 6, 1, 11, 33, 51, 114, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 859,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 42, 163.61m, 8152m, new DateTime(2020, 8, 18, 14, 10, 31, 327, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 860,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 42, 371.19m, 7625m, new DateTime(2019, 3, 27, 4, 47, 7, 518, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 861,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 42, 180.13m, 3696m, new DateTime(2020, 12, 14, 0, 24, 52, 680, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 862,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 2, 42, 244.23m, 9526m, new DateTime(2019, 9, 27, 1, 50, 50, 564, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 863,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 42, 360.37m, 1949m, new DateTime(2022, 6, 13, 11, 30, 7, 20, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 864,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 42, 73.04m, 246m, new DateTime(2021, 8, 15, 14, 21, 15, 75, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 865,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 42, 105.07m, 9098m, new DateTime(2022, 10, 7, 8, 8, 55, 10, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 866,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 42, 398.84m, 7481m, new DateTime(2022, 2, 9, 5, 30, 23, 637, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 867,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 42, 239.18m, 6157m, new DateTime(2020, 2, 9, 9, 47, 36, 706, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 868,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 42, 16.40m, 5956m, new DateTime(2021, 8, 7, 17, 7, 43, 640, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 869,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 42, 375.84m, 6711m, new DateTime(2022, 4, 28, 21, 26, 3, 831, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 870,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 43, 229.39m, 5020m, new DateTime(2022, 12, 15, 17, 12, 3, 808, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 871,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 43, 315.46m, 181m, new DateTime(2019, 3, 7, 1, 26, 46, 58, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 872,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 43, 228.88m, 9259m, new DateTime(2021, 3, 4, 5, 40, 49, 611, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 873,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 43, 11.52m, 8022m, new DateTime(2020, 7, 30, 18, 5, 11, 841, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 874,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 43, 304.23m, 1757m, new DateTime(2019, 8, 11, 18, 0, 46, 606, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 875,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 43, 79.83m, 6101m, new DateTime(2021, 9, 21, 2, 29, 47, 621, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 876,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 43, 216.46m, 7027m, new DateTime(2021, 9, 4, 0, 24, 57, 479, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 877,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 43, 268.44m, 9616m, new DateTime(2019, 3, 9, 4, 48, 23, 584, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 878,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 43, 19.95m, 1104m, new DateTime(2021, 1, 28, 20, 51, 16, 766, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 879,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 43, 107.73m, 9918m, new DateTime(2020, 3, 21, 21, 34, 27, 834, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 880,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 43, 107.19m, 5818m, new DateTime(2022, 2, 20, 8, 1, 59, 294, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 881,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 43, 298.14m, 6553m, new DateTime(2022, 11, 14, 23, 13, 47, 308, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 882,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 43, 129.32m, 4592m, new DateTime(2022, 12, 4, 19, 22, 12, 396, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 883,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 43, 158.22m, 3468m, new DateTime(2022, 4, 4, 10, 41, 33, 111, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 884,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 43, 308.22m, 2250m, new DateTime(2021, 10, 11, 5, 35, 2, 742, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 885,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 43, 244.61m, 6434m, new DateTime(2021, 2, 6, 15, 6, 22, 815, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 886,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 43, 64.28m, 5008m, new DateTime(2021, 12, 15, 6, 1, 59, 260, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 887,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 43, 324.54m, 6182m, new DateTime(2019, 12, 18, 19, 26, 18, 163, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 888,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 43, 63.69m, 323m, new DateTime(2019, 5, 17, 23, 15, 44, 781, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 889,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 43, 132.42m, 5158m, new DateTime(2021, 8, 12, 19, 21, 4, 314, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 890,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 43, 55.27m, 7512m, new DateTime(2019, 2, 26, 9, 41, 5, 463, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 891,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 43, 358.43m, 1780m, new DateTime(2020, 6, 1, 3, 38, 34, 128, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 892,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 43, 45.90m, 6524m, new DateTime(2020, 2, 23, 2, 50, 27, 376, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 893,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 43, 108.40m, 279m, new DateTime(2022, 2, 1, 14, 47, 53, 307, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 894,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 43, 173.26m, 7789m, new DateTime(2019, 2, 8, 20, 33, 54, 809, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 895,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 43, 16.33m, 2548m, new DateTime(2020, 12, 31, 23, 3, 50, 991, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 896,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 5, 43, 240.65m, 4775m, new DateTime(2020, 5, 27, 9, 59, 27, 104, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 897,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 43, 24.32m, 6618m, new DateTime(2022, 3, 30, 2, 58, 56, 392, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 898,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 43, 118.44m, 1060m, new DateTime(2019, 6, 4, 13, 35, 31, 255, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 899,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 44, 34.96m, 8512m, new DateTime(2022, 7, 5, 3, 23, 52, 36, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 900,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 44, 42.44m, 7920m, new DateTime(2022, 11, 16, 15, 37, 43, 529, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 901,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 44, 352.79m, 6312m, new DateTime(2021, 8, 13, 9, 17, 28, 436, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 902,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 44, 225.78m, 7708m, new DateTime(2020, 8, 15, 14, 3, 17, 311, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 903,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 44, 283.35m, 1878m, new DateTime(2019, 10, 11, 17, 37, 16, 498, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 904,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 44, 67.79m, 8524m, new DateTime(2020, 1, 9, 3, 25, 4, 929, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 905,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 44, 20.55m, 9513m, new DateTime(2020, 1, 8, 0, 51, 48, 141, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 906,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 44, 50.79m, 5875m, new DateTime(2021, 9, 5, 6, 6, 58, 705, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 907,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 44, 340.26m, 745m, new DateTime(2020, 10, 10, 11, 53, 6, 420, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 908,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 44, 187.98m, 9307m, new DateTime(2021, 8, 3, 5, 42, 5, 77, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 909,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 44, 121.97m, 8969m, new DateTime(2019, 3, 28, 6, 47, 27, 279, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 910,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 44, 238.44m, 4093m, new DateTime(2020, 2, 6, 7, 35, 53, 555, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 911,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 44, 36.27m, 7122m, new DateTime(2020, 12, 29, 8, 58, 35, 250, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 912,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 44, 306.49m, 189m, new DateTime(2020, 8, 17, 12, 52, 37, 355, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 913,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 44, 344.53m, 5208m, new DateTime(2020, 3, 30, 17, 2, 54, 788, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 914,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 44, 71.96m, 5182m, new DateTime(2020, 1, 5, 3, 10, 17, 506, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 915,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 44, 82.27m, 1663m, new DateTime(2020, 12, 18, 3, 8, 13, 478, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 916,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 44, 293.27m, 6400m, new DateTime(2019, 4, 21, 1, 24, 5, 694, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 917,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 44, 310.53m, 2577m, new DateTime(2020, 2, 17, 20, 43, 25, 823, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 918,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 44, 340.23m, 3294m, new DateTime(2020, 10, 13, 9, 27, 2, 799, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 919,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 44, 39.08m, 1675m, new DateTime(2021, 7, 20, 23, 19, 54, 281, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 920,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 45, 216.72m, 1457m, new DateTime(2022, 2, 22, 14, 31, 47, 635, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 921,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 45, 332.43m, 2520m, new DateTime(2020, 8, 20, 16, 4, 6, 416, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 922,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 22, 45, 169.05m, 7192m, new DateTime(2021, 5, 24, 20, 12, 51, 508, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 923,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 45, 224.85m, 3485m, new DateTime(2020, 10, 14, 16, 5, 23, 733, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 924,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 45, 343.58m, 9718m, new DateTime(2022, 9, 8, 0, 4, 8, 836, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 925,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 7, 45, 135.22m, 2142m, new DateTime(2022, 2, 5, 17, 6, 8, 557, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 926,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 45, 144.51m, 7208m, new DateTime(2019, 4, 13, 15, 40, 0, 115, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 927,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 45, 233.14m, 7209m, new DateTime(2020, 11, 14, 22, 55, 18, 604, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 928,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 45, 118.83m, 2687m, new DateTime(2020, 9, 20, 21, 52, 57, 375, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 929,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 45, 134.16m, 2309m, new DateTime(2020, 4, 27, 23, 39, 4, 693, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 930,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 45, 127.16m, 8024m, new DateTime(2019, 5, 15, 1, 32, 40, 450, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 931,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 45, 1.35m, 1330m, new DateTime(2021, 7, 22, 14, 38, 11, 848, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 932,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 45, 114.07m, 1444m, new DateTime(2021, 10, 26, 3, 59, 54, 280, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 933,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 45, 111.11m, 6415m, new DateTime(2022, 1, 10, 16, 29, 59, 415, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 934,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 45, 151.10m, 3142m, new DateTime(2019, 10, 9, 19, 29, 18, 525, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 935,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 45, 217.86m, 1732m, new DateTime(2019, 6, 8, 21, 10, 15, 170, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 936,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 9, 45, 62.80m, 132m, new DateTime(2022, 6, 9, 0, 8, 0, 773, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 937,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 45, 215.14m, 5448m, new DateTime(2022, 10, 15, 14, 19, 35, 267, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 938,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 45, 30.90m, 4720m, new DateTime(2020, 6, 3, 19, 35, 23, 864, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 939,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 45, 351.59m, 8045m, new DateTime(2019, 6, 1, 5, 11, 31, 591, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 940,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 46, 156.48m, 3827m, new DateTime(2021, 6, 17, 2, 56, 18, 462, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 941,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 46, 370.16m, 1893m, new DateTime(2021, 5, 25, 15, 30, 50, 248, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 942,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 46, 142.91m, 2278m, new DateTime(2021, 10, 18, 19, 55, 38, 327, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 943,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 46, 295.02m, 5119m, new DateTime(2021, 2, 8, 1, 30, 23, 275, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 944,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 46, 141.18m, 4052m, new DateTime(2020, 6, 1, 8, 46, 41, 336, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 945,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 46, 299.81m, 9348m, new DateTime(2020, 2, 11, 13, 54, 42, 593, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 946,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 17, 46, 308.27m, 5542m, new DateTime(2021, 3, 28, 4, 26, 57, 450, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 947,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 46, 399.25m, 1198m, new DateTime(2019, 7, 19, 0, 43, 30, 772, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 948,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 46, 202.88m, 1579m, new DateTime(2020, 8, 31, 12, 7, 31, 726, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 949,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 25, 46, 296.39m, 2495m, new DateTime(2022, 5, 11, 22, 3, 3, 515, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 950,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 46, 301.19m, 3071m, new DateTime(2022, 1, 21, 3, 18, 23, 275, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 951,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 46, 69.07m, 120m, new DateTime(2022, 4, 2, 3, 51, 6, 616, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 952,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 46, 100.99m, 1700m, new DateTime(2021, 8, 15, 19, 23, 17, 902, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 953,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 46, 1.72m, 8314m, new DateTime(2020, 11, 12, 4, 37, 28, 282, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 954,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 46, 1.17m, 7926m, new DateTime(2020, 6, 18, 16, 48, 19, 82, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 955,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 46, 52.07m, 3686m, new DateTime(2021, 5, 1, 4, 38, 26, 403, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 956,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 46, 108.68m, 9277m, new DateTime(2022, 2, 1, 11, 53, 44, 231, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 957,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 46, 42.12m, 9490m, new DateTime(2022, 12, 21, 2, 44, 57, 402, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 958,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 46, 296.13m, 5339m, new DateTime(2020, 5, 4, 1, 23, 24, 729, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 959,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 46, 167.79m, 4343m, new DateTime(2022, 4, 1, 1, 14, 0, 936, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 960,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 21, 46, 90.75m, 8123m, new DateTime(2021, 6, 16, 18, 3, 53, 140, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 961,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 23, 46, 360.61m, 5988m, new DateTime(2019, 7, 14, 15, 31, 8, 312, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 962,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 46, 65.14m, 706m, new DateTime(2022, 5, 21, 0, 43, 6, 971, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 963,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 27, 46, 165.04m, 8968m, new DateTime(2022, 1, 3, 18, 28, 55, 330, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 964,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 8, 46, 40.25m, 5734m, new DateTime(2022, 4, 15, 2, 33, 15, 742, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 965,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 46, 383.47m, 8542m, new DateTime(2020, 1, 17, 22, 13, 41, 392, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 966,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 46, 298.04m, 8545m, new DateTime(2022, 9, 28, 1, 8, 15, 265, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 967,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 6, 46, 105.89m, 5907m, new DateTime(2022, 8, 13, 3, 11, 37, 897, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 968,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 46, 186.69m, 5725m, new DateTime(2021, 6, 26, 8, 34, 31, 55, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 969,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 47, 251.21m, 3295m, new DateTime(2021, 3, 31, 2, 51, 49, 539, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 970,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 47, 375.96m, 1785m, new DateTime(2020, 11, 19, 6, 50, 37, 88, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 971,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 47, 305.45m, 1644m, new DateTime(2020, 1, 6, 18, 44, 17, 562, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 972,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 47, 245.43m, 2505m, new DateTime(2019, 6, 27, 5, 33, 37, 584, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 973,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 47, 211.01m, 7029m, new DateTime(2022, 4, 27, 2, 20, 36, 98, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 974,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 47, 3.91m, 6407m, new DateTime(2019, 8, 20, 3, 5, 9, 17, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 975,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 48, 319.56m, 5653m, new DateTime(2020, 5, 6, 6, 51, 36, 416, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 976,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 48, 172.73m, 6765m, new DateTime(2019, 1, 5, 7, 7, 38, 557, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 977,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 48, 99.29m, 7425m, new DateTime(2020, 1, 21, 1, 21, 17, 330, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 978,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 48, 273.33m, 2175m, new DateTime(2022, 1, 23, 0, 55, 0, 33, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 979,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 48, 279.15m, 3255m, new DateTime(2020, 7, 26, 11, 39, 28, 199, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 980,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 48, 138.13m, 2255m, new DateTime(2019, 6, 15, 19, 58, 53, 112, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 981,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 29, 48, 347.43m, 2164m, new DateTime(2019, 7, 2, 13, 5, 6, 203, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 982,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 48, 318.27m, 3088m, new DateTime(2019, 12, 24, 21, 2, 40, 195, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 983,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 48, 346.19m, 1313m, new DateTime(2019, 11, 13, 17, 36, 22, 902, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 984,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 48, 299.91m, 8276m, new DateTime(2022, 5, 30, 3, 6, 59, 19, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 985,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 16, 48, 57.76m, 3143m, new DateTime(2021, 8, 23, 16, 19, 54, 313, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 986,
                columns: new[] { "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 48, 374.30m, 8604m, new DateTime(2021, 7, 5, 13, 2, 52, 238, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 987,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 10, 48, 94.22m, 8347m, new DateTime(2019, 8, 7, 21, 13, 44, 494, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 988,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 48, 10.19m, 8701m, new DateTime(2021, 9, 25, 13, 22, 40, 443, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 989,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 48, 38.16m, 1566m, new DateTime(2022, 2, 8, 5, 49, 18, 12, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 990,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 48, 25.71m, 4964m, new DateTime(2019, 10, 3, 12, 27, 47, 208, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 991,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 4, 48, 278.07m, 9315m, new DateTime(2019, 3, 13, 9, 43, 35, 17, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 992,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 48, 351.09m, 825m, new DateTime(2021, 8, 6, 7, 32, 57, 847, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 993,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 18, 48, 259.86m, 2223m, new DateTime(2020, 9, 11, 10, 56, 12, 913, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 994,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 1, 48, 114.30m, 8422m, new DateTime(2022, 9, 3, 9, 34, 34, 273, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 995,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 48, 39.00m, 3841m, new DateTime(2021, 11, 18, 20, 57, 13, 106, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 996,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 48, 3.15m, 4820m, new DateTime(2022, 9, 13, 22, 20, 20, 50, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 997,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 30, 48, 157.40m, 4312m, new DateTime(2022, 7, 30, 5, 57, 39, 698, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 998,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 26, 48, 271.37m, 9673m, new DateTime(2020, 1, 17, 0, 7, 16, 678, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 999,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 48, 223.76m, 7169m, new DateTime(2021, 12, 28, 22, 34, 1, 927, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1000,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 24, 48, 59.16m, 8315m, new DateTime(2022, 4, 26, 3, 52, 47, 968, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1001,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 3, 48, 299.73m, 4632m, new DateTime(2019, 2, 25, 11, 44, 40, 428, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1002,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 12, 48, 146.29m, 4558m, new DateTime(2022, 2, 4, 3, 36, 6, 423, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1003,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 13, 48, 204.14m, 926m, new DateTime(2019, 7, 9, 2, 40, 25, 855, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1004,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 15, 48, 144.59m, 1548m, new DateTime(2021, 5, 22, 21, 44, 5, 916, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1005,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 28, 48, 3.50m, 7885m, new DateTime(2019, 4, 10, 15, 10, 17, 495, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1006,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 48, 18.15m, 8853m, new DateTime(2020, 4, 1, 7, 20, 47, 355, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1007,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 11, 48, 131.51m, 8094m, new DateTime(2020, 10, 29, 8, 8, 36, 460, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1008,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 14, 48, 338.15m, 8500m, new DateTime(2021, 11, 5, 4, 56, 44, 350, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1009,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 19, 48, 384.01m, 3314m, new DateTime(2022, 1, 17, 10, 6, 20, 214, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1010,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 48, 275.46m, 9106m, new DateTime(2020, 1, 23, 20, 38, 33, 872, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1011,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity", "trade_date" },
                values: new object[] { 20, 48, 52.49m, 252m, new DateTime(2022, 9, 23, 23, 24, 11, 165, DateTimeKind.Local).AddTicks(6882) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "trade_date",
                table: "position");

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 257.43m, 3496m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 29, 31.18m, 6899m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 310.33m, 9182m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 4, 15.11m, 6069m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 293.92m, 7841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 11, 258.01m, 9678m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 6, 177.55m, 6685m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 4, 374.40m, 8273m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 17, 394.70m, 1386m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 11, 254.58m, 5517m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 30, 134.57m, 2117m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 1, 7.02m, 4252m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 28, 245.92m, 2457m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 399.43m, 4448m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 23, 188.68m, 7511m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 14, 172.47m, 8418m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 2, 231.14m, 2399m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 7, 342.76m, 7836m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 1, 283.02m, 5222m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 36.47m, 5612m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 13, 56.75m, 3765m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 280.54m, 4051m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 287.90m, 3688m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 14, 13.09m, 7320m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 28, 178.11m, 2336m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 186.72m, 861m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 3, 223.23m, 2968m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 10, 24.44m, 3217m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 4, 221.75m, 3874m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 199.55m, 2110m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 25, 23.75m, 2187m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 251.72m, 562m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 2, 29.42m, 3258m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 23, 27.84m, 6900m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "price", "quantity" },
                values: new object[] { 339.12m, 4563m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 13, 222.67m, 3728m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 8, 176.76m, 3156m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 16, 107.57m, 6516m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 3, 23.06m, 3025m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 8.15m, 1174m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 7, 64.61m, 449m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 30, 207.88m, 4915m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 25, 72.51m, 6429m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 303.41m, 7628m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 15, 241.50m, 3348m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 7, 345.75m, 3668m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 2, 6.87m, 3173m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 2, 357.83m, 7082m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 2, 225.52m, 631m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 2, 300.70m, 2919m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 28, 22.27m, 2183m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 16, 363.22m, 6550m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 2, 132.23m, 9648m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 4, 239.25m, 3825m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 4, 338.98m, 6857m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 4, 17.85m, 6676m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 4, 347.98m, 1993m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 4, 60.71m, 131m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 4, 66.56m, 2724m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 4, 74.16m, 9562m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 4, 97.73m, 4337m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 137.04m, 5519m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 4, 233.16m, 9516m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 4, 353.08m, 9006m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 4, 248.90m, 2946m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 4, 150.44m, 3525m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 4, 51.10m, 2503m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 4, 153.35m, 8179m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 4, 21.00m, 4182m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 4, 257.44m, 3283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 149.88m, 5363m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 4, 379.36m, 3789m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 4, 54.92m, 8556m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 4, 285.54m, 8964m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 30, 117.36m, 987m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 16, 286.55m, 5298m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 367.70m, 2297m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 2, 285.48m, 2339m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 26, 245.16m, 1208m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 54.88m, 5025m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 29, 252.23m, 6738m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 16, 147.80m, 4997m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 21, 365.99m, 4248m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 5, 96.52m, 4969m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 5, 165.55m, 3538m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 5, 36.99m, 7292m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 5, 134.44m, 8884m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 5, 289.73m, 1085m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 5, 264.39m, 3124m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 5, 135.20m, 2681m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 5, 1.04m, 3630m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 5, 34.31m, 2326m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 15, 369.56m, 5990m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 26, 320.55m, 1150m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 17, 171.45m, 4738m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 20, 146.90m, 5304m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 354.29m, 3364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 5, 99.83m, 2952m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 5, 212.50m, 4503m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 5, 25.91m, 9343m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 5, 261.96m, 6265m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 5, 54.96m, 2667m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 5, 49.84m, 4903m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 5, 53.48m, 2683m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 5, 312.71m, 7341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 5, 252.78m, 3766m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 5, 312.11m, 205m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 5, 372.46m, 1593m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 5, 28.36m, 7264m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 5, 312.25m, 2663m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 5, 264.84m, 3126m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 5, 193.84m, 6324m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 5, 84.48m, 5234m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 5, 17.20m, 3179m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 6, 301.80m, 780m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 6, 187.11m, 5610m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 6, 359.71m, 837m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 6, 113.80m, 9238m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 6, 289.48m, 4771m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 6, 27.60m, 5402m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 6, 137.58m, 2340m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 6, 188.63m, 9557m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 6, 119.87m, 1116m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 6, 169.30m, 8531m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 6, 295.91m, 7026m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 6, 345.04m, 8360m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 6, 205.27m, 1286m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 7, 262.07m, 7085m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 7, 231.85m, 7408m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 7, 170.10m, 212m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 7, 90.89m, 6769m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 7, 360.46m, 8161m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 7, 114.18m, 1222m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 7, 68.24m, 4593m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 7, 191.41m, 2305m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 7, 217.87m, 2311m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 7, 344.43m, 6411m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 7, 222.32m, 4216m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 7, 255.05m, 3963m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 7, 293.07m, 5729m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 7, 115.32m, 383m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 7, 299.51m, 2266m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 7, 370.00m, 8767m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 7, 299.79m, 3005m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 7, 24.17m, 8228m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 7, 193.63m, 8018m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 7, 206.41m, 4773m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 7, 150.19m, 5749m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 7, 103.89m, 4496m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 7, 170.21m, 6269m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 7, 218.37m, 4254m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 7, 170.69m, 5764m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 7, 2.59m, 825m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 7, 139.83m, 1440m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 7, 138.24m, 3596m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 238.29m, 7776m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 7, 236.55m, 927m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 7, 39.51m, 9446m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 7, 183.73m, 6946m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 7, 310.10m, 4058m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 101.68m, 1175m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 8, 82.42m, 8750m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 8, 253.47m, 2564m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 8, 192.04m, 7293m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 8, 67.58m, 3433m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 8, 12.96m, 2252m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 8, 265.60m, 6719m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 8, 333.65m, 5442m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 8, 179.85m, 4808m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 8, 386.95m, 8817m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 8, 92.47m, 6767m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 8, 39.15m, 364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 8, 188.57m, 4724m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 8, 138.98m, 9146m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 8, 345.63m, 8496m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 8, 304.14m, 5010m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 8, 96.98m, 2825m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 8, 43.31m, 9491m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 8, 285.37m, 9352m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 8, 159.90m, 7780m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 8, 147.94m, 5319m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 8, 22.20m, 2733m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 8, 124.68m, 2171m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 8, 300.36m, 3053m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 8, 302.20m, 5479m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 8, 276.89m, 3170m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 8, 391.83m, 4408m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 8, 242.53m, 2912m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 8, 290.20m, 959m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 8, 37.76m, 4175m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 8, 276.84m, 4564m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 8, 155.22m, 1605m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 8, 233.25m, 2063m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 8, 115.42m, 4312m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 8, 390.80m, 9792m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 8, 162.70m, 3295m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 8, 250.16m, 5146m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 9, 168.06m, 3472m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 9, 305.41m, 2506m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 9, 131.99m, 1874m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 9, 87.92m, 7996m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 9, 24.52m, 8488m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 9, 147.98m, 3974m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 44.64m, 1206m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 9, 277.40m, 195m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 9, 251.72m, 3120m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 9, 128.50m, 7663m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 9, 187.59m, 9028m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 9, 140.93m, 7564m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 9, 58.22m, 938m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 9, 161.74m, 2670m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 9, 196.17m, 3062m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 9, 52.73m, 2977m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 6.56m, 8364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 9, 205.57m, 1782m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 9, 133.07m, 5422m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 9, 375.25m, 8303m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 9, 166.68m, 7052m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 9, 358.40m, 3607m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 9, 38.24m, 3334m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 9, 123.34m, 8364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 9, 340.99m, 1339m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 9, 284.44m, 6802m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 6.76m, 167m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 9, 371.73m, 8071m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 10, 382.01m, 7345m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 10, 8.86m, 2241m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 10, 82.96m, 2635m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 10, 395.04m, 5618m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 10, 237.76m, 9454m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 10, 15.48m, 9642m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 10, 283.22m, 100m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 10, 264.56m, 542m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 10, 248.62m, 8619m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 10, 369.49m, 8235m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 10, 194.94m, 8980m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 10, 66.39m, 5693m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 10, 350.93m, 8782m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 10, 21.14m, 9084m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 10, 118.59m, 547m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 10, 306.42m, 2114m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 10, 21.17m, 5298m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 10, 371.72m, 913m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 10, 275.16m, 411m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 10, 142.93m, 2519m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 10, 174.30m, 4108m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 10, 264.48m, 4497m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 10, 152.59m, 7727m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 10, 35.67m, 6895m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 10, 37.89m, 441m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 10, 399.81m, 7408m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 10, 263.16m, 4915m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 10, 119.38m, 9130m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 10, 326.14m, 1816m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 10, 213.85m, 1137m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 10, 253.40m, 5059m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 10, 201.58m, 2965m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 11, 254.11m, 6049m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 11, 154.82m, 4387m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 11, 385.50m, 8402m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 11, 334.83m, 571m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 11, 275.34m, 3003m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 11, 279.76m, 7604m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 11, 55.92m, 4977m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 11, 338.33m, 2781m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 11, 338.73m, 6689m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 11, 182.26m, 1936m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 11, 236.30m, 7475m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 11, 160.03m, 105m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 11, 90.37m, 2763m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 11, 183.75m, 7341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 11, 307.14m, 8714m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 11, 96.84m, 1717m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 11, 349.96m, 5766m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 11, 4.99m, 7480m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 11, 132.71m, 3355m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 11, 307.22m, 2800m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 11, 261.60m, 2356m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 121.73m, 6685m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 11, 117.78m, 9017m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 11, 196.09m, 2050m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 11, 304.73m, 835m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 11, 160.88m, 5045m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 11, 201.38m, 2320m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 11, 245.62m, 1719m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 11, 399.79m, 8171m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 11, 269.02m, 5665m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 12, 183.14m, 9962m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 12, 322.14m, 5084m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 12, 186.41m, 2128m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 12, 379.05m, 2700m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 12, 154.86m, 3816m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 12, 100.25m, 6744m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 12, 371.82m, 8309m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 12, 106.83m, 580m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 12, 16.99m, 736m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 12, 121.94m, 8514m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 12, 248.75m, 3451m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 12, 197.61m, 2619m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 12, 103.83m, 1523m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 301,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 12, 79.13m, 1085m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 302,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 12, 96.60m, 7535m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 303,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 12, 95.85m, 6668m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 304,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 12, 131.98m, 4726m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 305,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 12, 337.13m, 7656m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 306,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 12, 379.13m, 2394m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 307,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 12, 176.24m, 9977m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 308,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 12, 142.62m, 4755m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 309,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 12, 369.70m, 8080m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 310,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 12, 49.24m, 2867m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 311,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 12, 211.44m, 3364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 312,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 12, 292.14m, 9249m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 313,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 12, 119.68m, 1063m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 314,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 12, 160.93m, 2813m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 315,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 12, 153.66m, 7382m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 316,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 12, 230.51m, 3428m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 317,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 12, 10.04m, 906m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 318,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 12, 59.27m, 8286m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 319,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 12, 252.10m, 1188m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 320,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 378.03m, 4573m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 321,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 12, 154.18m, 3388m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 322,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 12, 55.88m, 3081m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 323,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 12, 335.81m, 3465m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 324,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 12, 54.67m, 4114m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 325,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 12, 289.73m, 1739m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 326,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 13, 388.96m, 7372m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 327,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 13, 140.19m, 4751m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 328,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 13, 40.20m, 2061m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 329,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 153.17m, 5078m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 330,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 13, 41.04m, 8160m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 331,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 141.64m, 6489m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 332,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 13, 7.75m, 9425m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 333,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 13, 98.78m, 4400m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 334,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 13, 294.69m, 9963m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 335,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 13, 355.36m, 6792m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 336,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 13, 169.53m, 6647m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 337,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 13, 357.97m, 1559m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 338,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 13, 190.57m, 2724m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 339,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 13, 75.15m, 7862m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 340,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 13, 254.23m, 9538m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 341,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 13, 10.94m, 1757m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 342,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 13, 196.15m, 5176m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 343,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 13, 312.90m, 4608m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 344,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 13, 120.79m, 2841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 345,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 13, 189.94m, 226m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 346,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 13, 209.31m, 8834m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 347,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 13, 336.76m, 4584m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 348,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 13, 267.04m, 3984m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 349,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 13, 152.73m, 339m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 350,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 13, 63.98m, 7460m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 351,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 13, 192.92m, 6702m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 352,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 13, 331.71m, 7569m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 353,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 13, 66.12m, 6568m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 354,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 13, 83.16m, 6010m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 355,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 13, 348.33m, 7610m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 356,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 13, 101.67m, 1498m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 357,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 13, 360.80m, 3603m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 358,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 13, 200.65m, 8104m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 359,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 13, 310.22m, 4658m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 360,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 13, 195.93m, 8086m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 361,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 13, 285.05m, 4262m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 362,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 13, 244.38m, 1985m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 363,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 13, 104.07m, 1257m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 364,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 13, 92.34m, 9025m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 365,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 14, 254.60m, 8574m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 366,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 14, 318.69m, 6374m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 367,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 14, 52.06m, 8841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 368,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 14, 103.17m, 3957m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 369,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 14, 392.26m, 8598m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 370,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 14, 22.49m, 3010m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 371,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 14, 270.18m, 8481m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 372,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 14, 198.10m, 1847m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 373,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 14, 104.96m, 5725m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 374,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 14, 397.59m, 341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 375,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 14, 269.45m, 4577m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 376,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 14, 258.09m, 9974m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 377,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 14, 57.34m, 1507m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 378,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 14, 242.61m, 2035m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 379,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 14, 129.58m, 5491m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 380,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 14, 300.85m, 328m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 381,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 14, 385.77m, 3066m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 382,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 14, 153.53m, 5530m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 383,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 14, 272.10m, 5256m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 384,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 27.16m, 3085m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 385,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 14, 343.59m, 8376m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 386,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 14, 374.99m, 5237m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 387,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 14, 344.54m, 8638m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 388,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 14, 61.58m, 6631m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 389,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 14, 260.80m, 7932m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 390,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 14, 253.13m, 3162m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 391,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 14, 218.51m, 6524m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 392,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 14, 290.15m, 9372m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 393,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 14, 361.60m, 7683m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 394,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 14, 191.15m, 6244m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 395,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 14, 336.37m, 257m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 396,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 14, 144.45m, 359m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 397,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 14, 11.26m, 8484m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 398,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 15, 356.31m, 1689m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 399,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 15, 325.19m, 6435m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 400,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 15, 292.71m, 7597m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 401,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 15, 19.97m, 2194m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 402,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 15, 208.64m, 6561m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 403,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 15, 54.44m, 9003m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 404,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 15, 14.39m, 7553m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 405,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 15, 154.38m, 2494m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 406,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 15, 125.20m, 6473m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 407,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 15, 117.35m, 7673m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 408,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 15, 242.87m, 4678m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 409,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 15, 154.43m, 8657m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 410,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 15, 34.82m, 4399m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 411,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 15, 59.43m, 969m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 412,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 15, 106.76m, 154m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 413,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 15, 75.98m, 555m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 414,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 15, 184.61m, 9995m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 415,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 15, 109.86m, 7451m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 416,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 15, 367.58m, 4969m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 417,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 15, 398.46m, 1396m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 418,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 15, 396.95m, 8427m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 419,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 15, 299.88m, 3000m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 420,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 15, 315.50m, 1912m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 421,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 15, 186.57m, 4140m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 422,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 15, 266.33m, 8883m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 423,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 15, 95.27m, 7359m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 424,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 15, 239.49m, 4594m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 425,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 15, 306.40m, 2889m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 426,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 15, 288.23m, 7121m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 427,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 149.63m, 4410m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 428,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 15, 122.00m, 1213m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 429,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 15, 99.43m, 7187m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 430,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 16, 206.86m, 7154m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 431,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 16, 160.46m, 8643m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 432,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 16, 398.03m, 5954m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 433,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 16, 243.51m, 8567m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 434,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 16, 273.31m, 7610m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 435,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 17, 151.77m, 4044m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 436,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 17, 243.61m, 2346m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 437,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 17, 44.08m, 389m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 438,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 17, 268.37m, 4215m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 439,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 17, 384.26m, 1701m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 440,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 17, 293.48m, 4241m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 441,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 17, 241.75m, 5284m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 442,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 17, 289.75m, 7374m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 443,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 17, 334.70m, 1823m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 444,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 17, 290.49m, 8659m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 445,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 17, 313.52m, 6177m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 446,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 17, 276.38m, 6300m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 447,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 17, 370.92m, 6904m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 448,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 17, 195.21m, 1375m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 449,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 17, 393.58m, 1241m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 450,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 17, 333.47m, 3027m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 451,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 17, 76.61m, 6870m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 452,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 17, 64.37m, 1537m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 453,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 17, 265.78m, 7019m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 454,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 17, 22.10m, 6999m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 455,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 17, 66.68m, 4439m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 456,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 320.91m, 7787m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 457,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 17, 214.67m, 5743m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 458,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 17, 292.65m, 8350m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 459,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 17, 158.53m, 1104m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 460,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 17, 248.18m, 6138m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 461,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 17, 351.47m, 1221m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 462,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 17, 73.10m, 5467m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 463,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 18, 250.15m, 4740m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 464,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 18, 11.61m, 9280m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 465,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 18, 349.81m, 9905m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 466,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 18, 129.53m, 6936m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 467,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 18, 73.68m, 3453m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 468,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 18, 119.80m, 7283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 469,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 18, 183.96m, 8519m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 470,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 18, 305.83m, 533m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 471,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 18, 18.60m, 980m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 472,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 18, 70.63m, 5878m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 473,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 19, 338.70m, 9840m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 474,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 19, 105.70m, 3397m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 475,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 19, 98.27m, 6120m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 476,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 19, 372.73m, 7431m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 477,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 19, 317.99m, 7072m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 478,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 19, 223.48m, 2879m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 479,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 19, 282.42m, 1612m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 480,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 19, 31.92m, 3369m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 481,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 19, 344.31m, 4306m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 482,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 19, 393.00m, 8399m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 483,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 19, 280.19m, 4127m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 484,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 19, 135.96m, 7963m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 485,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 19, 339.76m, 8041m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 486,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 19, 276.13m, 1069m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 487,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 19, 287.49m, 7038m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 488,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 19, 24.82m, 6855m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 489,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 19, 305.57m, 4699m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 490,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 19, 9.68m, 3394m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 491,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 19, 261.81m, 6900m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 492,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 19, 363.35m, 2297m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 493,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 19, 308.14m, 3584m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 494,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 19, 134.16m, 3863m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 495,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 19, 364.08m, 3959m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 496,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 19, 191.96m, 4902m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 497,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 19, 22.85m, 6543m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 498,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 19, 252.10m, 1290m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 499,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 19, 297.27m, 3277m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 500,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 19, 150.13m, 4094m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 501,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 30.52m, 4184m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 502,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 19, 43.85m, 9091m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 503,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 19, 232.48m, 3766m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 504,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 19, 298.64m, 2060m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 505,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 19, 128.96m, 8294m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 506,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 19, 117.74m, 7640m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 507,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 19, 391.79m, 4218m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 508,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 19, 273.07m, 6517m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 509,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 20, 10.71m, 5710m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 510,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 20, 67.08m, 9020m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 511,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 21, 17.84m, 4020m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 512,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 21, 222.02m, 2671m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 513,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 21, 308.89m, 8045m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 514,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 21, 307.28m, 8994m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 515,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 21, 39.30m, 3157m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 516,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 21, 390.08m, 3155m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 517,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 21, 260.77m, 4554m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 518,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 21, 373.79m, 4003m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 519,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 21, 284.68m, 3981m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 520,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 21, 264.42m, 5453m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 521,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 21, 310.33m, 6823m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 522,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 21, 209.97m, 7994m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 523,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 21, 50.69m, 3595m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 524,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 21, 139.48m, 8129m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 525,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 21, 155.14m, 8659m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 526,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 21, 263.61m, 2367m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 527,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 21, 286.57m, 2814m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 528,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 21, 286.55m, 3483m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 529,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 21, 1.68m, 9614m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 530,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 21, 347.19m, 2112m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 531,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 21, 105.49m, 6245m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 532,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 21, 88.49m, 1623m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 533,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 21, 205.02m, 8574m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 534,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 21, 382.24m, 5118m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 535,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 21, 255.90m, 3580m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 536,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 212.34m, 3497m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 537,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 21, 66.06m, 8848m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 538,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 21, 107.32m, 9101m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 539,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 21, 135.63m, 5313m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 540,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 21, 334.72m, 6502m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 541,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 21, 60.79m, 6809m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 542,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 21, 76.93m, 3711m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 543,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 21, 284.57m, 5375m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 544,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 21, 149.81m, 8893m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 545,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 21, 307.16m, 3854m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 546,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 21, 396.08m, 5878m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 547,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 21, 247.51m, 6496m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 548,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 21, 128.49m, 5642m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 549,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 22, 398.16m, 7143m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 550,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 22, 352.85m, 6310m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 551,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 22, 270.29m, 2172m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 552,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 22, 322.45m, 8309m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 553,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 22, 179.98m, 9868m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 554,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 22, 327.76m, 8122m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 555,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 22, 316.23m, 9955m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 556,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 22, 200.15m, 5347m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 557,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 22, 139.54m, 9434m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 558,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 22, 88.22m, 105m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 22, 332.29m, 1266m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 22, 192.03m, 5788m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 22, 34.27m, 3722m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 22, 66.27m, 9559m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 22, 375.29m, 3357m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 22, 2.37m, 9900m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 22, 323.18m, 4330m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 22, 130.30m, 1871m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 22, 73.42m, 8853m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 22, 274.09m, 9828m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 22, 84.33m, 9504m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 22, 284.84m, 101m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 22, 165.44m, 510m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 572,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 22, 178.32m, 1377m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 573,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 22, 16.95m, 1048m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 574,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 22, 81.18m, 4397m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 575,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 22, 381.22m, 2374m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 576,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 22, 229.68m, 3610m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 577,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 22, 375.63m, 4030m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 578,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 22, 276.47m, 6413m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 579,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 22, 153.93m, 5975m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 580,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 22, 3.22m, 7530m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 581,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 23, 91.45m, 3355m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 582,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 24, 263.71m, 5953m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 583,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 24, 367.05m, 3694m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 584,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 24, 115.93m, 2912m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 585,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 24, 374.14m, 9807m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 586,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 24, 77.16m, 7341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 587,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 24, 19.04m, 6393m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 588,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 24, 188.16m, 7747m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 589,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 24, 269.32m, 7245m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 590,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 24, 135.33m, 705m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 591,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 24, 269.02m, 440m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 592,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 24, 134.40m, 8733m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 593,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 24, 301.23m, 144m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 594,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 24, 20.17m, 2820m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 595,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 24, 89.65m, 8572m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 596,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 24, 127.38m, 2478m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 597,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 24, 267.30m, 6340m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 598,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 24, 128.30m, 4161m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 599,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 24, 182.24m, 7283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 600,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 24, 347.95m, 5492m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 601,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 24, 121.47m, 7652m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 602,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 24, 100.61m, 7405m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 603,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 24, 44.26m, 413m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 604,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 24, 291.07m, 5073m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 605,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 24, 145.00m, 9001m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 606,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 24, 366.74m, 1324m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 607,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 24, 193.10m, 635m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 608,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 24, 172.85m, 8784m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 609,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 24, 250.05m, 7876m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 610,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 24, 59.44m, 4536m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 611,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 24, 184.46m, 7430m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 612,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 205.24m, 7131m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 613,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 24, 48.04m, 8997m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 614,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 24, 84.22m, 7360m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 615,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 24, 52.10m, 668m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 616,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 24, 204.90m, 1300m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 617,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 24, 241.19m, 9734m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 618,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 24, 196.72m, 2705m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 619,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 24, 354.39m, 6338m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 620,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 25, 250.54m, 9528m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 621,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 25, 384.81m, 5877m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 622,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 25, 107.62m, 7642m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 623,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 25, 339.75m, 1970m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 624,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 25, 319.70m, 2326m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 625,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 25, 109.88m, 3275m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 626,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 25, 121.76m, 8215m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 627,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 25, 46.15m, 6676m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 628,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 25, 218.24m, 4801m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 629,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 25, 387.72m, 4824m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 630,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 25, 250.83m, 892m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 631,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 25, 67.04m, 9873m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 632,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 25, 250.35m, 4750m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 633,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 25, 147.11m, 3432m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 634,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 25, 129.50m, 5700m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 635,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 151.46m, 7249m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 636,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 25, 68.73m, 9889m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 637,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 25, 27.32m, 4879m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 638,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 25, 115.95m, 1908m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 639,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 44.39m, 8703m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 640,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 25, 114.56m, 3844m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 641,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 25, 44.47m, 701m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 642,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 25, 95.82m, 3823m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 643,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 25, 340.56m, 9280m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 644,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 25, 193.75m, 9020m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 645,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 25, 40.30m, 650m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 646,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 301.30m, 2925m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 647,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 25, 195.89m, 6076m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 648,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 25, 239.29m, 3857m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 649,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 25, 322.00m, 3132m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 650,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 25, 240.66m, 8364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 651,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 25, 383.40m, 8306m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 652,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 25, 202.50m, 3814m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 653,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 25, 139.08m, 8873m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 654,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 25, 25.54m, 1144m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 655,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 25, 233.12m, 4726m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 656,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 25, 51.70m, 6357m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 657,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 26, 143.08m, 5877m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 658,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 26, 318.65m, 7767m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 659,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 26, 205.17m, 6843m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 660,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 26, 173.81m, 790m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 661,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 26, 100.90m, 1015m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 662,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 26, 210.34m, 813m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 663,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 26, 237.80m, 6835m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 664,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 26, 163.23m, 4051m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 665,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 26, 171.35m, 5032m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 666,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 26, 7.17m, 9131m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 667,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 26, 271.30m, 6775m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 668,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 26, 7.81m, 1225m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 669,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 26, 74.38m, 5830m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 670,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 26, 329.70m, 8779m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 671,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 26, 111.24m, 2313m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 672,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 26, 387.64m, 3561m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 673,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 26, 204.35m, 3422m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 674,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 26, 179.22m, 7794m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 675,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 26, 74.59m, 1517m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 676,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 26, 111.25m, 2299m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 677,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 26, 307.80m, 275m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 678,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 26, 158.81m, 6885m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 679,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 26, 391.54m, 773m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 680,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 26, 197.81m, 9718m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 681,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 26, 321.65m, 5737m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 682,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 26, 71.06m, 8778m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 683,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 26, 60.25m, 3283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 684,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 26, 231.09m, 4183m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 685,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 26, 358.91m, 9199m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 686,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 27, 333.21m, 9707m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 687,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 27, 363.12m, 3630m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 688,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 27, 22.91m, 8604m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 689,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 27, 352.42m, 5428m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 690,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 28, 334.15m, 9903m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 691,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 28, 287.26m, 262m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 692,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 28, 330.75m, 6466m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 693,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 28, 327.85m, 187m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 694,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 28, 364.59m, 1365m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 695,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 28, 396.18m, 2003m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 696,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 28, 210.42m, 5034m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 697,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 28, 160.87m, 183m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 698,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 28, 173.83m, 1452m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 699,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 28, 286.18m, 9451m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 700,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 28, 100.56m, 6409m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 701,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 28, 187.60m, 8682m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 702,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 29, 81.46m, 4944m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 703,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 29, 106.82m, 5918m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 704,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 29, 157.18m, 8255m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 705,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 29, 2.98m, 7819m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 706,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 29, 86.66m, 8640m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 707,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 29, 170.89m, 3884m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 708,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 29, 174.28m, 9820m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 709,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 114.42m, 8809m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 710,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 29, 45.57m, 7014m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 711,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 30, 212.39m, 5739m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 712,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 30, 12.06m, 4491m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 713,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 30, 226.27m, 5060m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 714,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 30, 284.75m, 9377m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 715,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 30, 148.44m, 5811m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 716,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 30, 259.65m, 6568m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 717,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 30, 183.23m, 8535m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 718,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 30, 378.06m, 8685m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 719,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 30, 58.13m, 4910m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 720,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 30, 367.02m, 6134m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 721,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 30, 62.25m, 8903m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 722,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 30, 328.87m, 4577m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 723,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 30, 224.98m, 5236m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 724,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 30, 285.73m, 8842m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 725,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 30, 195.97m, 5774m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 726,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 31, 94.16m, 8587m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 727,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 31, 362.59m, 6345m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 31, 56.24m, 2670m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 729,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 31, 234.32m, 7054m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 730,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 31, 353.92m, 9581m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 731,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 31, 259.24m, 8925m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 732,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 31, 223.50m, 573m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 733,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 31, 219.56m, 1334m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 734,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 31, 35.68m, 1431m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 735,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 31, 297.50m, 9693m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 736,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 31, 183.09m, 3011m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 737,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 31, 115.04m, 8105m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 738,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 31, 115.31m, 4163m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 739,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 31, 357.66m, 8827m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 740,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 31, 48.61m, 9466m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 741,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 31, 241.84m, 8214m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 742,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 31, 329.02m, 5179m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 743,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 31, 176.87m, 8997m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 744,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 31, 293.35m, 4864m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 745,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 31, 199.03m, 4502m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 746,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 31, 116.93m, 5477m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 747,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 31, 163.93m, 8496m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 748,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 31, 60.50m, 7342m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 749,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 31, 192.94m, 9938m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 750,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 31, 67.37m, 4513m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 751,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 31, 72.23m, 2335m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 752,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 31, 126.64m, 4189m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 753,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 31, 182.90m, 1317m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 754,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 32, 7.21m, 4013m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 755,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 32, 221.68m, 3340m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 756,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 32, 316.27m, 9660m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 757,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 32, 241.73m, 3449m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 758,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 33, 85.98m, 7138m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 759,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 33, 297.42m, 4599m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 760,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 33, 80.56m, 3476m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 761,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 33, 149.69m, 2817m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 762,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 34, 13.63m, 2646m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 763,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 34, 168.68m, 3427m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 764,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 34, 300.35m, 4795m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 765,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 34, 320.32m, 1217m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 766,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 34, 122.01m, 551m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 767,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 34, 15.64m, 5748m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 768,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 34, 260.73m, 697m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 769,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 34, 80.82m, 7203m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 770,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 34, 152.62m, 384m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 771,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 34, 359.47m, 5841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 772,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 34, 223.87m, 7436m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 773,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 34, 173.86m, 9989m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 774,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 34, 30.17m, 6126m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 775,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 34, 41.09m, 7709m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 776,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 34, 40.96m, 7009m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 777,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 34, 279.22m, 6363m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 778,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 34, 251.90m, 8274m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 779,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 34, 125.59m, 4520m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 780,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 34, 216.34m, 4789m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 781,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 34, 123.60m, 9550m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 782,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 34, 357.85m, 8991m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 783,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 34, 149.32m, 798m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 784,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 34, 19.63m, 7525m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 785,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 35, 385.46m, 9622m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 786,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 35, 220.63m, 2988m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 787,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 35, 40.86m, 293m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 788,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 35, 273.40m, 4021m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 789,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 35, 108.57m, 7567m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 790,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 35, 99.29m, 3016m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 791,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 35, 357.50m, 5299m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 792,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 35, 306.56m, 6575m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 793,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 35, 83.23m, 8718m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 794,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 35, 291.63m, 6310m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 795,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 35, 260.58m, 8837m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 796,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 35, 267.12m, 2519m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 797,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 35, 9.19m, 5412m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 798,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 35, 208.53m, 7434m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 799,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 35, 364.54m, 254m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 800,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 35, 56.90m, 1858m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 801,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 35, 31.76m, 5489m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 802,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 35, 209.07m, 2900m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 803,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 35, 123.81m, 4841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 804,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 35, 169.03m, 417m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 805,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 35, 157.51m, 2445m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 806,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 35, 205.90m, 8941m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 807,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 35, 204.45m, 3807m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 808,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 35, 303.46m, 828m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 809,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 36, 149.97m, 7864m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 810,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 36, 342.00m, 6421m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 811,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 36, 27.33m, 6960m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 36, 260.87m, 920m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 813,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 36, 52.52m, 6036m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 814,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 36, 144.31m, 7678m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 815,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 36, 240.15m, 5094m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 816,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 36, 52.03m, 5089m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 817,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 36, 159.65m, 1312m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 818,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 36, 252.44m, 8050m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 819,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 36, 128.29m, 4761m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 820,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 36, 295.13m, 8711m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 821,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 36, 268.04m, 1170m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 822,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 36, 291.54m, 5165m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 823,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 36, 124.42m, 3299m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 824,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 36, 365.61m, 8439m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 825,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 36, 298.03m, 150m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 826,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 37, 250.94m, 2610m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 827,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 37, 98.95m, 2874m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 828,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 37, 183.36m, 5208m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 829,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 37, 174.88m, 8909m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 830,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 37, 133.58m, 6159m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 831,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 37, 157.38m, 7325m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 832,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 37, 276.26m, 6607m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 833,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 37, 348.60m, 9928m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 834,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 37, 327.60m, 1890m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 835,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 37, 194.02m, 2872m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 836,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 37, 354.40m, 8000m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 837,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 37, 27.13m, 6556m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 838,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 37, 183.30m, 1747m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 839,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 37, 62.17m, 1067m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 840,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 37, 335.50m, 3236m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 841,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 37, 279.19m, 3952m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 842,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 37, 74.39m, 5657m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 843,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 37, 35.78m, 2464m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 844,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 37, 105.03m, 9077m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 845,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 37, 40.69m, 2792m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 846,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 37, 95.12m, 3766m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 847,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 37, 37.61m, 7747m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 848,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 37, 384.01m, 2059m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 849,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 37, 225.81m, 1465m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 850,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 37, 224.27m, 4144m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 851,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 37, 270.73m, 355m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 852,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 37, 316.88m, 5928m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 853,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 37, 287.76m, 2597m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 854,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 37, 224.14m, 9122m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 855,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 37, 298.36m, 1907m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 856,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 37, 357.87m, 3940m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 857,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 37, 291.20m, 9314m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 858,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 37, 218.16m, 9136m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 859,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 38, 295.17m, 1992m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 860,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 38, 248.57m, 4292m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 861,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 38, 211.50m, 8319m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 862,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 38, 234.30m, 8822m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 863,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 38, 123.79m, 6864m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 864,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 38, 207.35m, 1269m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 865,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 38, 213.47m, 8625m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 866,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 38, 86.64m, 252m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 867,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 38, 267.93m, 7524m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 868,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 38, 333.06m, 4829m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 869,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 38, 53.57m, 1218m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 870,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 38, 240.62m, 3032m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 871,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 39, 272.05m, 3022m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 872,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 39, 109.11m, 7316m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 873,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 39, 88.78m, 8655m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 874,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 39, 20.82m, 2190m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 875,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 39, 160.69m, 6131m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 876,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 39, 86.42m, 6862m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 877,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 40, 263.91m, 5274m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 878,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 40, 399.35m, 9519m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 879,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 40, 159.71m, 6983m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 880,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 40, 175.02m, 4584m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 881,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 40, 368.69m, 7101m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 882,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 40, 397.64m, 2297m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 883,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 40, 192.73m, 8054m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 884,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 40, 97.58m, 3569m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 885,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 41, 341.17m, 5326m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 886,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 41, 349.59m, 2267m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 887,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 41, 302.34m, 814m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 888,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 41, 189.45m, 8627m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 889,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 41, 135.43m, 7305m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 890,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 41, 307.35m, 5798m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 891,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 41, 92.52m, 7693m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 892,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 41, 281.74m, 3490m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 893,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 41, 98.83m, 1864m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 894,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 41, 25.12m, 4164m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 895,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 41, 167.33m, 1804m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 896,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 41, 188.71m, 4986m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 897,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 41, 72.35m, 4776m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 898,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 41, 146.23m, 142m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 899,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 41, 25.00m, 2895m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 900,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 41, 107.23m, 6042m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 901,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 41, 362.06m, 4327m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 902,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 41, 190.53m, 2618m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 903,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 41, 75.00m, 6373m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 904,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 42, 251.76m, 502m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 905,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 42, 278.22m, 6649m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 906,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 42, 23.12m, 6923m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 907,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 42, 346.72m, 2419m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 908,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 42, 236.00m, 1122m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 909,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 42, 346.29m, 7651m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 910,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 42, 257.74m, 694m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 911,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 42, 391.60m, 5822m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 912,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 42, 63.05m, 9836m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 913,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 42, 376.79m, 9186m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 914,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 42, 114.71m, 8613m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 915,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 42, 56.12m, 8729m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 916,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 42, 281.24m, 7157m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 917,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 42, 149.01m, 1917m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 918,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 42, 13.77m, 5720m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 919,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 42, 320.85m, 5549m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 920,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 42, 285.18m, 621m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 921,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 42, 51.02m, 4467m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 922,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 42, 185.59m, 4979m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 923,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 42, 271.56m, 3298m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 924,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 42, 308.77m, 8562m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 925,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 42, 150.33m, 3054m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 926,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 42, 93.41m, 5303m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 927,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 42, 20.90m, 9364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 928,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 42, 350.74m, 2629m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 929,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 43, 378.83m, 202m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 930,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 43, 142.19m, 4387m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 931,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 43, 92.61m, 8665m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 932,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 43, 64.69m, 4246m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 933,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 43, 270.52m, 3850m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 934,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 43, 10.69m, 3959m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 935,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 43, 240.23m, 3354m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 936,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 43, 263.43m, 2765m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 937,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 43, 228.43m, 345m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 938,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 43, 265.29m, 1256m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 939,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 43, 100.28m, 1937m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 940,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 43, 181.47m, 8457m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 941,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 43, 98.77m, 6803m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 942,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 43, 362.55m, 1127m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 943,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 43, 382.22m, 5584m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 944,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 43, 341.25m, 6833m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 945,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 43, 264.35m, 3262m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 946,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 43, 219.59m, 8593m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 947,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 43, 296.70m, 3101m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 948,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 43, 163.87m, 9059m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 949,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 43, 299.59m, 7118m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 950,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 43, 94.03m, 9187m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 951,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 43, 214.34m, 6163m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 952,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 43, 285.35m, 9146m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 953,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 43, 90.73m, 2201m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 954,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 43, 286.37m, 4669m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 955,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 44, 287.17m, 3512m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 956,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 44, 1.93m, 7994m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 957,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 44, 280.68m, 3344m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 958,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 44, 284.76m, 5455m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 959,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 44, 334.90m, 7744m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 960,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 44, 63.96m, 4009m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 961,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 44, 289.18m, 6397m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 962,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 44, 127.91m, 769m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 963,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 44, 378.99m, 4115m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 964,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 44, 129.86m, 6492m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 965,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 44, 11.32m, 8431m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 966,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 44, 26.34m, 5900m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 967,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 44, 380.42m, 4477m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 968,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 45, 84.72m, 9063m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 969,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 45, 205.27m, 9937m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 970,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 45, 377.00m, 9410m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 971,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 45, 214.71m, 8316m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 972,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 45, 392.01m, 883m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 973,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 45, 160.25m, 2842m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 974,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 45, 22.93m, 3978m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 975,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 45, 151.82m, 6852m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 976,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 45, 274.44m, 7023m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 977,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 45, 309.56m, 1944m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 978,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 46, 301.00m, 2147m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 979,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 46, 121.19m, 8186m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 980,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 46, 17.05m, 3311m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 981,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 46, 167.44m, 168m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 982,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 46, 178.10m, 4980m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 983,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 46, 243.16m, 9472m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 984,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 46, 267.32m, 7885m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 985,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 46, 204.45m, 5635m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 986,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 46, 332.90m, 2311m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 987,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 46, 330.82m, 3013m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 988,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 46, 68.44m, 7566m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 989,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 46, 132.19m, 8784m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 990,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 46, 66.09m, 6763m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 991,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 46, 30.83m, 2692m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 992,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 46, 20.18m, 4917m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 993,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 46, 354.11m, 8485m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 994,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 46, 295.69m, 125m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 995,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 46, 394.76m, 4143m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 996,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 46, 259.41m, 2329m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 997,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 46, 237.80m, 5093m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 998,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 46, 12.99m, 5478m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 999,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 46, 101.82m, 2387m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1000,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 46, 246.67m, 3656m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1001,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 46, 110.20m, 3108m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1002,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 46, 210.30m, 2783m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1003,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 46, 29.93m, 626m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1004,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 46, 151.14m, 9905m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1005,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 46, 117.41m, 3419m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1006,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 46, 138.97m, 4600m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1007,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 46, 261.18m, 8102m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1008,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 46, 68.29m, 1594m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1009,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 46, 287.73m, 470m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1010,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 46, 102.97m, 4661m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1011,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 46, 195.63m, 6664m });

            migrationBuilder.InsertData(
                table: "position",
                columns: new[] { "id", "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[,]
                {
                    { 1012, 14, 46, 279.75m, 313m },
                    { 1013, 14, 46, 55.79m, 7779m },
                    { 1014, 18, 46, 69.60m, 839m },
                    { 1015, 7, 46, 206.04m, 7823m },
                    { 1016, 23, 46, 83.97m, 5273m },
                    { 1017, 2, 47, 362.84m, 7787m },
                    { 1018, 14, 47, 385.49m, 5554m },
                    { 1019, 27, 47, 42.91m, 1614m },
                    { 1020, 17, 47, 322.57m, 2413m },
                    { 1021, 20, 47, 326.95m, 5965m },
                    { 1022, 21, 47, 355.50m, 3341m },
                    { 1023, 21, 48, 249.63m, 5971m },
                    { 1024, 23, 48, 288.20m, 2163m },
                    { 1025, 12, 48, 43.29m, 4853m },
                    { 1026, 16, 48, 141.63m, 6581m },
                    { 1027, 11, 48, 123.26m, 5155m },
                    { 1028, 18, 48, 355.51m, 4843m },
                    { 1029, 18, 48, 122.94m, 9374m },
                    { 1030, 28, 48, 144.58m, 5501m },
                    { 1031, 16, 48, 262.88m, 9046m },
                    { 1032, 4, 48, 303.51m, 5836m },
                    { 1033, 26, 48, 132.15m, 1946m },
                    { 1034, 16, 48, 58.93m, 8952m },
                    { 1035, 11, 48, 279.66m, 1065m }
                });
        }
    }
}
