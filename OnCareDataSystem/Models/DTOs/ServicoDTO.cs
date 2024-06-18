using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.DTOs
{
    public class ServicoDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Preco { get; set; }
    }
}
