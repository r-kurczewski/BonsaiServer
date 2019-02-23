using Microsoft.EntityFrameworkCore.Migrations;

namespace BonsaiServer.Migrations
{
    public partial class SlotsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "11f", "f91", "BMXRE", "155", (byte)5, (byte)1, "3bb", "3f1" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "fbd", "555", "JMZJLDH", "5df", (byte)5, (byte)2, "9b9", "d39" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "9f1", "5b1", "QFZKJQKX", "f3d", (byte)4, (byte)3, "fd3", "1f3" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "3f3", "f73", "SGBHGZAXB", "119", (byte)0, (byte)4, "bdb", "ddb" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "919", "739", "QSRUCQRUGXT", "5f7", (byte)1, (byte)5, "759", "71b" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "3b1", "bfb", "NFSLWQL", "fbd", (byte)1, (byte)1, "bb1", "511" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "5b3", "bd3", "DQDUFLDACMZ", "dd9", (byte)2, (byte)2, "3f7", "bbf" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "133", "597", "JDQWYLWT", "dbf", (byte)3, "7fb", "5bf" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "1fb", "5b9", "WEAYKSVPV", "137", (byte)3, (byte)4, "1db", "591" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "f9d", "dbd", "KLEVA", "15b", (byte)5, (byte)5, "71b", "75f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "450a10fad8bc1453cf4690e7391f34df4e7c3621ccc7e1b45699190c6acc36e4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "5bb", "3f3", "FQJHOC", "31f", (byte)0, (byte)0, "119", "135" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "793", "db5", "TLHIVVCZF", "19f", (byte)1, (byte)1, "f9b", "59d" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "151", "553", "EVXBJFCNX", "ff3", (byte)2, (byte)2, "9d3", "775" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "b3d", "9f7", "NWUWD", "b79", (byte)2, (byte)3, "b75", "b95" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "751", "fb7", "RNJRRYDFQ", "9d3", (byte)0, (byte)4, "135", "391" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "d75", "7d3", "MZPPF", "3db", (byte)4, (byte)0, "b97", "957" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "79f", "7d9", "ZKXMKDVLHT", "1bf", (byte)3, (byte)1, "7b3", "55f" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "9bd", "9f7", "ZEXRLEFDP", "b17", (byte)2, "975", "15b" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "5b9", "f7f", "OAFSSLGSC", "395", (byte)0, (byte)3, "ff3", "7d5" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "3b9", "71f", "IXTWJYQFORY", "fd1", (byte)4, (byte)4, "1d5", "9d1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "450A10FAD8BC1453CF4690E7391F34DF4E7C3621CCC7E1B45699190C6ACC36E4");
        }
    }
}
