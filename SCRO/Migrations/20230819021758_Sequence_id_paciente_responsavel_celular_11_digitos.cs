using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCRO.Migrations
{
    /// <inheritdoc />
    public partial class Sequence_id_paciente_responsavel_celular_11_digitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Responsavel",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(9)");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Paciente",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(9)");

            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "Paciente",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Paciente",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(9)");

            var SequencePaciente = @"CREATE SEQUENCE PacienteSequence START WITH 1 INCREMENT BY 1 NO MINVALUE NO MAXVALUE CACHE 1";
            migrationBuilder.Sql(SequencePaciente);

            var SequenceResponsavel = @"CREATE SEQUENCE ResponsavelSequence START WITH 1 INCREMENT BY 1 NO MINVALUE NO MAXVALUE CACHE 1";
            migrationBuilder.Sql(SequenceResponsavel);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Responsavel",
                type: "varchar(9)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Paciente",
                type: "varchar(9)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "Paciente",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Paciente",
                type: "varchar(9)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            var sequencePaciente = "DROP SEQUENCE PacienteSequence";
            migrationBuilder.Sql(sequencePaciente);

            var sequenceResponsavel = "DROP SEQUENCE ResponsavelSequence";
            migrationBuilder.Sql(sequenceResponsavel);
        }
    }
}
