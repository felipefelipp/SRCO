using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SCRO.Models.Paciente
{
<<<<<<< HEAD
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

        public Responsavel(string nome, int idade, int cpf, int rg, long celular, string email)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            RG = rg;
            Celular = celular;
            Email = email;
=======
    public class Responsavel : Pessoa
    {
        public Responsavel(string nome,
                           int idade,
                           int cPF,
                           int rG,
                           int celular
                           ) : base(nome, idade, cPF, rG, celular)
        {
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
        }

        public Responsavel() { }
    }
}
