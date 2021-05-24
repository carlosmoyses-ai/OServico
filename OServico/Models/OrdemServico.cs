using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OServico.Models
{
    public class OrdemServico
    {
        [Key]
        public int OrdemServicoId { get; set; }

        [StringLength(100)]
        [Display(Name = "Cliente")]
        [Required]
        public string Cliente { get; set; }

        [StringLength(100)]
        [Display(Name = "Técnico/Responsável")]
        [Required]
        public string Tecnico { get; set; }

        [Required]
        public int status { get; set; }

        [Display(Name = "Data Inicial")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataInicial { get; set; }

        [Display(Name = "Data Final")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataFinal { get; set; }

        [StringLength(100)]
        [Required]
        public string Garantia { get; set; }

        [StringLength(300)]
        [Display(Name = "Descrição Produto/Serviço")]
        [Required]
        public string DescriçãoServico { get; set; }

        [StringLength(200)]
        [Required]
        public string Defeito { get; set; }

        [StringLength(200)]
        [Display(Name = "Observações")]
        [Required]
        public string Observacoes { get; set; }

        [StringLength(200)]
        [Display(Name = "Laudo Técnico")]
        [Required]
        public string LaudoTecnico { get; set; }
    }
}