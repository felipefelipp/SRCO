using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class Resposta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resposta",
                columns: table => new
                {
                    RespostaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RespostaTexto = table.Column<string>(type: "varchar(100)", nullable: false),
                    RespostaTextoArea = table.Column<string>(type: "varchar(max)", nullable: false),
                    RespostaCheckBox = table.Column<string>(type: "varchar(100)", nullable: false),
                    RespostaComboBox = table.Column<string>(type: "varchar(100)", nullable: false),
                    RespostaRadioButtom = table.Column<string>(type: "varchar(100)", nullable: false),
                    RespostaData = table.Column<DateTime>(type: "Datetime", nullable: true),
                    ValorTipoResposta = table.Column<int>(type: "int", nullable: false),
                    ValorResposta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resposta", x => x.RespostaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resposta");
        }
    }
}
