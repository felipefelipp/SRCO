using Models.SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Funcionario
{
    public class Usuario //: IPessoa
    {

        private string? _COREN;

        private string? _CRM;

        public Usuario(string nome,
                       int idade,
                       int cPF,
                       int rG,
                       int celular,
                       string? coren,
                       string? crm) //: base(nome, idade, cPF, rG, celular)
        {
            _COREN = coren;
            _CRM = crm;
        }
    }
}
