using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Backend.Migrations
{
    public partial class Deploy2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanhas_Instituicaos_Fk_campanha_instituicao",
                table: "Campanhas");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Campanhas_Fk_estoque_campanha",
                table: "Estoques");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Produtos_Fk_estoque_produto",
                table: "Estoques");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituicaos_Usuarios_Fk_instituicao_usuario",
                table: "Instituicaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_Fk_produto_categoria",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_Fk_produto_categoria",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Instituicaos_Fk_instituicao_usuario",
                table: "Instituicaos");

            migrationBuilder.DropIndex(
                name: "IX_Estoques_Fk_estoque_campanha",
                table: "Estoques");

            migrationBuilder.DropIndex(
                name: "IX_Estoques_Fk_estoque_produto",
                table: "Estoques");

            migrationBuilder.DropIndex(
                name: "IX_Campanhas_Fk_campanha_instituicao",
                table: "Campanhas");

            migrationBuilder.DropColumn(
                name: "Fk_produto_categoria",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Fk_instituicao_usuario",
                table: "Instituicaos");

            migrationBuilder.DropColumn(
                name: "Fk_estoque_campanha",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "Fk_estoque_produto",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "Fk_campanha_instituicao",
                table: "Campanhas");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Instituicaos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampanhaId",
                table: "Estoques",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Estoques",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Campanhas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicaos_UsuarioId",
                table: "Instituicaos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_CampanhaId",
                table: "Estoques",
                column: "CampanhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ProdutoId",
                table: "Estoques",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Campanhas_InstituicaoId",
                table: "Campanhas",
                column: "InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campanhas_Instituicaos_InstituicaoId",
                table: "Campanhas",
                column: "InstituicaoId",
                principalTable: "Instituicaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Campanhas_CampanhaId",
                table: "Estoques",
                column: "CampanhaId",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Produtos_ProdutoId",
                table: "Estoques",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicaos_Usuarios_UsuarioId",
                table: "Instituicaos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanhas_Instituicaos_InstituicaoId",
                table: "Campanhas");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Campanhas_CampanhaId",
                table: "Estoques");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Produtos_ProdutoId",
                table: "Estoques");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituicaos_Usuarios_UsuarioId",
                table: "Instituicaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Instituicaos_UsuarioId",
                table: "Instituicaos");

            migrationBuilder.DropIndex(
                name: "IX_Estoques_CampanhaId",
                table: "Estoques");

            migrationBuilder.DropIndex(
                name: "IX_Estoques_ProdutoId",
                table: "Estoques");

            migrationBuilder.DropIndex(
                name: "IX_Campanhas_InstituicaoId",
                table: "Campanhas");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Instituicaos");

            migrationBuilder.DropColumn(
                name: "CampanhaId",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Campanhas");

            migrationBuilder.AddColumn<int>(
                name: "Fk_produto_categoria",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fk_instituicao_usuario",
                table: "Instituicaos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fk_estoque_campanha",
                table: "Estoques",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fk_estoque_produto",
                table: "Estoques",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fk_campanha_instituicao",
                table: "Campanhas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Fk_produto_categoria",
                table: "Produtos",
                column: "Fk_produto_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicaos_Fk_instituicao_usuario",
                table: "Instituicaos",
                column: "Fk_instituicao_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_Fk_estoque_campanha",
                table: "Estoques",
                column: "Fk_estoque_campanha");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_Fk_estoque_produto",
                table: "Estoques",
                column: "Fk_estoque_produto");

            migrationBuilder.CreateIndex(
                name: "IX_Campanhas_Fk_campanha_instituicao",
                table: "Campanhas",
                column: "Fk_campanha_instituicao");

            migrationBuilder.AddForeignKey(
                name: "FK_Campanhas_Instituicaos_Fk_campanha_instituicao",
                table: "Campanhas",
                column: "Fk_campanha_instituicao",
                principalTable: "Instituicaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Campanhas_Fk_estoque_campanha",
                table: "Estoques",
                column: "Fk_estoque_campanha",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Produtos_Fk_estoque_produto",
                table: "Estoques",
                column: "Fk_estoque_produto",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicaos_Usuarios_Fk_instituicao_usuario",
                table: "Instituicaos",
                column: "Fk_instituicao_usuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_Fk_produto_categoria",
                table: "Produtos",
                column: "Fk_produto_categoria",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
