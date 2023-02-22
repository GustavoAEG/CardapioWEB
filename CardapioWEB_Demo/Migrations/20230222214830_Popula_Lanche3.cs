using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardapioWEB_Demo.Migrations
{
    /// <inheritdoc />
    public partial class Popula_Lanche3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Batata frita normal','Porção de altíssima qualidade',1,' https://t2.uc.ltmcdn.com/pt/posts/6/3/3/como_fazer_massa_de_pastel_9336_600_square.jpg',' https://t2.uc.ltmcdn.com/pt/posts/6/3/3/como_fazer_massa_de_pastel_9336_600_square.jpg',0, 'Pastel',9.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Batata frita normal','Porção de altíssima qualidade',1,' https://formaggiomineiro.com.br/wp-content/uploads/2014/07/IMG_9405-e1471980631986.jpeg',' https://formaggiomineiro.com.br/wp-content/uploads/2014/07/IMG_9405-e1471980631986.jpeg',0, 'Pão de Queijo',12.00)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
