using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardapioWEB_Demo.Migrations
{
    /// <inheritdoc />
    public partial class Popula_lanche_again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, Bacon, ovo, presunto, queijo e batata palha','Pão de hambúrger; presunto e queijo de 1a qualidade',1,'https://www.macoratti.net/Imagens/lanches/cheesesalada.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada.jpg',0,'Cheese Bacon',16.50)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
