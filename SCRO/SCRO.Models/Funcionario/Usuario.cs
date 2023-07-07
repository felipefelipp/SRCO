using Models.SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Funcionario
{
<<<<<<< HEAD
    public class Usuario //: IPessoa
=======
    public class Usuario : Pessoa
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
    {

        private string? _COREN;

        private string? _CRM;

        public Usuario(string nome,
                       int idade,
                       int cPF,
                       int rG,
                       int celular,
                       string? coren,
<<<<<<< HEAD
                       string? crm) //: base(nome, idade, cPF, rG, celular)
=======
                       string? crm) : base(nome, idade, cPF, rG, celular)
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
        {
            _COREN = coren;
            _CRM = crm;
        }
    }
}
