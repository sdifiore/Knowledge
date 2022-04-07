using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Knowledge.Data.Migrations
{
    public partial class AddPlataformasRelationToArtigos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtigoId",
                table: "Plataformas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plataformas_ArtigoId",
                table: "Plataformas",
                column: "ArtigoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plataformas_Artigos_ArtigoId",
                table: "Plataformas",
                column: "ArtigoId",
                principalTable: "Artigos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plataformas_Artigos_ArtigoId",
                table: "Plataformas");

            migrationBuilder.DropIndex(
                name: "IX_Plataformas_ArtigoId",
                table: "Plataformas");

            migrationBuilder.DropColumn(
                name: "ArtigoId",
                table: "Plataformas");
        }
    }
}
