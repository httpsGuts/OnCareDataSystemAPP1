using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnCareDataSystem.Models.Entities
{
    public class Profissao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da profissão é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome da profissão deve ter no máximo 100 caracteres.")]
        public string NomeProfissao { get; set; }

        [StringLength(20, ErrorMessage = "O registro deve ter no máximo 20 caracteres.")]
        public string NumRegistro { get; set; }

        [DisplayName("Vencimento do Registro")]
        [Required(ErrorMessage = "O vencimento do registro é obrigatório.")]
        public DateTime VenRegistro { get; set; }

        [Required(ErrorMessage = "O setor de saúde é obrigatório.")]
        public SetorSaude Setor { get; set; }

        // Propriedade de navegação para Colaborador
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
    }

    public enum SetorSaude
    {
        Medico,
        Enfermeiro,
        TecEnfermagem,
        AuxEnfermagem,
        Fisioterapeuta,
        Psicologo,
        Nutricionista,
        TecnicoEnfermagem,
        AssistenteSocial,
        TerapeutaOcupacional,
        Farmaceutico,
        Outros
    }
}
