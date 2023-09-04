using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class ClassificacaoPaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassificacaoPacienteId",
                table: "RespostaSelecionadaPaciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassificacaoPacienteId",
                table: "PerguntaSelecionadaPaciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClassificacaoPaciente",
                columns: table => new
                {
                    ClassificacaoPacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    ValorResultadoClassificacao = table.Column<int>(type: "int", nullable: false),
                    ResultadoCor = table.Column<int>(type: "int", nullable: false),
                    ResultadoClassificacaoCor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificacaoPaciente", x => x.ClassificacaoPacienteId);
                    table.ForeignKey(
                        name: "FK_ClassificacaoPaciente_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassificacaoPaciente_PacienteId",
                table: "ClassificacaoPaciente",
                column: "PacienteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassificacaoPaciente");

            migrationBuilder.DropColumn(
                name: "ClassificacaoPacienteId",
                table: "RespostaSelecionadaPaciente");

            migrationBuilder.DropColumn(
                name: "ClassificacaoPacienteId",
                table: "PerguntaSelecionadaPaciente");
        }
    }
}
