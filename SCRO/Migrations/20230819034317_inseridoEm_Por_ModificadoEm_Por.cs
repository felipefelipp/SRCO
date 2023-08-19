using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class inseridoEm_Por_ModificadoEm_Por : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "Responsavel",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "Responsavel",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "Responsavel",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "Responsavel",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "InseridoEm",
                table: "Paciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "InseridoPor",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificadoEm",
                table: "Paciente",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "ModificadoPor",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValueSql: "1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "InseridoEm",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "InseridoPor",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "ModificadoEm",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "Paciente");
        }
    }
}
