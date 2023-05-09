using Models.SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Paciente
{
    public class Paciente : Pessoa
    {
        public Paciente(string nome,
                        int idade,
                        Responsavel? responsavel,
                        int cPF,
                        int rG,
                        int celular,
                        int? telefone,
                        string endereco,
                        string bairro,
                        string municipio,
                        string uF,
                        int cEP,
                        char sexo,
                        string profissao,
                        string email) : base(nome, idade, responsavel, cPF, rG, celular, telefone, endereco, bairro, municipio, uF, cEP, sexo, profissao, email)
        {
        }

        public Paciente()
        {

        }
    }
}
