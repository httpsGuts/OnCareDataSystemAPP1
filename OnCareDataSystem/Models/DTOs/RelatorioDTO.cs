﻿using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.DTOs
{
    public class RelatorioDTO
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public DateTime DataFim { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        public string Conteudo { get; set; }
    }

}
