using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class Inserido_Por_Em_Modificado_Por_Em_Resposta_Selecionada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ValorRespostaTextoArea",
                table: "RespostaSelecionadaPaciente",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ValorRespostaTexto",
                table: "RespostaSelecionadaPaciente",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "RespostaSelecionadaPaciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "RespostaSelecionadaPaciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "RespostaSelecionadaPaciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "RespostaSelecionadaPaciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "RespostaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "RespostaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "RespostaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "RespostaSelecionadaPaciente");

            migrationBuilder.AlterColumn<string>(
                name: "ValorRespostaTextoArea",
                table: "RespostaSelecionadaPaciente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ValorRespostaTexto",
                table: "RespostaSelecionadaPaciente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);
        }
    }
}
