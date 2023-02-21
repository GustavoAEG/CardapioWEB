namespace CardapioWEB_Demo.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Relacionamento de 1 pra muitos N
        public List<Lanche> Lanches { get; set; }
    }
}
