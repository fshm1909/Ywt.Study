using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ywt.Study.EFCore.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "TestC");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "TestD",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "TestD");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "TestC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
