using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyThinkBook.Web.Migrations.InvestmentDb
{
    /// <inheritdoc />
    public partial class _202212211947 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "instrument",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "isin",
                table: "instrument",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "code", "isin" },
                values: new object[] { "d3mb", "qv9bp0x6o" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "code", "isin" },
                values: new object[] { "bo8y", "ecvw3j7t4" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "code", "isin" },
                values: new object[] { "2tv2", "r16nap0zd" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "code", "isin" },
                values: new object[] { "y1b5", "muddst4wm" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "code", "isin" },
                values: new object[] { "wz13", "76yljk3q8" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "code", "isin" },
                values: new object[] { "cfqj", "emb19200w" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "code", "isin" },
                values: new object[] { "u1ri", "v31424b4h" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "code", "isin" },
                values: new object[] { "ikkp", "8sbdydcoe" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "code", "isin" },
                values: new object[] { "zp3u", "zb4atiu0p" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "code", "isin" },
                values: new object[] { "7oje", "vqywsaaqt" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "code", "isin" },
                values: new object[] { "0z70", "2euglgkc4" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "code", "isin" },
                values: new object[] { "mqiq", "jxijtm93i" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "code", "isin" },
                values: new object[] { "f58e", "aay63grfg" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "code", "isin" },
                values: new object[] { "c79e", "8jhqqyprq" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "code", "isin" },
                values: new object[] { "9eyw", "29ajs4yv6" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "code", "isin" },
                values: new object[] { "pmsv", "jgl3hdbfe" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "code", "isin" },
                values: new object[] { "h4wn", "rtyjxqwod" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "code", "isin" },
                values: new object[] { "96nv", "09i193rtf" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "code", "isin" },
                values: new object[] { "5wmc", "uyzojoqwd" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "code", "isin" },
                values: new object[] { "1wcf", "n176yg6tc" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "code", "isin" },
                values: new object[] { "yppx", "i02cjsv2w" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "code", "isin" },
                values: new object[] { "ql9a", "f6qn4mexg" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "code", "isin" },
                values: new object[] { "qu1l", "ph1iw3b45" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "code", "isin" },
                values: new object[] { "03ow", "4r9q2ig00" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "code", "isin" },
                values: new object[] { "e0d2", "9xh2ag392" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "code", "isin" },
                values: new object[] { "nopn", "ldtafwmih" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "code", "isin" },
                values: new object[] { "em3f", "2s9ohyuzt" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "code", "isin" },
                values: new object[] { "37qk", "dyc1c9d0x" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "code", "isin" },
                values: new object[] { "azdw", "61ds9tcne" });

            migrationBuilder.UpdateData(
                table: "instrument",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "code", "isin" },
                values: new object[] { "o6ga", "2j2sy760j" });

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
                columns: new[] { "price", "quantity" },
                values: new object[] { 31.18m, 6899m });

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
                columns: new[] { "price", "quantity" },
                values: new object[] { 134.57m, 2117m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 2, 342.76m, 7836m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 2, 283.02m, 5222m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 2, 36.47m, 5612m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 2, 56.75m, 3765m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 2, 280.54m, 4051m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 2, 287.90m, 3688m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 2, 13.09m, 7320m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 2, 178.11m, 2336m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 2, 186.72m, 861m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 2, 223.23m, 2968m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 24.44m, 3217m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 2, 221.75m, 3874m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 2, 251.72m, 562m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 2, 29.42m, 3258m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 2, 27.84m, 6900m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 2, 339.12m, 4563m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 2, 222.67m, 3728m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 2, 176.76m, 3156m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 2, 107.57m, 6516m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 2, 23.06m, 3025m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 2, 8.15m, 1174m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 2, 64.61m, 449m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 2, 207.88m, 4915m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 2, 72.51m, 6429m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 2, 303.41m, 7628m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 2, 241.50m, 3348m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 2, 345.75m, 3668m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 4, 137.04m, 5519m });

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
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 11, 257.44m, 3283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 26, 149.88m, 5363m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 11, 379.36m, 3789m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 16, 54.92m, 8556m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 14, 285.54m, 8964m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 5, 369.56m, 5990m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 5, 320.55m, 1150m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 5, 171.45m, 4738m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 5, 146.90m, 5304m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 5, 354.29m, 3364m });

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
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 23, 28.36m, 7264m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 17, 312.25m, 2663m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 26, 264.84m, 3126m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 193.84m, 6324m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 84.48m, 5234m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 8, 17.20m, 3179m });

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
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 137.58m, 2340m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 10, 188.63m, 9557m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 119.87m, 1116m });

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
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 262.07m, 7085m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 3, 231.85m, 7408m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 19, 170.10m, 212m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 25, 90.89m, 6769m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 17, 360.46m, 8161m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 114.18m, 1222m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 2, 68.24m, 4593m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 28, 191.41m, 2305m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 16, 217.87m, 2311m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 6, 344.43m, 6411m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 7, 222.32m, 4216m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 7, 238.29m, 7776m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 39.51m, 9446m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 7, 101.68m, 1175m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 305.41m, 2506m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 9, 44.64m, 1206m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 9, 6.56m, 8364m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 9, 6.76m, 167m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 395.04m, 5618m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 15.48m, 9642m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 263.16m, 4915m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 55.92m, 4977m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 307.22m, 2800m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 11, 121.73m, 6685m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 186.41m, 2128m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 369.70m, 8080m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 12, 378.03m, 4573m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 13, 153.17m, 5078m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 13, 141.64m, 6489m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 75.15m, 7862m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 22.49m, 3010m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 14, 27.16m, 3085m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 186.57m, 4140m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 15, 149.63m, 4410m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 44.08m, 389m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 17, 320.91m, 7787m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 250.15m, 4740m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 252.10m, 1290m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 19, 30.52m, 4184m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 347.19m, 2112m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 21, 212.34m, 3497m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 334.72m, 6502m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 149.81m, 8893m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 2.37m, 9900m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 153.93m, 5975m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 19.04m, 6393m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 24, 205.24m, 7131m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 25, 151.46m, 7249m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 25, 44.39m, 8703m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 25, 301.30m, 2925m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 205.17m, 6843m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 81.46m, 4944m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 29, 114.42m, 8809m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 31, 362.59m, 6345m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 31, 56.24m, 2670m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 31, 35.68m, 1431m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 34, 41.09m, 7709m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 35, 31.76m, 5489m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 35, 169.03m, 417m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 35, 303.46m, 828m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 36, 27.33m, 6960m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 36, 260.87m, 920m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 37, 27.13m, 6556m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 37, 35.78m, 2464m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 37, 287.76m, 2597m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 40, 397.64m, 2297m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 41, 92.52m, 7693m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 42, 346.72m, 2419m });

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
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 42, 63.05m, 9836m });

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
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 42, 320.85m, 5549m });

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

            migrationBuilder.InsertData(
                table: "position",
                columns: new[] { "id", "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[,]
                {
                    { 940, 22, 43, 181.47m, 8457m },
                    { 941, 6, 43, 98.77m, 6803m },
                    { 942, 27, 43, 362.55m, 1127m },
                    { 943, 13, 43, 382.22m, 5584m },
                    { 944, 24, 43, 341.25m, 6833m },
                    { 945, 5, 43, 264.35m, 3262m },
                    { 946, 21, 43, 219.59m, 8593m },
                    { 947, 9, 43, 296.70m, 3101m },
                    { 948, 24, 43, 163.87m, 9059m },
                    { 949, 18, 43, 299.59m, 7118m },
                    { 950, 28, 43, 94.03m, 9187m },
                    { 951, 7, 43, 214.34m, 6163m },
                    { 952, 24, 43, 285.35m, 9146m },
                    { 953, 21, 43, 90.73m, 2201m },
                    { 954, 22, 43, 286.37m, 4669m },
                    { 955, 9, 44, 287.17m, 3512m },
                    { 956, 21, 44, 1.93m, 7994m },
                    { 957, 17, 44, 280.68m, 3344m },
                    { 958, 13, 44, 284.76m, 5455m },
                    { 959, 13, 44, 334.90m, 7744m },
                    { 960, 10, 44, 63.96m, 4009m },
                    { 961, 16, 44, 289.18m, 6397m },
                    { 962, 17, 44, 127.91m, 769m },
                    { 963, 11, 44, 378.99m, 4115m },
                    { 964, 30, 44, 129.86m, 6492m },
                    { 965, 18, 44, 11.32m, 8431m },
                    { 966, 2, 44, 26.34m, 5900m },
                    { 967, 17, 44, 380.42m, 4477m },
                    { 968, 2, 45, 84.72m, 9063m },
                    { 969, 16, 45, 205.27m, 9937m },
                    { 970, 25, 45, 377.00m, 9410m },
                    { 971, 5, 45, 214.71m, 8316m },
                    { 972, 25, 45, 392.01m, 883m },
                    { 973, 22, 45, 160.25m, 2842m },
                    { 974, 10, 45, 22.93m, 3978m },
                    { 975, 18, 45, 151.82m, 6852m },
                    { 976, 25, 45, 274.44m, 7023m },
                    { 977, 11, 45, 309.56m, 1944m },
                    { 978, 13, 46, 301.00m, 2147m },
                    { 979, 1, 46, 121.19m, 8186m },
                    { 980, 28, 46, 17.05m, 3311m },
                    { 981, 26, 46, 167.44m, 168m },
                    { 982, 21, 46, 178.10m, 4980m },
                    { 983, 24, 46, 243.16m, 9472m },
                    { 984, 22, 46, 267.32m, 7885m },
                    { 985, 28, 46, 204.45m, 5635m },
                    { 986, 15, 46, 332.90m, 2311m },
                    { 987, 21, 46, 330.82m, 3013m },
                    { 988, 15, 46, 68.44m, 7566m },
                    { 989, 12, 46, 132.19m, 8784m },
                    { 990, 16, 46, 66.09m, 6763m },
                    { 991, 21, 46, 30.83m, 2692m },
                    { 992, 28, 46, 20.18m, 4917m },
                    { 993, 5, 46, 354.11m, 8485m },
                    { 994, 7, 46, 295.69m, 125m },
                    { 995, 21, 46, 394.76m, 4143m },
                    { 996, 8, 46, 259.41m, 2329m },
                    { 997, 15, 46, 237.80m, 5093m },
                    { 998, 7, 46, 12.99m, 5478m },
                    { 999, 8, 46, 101.82m, 2387m },
                    { 1000, 4, 46, 246.67m, 3656m },
                    { 1001, 14, 46, 110.20m, 3108m },
                    { 1002, 18, 46, 210.30m, 2783m },
                    { 1003, 14, 46, 29.93m, 626m },
                    { 1004, 29, 46, 151.14m, 9905m },
                    { 1005, 3, 46, 117.41m, 3419m },
                    { 1006, 6, 46, 138.97m, 4600m },
                    { 1007, 21, 46, 261.18m, 8102m },
                    { 1008, 18, 46, 68.29m, 1594m },
                    { 1009, 2, 46, 287.73m, 470m },
                    { 1010, 24, 46, 102.97m, 4661m },
                    { 1011, 9, 46, 195.63m, 6664m },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "position",
                keyColumn: "id",
                keyValue: 1011);

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

            migrationBuilder.DropColumn(
                name: "code",
                table: "instrument");

            migrationBuilder.DropColumn(
                name: "isin",
                table: "instrument");

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 10, 108.95m, 8684m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "price", "quantity" },
                values: new object[] { 3.55m, 7041m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 274.25m, 1788m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 10, 254.94m, 1160m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 27, 134.17m, 4205m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 17, 34.58m, 8995m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 4, 328.74m, 2180m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 7, 277.43m, 3270m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 1, 304.24m, 9543m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 256.32m, 1850m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "price", "quantity" },
                values: new object[] { 8.26m, 7079m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 25, 29.66m, 3696m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 19, 28.97m, 8882m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 152.42m, 8585m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 4, 325.98m, 7819m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 29, 250.08m, 9077m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 130.20m, 590m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 1, 72.64m, 2151m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 1, 219.20m, 5965m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 1, 299.17m, 1011m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 1, 397.48m, 9087m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 1, 161.43m, 1010m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 1, 21.49m, 3371m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 1, 5.56m, 695m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 1, 141.85m, 9138m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 1, 216.64m, 7481m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 1, 19.76m, 1143m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 51.78m, 724m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 1, 199.61m, 1394m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 8, 210.45m, 7730m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 129.80m, 7970m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 3, 137.02m, 3919m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 3, 204.06m, 4182m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 3, 282.18m, 5771m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 3, 55.91m, 3192m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 3, 203.13m, 8282m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 3, 280.06m, 163m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 3, 45.14m, 7032m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 3, 291.79m, 8677m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 3, 312.05m, 9052m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 3, 295.05m, 2877m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 3, 276.80m, 2242m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 3, 23.39m, 4097m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 3, 186.89m, 8541m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 3, 225.57m, 4759m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 3, 2.49m, 1464m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 3, 5.84m, 2115m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 3, 207.90m, 9246m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 3, 249.38m, 8103m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 3, 208.21m, 1133m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 22, 203.73m, 7293m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 30, 117.64m, 2976m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 14, 39.29m, 1863m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 3, 169.66m, 7602m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 3, 62.32m, 4478m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 3, 92.62m, 3962m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 3, 291.72m, 4916m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 3, 280.60m, 9683m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 3, 143.32m, 7502m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 3, 163.79m, 2693m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 3, 120.47m, 2776m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 3, 51.32m, 7946m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 3, 72.85m, 8684m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 3, 383.92m, 3966m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 3, 178.83m, 5513m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 3, 193.16m, 966m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 3, 167.89m, 3227m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 3, 247.52m, 7210m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 3, 303.67m, 8881m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 23, 374.30m, 5473m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 12, 275.49m, 9170m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 28, 50.19m, 4926m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 12.00m, 6531m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 20.76m, 5277m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 25, 307.79m, 1049m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 6, 102.77m, 4269m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 26, 350.15m, 6636m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 21, 395.90m, 9465m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 23, 272.94m, 5565m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 147.64m, 9065m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 11, 255.27m, 9062m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 7, 18.38m, 6448m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 14, 383.30m, 1774m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 4, 332.95m, 1820m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 4, 358.22m, 497m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 4, 209.25m, 4465m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 4, 135.62m, 789m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 4, 353.14m, 7859m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 4, 388.06m, 8967m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 4, 374.22m, 7048m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 4, 297.86m, 1759m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 4, 247.45m, 1339m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 4, 182.40m, 9429m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 4, 101.57m, 6015m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 4, 195.06m, 7148m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 4, 362.43m, 5211m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 4, 45.34m, 3391m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 4, 334.53m, 7270m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 4, 49.46m, 6022m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 4, 298.46m, 2816m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 4, 187.46m, 5263m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 4, 3.46m, 341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 4, 366.06m, 6804m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 4, 199.93m, 9318m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 4, 189.39m, 3034m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 4, 29.69m, 2628m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 4, 152.41m, 272m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 4, 148.37m, 6077m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 19, 363.32m, 4489m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 20, 198.99m, 5317m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 20, 283.93m, 6713m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 314.10m, 851m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 29, 192.60m, 6906m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 25, 396.36m, 8406m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 5, 245.40m, 4073m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 5, 146.14m, 4335m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 5, 20.78m, 3494m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 5, 147.05m, 2643m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 5, 40.08m, 9186m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 5, 225.55m, 7449m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 9, 312.78m, 3940m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 20, 143.91m, 8322m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 392.50m, 3076m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 7, 25.84m, 9168m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 7, 315.01m, 826m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 7, 76.71m, 2196m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 7, 274.37m, 5488m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 13, 120.32m, 4521m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 5, 257.43m, 3496m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 29, 31.18m, 6899m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 310.33m, 9182m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 4, 15.11m, 6069m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 24, 293.92m, 7841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 11, 258.01m, 9678m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 6, 177.55m, 6685m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 4, 374.40m, 8273m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 17, 394.70m, 1386m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "instrument_id", "price", "quantity" },
                values: new object[] { 11, 254.58m, 5517m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 8, 389.82m, 3414m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 8, 1.74m, 249m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 8, 362.33m, 6177m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 8, 115.50m, 9986m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 8, 300.89m, 4756m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 8, 182.77m, 4354m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 8, 17.36m, 5810m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 8, 342.76m, 7836m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 8, 283.02m, 5222m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 9, 157.62m, 980m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 9, 172.42m, 1483m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 9, 62.16m, 7036m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 9, 312.78m, 7218m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 9, 182.94m, 400m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 9, 363.16m, 4494m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 9, 152.29m, 4708m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 9, 39.71m, 5614m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 9, 129.12m, 681m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 9, 48.06m, 5577m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 118.70m, 5026m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 9, 326.86m, 664m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 9, 59.75m, 6320m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 9, 21.35m, 805m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 9, 294.86m, 765m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 9, 5.27m, 8489m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 9, 165.65m, 5600m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 9, 97.30m, 4461m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 9, 213.23m, 2744m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 9, 33.31m, 647m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 9, 59.79m, 277m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 9, 89.35m, 1678m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 9, 389.33m, 5233m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 10, 304.40m, 8173m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 10, 131.94m, 4003m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 10, 144.83m, 4948m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 10, 124.86m, 2192m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 10, 282.40m, 9977m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 10, 22.41m, 665m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 10, 114.63m, 7920m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 10, 27.45m, 5773m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 11, 260.98m, 9046m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 11, 385.80m, 5199m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 11, 291.16m, 470m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 12, 273.34m, 5528m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 12, 266.06m, 3267m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 12, 77.31m, 9356m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 12, 2.27m, 8001m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 12, 106.78m, 3367m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 12, 382.35m, 4384m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 12, 171.79m, 3609m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 12, 219.42m, 6972m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 12, 380.51m, 4302m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 12, 359.93m, 8469m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 12, 115.71m, 2802m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 12, 139.06m, 1170m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 12, 97.87m, 2145m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 12, 326.62m, 2501m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 12, 165.54m, 2046m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 12, 129.28m, 7564m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 12, 213.13m, 3572m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 149.71m, 8554m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 12, 341.80m, 3611m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 12, 358.27m, 5110m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 12, 36.76m, 4657m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 12, 210.50m, 9873m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 12, 89.55m, 5330m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 12, 91.25m, 7918m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 13, 245.16m, 1208m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 13, 54.88m, 5025m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 13, 252.23m, 6738m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 14, 204.20m, 3742m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 14, 269.53m, 9156m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 14, 96.52m, 4969m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 14, 165.55m, 3538m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 14, 36.99m, 7292m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 14, 134.44m, 8884m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 14, 289.73m, 1085m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 14, 264.39m, 3124m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 14, 135.20m, 2681m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 14, 1.04m, 3630m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 14, 34.31m, 2326m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 14, 369.56m, 5990m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 14, 320.55m, 1150m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 14, 171.45m, 4738m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 14, 146.90m, 5304m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 14, 354.29m, 3364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 14, 99.83m, 2952m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 14, 212.50m, 4503m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 14, 25.91m, 9343m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 14, 261.96m, 6265m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 96.48m, 1438m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 15, 132.24m, 1311m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 67.42m, 1402m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 15, 213.88m, 7834m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 15, 119.28m, 6347m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 15, 118.49m, 7819m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 15, 180.91m, 9317m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 15, 301.20m, 778m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 15, 221.80m, 7822m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 15, 344.65m, 6646m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 15, 59.59m, 4884m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 16, 125.10m, 2990m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 16, 127.26m, 2508m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 16, 241.96m, 7563m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 16, 169.71m, 4717m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 16, 367.69m, 9000m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 16, 222.31m, 2898m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 16, 354.41m, 7258m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 16, 195.27m, 760m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 16, 310.43m, 3488m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 17, 41.98m, 3121m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 17, 340.82m, 3928m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 17, 280.14m, 144m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 333.93m, 607m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 17, 48.80m, 7000m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 17, 334.57m, 2930m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 17, 155.28m, 6577m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 17, 30.56m, 5828m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 17, 253.51m, 4295m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 17, 329.82m, 2330m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 17, 216.81m, 9019m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 17, 120.20m, 2908m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 17, 15.43m, 1768m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 17, 365.90m, 4824m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 17, 201.88m, 5481m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 76.32m, 8621m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 17, 81.19m, 5591m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 17, 49.36m, 6403m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 17, 290.90m, 7346m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 18, 88.31m, 9632m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 18, 350.31m, 7814m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 18, 118.11m, 1587m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 18, 328.59m, 4191m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 18, 320.14m, 1262m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 18, 189.37m, 1853m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 18, 228.67m, 446m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 18, 178.19m, 5674m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 18, 249.63m, 6738m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 168.45m, 2715m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 18, 229.29m, 5561m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 18, 30.24m, 8831m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 19, 139.83m, 1440m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 19, 138.24m, 3596m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 19, 238.29m, 7776m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 19, 236.55m, 927m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 19, 39.51m, 9446m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 19, 183.73m, 6946m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 19, 310.10m, 4058m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 19, 101.68m, 1175m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 19, 349.65m, 8872m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 19, 100.31m, 8630m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 290.91m, 2430m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 19, 135.36m, 4535m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 19, 87.75m, 4221m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 19, 267.79m, 4566m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 19, 216.30m, 1822m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 19, 190.76m, 1191m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 19, 352.35m, 3411m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 19, 269.71m, 9697m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 19, 11.68m, 2463m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 19, 187.38m, 1268m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 19, 365.58m, 9087m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 301,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 19, 339.39m, 8651m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 302,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 19, 198.92m, 6783m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 303,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 19, 110.83m, 598m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 304,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 19, 379.49m, 8838m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 305,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 19, 373.91m, 8288m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 306,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 19, 310.53m, 6703m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 307,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 19, 211.36m, 7582m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 308,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 19, 107.14m, 6688m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 309,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 84.50m, 2570m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 310,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 20, 300.36m, 3053m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 311,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 20, 302.20m, 5479m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 312,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 20, 276.89m, 3170m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 313,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 21, 275.70m, 9797m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 314,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 21, 290.97m, 6092m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 315,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 21, 50.16m, 7275m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 316,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 21, 153.76m, 1012m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 317,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 21, 29.68m, 6944m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 318,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 21, 391.02m, 3926m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 319,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 21, 324.42m, 5862m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 320,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 21, 180.46m, 2939m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 321,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 21, 196.61m, 9771m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 322,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 21, 141.10m, 4112m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 323,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 21, 9.48m, 6282m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 324,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 21, 168.06m, 3472m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 325,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 21, 305.41m, 2506m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 326,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 21, 131.99m, 1874m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 327,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 21, 87.92m, 7996m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 328,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 21, 24.52m, 8488m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 329,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 21, 147.98m, 3974m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 330,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 21, 44.64m, 1206m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 331,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 22, 96.25m, 6958m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 332,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 23, 305.82m, 2441m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 333,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 23, 360.83m, 7743m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 334,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 23, 301.82m, 3680m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 335,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 23, 34.80m, 6566m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 336,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 23, 104.59m, 2224m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 337,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 23, 120.38m, 4874m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 338,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 23, 116.97m, 2395m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 339,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 334.08m, 4369m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 340,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 23, 68.82m, 9829m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 341,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 23, 215.52m, 9127m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 342,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 23, 331.60m, 7286m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 343,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 23, 281.18m, 1432m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 344,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 23, 142.36m, 186m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 345,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 23, 131.38m, 7527m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 346,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 23, 334.07m, 7111m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 347,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 23, 50.96m, 2327m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 348,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 23, 271.14m, 7094m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 349,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 23, 3.71m, 2115m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 350,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 23, 322.26m, 5037m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 351,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 23, 315.92m, 3125m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 352,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 23, 180.45m, 9553m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 353,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 23, 370.95m, 294m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 354,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 23, 32.93m, 2133m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 355,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 23, 189.94m, 9877m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 356,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 23, 193.20m, 5974m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 357,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 23, 289.49m, 459m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 358,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 24, 18.85m, 7602m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 359,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 24, 344.36m, 2132m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 360,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 24, 328.89m, 5271m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 361,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 24, 358.91m, 6394m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 362,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 24, 226.42m, 7060m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 363,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 24, 350.92m, 7973m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 364,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 24, 363.11m, 6916m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 365,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 24, 19.03m, 293m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 366,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 24, 82.20m, 7217m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 367,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 24, 210.51m, 6141m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 368,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 24, 33.77m, 4678m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 369,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 24, 13.57m, 6023m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 370,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 98.52m, 3014m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 371,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 24, 162.54m, 4050m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 372,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 24, 178.24m, 2890m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 373,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 24, 308.39m, 5065m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 374,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 24, 274.88m, 4352m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 375,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 24, 14.77m, 1676m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 376,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 24, 295.55m, 6602m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 377,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 24, 195.08m, 3721m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 378,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 24, 364.94m, 8565m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 379,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 24, 70.17m, 8742m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 380,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 24, 42.83m, 5613m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 381,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 24, 200.86m, 4819m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 382,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 24, 116.50m, 5260m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 383,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 24, 295.33m, 6199m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 384,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 24, 87.74m, 6380m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 385,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 24, 73.10m, 3916m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 386,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 24, 121.97m, 9640m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 387,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 25, 118.01m, 9420m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 388,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 25, 303.43m, 9292m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 389,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 25, 197.59m, 5484m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 390,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 25, 109.07m, 4147m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 391,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 25, 266.57m, 9451m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 392,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 25, 75.01m, 9532m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 393,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 25, 298.26m, 6415m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 394,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 25, 1.23m, 502m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 395,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 25, 108.34m, 7341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 396,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 25, 292.84m, 4749m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 397,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 25, 348.18m, 9102m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 398,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 25, 66.19m, 7230m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 399,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 25, 229.39m, 7912m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 400,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 25, 298.46m, 8244m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 401,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 25, 132.20m, 4837m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 402,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 25, 109.85m, 7910m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 403,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 25, 91.94m, 5436m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 404,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 25, 266.43m, 5142m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 405,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 25, 360.39m, 2544m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 406,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 25, 79.61m, 2961m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 407,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 25, 30.66m, 4799m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 408,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 25, 200.31m, 6828m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 409,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 25, 90.51m, 873m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 410,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 25, 66.28m, 6101m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 411,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 25, 326.30m, 5838m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 412,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 25, 225.31m, 5839m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 413,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 25, 377.07m, 777m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 414,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 25, 372.28m, 4619m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 415,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 25, 160.57m, 8068m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 416,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 25, 189.84m, 4700m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 417,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 25, 200.55m, 9480m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 418,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 25, 139.84m, 3917m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 419,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 25, 319.75m, 2562m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 420,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 25, 284.58m, 9300m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 421,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 26.66m, 9334m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 422,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 26, 340.12m, 9303m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 423,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 26, 136.07m, 6705m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 424,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 26, 102.53m, 2283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 425,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 26, 58.37m, 279m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 426,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 26, 40.74m, 8759m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 427,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 26, 300.66m, 6173m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 428,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 26, 265.72m, 6621m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 429,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 26, 187.46m, 2021m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 430,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 26, 305.55m, 3376m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 431,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 26, 93.49m, 1476m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 432,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 27, 176.24m, 9977m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 433,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 27, 142.62m, 4755m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 434,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 27, 369.70m, 8080m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 435,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 27, 49.24m, 2867m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 436,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 27, 211.44m, 3364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 437,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 292.14m, 9249m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 438,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 27, 119.68m, 1063m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 439,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 27, 160.93m, 2813m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 440,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 28, 389.94m, 3887m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 441,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 28, 311.62m, 5794m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 442,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 28, 218.47m, 324m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 443,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 28, 327.57m, 1545m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 444,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 28, 336.49m, 6330m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 445,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 28, 126.88m, 9455m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 446,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 28, 47.61m, 3900m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 447,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 28, 320.54m, 1461m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 448,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 28, 45.99m, 8407m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 449,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 28, 260.45m, 1431m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 450,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 28, 16.32m, 7264m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 451,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 28, 388.96m, 7372m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 452,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 28, 140.19m, 4751m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 453,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 28, 40.20m, 2061m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 454,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 28, 153.17m, 5078m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 455,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 28, 41.04m, 8160m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 456,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 28, 141.64m, 6489m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 457,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 28, 7.75m, 9425m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 458,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 28, 98.78m, 4400m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 459,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 28, 294.69m, 9963m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 460,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 28, 355.36m, 6792m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 461,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 28, 169.53m, 6647m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 462,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 28, 357.97m, 1559m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 463,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 190.57m, 2724m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 464,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 28, 75.15m, 7862m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 465,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 28, 254.23m, 9538m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 466,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 28, 10.94m, 1757m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 467,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 28, 196.15m, 5176m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 468,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 28, 312.90m, 4608m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 469,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 28, 120.79m, 2841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 470,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 29, 245.49m, 4788m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 471,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 30, 181.75m, 2179m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 472,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 30, 157.57m, 9594m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 473,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 30, 10.66m, 2136m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 474,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 30, 297.66m, 8785m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 475,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 30, 267.11m, 8327m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 476,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 30, 302.03m, 6142m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 477,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 30, 261.69m, 7140m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 478,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 30, 239.19m, 4050m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 479,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 30, 303.68m, 6442m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 480,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 30, 57.35m, 5985m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 481,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 30, 142.19m, 115m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 482,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 30, 323.58m, 6671m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 483,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 30, 184.73m, 7952m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 484,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 30, 322.87m, 3645m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 485,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 30, 168.75m, 1177m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 486,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 30, 76.97m, 6276m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 487,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 30, 47.64m, 8210m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 488,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 30, 360.72m, 6482m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 489,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 30, 324.60m, 3652m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 490,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 30, 128.02m, 6392m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 491,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 30, 244.87m, 7982m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 492,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 31, 156.46m, 8770m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 493,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 31, 343.52m, 1756m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 494,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 31, 118.29m, 8190m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 495,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 31, 338.81m, 3595m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 496,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 31, 71.44m, 2972m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 497,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 31, 227.71m, 265m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 498,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 32, 397.59m, 341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 499,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 32, 269.45m, 4577m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 500,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 32, 258.09m, 9974m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 501,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 32, 57.34m, 1507m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 502,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 32, 242.61m, 2035m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 503,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 32, 129.58m, 5491m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 504,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 32, 300.85m, 328m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 505,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 32, 385.77m, 3066m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 506,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 32, 153.53m, 5530m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 507,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 32, 272.10m, 5256m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 508,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 32, 27.16m, 3085m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 509,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 32, 343.59m, 8376m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 510,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 32, 374.99m, 5237m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 511,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 32, 344.54m, 8638m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 512,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 32, 61.58m, 6631m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 513,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 32, 260.80m, 7932m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 514,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 32, 253.13m, 3162m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 515,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 32, 218.51m, 6524m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 516,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 32, 290.15m, 9372m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 517,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 32, 361.60m, 7683m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 518,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 32, 191.15m, 6244m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 519,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 32, 336.37m, 257m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 520,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 32, 144.45m, 359m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 521,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 32, 11.26m, 8484m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 522,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 32, 65.08m, 7867m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 523,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 32, 256.33m, 5073m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 524,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 32, 303.17m, 6813m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 525,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 32, 85.40m, 6189m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 526,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 32, 261.40m, 9701m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 527,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 32, 359.83m, 363m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 528,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 32, 301.39m, 1133m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 529,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 32, 97.48m, 2997m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 530,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 33, 125.20m, 6473m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 531,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 33, 117.35m, 7673m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 532,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 33, 242.87m, 4678m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 533,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 33, 154.43m, 8657m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 534,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 33, 34.82m, 4399m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 535,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 33, 59.43m, 969m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 536,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 33, 106.76m, 154m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 537,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 33, 75.98m, 555m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 538,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 33, 184.61m, 9995m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 539,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 33, 109.86m, 7451m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 540,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 33, 367.58m, 4969m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 541,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 33, 398.46m, 1396m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 542,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 33, 396.95m, 8427m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 543,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 33, 299.88m, 3000m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 544,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 33, 315.50m, 1912m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 545,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 34, 20.62m, 4704m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 546,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 34, 354.95m, 6683m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 547,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 34, 48.62m, 2439m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 548,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 34, 50.22m, 6017m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 549,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 34, 332.74m, 7677m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 550,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 34, 134.01m, 7226m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 551,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 34, 186.84m, 3788m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 552,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 34, 36.35m, 3102m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 553,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 34, 62.47m, 2542m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 554,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 34, 206.86m, 7154m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 555,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 34, 160.46m, 8643m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 556,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 34, 398.03m, 5954m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 557,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 34, 243.51m, 8567m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 558,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 34, 273.31m, 7610m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 34, 159.96m, 6802m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 34, 91.55m, 5637m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 34, 12.65m, 5879m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 35, 268.37m, 4215m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 35, 384.26m, 1701m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 35, 293.48m, 4241m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 35, 241.75m, 5284m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 35, 289.75m, 7374m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 35, 334.70m, 1823m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 35, 290.49m, 8659m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 35, 313.52m, 6177m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 35, 276.38m, 6300m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 35, 370.92m, 6904m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 572,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 35, 195.21m, 1375m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 573,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 35, 393.58m, 1241m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 574,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 35, 333.47m, 3027m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 575,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 35, 76.61m, 6870m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 576,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 35, 64.37m, 1537m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 577,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 35, 265.78m, 7019m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 578,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 35, 22.10m, 6999m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 579,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 35, 66.68m, 4439m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 580,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 35, 320.91m, 7787m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 581,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 35, 214.67m, 5743m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 582,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 35, 292.65m, 8350m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 583,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 35, 158.53m, 1104m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 584,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 35, 248.18m, 6138m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 585,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 35, 351.47m, 1221m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 586,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 35, 73.10m, 5467m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 587,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 35, 188.00m, 2475m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 588,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 35, 371.00m, 9429m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 589,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 35, 396.18m, 6869m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 590,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 35, 276.51m, 7427m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 591,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 35, 136.16m, 9857m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 592,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 36, 119.80m, 7283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 593,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 36, 183.96m, 8519m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 594,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 36, 305.83m, 533m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 595,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 36, 18.60m, 980m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 596,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 36, 70.63m, 5878m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 597,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 36, 393.57m, 8972m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 598,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 36, 133.90m, 5412m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 599,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 36, 243.66m, 6313m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 600,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 36, 296.46m, 1580m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 601,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 36, 282.01m, 3677m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 602,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 36, 113.02m, 6281m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 603,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 36, 61.94m, 2583m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 604,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 36, 132.76m, 2171m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 605,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 36, 170.55m, 3214m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 606,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 36, 335.50m, 2829m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 607,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 36, 163.30m, 7717m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 608,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 36, 317.92m, 9718m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 609,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 36, 321.05m, 1478m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 610,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 36, 40.09m, 6039m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 611,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 36, 280.65m, 981m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 612,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 36, 273.27m, 9936m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 613,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 36, 186.37m, 8734m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 614,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 36, 133.78m, 3632m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 615,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 36, 275.07m, 726m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 616,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 36, 89.57m, 7712m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 617,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 36, 141.44m, 4079m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 618,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 36, 152.69m, 2687m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 619,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 36, 156.53m, 2396m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 620,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 36, 194.57m, 4616m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 621,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 36, 260.70m, 7114m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 622,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 36, 48.96m, 256m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 623,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 36, 129.07m, 3658m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 624,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 36, 161.98m, 8027m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 625,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 36, 165.62m, 2269m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 626,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 36, 363.39m, 6811m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 627,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 37, 232.48m, 3766m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 628,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 37, 298.64m, 2060m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 629,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 37, 128.96m, 8294m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 630,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 37, 117.74m, 7640m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 631,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 37, 391.79m, 4218m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 632,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 37, 273.07m, 6517m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 633,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 37, 227.10m, 570m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 634,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 37, 360.49m, 4153m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 635,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 37, 379.45m, 6051m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 636,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 37, 387.06m, 517m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 637,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 37, 193.13m, 5584m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 638,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 37, 46.81m, 7739m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 639,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 37, 181.69m, 7699m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 640,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 37, 117.69m, 1050m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 641,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 37, 224.15m, 9754m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 642,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 37, 395.00m, 6545m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 643,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 37, 305.96m, 9350m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 644,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 37, 344.44m, 7138m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 645,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 37, 384.38m, 6636m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 646,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 37, 239.12m, 7775m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 647,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 37, 314.43m, 5285m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 648,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 37, 83.89m, 1332m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 649,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 37, 258.07m, 3536m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 650,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 37, 352.35m, 3924m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 651,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 37, 380.64m, 6616m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 652,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 37, 174.28m, 7185m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 653,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 37, 380.09m, 7185m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 654,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 37, 44.04m, 116m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 655,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 38, 248.68m, 8445m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 656,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 38, 62.42m, 1203m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 657,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 38, 342.56m, 9924m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 658,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 38, 203.25m, 5765m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 659,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 38, 141.26m, 8521m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 660,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 38, 137.93m, 3109m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 661,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 38, 353.60m, 5525m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 662,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 38, 363.78m, 622m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 663,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 38, 211.10m, 9450m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 664,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 38, 259.02m, 690m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 665,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 38, 271.39m, 5268m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 666,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 38, 146.54m, 2643m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 667,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 38, 213.61m, 943m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 668,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 38, 355.40m, 1753m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 669,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 38, 152.32m, 1553m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 670,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 38, 233.89m, 7626m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 671,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 38, 258.81m, 860m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 672,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 38, 224.38m, 4772m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 673,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 38, 316.27m, 7075m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 674,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 38, 67.60m, 9954m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 675,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 38, 373.16m, 8830m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 676,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 38, 21.04m, 6781m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 677,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 38, 237.90m, 8076m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 678,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 38, 88.29m, 4540m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 679,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 38, 153.00m, 8207m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 680,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 38, 362.47m, 7921m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 681,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 38, 74.53m, 5041m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 682,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 38, 393.13m, 3537m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 683,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 38, 20.96m, 2264m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 684,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 38, 221.34m, 8320m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 685,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 38, 36.82m, 4840m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 686,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 38, 114.79m, 925m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 687,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 38, 189.29m, 1719m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 688,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 38, 381.85m, 9387m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 689,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 38, 251.65m, 134m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 690,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 39, 72.38m, 6565m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 691,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 39, 353.79m, 9153m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 692,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 39, 393.06m, 5013m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 693,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 39, 380.01m, 5392m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 694,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 39, 1.07m, 4617m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 695,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 39, 17.55m, 9755m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 696,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 39, 52.47m, 9700m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 697,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 39, 39.21m, 7382m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 698,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 39, 174.18m, 6302m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 699,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 39, 92.67m, 5654m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 700,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 39, 142.48m, 3503m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 701,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 39, 159.39m, 4170m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 702,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 39, 255.44m, 5111m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 703,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 39, 237.81m, 3043m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 704,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 39, 300.46m, 4049m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 705,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 39, 7.22m, 9551m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 706,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 39, 391.69m, 2344m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 707,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 39, 263.71m, 5953m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 708,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 39, 367.05m, 3694m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 709,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 39, 115.93m, 2912m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 710,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 39, 374.14m, 9807m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 711,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 39, 77.16m, 7341m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 712,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 39, 19.04m, 6393m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 713,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 39, 188.16m, 7747m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 714,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 39, 269.32m, 7245m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 715,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 39, 135.33m, 705m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 716,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 39, 269.02m, 440m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 717,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 39, 134.40m, 8733m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 718,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 39, 301.23m, 144m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 719,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 39, 20.17m, 2820m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 720,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 39, 89.65m, 8572m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 721,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 39, 127.38m, 2478m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 722,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 39, 267.30m, 6340m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 723,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 40, 388.17m, 3258m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 724,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 40, 204.52m, 4596m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 725,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 40, 394.38m, 8708m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 726,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 40, 232.72m, 3089m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 727,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 40, 246.90m, 2571m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 40, 240.74m, 1173m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 729,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 40, 175.92m, 7297m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 730,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 40, 398.85m, 3672m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 731,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 40, 99.52m, 9174m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 732,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 40, 142.94m, 4866m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 733,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 40, 268.02m, 4364m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 734,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 40, 141.72m, 6279m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 735,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 40, 352.15m, 1550m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 736,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 40, 353.26m, 4652m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 737,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 40, 298.69m, 5167m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 738,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 40, 389.03m, 1267m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 739,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 40, 84.12m, 2164m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 740,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 41, 49.39m, 9410m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 741,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 41, 389.31m, 9585m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 742,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 41, 106.01m, 5422m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 743,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 41, 252.44m, 3942m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 744,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 41, 364.69m, 8725m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 745,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 41, 106.18m, 6291m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 746,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 42, 304.98m, 7235m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 747,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 42, 76.40m, 5599m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 748,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 42, 90.73m, 2585m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 749,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 42, 128.99m, 2816m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 750,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 42, 328.07m, 1559m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 751,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 42, 266.04m, 7315m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 752,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 42, 190.46m, 4006m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 753,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 42, 191.43m, 3491m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 754,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 42, 32.93m, 4998m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 755,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 42, 394.90m, 8761m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 756,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 42, 188.42m, 3536m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 757,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 42, 135.32m, 2539m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 758,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 42, 226.73m, 6764m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 759,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 42, 289.15m, 1180m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 760,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 42, 395.52m, 7414m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 761,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 42, 193.63m, 1240m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 762,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 42, 73.90m, 5728m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 763,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 42, 347.74m, 5171m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 764,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 42, 151.91m, 4232m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 765,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 42, 25.23m, 3049m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 766,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 42, 151.07m, 2306m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 767,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 42, 370.98m, 6369m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 768,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 42, 360.50m, 6514m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 769,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 42, 23.20m, 9371m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 770,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 42, 114.89m, 7931m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 771,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 42, 241.88m, 1756m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 772,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 42, 152.44m, 8014m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 773,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 42, 123.23m, 5645m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 774,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 42, 334.08m, 8786m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 775,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 42, 331.73m, 5210m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 776,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 42, 150.71m, 907m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 777,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 42, 354.61m, 2209m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 778,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 42, 43.11m, 1480m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 779,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 42, 187.45m, 3255m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 780,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 42, 253.20m, 5870m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 781,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 42, 288.74m, 1977m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 782,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 42, 100.79m, 3625m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 783,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 42, 199.89m, 7981m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 784,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 42, 265.40m, 5166m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 785,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 43, 37.89m, 7583m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 786,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 43, 29.76m, 1403m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 787,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 43, 272.47m, 8563m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 788,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 43, 160.27m, 5821m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 789,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 43, 199.77m, 376m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 790,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 43, 364.98m, 4859m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 791,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 43, 270.02m, 9775m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 792,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 43, 46.34m, 6909m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 793,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 43, 231.95m, 1685m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 794,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 43, 350.82m, 2925m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 795,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 43, 90.21m, 7043m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 796,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 43, 140.52m, 7092m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 797,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 43, 134.90m, 776m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 798,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 43, 311.10m, 676m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 799,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 43, 58.14m, 6001m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 800,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 43, 89.65m, 9500m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 801,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 43, 8.06m, 3755m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 802,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 43, 274.45m, 5012m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 803,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 44, 391.54m, 773m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 804,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 44, 197.81m, 9718m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 805,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 44, 321.65m, 5737m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 806,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 44, 71.06m, 8778m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 807,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 44, 60.25m, 3283m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 808,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 44, 231.09m, 4183m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 809,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 44, 358.91m, 9199m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 810,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 44, 388.20m, 1007m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 811,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 44, 143.30m, 2185m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 44, 343.76m, 9170m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 813,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 44, 215.75m, 2130m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 814,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 44, 113.36m, 9511m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 815,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 44, 146.23m, 8366m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 816,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 44, 83.89m, 7202m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 817,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 44, 107.38m, 8281m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 818,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 44, 360.35m, 8210m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 819,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 44, 242.47m, 9121m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 820,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 44, 306.73m, 9905m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 821,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 44, 390.57m, 5296m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 822,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 44, 304.62m, 4066m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 823,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 44, 261.63m, 4388m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 824,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 44, 268.89m, 7176m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 825,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 44, 148.96m, 2570m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 826,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 44, 231.41m, 4730m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 827,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 44, 81.46m, 4944m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 828,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 44, 106.82m, 5918m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 829,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 44, 157.18m, 8255m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 830,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 44, 2.98m, 7819m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 831,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 44, 86.66m, 8640m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 832,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 44, 170.89m, 3884m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 833,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 44, 174.28m, 9820m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 834,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 45, 222.25m, 2914m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 835,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 45, 238.48m, 1205m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 836,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 45, 212.39m, 5739m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 837,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 45, 12.06m, 4491m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 838,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 45, 226.27m, 5060m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 839,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 10, 45, 284.75m, 9377m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 840,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 45, 148.44m, 5811m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 841,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 45, 259.65m, 6568m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 842,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 45, 183.23m, 8535m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 843,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 45, 378.06m, 8685m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 844,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 45, 58.13m, 4910m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 845,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 45, 367.02m, 6134m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 846,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 45, 62.25m, 8903m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 847,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 45, 328.87m, 4577m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 848,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 45, 224.98m, 5236m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 849,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 45, 285.73m, 8842m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 850,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 45, 195.97m, 5774m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 851,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 45, 343.08m, 6804m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 852,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 45, 252.71m, 2071m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 853,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 5, 45, 104.58m, 176m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 854,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 45, 281.27m, 5110m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 855,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 45, 383.13m, 7022m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 856,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 45, 356.70m, 3762m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 857,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 45, 20.10m, 6776m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 858,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 45, 50.74m, 2039m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 859,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 45, 54.68m, 7569m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 860,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 45, 387.64m, 4699m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 861,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 45, 118.34m, 6614m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 862,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 45, 323.62m, 9679m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 863,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 45, 164.75m, 3824m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 864,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 45, 352.72m, 2362m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 865,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 45, 378.50m, 9704m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 866,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 45, 328.03m, 3479m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 867,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 45, 205.73m, 3482m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 868,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 45, 359.60m, 5645m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 869,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 45, 193.04m, 460m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 870,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 46, 199.03m, 4502m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 871,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 46, 116.93m, 5477m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 872,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 46, 163.93m, 8496m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 873,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 46, 60.50m, 7342m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 874,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 46, 192.94m, 9938m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 875,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 20, 46, 67.37m, 4513m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 876,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 46, 72.23m, 2335m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 877,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 46, 126.64m, 4189m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 878,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 46, 182.90m, 1317m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 879,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 46, 158.73m, 1068m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 880,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 46, 131.59m, 9319m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 881,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 46, 386.31m, 6935m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 882,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 46, 136.00m, 4150m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 883,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 46, 40.10m, 5790m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 884,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 46, 36.14m, 2208m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 885,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 46, 208.22m, 7454m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 886,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 9, 46, 181.70m, 2074m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 887,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 17, 46, 102.95m, 3789m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 888,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 6, 46, 13.63m, 2646m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 889,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 26, 46, 168.68m, 3427m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 890,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 46, 300.35m, 4795m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 891,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 46, 320.32m, 1217m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 892,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 46, 122.01m, 551m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 893,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 46, 15.64m, 5748m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 894,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 46, 260.73m, 697m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 895,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 7, 46, 80.82m, 7203m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 896,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 46, 152.62m, 384m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 897,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 46, 359.47m, 5841m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 898,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 47, 29.63m, 5630m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 899,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 47, 373.67m, 4389m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 900,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 24, 47, 367.31m, 823m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 901,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 21, 47, 139.74m, 1094m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 902,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 19, 47, 115.81m, 1091m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 903,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 25, 47, 87.21m, 7003m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 904,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 47, 167.07m, 6325m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 905,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 47, 242.22m, 3191m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 906,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 47, 332.80m, 5443m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 907,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 47, 17.05m, 3142m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 908,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 47, 340.87m, 8954m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 909,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 23, 47, 97.45m, 3780m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 910,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 47, 348.15m, 562m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 911,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 47, 385.46m, 9622m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 912,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 47, 220.63m, 2988m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 913,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 29, 47, 40.86m, 293m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 914,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 47, 273.40m, 4021m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 915,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 47, 108.57m, 7567m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 916,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 47, 99.29m, 3016m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 917,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 4, 47, 357.50m, 5299m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 918,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 47, 306.56m, 6575m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 919,
                columns: new[] { "portfolio_id", "price", "quantity" },
                values: new object[] { 47, 83.23m, 8718m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 920,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 47, 291.63m, 6310m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 921,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 47, 260.58m, 8837m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 922,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 14, 47, 267.12m, 2519m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 923,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 47, 9.19m, 5412m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 924,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 22, 47, 208.53m, 7434m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 925,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 11, 47, 364.54m, 254m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 926,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 18, 47, 56.90m, 1858m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 927,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 30, 47, 31.76m, 5489m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 928,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 15, 48, 390.64m, 5262m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 929,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 1, 48, 79.90m, 3147m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 930,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 8, 48, 138.40m, 4269m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 931,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 27, 48, 149.21m, 3983m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 932,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 48, 13.81m, 5184m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 933,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 3, 48, 241.45m, 5148m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 934,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 13, 48, 91.10m, 7604m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 935,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 48, 149.97m, 7864m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 936,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 16, 48, 342.00m, 6421m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 937,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 28, 48, 27.33m, 6960m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 938,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 2, 48, 260.87m, 920m });

            migrationBuilder.UpdateData(
                table: "position",
                keyColumn: "id",
                keyValue: 939,
                columns: new[] { "instrument_id", "portfolio_id", "price", "quantity" },
                values: new object[] { 12, 48, 52.52m, 6036m });
        }
    }
}
