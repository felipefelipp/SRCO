    using Microsoft.EntityFrameworkCore.Migrations;

    #nullable disable

    namespace SCRO.Migrations
    {
        /// <inheritdoc />
        public partial class RespostaSelecionadaPaciente : Migration
        {
            /// <inheritdoc />
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.AlterColumn<bool>(
                    name: "RespostaTextoArea",
                    table: "Resposta",
                    type: "bit",
                    nullable: false,
                    oldClrType: typeof(string),
                    oldType: "varchar(max)");

                migrationBuilder.AlterColumn<bool>(
                    name: "RespostaTexto",
                    table: "Resposta",
                    type: "bit",
                    nullable: false,
                    oldClrType: typeof(string),
                    oldType: "varchar(100)");

                migrationBuilder.CreateTable(
                    name: "RespostaSelecionadaPaciente",
                    columns: table => new
                    {
                        RespostaSelecionadaPacienteId = table.Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        RespostaId = table.Column<int>(type: "int", nullable: false),
                        ValorRespostaTexto = table.Column<string>(type: "nvarchar(100)", nullable: false),
                        ValorRespostaTextoArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        PacienteId = table.Column<int>(type: "int", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_RespostaSelecionadaPaciente", x => x.RespostaSelecionadaPacienteId);
                        table.ForeignKey(
                            name: "FK_RespostaSelecionadaPaciente_Paciente_PacienteId",
                            column: x => x.PacienteId,
                            principalTable: "Paciente",
                            principalColumn: "PacienteId",
                            onDelete: ReferentialAction.Cascade);
                    });

                migrationBuilder.CreateIndex(
                    name: "IX_RespostaSelecionadaPaciente_PacienteId",
                    table: "RespostaSelecionadaPaciente",
                    column: "PacienteId",
                    unique: true);
            }

            /// <inheritdoc />
            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropTable(
                    name: "RespostaSelecionadaPaciente");

                migrationBuilder.AlterColumn<string>(
                    name: "RespostaTextoArea",
                    table: "Resposta",
                    type: "varchar(max)",
                    nullable: false,
                    oldClrType: typeof(bool),
                    oldType: "bit");

                migrationBuilder.AlterColumn<string>(
                    name: "RespostaTexto",
                    table: "Resposta",
                    type: "varchar(100)",
                    nullable: false,
                    oldClrType: typeof(bool),
                    oldType: "bit");
            }
        }
    }
