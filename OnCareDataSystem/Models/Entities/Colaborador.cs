using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnCareDataSystem.Models.Entities
{
    public class Colaborador
    {
        // Id do Colaborador :
        [Key]
        public int Id { get; set; }

        //Dados Pessoais:

        [StringLength(50)]
        public string? Nome { get; set; }

        [StringLength(100)]
        public string? Sobrenome { get; set; }

        [Required(ErrorMessage = "O sexo é obrigatório.")]
        [EnumDataType(typeof(Sexo), ErrorMessage = "O sexo é inválido.")]
        public Sexo Sexo { get; set; }

        // Contatos:
        [StringLength(15)]
        public string? Contato1 { get; set; }

        [StringLength(15)]
        public string? Contato2 { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(16)]
        public string? Senha { get; set; }

        // Relacionamento com Imagem:
        public List<Imagem> ListImagem { get; set; }
        public List<Endereco> listEndereco { get; set; }
        public List<Profissao> ListProfissao { get; set; }

        // Rodapé:
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime ExpedicaoRG { get; set; }
        public DateTime UltimaVisita { get; set; }
        public DateTime DataNascimento { get; set; }
    }
    public enum Sexo
    {
        Masculino,
        Feminino,
        Outro
    }
}
