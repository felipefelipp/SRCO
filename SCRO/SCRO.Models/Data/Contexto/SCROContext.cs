using Microsoft.EntityFrameworkCore;
using SCRO.Models.Cliente;
using SCRO.Models.Funcionario;
using SCRO.Models.Classificacao;
using SCRO.SCRO.Models.Data.Configuracao;

namespace SCRO.SCRO.Models.Data.Contexto
{
    public class SCROContext : DbContext
    {

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<CategoriaPergunta> CategoriaPerguntas { get; set; }
        public DbSet<PerguntaSelecionadaPaciente> PerguntaSelecionadaPacientes { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<RespostaSelecionadaPaciente> RespostaSelecionadaPaciente { get; set; }
        public DbSet<ClassificacaoPaciente> Classificacoes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SCRO;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration(new ResponsavelConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PerguntaConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaPerguntaConfiguration());
            modelBuilder.ApplyConfiguration(new RespostaConfiguration());
            modelBuilder.ApplyConfiguration(new PerguntaSelecionadaPacienteConfiguration());    
            modelBuilder.ApplyConfiguration(new ClassificacaoPacienteConfiguration());
            modelBuilder.ApplyConfiguration(new RespostaSelecionadaPacienteConfiguration());
        }

    }
}
