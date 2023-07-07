using Models.SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Paciente
{

    [Table("Paciente")]
    public class Paciente : IPessoa
    {
        [Key]
        public int PacienteId { get;  set; }
        public int? ResponsavelId { get;  set; }  
        public string Nome { get;  set; }
        public int Idade { get;  set; }
        public long CPF { get;  set; }
        public int RG { get;  set; }
        public long Celular { get;  set; }
        public long? Telefone { get;  set; }
        public string Rua { get;  set; }
        public int Numero { get;  set; }
        public string Bairro { get;  set; }
        public string Municipio { get;  set; }
        public string UF { get;  set; }
        public int CEP { get;  set; }
        public char Sexo { get;  set; }
        public string Profissao { get;  set; }
        public string Email { get;  set; }

        public Paciente( string nome, int idade, long cpf, int rg, long celular, long? telefone, string rua, int numero, string bairro, string municipio, string uf, int cep, char sexo, string profissao, string email)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            RG = rg;
            Celular = celular;
            Telefone = telefone;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Municipio = municipio;
            UF = uf;
            CEP = cep;
            Sexo = sexo;
            Profissao = profissao;
            Email = email;
        }

        public Paciente(int responsavel, string nome, int idade, long cpf, int rg, long celular, long? telefone, string rua, int numero,  string bairro, string municipio, string uf, int cep, char sexo, string profissao, string email)
        {
            ResponsavelId = responsavel;
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            RG = rg;
            Celular = celular;
            Telefone = telefone;
            Rua = rua;
            Numero = Numero;
            Bairro = bairro;
            Municipio = municipio;
            UF = uf;
            CEP = cep;
            Sexo = sexo;
            Profissao = profissao;
            Email = email;
        }

        public Paciente() { }

    }
}
