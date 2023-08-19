using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Paciente
{
    public abstract class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }

        public Pessoa(string nome,
                      int idade,
                      string cpf,
                      string rg,
                      string celular,
                      string email)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            RG = rg;
            Celular = celular;
            Email = email;
        }


        public Pessoa() { }
    }
}
