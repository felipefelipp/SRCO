using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCRO.Models.Classificacao;

namespace SCRO.SCRO.Models.Data.Configuracao
{
    public class RespostaSelecionadaPacienteConfiguration : IEntityTypeConfiguration<RespostaSelecionadaPaciente>
    {
        public void Configure(EntityTypeBuilder<RespostaSelecionadaPaciente> builder)
        {
            builder
                .ToTable("RespostaSelecionadaPaciente");

            builder
                .Property(rspc => rspc.RespostaSelecionadaPacienteId)
                .HasColumnName("RespostaSelecionadaPacienteId");

            builder
                .Property(rspc => rspc.ValorRespostaTexto)
                .HasColumnName("ValorRespostaTexto")
                .HasColumnType("varchar(100)")
                .IsRequired(false);

            builder
                .Property(rspc => rspc.ValorRespostaTextoArea)
                .HasColumnName("ValorRespostaTexto")
                .HasColumnType("varchar(max)")
                .IsRequired(false);

            builder
                .HasOne(rspc => rspc.Paciente)
                .WithOne(p => p.RespostaSelecionadaPaciente)
                .HasForeignKey<RespostaSelecionadaPaciente>(rspc => rspc.PacienteId);

            builder
                 .Property(rspc => rspc.ClassificacaoPacienteId)
                 .HasColumnName("ClassificacaoPacienteId");
        }

    }
}
