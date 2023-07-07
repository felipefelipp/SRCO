using SCRO.Models.Paciente;
using SCRO.SCRO.Models.Data;
using SCRO.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Controllers
{
    public class PacienteController
    {


        public IList<Paciente> BuscarPaciente(string nome = "null", int idade = -1, long cpf = -1, long celular = -1, string email = "null")
        {
            using var repo = new PacienteDAO();
            var pacienteEncontrado = repo.Obter(nome, idade, cpf, celular, email);
            return pacienteEncontrado;
        }

        public void BuscarTodos()
        {
            using var repo = new PacienteDAO();
            var todosOsPaciente = repo.ObterTodos();
            PacienteView.ExibirPaciente(todosOsPaciente);
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            using var repo = new PacienteDAO();
            repo.Adicionar(paciente);
        }

        public void AtualizarPaciente(Paciente paciente) {
            using var repo = new PacienteDAO();
            repo.Atualizar(paciente);
        }

        public void ExcluirPaciente(Paciente paciente)
        {
            using var repo = new PacienteDAO();
            repo.Remover(paciente);
        }

        public PacienteController ()
        {
            
        }
    }
}
