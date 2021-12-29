using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ywt.Study.EFCore.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Field10",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Field11",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field12",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field13",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field14",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field15",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field16",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field2_1",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field3",
                table: "TestA",
                type: "varchar(200)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Field4",
                table: "TestA",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Field5",
                table: "TestA",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Field6",
                table: "TestA",
                type: "varbinary(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Field7",
                table: "TestA",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Field8",
                table: "TestA",
                type: "datetime2(3)",
                precision: 3,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Field9",
                table: "TestA",
                type: "varchar(max)",
                unicode: false,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Field10",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field11",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field12",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field13",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field14",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field15",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field16",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field2_1",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field3",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field4",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field5",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field6",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field7",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field8",
                table: "TestA");

            migrationBuilder.DropColumn(
                name: "Field9",
                table: "TestA");
        }
    }
}
