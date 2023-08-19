using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class PK_CPF_Celular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "Paciente",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_celular",
                table: "Responsavel",
                column: "celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_cpf",
                table: "Responsavel",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_celular",
                table: "Paciente",
                column: "celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_cpf",
                table: "Paciente",
                column: "cpf",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Responsavel_celular",
                table: "Responsavel");

            migrationBuilder.DropIndex(
                name: "IX_Responsavel_cpf",
                table: "Responsavel");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_celular",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_cpf",
                table: "Paciente");

            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "Paciente",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");
        }
    }
}
