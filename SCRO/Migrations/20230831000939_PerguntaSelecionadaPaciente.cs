using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class PerguntaSelecionadaPaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PerguntaSelecionadaPaciente",
                columns: table => new
                {
                    PerguntaSelecionadaPacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerguntaId = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaSelecionadaPaciente", x => x.PerguntaSelecionadaPacienteId);
                    table.ForeignKey(
                        name: "FK_PerguntaSelecionadaPaciente_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerguntaSelecionadaPaciente_Pergunta_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Pergunta",
                        principalColumn: "PerguntaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaSelecionadaPaciente_PacienteId",
                table: "PerguntaSelecionadaPaciente",
                column: "PacienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaSelecionadaPaciente_PerguntaId",
                table: "PerguntaSelecionadaPaciente",
                column: "PerguntaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerguntaSelecionadaPaciente");
        }
    }
}
