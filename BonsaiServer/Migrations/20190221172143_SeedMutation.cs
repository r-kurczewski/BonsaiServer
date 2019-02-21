using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BonsaiServer.Migrations
{
    public partial class SeedMutation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mutations",
                columns: new[] { "Id", "End", "Plant1Id", "Plant2Id", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1 });

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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "SoilColor", "StalkColor" },
                values: new object[] { "3d5", "b51", "TQRKCCMD", "bb9", "93b", "dbf" });

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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "3f1", "f19", "HNFLNKXN", "55d", (byte)4, "9b5", "b57" });

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
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "f91", "d75", "IXXBJ", "b9d", (byte)2, "5dd", "1bf" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mutations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "175", "3b1", "NOBYEMCSC", "379", (byte)0, "d57", "915" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "55b", "35f", "GYRAI", "53f", (byte)3, "d91", "171" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "SoilColor", "StalkColor" },
                values: new object[] { "9b7", "931", "DPVZUPHKKIK", "d51", "711", "155" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "f5b", "bb3", "FCLSNKPSUN", "db1", (byte)2, "335", "ff7" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "935", "5fd", "JEBQQAZEN", "f17", (byte)2, "b71", "559" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "1d9", "b95", "XOOZF", "375", (byte)0, "93b", "791" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "3b7", "193", "YGQOVCINAP", "1d7", (byte)4, "b1d", "fbd" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "1fb", "df3", "LHLQFQAM", "37d", (byte)3, "f71", "b17" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "fbd", "99b", "TYQKKEXSHO", "ddd", (byte)3, "9d1", "b79" });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlowersColor", "LeavesColor", "Name", "PotColor", "Rarity", "SoilColor", "StalkColor" },
                values: new object[] { "7b5", "95f", "THOQLEYUGWN", "f71", (byte)4, "ff1", "515" });
        }
    }
}
