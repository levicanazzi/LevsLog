using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLevsLog.Migrations
{
    public partial class Corrigindo_Estrutura_Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orcamentos_IdEndereco",
                table: "Orcamentos");

            migrationBuilder.DropIndex(
                name: "IX_Orcamentos_IdTipoServico",
                table: "Orcamentos");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_IdEndereco",
                table: "Orcamentos",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_IdTipoServico",
                table: "Orcamentos",
                column: "IdTipoServico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orcamentos_IdEndereco",
                table: "Orcamentos");

            migrationBuilder.DropIndex(
                name: "IX_Orcamentos_IdTipoServico",
                table: "Orcamentos");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_IdEndereco",
                table: "Orcamentos",
                column: "IdEndereco",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_IdTipoServico",
                table: "Orcamentos",
                column: "IdTipoServico",
                unique: true);
        }
    }
}
