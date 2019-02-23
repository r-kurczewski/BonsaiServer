using Microsoft.EntityFrameworkCore.Migrations;

namespace BonsaiServer.Migrations
{
    public partial class PlantSlots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "5bb", "3f3", "FQJHOC", "31f", (byte)0, "119", "135" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "793", "db5", "TLHIVVCZF", "19f", (byte)1, "f9b", "59d" });

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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "b3d", "9f7", "NWUWD", "b79", (byte)3, "b75", "b95" });

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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "d75", "7d3", "MZPPF", "3db", (byte)4, "b97", "957" });

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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "9bd", "9f7", "ZEXRLEFDP", "b17", (byte)5, (byte)2, "975", "15b" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "5b9", "f7f", "OAFSSLGSC", "395", (byte)3, "ff3", "7d5" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "3b9", "71f", "IXTWJYQFORY", "fd1", (byte)4, (byte)4, "1d5", "9d1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "df9", "5b1", "NASEEPVRC", "751", (byte)0, "379", "157" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "9fd", "d11", "QGGNYKI", "d91", (byte)3, (byte)0, "555", "d3b" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "d95", "d5d", "IJZEYIOSSF", "315", (byte)0, "ff9", "df9" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "b93", "1df", "WUWYHB", "b19", (byte)4, (byte)0, "31f", "91d" });

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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "355", "dd5", "PSITTA", "5f1", (byte)2, (byte)0, "1df", "f75" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "97b", "9d5", "RPFRI", "d91", (byte)4, (byte)0, "b79", "b77" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "d95", "fb7", "JPLXP", "377", (byte)0, "973", "1bb" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor" },
                values: new object[] { "733", "53b", "GOUHZLOO", "371", (byte)5, (byte)0, "195", "593" });
        }
    }
}
