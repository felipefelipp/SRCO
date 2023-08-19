using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class Add_Usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    rg = table.Column<string>(type: "varchar(8)", nullable: false),
                    celular = table.Column<string>(type: "varchar(11)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    coren = table.Column<string>(type: "varchar(8)", nullable: false),
                    crm = table.Column<string>(type: "varchar(8)", nullable: false),
                    senha = table.Column<string>(type: "varchar(8)", nullable: false),
                    InseridoPor = table.Column<int>(type: "int", nullable: false, defaultValueSql: "1"),
                    InseridoEm = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    ModificadoPor = table.Column<int>(type: "int", nullable: false, defaultValueSql: "1"),
                    ModificadoEm = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_celular",
                table: "Usuario",
                column: "celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_cpf",
                table: "Usuario",
                column: "cpf",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
