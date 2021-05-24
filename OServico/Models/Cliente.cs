using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OServico.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [StringLength(100)]
        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Column("CPFCNPJ")]
        [Display(Name = "CPFCNPJ ")]
        [Required]
        public int Cpf { get; set; }

        [StringLength(14)]
        [Required]
        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [StringLength(14)]
        [Required]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [StringLength(60)]
        [Required]
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [StringLength(2)]
        [Required]
        public string Estado { get; set; }

        [StringLength(8)]
        [Column("CEP")]
        [Display(Name = "CEP")]
        [Required]
        public int Cep { get; set; }
    }
}