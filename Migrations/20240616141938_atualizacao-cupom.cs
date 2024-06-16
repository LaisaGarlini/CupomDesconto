using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CupomDesconto.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaocupom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cupom_Loja_LojaID",
                table: "Cupom");

            migrationBuilder.DropForeignKey(
                name: "FK_Cupom_Produto_ProdutoID",
                table: "Cupom");

            migrationBuilder.DropForeignKey(
                name: "FK_Cupom_Usuario_UsuarioID",
                table: "Cupom");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "Cupom",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "ProdutoID",
                table: "Cupom",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "LojaID",
                table: "Cupom",
                newName: "LojaId");

            migrationBuilder.RenameIndex(
                name: "IX_Cupom_UsuarioID",
                table: "Cupom",
                newName: "IX_Cupom_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Cupom_ProdutoID",
                table: "Cupom",
                newName: "IX_Cupom_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cupom_LojaID",
                table: "Cupom",
                newName: "IX_Cupom_LojaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cupom_Loja_LojaId",
                table: "Cupom",
                column: "LojaId",
                principalTable: "Loja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cupom_Produto_ProdutoId",
                table: "Cupom",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cupom_Usuario_UsuarioId",
                table: "Cupom",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cupom_Loja_LojaId",
                table: "Cupom");

            migrationBuilder.DropForeignKey(
                name: "FK_Cupom_Produto_ProdutoId",
                table: "Cupom");

            migrationBuilder.DropForeignKey(
                name: "FK_Cupom_Usuario_UsuarioId",
                table: "Cupom");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Cupom",
                newName: "UsuarioID");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Cupom",
                newName: "ProdutoID");

            migrationBuilder.RenameColumn(
                name: "LojaId",
                table: "Cupom",
                newName: "LojaID");

            migrationBuilder.RenameIndex(
                name: "IX_Cupom_UsuarioId",
                table: "Cupom",
                newName: "IX_Cupom_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Cupom_ProdutoId",
                table: "Cupom",
                newName: "IX_Cupom_ProdutoID");

            migrationBuilder.RenameIndex(
                name: "IX_Cupom_LojaId",
                table: "Cupom",
                newName: "IX_Cupom_LojaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cupom_Loja_LojaID",
                table: "Cupom",
                column: "LojaID",
                principalTable: "Loja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cupom_Produto_ProdutoID",
                table: "Cupom",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cupom_Usuario_UsuarioID",
                table: "Cupom",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
