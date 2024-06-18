using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.DTOs
{
    public class EnderecoDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(100)]
        public string Complemento { get; set; }

        [Required]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

        [Required]
        [StringLength(8)]
        [RegularExpression(@"^\d{5}-\d{3}$")]
        public string CEP { get; set; }
    }

}
