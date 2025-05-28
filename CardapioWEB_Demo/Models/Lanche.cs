﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWEB_Demo.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int lancheID { get; set; }
        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
   
        [Display(Name = "Nome do lanche")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição do lanche deve ser informado")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(5, ErrorMessage = " Descrição deve tetr no minimo {1} caracteres")]
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = "A descrição do lanche deve ser informado")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = " Descrição deve tetr no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preco")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }
        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        //Definir relacionamento entre lanche e categoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
