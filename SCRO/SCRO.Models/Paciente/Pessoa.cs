using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Paciente
{
    public abstract class Pessoa
    {
        private string _nome;

        private int _idade;

        private Responsavel? responsavel;

        private int _CPF;

        private int _RG;

        private int _celular;

        private int? _telefone;

        private string _endereco;

        private string _bairro;

        private string _municipio;

        private string _UF;

        private int _CEP;

        private char _sexo;

        private string _profissao;

        private string _email;

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, int cPF, int rG, int celular)
        {
            Nome = nome;
            Idade = idade;
            CPF = cPF;
            RG = rG;
            Celular = celular;
        }

        public Pessoa(string nome, int idade, Responsavel? responsavel, int cPF, int rG, int celular, int? telefone,
                        string endereco, string bairro, string municipio, string uF, int cEP, char sexo, string profissao, string email)
        {
            Nome = nome;
            Idade = idade;
            this.Responsavel = responsavel;
            CPF = cPF;
            RG = rG;
            Celular = celular;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            Municipio = municipio;
            UF = uF;
            CEP = cEP;
            Sexo = sexo;
            Profissao = profissao;
            Email = email;
        }

        public string Profissao { get => _profissao; set => _profissao = value; }
        public char Sexo { get => _sexo; set => _sexo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }
        public Responsavel? Responsavel { get => responsavel; set => responsavel = value; }
        public int CPF { get => _CPF; set => _CPF = value; }
        public int RG { get => _RG; set => _RG = value; }
        public int Celular { get => _celular; set => _celular = value; }
        public int? Telefone { get => _telefone; set => _telefone = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Municipio { get => _municipio; set => _municipio = value; }
        public string UF { get => _UF; set => _UF = value; }
        public int CEP { get => _CEP; set => _CEP = value; }
        public string Email { get => _email; set => _email = value; }   
    }
}
