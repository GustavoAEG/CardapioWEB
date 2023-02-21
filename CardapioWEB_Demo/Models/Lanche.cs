namespace CardapioWEB_Demo.Models
{
    public class Lanche
    {
        public int lancheID { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImageUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        //Definir relacionamento entre lanche e categoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
