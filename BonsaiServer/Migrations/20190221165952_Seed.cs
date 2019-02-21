using Microsoft.EntityFrameworkCore.Migrations;

namespace BonsaiServer.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "PasswordHash", "Session" },
                values: new object[] { 1, "abc@wp.pl", "a", "28355A2D1A8636F26EBD23DB7F7BC58F319F8B4D85282DDD308CFC5EEB18031B", "IsThisWorking?" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "PasswordHash", "Session" },
                values: new object[] { 2, "radek@example.com", "radek", "450A10FAD8BC1453CF4690E7391F34DF4E7C3621CCC7E1B45699190C6ACC36E4", "OtherSessionHash" });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "FlowersColor", "FlowersId", "LeavesColor", "LeavesId", "Name", "PotColor", "Rarity", "Slot", "SoilColor", "StalkColor", "UserId" },
                values: new object[,]
                {
                    { 1, "175", (byte)1, "3b1", (byte)1, "NOBYEMCSC", "379", (byte)0, (byte)0, "d57", "915", 1 },
                    { 2, "55b", (byte)1, "35f", (byte)1, "GYRAI", "53f", (byte)3, (byte)0, "d91", "171", 1 },
                    { 3, "9b7", (byte)1, "931", (byte)1, "DPVZUPHKKIK", "d51", (byte)5, (byte)0, "711", "155", 1 },
                    { 4, "f5b", (byte)1, "bb3", (byte)1, "FCLSNKPSUN", "db1", (byte)2, (byte)0, "335", "ff7", 1 },
                    { 5, "935", (byte)1, "5fd", (byte)1, "JEBQQAZEN", "f17", (byte)2, (byte)0, "b71", "559", 1 },
                    { 6, "1d9", (byte)1, "b95", (byte)1, "XOOZF", "375", (byte)0, (byte)0, "93b", "791", 2 },
                    { 7, "3b7", (byte)1, "193", (byte)1, "YGQOVCINAP", "1d7", (byte)4, (byte)0, "b1d", "fbd", 2 },
                    { 8, "1fb", (byte)1, "df3", (byte)1, "LHLQFQAM", "37d", (byte)3, (byte)0, "f71", "b17", 2 },
                    { 9, "fbd", (byte)1, "99b", (byte)1, "TYQKKEXSHO", "ddd", (byte)3, (byte)0, "9d1", "b79", 2 },
                    { 10, "7b5", (byte)1, "95f", (byte)1, "THOQLEYUGWN", "f71", (byte)4, (byte)0, "ff1", "515", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
