//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCRO.SCRO.Models.Classificacao;

//namespace SCRO.SCRO.Models.Data.Configuracao
//{
//    public class PerguntaSelecionadaConfiguration : IEntityTypeConfiguration<PerguntaSelecionada>
//    {
//        public void Configure(EntityTypeBuilder<PerguntaSelecionada> builder)
//        {
//            builder
//                .ToTable("PerguntaSelecionada");

//            builder
//                .Property(psc => psc.PerguntaSelecionadaId)
//                .HasColumnName("PerguntaSelecionadaId");

//            builder
//                .HasMany(psc => psc.Perguntas)
//                .WithOne(p => p.PerguntaSelecionada);
//        }
//    }
//}
