﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCRO.Models.Classificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.SCRO.Models.Data.Configuracao
{
    public class PerguntaConfiguration : IEntityTypeConfiguration<Pergunta>
    {
        public void Configure(EntityTypeBuilder<Pergunta> builder)
        {
            builder
                .ToTable("Pergunta");

            builder
                .Property(p => p.PerguntaId)
                .HasColumnName("PerguntaId");

            builder
                .Property(p => p.TextoPergunta)
                .HasColumnName("DescricaoPergunta")
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
               .Property<DateTime>("InseridoEm")
               .HasColumnType("datetime")
               .HasDefaultValueSql("getdate()");

            builder
                .Property<int>("InseridoPor")
                .HasColumnType("int")
                .HasDefaultValueSql("1"); //Implementar inserido por usuário X ou Y

            builder
                .Property<DateTime>("ModificadoEm")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()"); //Implementar modificado em 

            builder
                .Property<int>("ModificadoPor")
                .HasColumnType("int")
                .HasDefaultValueSql("1"); //Implementar usuário que modificou 

        }
    }
}
