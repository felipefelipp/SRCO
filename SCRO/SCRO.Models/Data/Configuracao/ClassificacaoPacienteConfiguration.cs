using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCRO.Models.Classificacao;

namespace SCRO.SCRO.Models.Data.Configuracao
{
    public class ClassificacaoPacienteConfiguration : IEntityTypeConfiguration<ClassificacaoPaciente>
    {
        public void Configure(EntityTypeBuilder<ClassificacaoPaciente> builder)
        {
            builder
                .ToTable("ClassificacaoPaciente");

            builder
                .Property(cpc => cpc.ClassificacaoPacienteId)
                .HasColumnName("ClassificacaoPacienteId");

            builder
                .HasOne(cpc => cpc.Paciente)
                .WithOne(p => p.ClassificacaoPaciente)
                .HasForeignKey<ClassificacaoPaciente>(cp => cp.PacienteId);

            builder
                .Property(cpc => cpc.ValorResultadoClassificacao)
                .HasColumnName("ValorResultadoClassificacao");

            builder
                .Property(cpc => cpc.ResultadoCor)
                .HasColumnName("ValorResultadoCor");

        }
    }
}
