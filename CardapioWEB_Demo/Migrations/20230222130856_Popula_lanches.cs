using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardapioWEB_Demo.Migrations
{
    /// <inheritdoc />
    public partial class Popula_lanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger,ovo, presunto, queijo e batata palha','Pão de hambúrger; presunto e queijo de 1a qualidade',1,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',0,'Cheese Salada',12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pão, hambúrger,ovo, presunto, queijo e batata palha','Pão de hambúrger; presunto e queijo de 1a qualidade',1,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',1,'Cheese Salada',12.50)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
