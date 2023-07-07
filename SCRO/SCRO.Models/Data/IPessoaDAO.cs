using Models.SCRO.Models.Paciente;
using SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.SCRO.Models.Data
{
    public interface IPessoaDAO<T>
    {
        void Adicionar(T pessoa);

        void Atualizar(T pessoa);

        void Remover(T pessoa);   

        IList<T> ObterTodos();

        IList<T> Obter(string nome, int idade, long cpf, long celular, string email);
        IList<T> BuscarPorNome(string nome);
        IList<T> BuscarPorIdade(int idade);
        IList<T> BuscarPorCpf(long cpf);
        IList<T> BuscarPorCelular(long celular);
        IList<T> BuscarPorEmail(string email);
    }
}
