using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Paciente
{
    [Table("Responsavel")]
    public class Responsavel : IPessoa
    {

        [Key]
        public int IdResponsavel { get;  set; }
        public string Nome { get;  set; }
        public int Idade { get;  set; }
        public long CPF { get;  set; }
        public int RG { get;  set; }
        public long Celular { get;  set; }
        public string Email { get;  set; }

        public Responsavel(string nome, int idade, long cpf, int rg, long celular, string email)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            RG = rg;
            Celular = celular;
            Email = email;
        }

        public Responsavel() { }
    }
}
