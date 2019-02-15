using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BonsaiServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DirtColor = table.Column<string>(maxLength: 3, nullable: true),
                    FlowerColor = table.Column<string>(maxLength: 3, nullable: true),
                    FlowersId = table.Column<byte>(nullable: false),
                    LeavesColor = table.Column<string>(maxLength: 3, nullable: true),
                    LeavesId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    PotColor = table.Column<string>(maxLength: 3, nullable: true),
                    Rarity = table.Column<byte>(nullable: false),
                    Slot = table.Column<byte>(nullable: false),
                    SoilColor = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
