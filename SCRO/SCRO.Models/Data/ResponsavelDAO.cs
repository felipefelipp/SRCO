using Microsoft.EntityFrameworkCore;
using Models.SCRO.Models.Paciente;
using SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.SCRO.Models.Data
{
    public class ResponsavelDAO : IPessoaDAO<Responsavel>, IDisposable
    {
        private SCROContext context;

        public ResponsavelDAO()
        {
            this.context = new SCROContext();
        }

        public void Adicionar(Responsavel pessoa)
        {
            try
            {
                context.Responsavel.Add(pessoa);
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                Console.WriteLine(innerException);
            }
        }

        public void Atualizar(Responsavel pessoa)
        {
            context.Update(pessoa);
            context.SaveChanges();
        }

        public IList<Responsavel> BuscarPorCelular(long celular)
        {
            try
            {
                return context.Responsavel
                               .Where(r => r.Celular == celular)
                               .ToList();

            }
            catch (SqlNullValueException err)
            {
                Console.WriteLine(err.ToString());
                Console.WriteLine("Responsável não encontrado");
                return null;
            }
        }

        public IList<Responsavel> BuscarPorCpf(long cpf)
        {
            try
            {
                return context.Responsavel
                               .Where(r => r.CPF == cpf)
                               .ToList();
            }
            catch (SqlNullValueException err)
            {
                Console.WriteLine(err.ToString());
                Console.WriteLine("Responsável não encontrado");
                return null;
            }
        }

        public IList<Responsavel> BuscarPorEmail(string email)
        {
            try
            {
                return context.Responsavel
                               .Where(r => r.Email.Contains(email))
                               .ToList();

            }
            catch (SqlNullValueException err)
            {
                Console.WriteLine(err.ToString());
                Console.WriteLine("Responsável não encontrado");
                return null;
            }
        }

        public IList<Responsavel> BuscarPorIdade(int idade)
        {
            try
            {
                return context.Responsavel
                               .Where(r => r.Idade == idade)
                               .ToList();
            }
            catch (SqlNullValueException err)
            {
                Console.WriteLine(err.ToString());
                Console.WriteLine("Responsável não encontrado");
                return null;
            }
        }

        public IList<Responsavel> BuscarPorNome(string nome)
        {
            try
            {
                return context.Responsavel
                               .Where(r => r.Nome.Contains(nome))
                               .ToList();
            }
            catch (SqlNullValueException err)
            {
                Console.WriteLine(err.ToString());
                Console.WriteLine("Responsável não encontrado");
                return null;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Responsavel> Obter(string nome, int idade, long cpf, long celular, string email)
        {
            return context.Responsavel.Where(responsavel => (responsavel.Nome == nome) ||
                                                             (responsavel.Idade == idade) ||
                                                             (responsavel.CPF == cpf) ||
                                                             (responsavel.Celular == celular) ||
                                                             (responsavel.Email == email)
                                            ).ToList();
        }

        public IList<Responsavel> ObterTodos()
        {
            return context.Responsavel.ToList();
        }

        public void Remover(Responsavel pessoa)
        {
            context.Responsavel.Remove(pessoa);
            context.SaveChanges();
        }
    }
}
