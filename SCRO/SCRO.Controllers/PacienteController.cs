using SCRO.Models.Data;
using SCRO.Models.Paciente;
using SCRO.Views.Consulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Controllers
{
    public class PacienteController
    {
        CadastrarPacienteView cadastrarPacienteView;
        PacienteDbContext context;
        // criar o objeto paciente na main e manipular os dados aqui
        public void ExibirPaciente(Paciente paciente)
        {
            cadastrarPacienteView.ExibirPaciente(paciente);
            
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            cadastrarPacienteView.menuCadastrarPaciente(paciente);
            context.InsertPaciente(paciente);
        }

        public PacienteController ()
        {
            cadastrarPacienteView = new CadastrarPacienteView();
            context = new PacienteDbContext();
        }
    }
}
