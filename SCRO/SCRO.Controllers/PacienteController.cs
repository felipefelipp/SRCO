<<<<<<< HEAD
﻿using SCRO.Models.Paciente;
using SCRO.SCRO.Models.Data;
=======
﻿using SCRO.Models.Data;
using SCRO.Models.Paciente;
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
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
<<<<<<< HEAD


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
=======
        CadastrarPacienteView cadastrarPacienteView;
        PacienteDbContext context;
        // criar o objeto paciente na main e manipular os dados aqui
        public void ExibirPaciente(Paciente paciente)
        {
            cadastrarPacienteView.ExibirPaciente(paciente);
            
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
        }

        public void CadastrarPaciente(Paciente paciente)
        {
<<<<<<< HEAD
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
=======
            cadastrarPacienteView.menuCadastrarPaciente(paciente);
            context.InsertPaciente(paciente);
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
        }

        public PacienteController ()
        {
<<<<<<< HEAD
            
=======
            cadastrarPacienteView = new CadastrarPacienteView();
            context = new PacienteDbContext();
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
        }
    }
}
