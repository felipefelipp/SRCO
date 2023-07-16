using SCRO.Models.Paciente;
using SCRO.SCRO.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Controllers
{
    public class ResponsavelController
    {
        public IList<Responsavel> BuscarResponsavel(string nome = "null", int idade = -1, long cpf = -1, long celular = -1, string email = "null")
        {
            using var repo = new ResponsavelDAO();
            var pacienteEncontrado = repo.Obter(nome, idade, cpf, celular, email);
            return pacienteEncontrado;
        }

        public IList<Responsavel> BuscarTodos()
        {
            using var repo = new ResponsavelDAO();
            var todosOsPacientes = repo.ObterTodos();
            return todosOsPacientes;
        }

        public void CadastrarResponsavel(Responsavel responsavel)
        {
            using var repo = new ResponsavelDAO();
            repo.Adicionar(responsavel);
        }

        public void AtualizarResponsavel(Responsavel responsavel)
        {
            using var repo = new ResponsavelDAO();
            repo.Atualizar(responsavel);
        }

        public void ExcluirResponsavel(Responsavel responsavel)
        {
            using var repo = new ResponsavelDAO();
            repo.Remover(responsavel);
        }

        public bool VerificaSeExisteCpf(long cpf)
        {
            using var repo = new ResponsavelDAO();
            return repo.VerificaSeExisteCPF(cpf);
        }
    }
}
