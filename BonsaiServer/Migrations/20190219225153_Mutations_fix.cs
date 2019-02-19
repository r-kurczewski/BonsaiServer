using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BonsaiServer.Migrations
{
    public partial class Mutations_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Start",
                table: "Mutations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mutations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mutations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Mutations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
