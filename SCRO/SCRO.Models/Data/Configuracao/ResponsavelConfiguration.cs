using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCRO.Models.Cliente;

namespace SCRO.SCRO.Models.Data
{
    public class ResponsavelConfiguration : PessoaConfiguration<Responsavel>
    {
        public override void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("Responsavel");

            builder
                .Property(r => r.ResponsavelId)
                .HasColumnName("ResponsavelId");

            builder
                .HasKey(r => r.ResponsavelId);  

                
        }
    }
}
