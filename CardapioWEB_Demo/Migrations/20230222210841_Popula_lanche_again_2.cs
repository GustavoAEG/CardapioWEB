using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardapioWEB_Demo.Migrations
{
    /// <inheritdoc />
    public partial class Popula_lanche_again_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageUrl,ImagemThumbnailUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Batata frita normal','Porção de altíssima qualidade',1,' https://images.tcdn.com.br/img/img_prod/341142/caixinha_embalagem_para_batata_frita_e_porcoes_tamanho_pequeno_1000un_1218_1_20180306115417.jpg',' https://images.tcdn.com.br/img/img_prod/341142/caixinha_embalagem_para_batata_frita_e_porcoes_tamanho_pequeno_1000un_1218_1_20180306115417.jpg',0, 'Batata Frita',19.90)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
