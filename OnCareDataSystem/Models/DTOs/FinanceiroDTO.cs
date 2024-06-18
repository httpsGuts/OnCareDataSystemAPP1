using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.DTOs
{
    public class FinanceiroDTO
    {
        public int Id { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Valor { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
    }

}
