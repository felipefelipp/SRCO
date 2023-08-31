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
                .Property(c => c.ClassificacaoPacienteId)
                .HasColumnName("ClassificacaoPacienteId");
            
        }
    }
}
