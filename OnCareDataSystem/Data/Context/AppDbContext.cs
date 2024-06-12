using Microsoft.EntityFrameworkCore;
using OnCareDataSystem.Models.Entities;

namespace OnCareDataSystem.Data.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Imagem> Imagens { get; set; }

    }
}
