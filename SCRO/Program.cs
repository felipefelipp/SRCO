using SCRO.Controllers;
using SCRO.Models.Data;
using SCRO.Models.Paciente;
using SCRO.Views.Consulta;

Paciente felipe = new Paciente();
PacienteController controller = new PacienteController();   
controller.CadastrarPaciente(felipe);
