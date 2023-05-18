using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWEB_Demo.Models
{
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }//o  ED identifica Id como PK
        public Lanche Lanche { get; set; }//O EF vai identificar que será uma chave estrangeira
        public int Quantidade { get; set; }
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
