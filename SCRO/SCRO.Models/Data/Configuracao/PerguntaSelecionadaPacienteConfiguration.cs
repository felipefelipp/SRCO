using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCRO.Models.Classificacao;

namespace SCRO.SCRO.Models.Data.Configuracao
{
    public class PerguntaSelecionadaPacienteConfiguration : IEntityTypeConfiguration<PerguntaSelecionadaPaciente>
    {
        public void Configure(EntityTypeBuilder<PerguntaSelecionadaPaciente> builder)
        {
            builder
                .ToTable("PerguntaSelecionadaPaciente");

            builder
                .Property(pspc => pspc.PerguntaSelecionadaPacienteId)
                .HasColumnName("PerguntaSelecionadaPacienteId");

            builder
                .Property(pspc => pspc.PerguntaId)
                .HasColumnName("PerguntaId");

            builder
                .HasOne(pspc => pspc.Paciente)
                .WithOne(p => p.PerguntaSelecionadaPaciente)
                .HasForeignKey<PerguntaSelecionadaPaciente>("PacienteId");
                
        }
    }
}
