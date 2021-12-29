using Microsoft.EntityFrameworkCore.Migrations;

namespace Ywt.Study.EFCore.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "TestA",
                comment: "测试表A");

            migrationBuilder.AlterTable(
                name: "Person",
                oldComment: "人员表");

            migrationBuilder.AlterColumn<string>(
                name: "Field11",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true,
                comment: "这是一个测试列",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Field10",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "TestA",
                oldComment: "测试表A");

            migrationBuilder.AlterTable(
                name: "Person",
                comment: "人员表");

            migrationBuilder.AlterColumn<int>(
                name: "Field11",
                table: "TestA",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "这是一个测试列");

            migrationBuilder.AlterColumn<string>(
                name: "Field10",
                table: "TestA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
