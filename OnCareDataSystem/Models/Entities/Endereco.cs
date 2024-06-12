using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.Entities
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Rua { get; set; }

        [StringLength(10)]
        public string? Numero { get; set; }

        [StringLength(50)]
        public string? Bairro { get; set; }

        [StringLength(50)]
        public string? Cidade { get; set; }

        [StringLength(2)]
        public string? Estado { get; set; }

        [StringLength(8)]
        public string? CEP { get; set; }

        public int? PessoaId { get; set; } // Id do Colaborador ou do Paciente
        public string? PessoaNome { get; set; } // Nome do Colaborador ou do Paciente
    }
}