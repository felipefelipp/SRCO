using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefone = table.Column<string>(type: "varchar(9)", nullable: false),
                    rua = table.Column<string>(type: "varchar(100)", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    municipio = table.Column<string>(type: "varchar(100)", nullable: false),
                    uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    cep = table.Column<int>(type: "int", nullable: false),
                    sexo = table.Column<string>(type: "char(1)", nullable: false),
                    profissao = table.Column<string>(type: "varchar(50)", nullable: false),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    rg = table.Column<string>(type: "varchar(8)", nullable: false),
                    celular = table.Column<string>(type: "varchar(9)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    ResponsavelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: true),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    rg = table.Column<string>(type: "varchar(8)", nullable: false),
                    celular = table.Column<string>(type: "varchar(9)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.ResponsavelId);
                    table.ForeignKey(
                        name: "FK_Responsavel_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "PacienteId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_PacienteId",
                table: "Responsavel",
                column: "PacienteId",
                unique: true,
                filter: "[PacienteId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
