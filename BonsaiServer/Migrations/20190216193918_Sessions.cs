using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BonsaiServer.Migrations
{
    public partial class Sessions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plant1",
                table: "Mutations");

            migrationBuilder.DropColumn(
                name: "Plant2",
                table: "Mutations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Plants",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mutations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Plant1Id",
                table: "Mutations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Plant2Id",
                table: "Mutations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SessionHash = table.Column<string>(maxLength: 64, nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plants_UserId",
                table: "Plants",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_Plant1Id",
                table: "Mutations",
                column: "Plant1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_Plant2Id",
                table: "Mutations",
                column: "Plant2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_UserId",
                table: "Mutations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mutations_Plants_Plant1Id",
                table: "Mutations",
                column: "Plant1Id",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mutations_Plants_Plant2Id",
                table: "Mutations",
                column: "Plant2Id",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mutations_Users_UserId",
                table: "Mutations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Users_UserId",
                table: "Plants",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mutations_Plants_Plant1Id",
                table: "Mutations");

            migrationBuilder.DropForeignKey(
                name: "FK_Mutations_Plants_Plant2Id",
                table: "Mutations");

            migrationBuilder.DropForeignKey(
                name: "FK_Mutations_Users_UserId",
                table: "Mutations");

            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Users_UserId",
                table: "Plants");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Plants_UserId",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Mutations_Plant1Id",
                table: "Mutations");

            migrationBuilder.DropIndex(
                name: "IX_Mutations_Plant2Id",
                table: "Mutations");

            migrationBuilder.DropIndex(
                name: "IX_Mutations_UserId",
                table: "Mutations");

            migrationBuilder.DropColumn(
                name: "Plant1Id",
                table: "Mutations");

            migrationBuilder.DropColumn(
                name: "Plant2Id",
                table: "Mutations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Plants",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mutations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Plant1",
                table: "Mutations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Plant2",
                table: "Mutations",
                nullable: false,
                defaultValue: 0);
        }
    }
}
