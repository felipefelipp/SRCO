using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SCRO.Models.Paciente
{
    public class Responsavel : Pessoa
    {
        public Responsavel(string nome,
                           int idade,
                           int cPF,
                           int rG,
                           int celular
                           ) : base(nome, idade, cPF, rG, celular)
        {
        }
    }
}
