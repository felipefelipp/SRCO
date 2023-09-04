using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class Inserido_Por_Em_Modificado_Por_Em : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResultadoCor",
                table: "ClassificacaoPaciente",
                newName: "ValorResultadoCor");

            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "Resposta",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "Resposta",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "Resposta",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "Resposta",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "PerguntaSelecionadaPaciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "PerguntaSelecionadaPaciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "PerguntaSelecionadaPaciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "PerguntaSelecionadaPaciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "Pergunta",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "Pergunta",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "Pergunta",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "Pergunta",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "ClassificacaoPaciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "ClassificacaoPaciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "ClassificacaoPaciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "ClassificacaoPaciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "CategoriaPergunta",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "CategoriaPergunta",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "CategoriaPergunta",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "CategoriaPergunta",
                type: "int",
                nullable: false,
                defaultValueSql: "1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "Resposta");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "Resposta");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "Resposta");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "Resposta");

            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "PerguntaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "PerguntaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "PerguntaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "PerguntaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "Pergunta");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "Pergunta");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "Pergunta");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "Pergunta");

            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "ClassificacaoPaciente");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "ClassificacaoPaciente");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "ClassificacaoPaciente");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "ClassificacaoPaciente");

            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "CategoriaPergunta");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "CategoriaPergunta");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "CategoriaPergunta");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "CategoriaPergunta");

            migrationBuilder.RenameColumn(
                name: "ValorResultadoCor",
                table: "ClassificacaoPaciente",
                newName: "ResultadoCor");
        }
    }
}
