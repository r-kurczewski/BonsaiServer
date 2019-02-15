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
                    DirtColor = table.Column<string>(nullable: true),
                    FlowerColor = table.Column<string>(nullable: true),
                    FlowersId = table.Column<int>(nullable: false),
                    LeavesColor = table.Column<string>(nullable: true),
                    LeavesId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PotColor = table.Column<string>(nullable: true),
                    Rarity = table.Column<int>(nullable: false),
                    Slot = table.Column<int>(nullable: false),
                    SoilColor = table.Column<string>(nullable: true)
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
