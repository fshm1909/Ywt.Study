using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ywt.Study.EFCore.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Test1",
                columns: table => new
                {
                    Test1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test1", x => x.Test1Id);
                });

            migrationBuilder.CreateTable(
                name: "TestE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Test2",
                columns: table => new
                {
                    Test2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Test1Id = table.Column<int>(type: "int", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test2", x => x.Test2Id);
                    table.ForeignKey(
                        name: "FK_Test2_Test1_Test1Id",
                        column: x => x.Test1Id,
                        principalTable: "Test1",
                        principalColumn: "Test1Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Test2_Test1Id",
                table: "Test2",
                column: "Test1Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test2");

            migrationBuilder.DropTable(
                name: "TestE");

            migrationBuilder.DropTable(
                name: "Test1");
        }
    }
}
