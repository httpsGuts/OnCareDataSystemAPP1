using System;
using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.DTOs
{
    public class PessoaDTO
    {
        // Identificador da Pessoa
        public int Id { get; set; }

        // Dados Pessoais
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O Nome pode ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Sobrenome é obrigatório")]
        [StringLength(50, ErrorMessage = "O Sobrenome pode ter no máximo 50 caracteres")]
        public string Sobrenome { get; set; }

        [StringLength(20, ErrorMessage = "O RG pode ter no máximo 20 caracteres")]
        public string RG { get; set; }

        [StringLength(14, ErrorMessage = "O CPF pode ter no máximo 14 caracteres")]
        public string CPF { get; set; }

        [StringLength(100, ErrorMessage = "O Nome da Mãe pode ter no máximo 100 caracteres")]
        public string NomeMae { get; set; }

        // Dados de Contato
        [Required(ErrorMessage = "O Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Telefone principal é obrigatório")]
        [Phone(ErrorMessage = "Telefone em formato inválido")]
        [StringLength(15, ErrorMessage = "O Telefone principal pode ter no máximo 15 caracteres")]
        public string Telefone1 { get; set; }

        [Phone(ErrorMessage = "Telefone em formato inválido")]
        [StringLength(15, ErrorMessage = "O Telefone secundário pode ter no máximo 15 caracteres")]
        public string Telefone2 { get; set; }

        // Dados de Trabalho
        [Required(ErrorMessage = "A Profissão é obrigatória")]
        [StringLength(100, ErrorMessage = "A Profissão pode ter no máximo 100 caracteres")]
        public string Profissao { get; set; }

        [StringLength(20, ErrorMessage = "O Número de Registro pode ter no máximo 20 caracteres")]
        public string NumRegistro { get; set; }

        [StringLength(50, ErrorMessage = "A Especialidade pode ter no máximo 50 caracteres")]
        public string Especialidade { get; set; }

        // Datas
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A Data de Nascimento é obrigatória")]
        public DateTime Nascimento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ExpRG { get; set; }

        [DataType(DataType.Date)]
        public DateTime? VenRegistro { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataCriado { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime DataAlterado { get; set; } = DateTime.Now;
    }
}
