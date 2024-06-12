using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.Entities
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome completo deve ter no máximo 100 caracteres.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "O sexo é obrigatório.")]
        [EnumDataType(typeof(Sexo), ErrorMessage = "O sexo é inválido.")]
        public Sexo Sexo { get; set; }

        [Required(ErrorMessage = "O contato familiar 1 é obrigatório.")]
        [Phone(ErrorMessage = "O número de telefone é inválido.")]
        public string ContatoFamiliar1 { get; set; }

        [Phone(ErrorMessage = "O número de telefone é inválido.")]
        public string ContatoFamiliar2 { get; set; }

        [Required(ErrorMessage = "A empresa responsável é obrigatória.")]
        public string EmpresaResponsavel { get; set; }

        public string EscalistaResponsavel { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser maior ou igual a zero.")]
        public decimal? Valor { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser maior ou igual a zero.")]
        public decimal? Repasse { get; set; }

        // Relações:
        public List<Endereco> ListEnderecos { get; set; }
        
        // Rodapé:
        [Required(ErrorMessage = "O criador é obrigatório.")]
        public string CriadoPor { get; set; }

        public string AlteradoPor { get; set; }

        public DateTime DataCriado { get; set; }

        public DateTime? DataAlterado { get; set; }
    }

   
}
