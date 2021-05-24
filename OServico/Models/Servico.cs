using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OServico.Models
{
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }

        [StringLength(100)]
        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [StringLength(100)]
        [Display(Name = "Descrição")]
        [Required]
        public string Descricao { get; set; }
    }
}