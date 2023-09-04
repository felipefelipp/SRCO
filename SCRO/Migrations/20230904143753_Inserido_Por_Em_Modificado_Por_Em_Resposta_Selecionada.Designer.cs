﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCRO.SCRO.Models.Data.Contexto;

#nullable disable

namespace SCRO.Migrations
{
    [DbContext(typeof(SCROContext))]
    [Migration("20230904143753_Inserido_Por_Em_Modificado_Por_Em_Resposta_Selecionada")]
    partial class Inserido_Por_Em_Modificado_Por_Em_Resposta_Selecionada
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SCRO.Models.Classificacao.CategoriaPergunta", b =>
                {
                    b.Property<int>("CategoriaPerguntaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoriaPerguntaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaPerguntaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Descricao");

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<int>("PerguntaId")
                        .HasColumnType("int");

                    b.HasKey("CategoriaPerguntaId");

                    b.HasIndex("PerguntaId")
                        .IsUnique();

                    b.ToTable("CategoriaPergunta", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.ClassificacaoPaciente", b =>
                {
                    b.Property<int>("ClassificacaoPacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClassificacaoPacienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassificacaoPacienteId"));

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("ResultadoClassificacaoCor")
                        .HasColumnType("int");

                    b.Property<int>("ResultadoCor")
                        .HasColumnType("int")
                        .HasColumnName("ValorResultadoCor");

                    b.Property<int>("ValorResultadoClassificacao")
                        .HasColumnType("int")
                        .HasColumnName("ValorResultadoClassificacao");

                    b.HasKey("ClassificacaoPacienteId");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("ClassificacaoPaciente", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.Pergunta", b =>
                {
                    b.Property<int>("PerguntaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PerguntaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerguntaId"));

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<string>("TextoPergunta")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("DescricaoPergunta");

                    b.HasKey("PerguntaId");

                    b.ToTable("Pergunta", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.PerguntaSelecionadaPaciente", b =>
                {
                    b.Property<int>("PerguntaSelecionadaPacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PerguntaSelecionadaPacienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerguntaSelecionadaPacienteId"));

                    b.Property<int>("ClassificacaoPacienteId")
                        .HasColumnType("int")
                        .HasColumnName("ClassificacaoPacienteId");

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("PerguntaId")
                        .HasColumnType("int")
                        .HasColumnName("PerguntaId");

                    b.HasKey("PerguntaSelecionadaPacienteId");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.HasIndex("PerguntaId")
                        .IsUnique();

                    b.ToTable("PerguntaSelecionadaPaciente", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.Resposta", b =>
                {
                    b.Property<int>("RespostaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RespostaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RespostaId"));

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<string>("RespostaCheckBox")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("RespostaCheckBox");

                    b.Property<string>("RespostaComboBox")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("RespostaComboBox");

                    b.Property<DateTime?>("RespostaData")
                        .HasColumnType("Datetime")
                        .HasColumnName("RespostaData");

                    b.Property<string>("RespostaRadioButtom")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("RespostaRadioButtom");

                    b.Property<bool>("RespostaTexto")
                        .HasColumnType("bit")
                        .HasColumnName("RespostaTexto");

                    b.Property<bool>("RespostaTextoArea")
                        .HasColumnType("bit")
                        .HasColumnName("RespostaTextoArea");

                    b.Property<int>("ValorResposta")
                        .HasColumnType("int")
                        .HasColumnName("ValorResposta");

                    b.Property<int>("ValorTipoResposta")
                        .HasColumnType("int")
                        .HasColumnName("ValorTipoResposta");

                    b.HasKey("RespostaId");

                    b.ToTable("Resposta", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.RespostaSelecionadaPaciente", b =>
                {
                    b.Property<int>("RespostaSelecionadaPacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RespostaSelecionadaPacienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RespostaSelecionadaPacienteId"));

                    b.Property<int>("ClassificacaoPacienteId")
                        .HasColumnType("int")
                        .HasColumnName("ClassificacaoPacienteId");

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("RespostaId")
                        .HasColumnType("int");

                    b.Property<string>("ValorRespostaTexto")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ValorRespostaTexto");

                    b.Property<string>("ValorRespostaTextoArea")
                        .HasColumnType("varchar(max)")
                        .HasColumnName("ValorRespostaTextoArea");

                    b.HasKey("RespostaSelecionadaPacienteId");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("RespostaSelecionadaPaciente", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Cliente.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PacienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("bairro");

                    b.Property<int>("CEP")
                        .HasColumnType("int")
                        .HasColumnName("cep");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("celular");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("idade");

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("municipio");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("profissao");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("rg");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("rua");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .HasColumnName("sexo");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("telefone");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("PacienteId");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("Celular")
                        .IsUnique();

                    b.ToTable("Paciente", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Cliente.Responsavel", b =>
                {
                    b.Property<int?>("ResponsavelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ResponsavelId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ResponsavelId"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("celular");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("idade");

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("rg");

                    b.HasKey("ResponsavelId");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("Celular")
                        .IsUnique();

                    b.HasIndex("PacienteId")
                        .IsUnique()
                        .HasFilter("[PacienteId] IS NOT NULL");

                    b.ToTable("Responsavel", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Funcionario.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("COREN")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("coren");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("crm");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("celular");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("idade");

                    b.Property<DateTime>("InseridoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("InseridoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("ModificadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ModificadoPor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("rg");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("senha");

                    b.HasKey("UsuarioId");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("Celular")
                        .IsUnique();

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.CategoriaPergunta", b =>
                {
                    b.HasOne("SCRO.Models.Classificacao.Pergunta", "Pergunta")
                        .WithOne("Categoria")
                        .HasForeignKey("SCRO.Models.Classificacao.CategoriaPergunta", "PerguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pergunta");
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.ClassificacaoPaciente", b =>
                {
                    b.HasOne("SCRO.Models.Cliente.Paciente", "Paciente")
                        .WithOne("ClassificacaoPaciente")
                        .HasForeignKey("SCRO.Models.Classificacao.ClassificacaoPaciente", "PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.PerguntaSelecionadaPaciente", b =>
                {
                    b.HasOne("SCRO.Models.Cliente.Paciente", "Paciente")
                        .WithOne("PerguntaSelecionadaPaciente")
                        .HasForeignKey("SCRO.Models.Classificacao.PerguntaSelecionadaPaciente", "PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SCRO.Models.Classificacao.Pergunta", null)
                        .WithOne("PerguntaSelecionadaPaciente")
                        .HasForeignKey("SCRO.Models.Classificacao.PerguntaSelecionadaPaciente", "PerguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.RespostaSelecionadaPaciente", b =>
                {
                    b.HasOne("SCRO.Models.Cliente.Paciente", "Paciente")
                        .WithOne("RespostaSelecionadaPaciente")
                        .HasForeignKey("SCRO.Models.Classificacao.RespostaSelecionadaPaciente", "PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SCRO.Models.Cliente.Responsavel", b =>
                {
                    b.HasOne("SCRO.Models.Cliente.Paciente", "Paciente")
                        .WithOne("Responsavel")
                        .HasForeignKey("SCRO.Models.Cliente.Responsavel", "PacienteId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SCRO.Models.Classificacao.Pergunta", b =>
                {
                    b.Navigation("Categoria")
                        .IsRequired();

                    b.Navigation("PerguntaSelecionadaPaciente")
                        .IsRequired();
                });

            modelBuilder.Entity("SCRO.Models.Cliente.Paciente", b =>
                {
                    b.Navigation("ClassificacaoPaciente")
                        .IsRequired();

                    b.Navigation("PerguntaSelecionadaPaciente")
                        .IsRequired();

                    b.Navigation("Responsavel");

                    b.Navigation("RespostaSelecionadaPaciente")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
