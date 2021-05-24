using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OServico.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [StringLength(100)]
        [Display(Name = "Descrição")]
        [Required]
        public string Descricao { get; set; }

        [Required]
        public int Unidade { get; set; }

        [Display(Name = "Preço de Compra")]
        public decimal PrecoCompra { get; set; }

        [Display(Name = "Preço de Venda")]
        public decimal PrecoVenda { get; set; }

        [Display(Name = "Estoque Atual ")]
        [Required]
        public int EstoqueAtual { get; set; }

        [Display(Name = "Estoque Minimo")]
        [Required]
        public int EstoqueMinimo { get; set; }
    }
}