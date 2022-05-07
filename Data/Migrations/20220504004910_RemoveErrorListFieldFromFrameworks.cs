using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Knowledge.Data.Migrations
{
    public partial class RemoveErrorListFieldFromFrameworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Erros_Frameworks_FrameworkId",
                table: "Erros");

            migrationBuilder.DropIndex(
                name: "IX_Erros_FrameworkId",
                table: "Erros");

            migrationBuilder.DropColumn(
                name: "FrameworkId",
                table: "Erros");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FrameworkId",
                table: "Erros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Erros_FrameworkId",
                table: "Erros",
                column: "FrameworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Erros_Frameworks_FrameworkId",
                table: "Erros",
                column: "FrameworkId",
                principalTable: "Frameworks",
                principalColumn: "Id");
        }
    }
}
