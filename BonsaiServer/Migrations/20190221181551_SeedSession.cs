using Microsoft.EntityFrameworkCore.Migrations;

namespace BonsaiServer.Migrations
{
    public partial class SeedSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "3db", "11f", "SLLKYP", "99b", (byte)2, "175", "5b7" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "df9", "5b1", "NASEEPVRC", "751", (byte)1, "379", "157" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "9fd", "d11", "QGGNYKI", "d91", (byte)3, "555", "d3b" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "d95", "d5d", "IJZEYIOSSF", "315", (byte)2, "ff9", "df9" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "SoilColor", "StalkColor" },
                values: new object[] { "b93", "1df", "WUWYHB", "b19", "31f", "91d" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "fb7", "915", "VVPYYVE", "957", (byte)3, "f17", "3df" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "SoilColor", "StalkColor" },
                values: new object[] { "355", "dd5", "PSITTA", "5f1", "1df", "f75" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "97b", "9d5", "RPFRI", "d91", (byte)4, "b79", "b77" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "d95", "fb7", "JPLXP", "377", (byte)0, "973", "1bb" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "733", "53b", "GOUHZLOO", "371", (byte)5, "195", "593" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Session" },
                values: new object[] { "28355a2d1a8636f26ebd23db7f7bc58f319f8b4d85282ddd308cfc5eeb18031b", "c8f0cbf67674c562415f802542e9e384ca056af3b8f2756acbfa7b0cfeeb6a95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Session",
                value: "450a10fad8bc1453cf4690e7391f34df4e7c3621ccc7e1b45699190c6acc36e4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "7bb", "9b5", "RHCHFFMUI", "b3b", (byte)5, "95f", "f9f" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "577", "7f3", "XEDCNM", "bd9", (byte)0, "f3b", "59f" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "3d5", "b51", "TQRKCCMD", "bb9", (byte)5, "93b", "dbf" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "b15", "19b", "QTREAM", "53f", (byte)1, "dd1", "f31" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "SoilColor", "StalkColor" },
                values: new object[] { "3f1", "f19", "HNFLNKXN", "55d", "9b5", "b57" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "1f1", "bf1", "GGOOIK", "131", (byte)4, "3df", "d9f" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "SoilColor", "StalkColor" },
                values: new object[] { "f91", "d75", "IXXBJ", "b9d", "5dd", "1bf" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "b73", "bb9", "PEPDBP", "5b1", (byte)1, "bb7", "f31" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "b57", "337", "CDEKSWPHA", "f75", (byte)4, "3f5", "591" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "17f", "171", "JSDFVWXPVFQ", "1d3", (byte)2, "f59", "3f3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Session" },
                values: new object[] { "28355A2D1A8636F26EBD23DB7F7BC58F319F8B4D85282DDD308CFC5EEB18031B", "IsThisWorking?" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Session",
                value: "OtherSessionHash");
        }
    }
}
