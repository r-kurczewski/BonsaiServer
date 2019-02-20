using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BonsaiServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(maxLength: 16, nullable: true),
                    PasswordHash = table.Column<string>(maxLength: 64, nullable: true),
                    Session = table.Column<string>(maxLength: 64, nullable: true),
                    Email = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    LeavesId = table.Column<byte>(nullable: false),
                    FlowersId = table.Column<byte>(nullable: false),
                    StalkColor = table.Column<string>(maxLength: 3, nullable: true),
                    LeavesColor = table.Column<string>(maxLength: 3, nullable: true),
                    FlowersColor = table.Column<string>(maxLength: 3, nullable: true),
                    PotColor = table.Column<string>(maxLength: 3, nullable: true),
                    SoilColor = table.Column<string>(maxLength: 3, nullable: true),
                    Rarity = table.Column<byte>(nullable: false),
                    Slot = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plants_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mutations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Plant1Id = table.Column<int>(nullable: false),
                    Plant2Id = table.Column<int>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mutations_Plants_Plant1Id",
                        column: x => x.Plant1Id,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mutations_Plants_Plant2Id",
                        column: x => x.Plant2Id,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mutations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Plants_UserId",
                table: "Plants",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mutations");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
