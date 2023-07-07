using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SCRO.Models.Paciente
{
    public interface IPessoa
    {

            string Nome { get; }
            int Idade { get; }
            long CPF { get; }
            int RG { get; }
            long Celular { get; }
            string Email { get; }   

    }
}
