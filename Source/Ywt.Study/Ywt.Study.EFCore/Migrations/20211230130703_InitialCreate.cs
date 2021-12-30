using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ywt.Study.EFCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false),
                    state = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field2_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field3 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Field4 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Field5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Field6 = table.Column<byte[]>(type: "varbinary(500)", maxLength: 500, nullable: true),
                    Field7 = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Field8 = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false),
                    Field9 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Field10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Field11 = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "这是一个测试列"),
                    Field12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field13 = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "默认值"),
                    Field14 = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    Field15 = table.Column<string>(type: "nvarchar(max)", nullable: true, computedColumnSql: "[Field12] + ', ' + [Field13]"),
                    Field16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field20 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestA", x => x.Id);
                },
                comment: "测试表A");

            migrationBuilder.CreateTable(
                name: "TestB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestC", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "TestA");

            migrationBuilder.DropTable(
                name: "TestB");

            migrationBuilder.DropTable(
                name: "TestC");
        }
    }
}
