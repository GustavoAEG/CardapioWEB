﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
{
    public class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public virtual Lanche Lanche { get; set; }
    }
}