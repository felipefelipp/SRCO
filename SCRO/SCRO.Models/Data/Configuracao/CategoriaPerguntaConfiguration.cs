using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCRO.Models.Classificacao;

namespace SCRO.SCRO.Models.Data.Configuracao
{
    public class CategoriaPerguntaConfiguration : IEntityTypeConfiguration<CategoriaPergunta>
    {
        public void Configure(EntityTypeBuilder<CategoriaPergunta> builder)
        {
            builder
                .ToTable("CategoriaPergunta");

            builder
                .Property(cp => cp.CategoriaPerguntaId)
                .HasColumnName("CategoriaPerguntaId");

            builder
                .Property(cp => cp.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .HasOne(cp => cp.Pergunta)
                .WithOne(p => p.Categoria)
                .HasForeignKey<CategoriaPergunta>(cp => cp.PerguntaId)
                .IsRequired();

        }
    }
}
