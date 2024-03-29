﻿using Microsoft.EntityFrameworkCore;
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
                .HasForeignKey<PerguntaSelecionadaPaciente>(pspc => pspc.PacienteId);

            builder
                .Property(pspc => pspc.ClassificacaoPacienteId)
                .HasColumnName("ClassificacaoPacienteId");

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
