using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.Entities
{
    public class Imagem
    {
        [Key]
        public int Id { get; set; }

        public int ColaboradorId { get; set; } // ID do Colaborador relacionado

        [Url(ErrorMessage = "A URL da imagem é inválida.")]
        [StringLength(255)]
        public string? UrlRG { get; set; } // Caminho para a imagem do RG

        [Url(ErrorMessage = "A URL da imagem é inválida.")]
        [StringLength(255)]
        public string? UrlCPF { get; set; } // Caminho para a imagem do CPF

        [Url(ErrorMessage = "A URL da imagem é inválida.")]
        [StringLength(255)]
        public string? UrlRegistro { get; set; } // Caminho para a imagem do Registro

        [Url(ErrorMessage = "A URL da imagem é inválida.")]
        [StringLength(255)]
        public string? UrlEndereco { get; set; } // Caminho para a imagem do Comprovante de Endereço
    }
}
