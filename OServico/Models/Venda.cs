using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OServico.Models
{
    public class Venda
    {

        [Key]
        public int IdVenda { get; set; }

        [Display(Name = "Data da Venda")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataVenda { get; set; }

        [StringLength(100)]
        [Display(Name = "Cliente")]
        [Required]
        public string Cliente { get; set; }

        [StringLength(100)]
        [Display(Name = "Vendedor")]
        [Required]
        public string Vendedor { get; set; }
    }
}