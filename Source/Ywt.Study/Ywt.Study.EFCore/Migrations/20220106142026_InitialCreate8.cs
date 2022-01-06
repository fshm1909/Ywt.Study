using Microsoft.EntityFrameworkCore.Migrations;

namespace Ywt.Study.EFCore.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_R2_R1Id",
                table: "R2",
                column: "R1Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_R2_R1_R1Id",
                table: "R2",
                column: "R1Id",
                principalTable: "R1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_R2_R1_R1Id",
                table: "R2");

            migrationBuilder.DropIndex(
                name: "IX_R2_R1Id",
                table: "R2");
        }
    }
}
