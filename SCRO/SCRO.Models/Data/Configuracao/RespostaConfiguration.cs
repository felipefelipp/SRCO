﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCRO.Models.Classificacao;

namespace SCRO.SCRO.Models.Data.Configuracao
{
    public class RespostaConfiguration : IEntityTypeConfiguration<Resposta>
    {
        public void Configure(EntityTypeBuilder<Resposta> builder)
        {
            builder
                .ToTable("Resposta");

            builder
                .Property(r => r.RespostaId)
                .HasColumnName("RespostaId");

            builder
                .Property(r => r.RespostaTexto)
                .HasColumnName("RespostaTexto")
                .HasColumnType("varchar(100)");

            builder
                .Property(r => r.RespostaTextoArea)
                .HasColumnName("RespostaTextoArea")
                .HasColumnType("varchar(max)");

            builder
                .Property(r => r.RespostaCheckBox)
                .HasColumnName("RespostaCheckBox")
                .HasColumnType("varchar(100)");

            builder
                .Property(r => r.RespostaComboBox)
                .HasColumnName("RespostaComboBox")
                .HasColumnType("varchar(100)");

            builder
                .Property(r => r.RespostaRadioButtom)
                .HasColumnName("RespostaRadioButtom")
                .HasColumnType("varchar(100)");

            builder
                .Property(r => r.RespostaData)
                .HasColumnName("RespostaData")
                .HasColumnType("Datetime");

            builder
                .Property(r => r.ValorTipoResposta)
                .HasColumnName("ValorTipoResposta");

            builder
                .Property(r => r.ValorResposta)
                .HasColumnName("ValorResposta");

            builder
                .Ignore(r => r.TipoResposta);
        }
    }
}