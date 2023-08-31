using SCRO.Models.Classificacao;

namespace SCRO.Models.Cliente
{
    public class Paciente : Pessoa
    {
        public int PacienteId { get; set; }
        public Responsavel? Responsavel { get; set; }
        public PerguntaSelecionadaPaciente PerguntaSelecionadaPaciente { get; set; }
        public string Telefone { get; private set; }
        public string Rua { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string UF { get; private set; }
        public int CEP { get; private set; }
        public char Sexo { get; private set; }
        public string Profissao { get; private set; }
        public Paciente(string nome,
                        int idade,
                        string cpf,
                        string rg,
                        string celular,
                        string telefone,
                        string rua,
                        int numero,
                        string bairro,
                        string municipio,
                        string uf,
                        int cep,
                        char sexo,
                        string profissao,
                        string email) : base(nome, idade, cpf, rg, celular, email)
        {
            Telefone = telefone;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Municipio = municipio;
            UF = uf;
            CEP = cep;
            Sexo = sexo;
            Profissao = profissao;
        }

        public Paciente(Responsavel responsavel,
                        string nome,
                        int idade,
                        string cpf,
                        string rg,
                        string celular,
                        string telefone,
                        string rua,
                        int numero,
                        string bairro,
                        string municipio,
                        string uf,
                        int cep,
                        char sexo,
                        string profissao,
                        string email) : this(nome, idade, cpf, rg, celular, telefone, rua, numero, bairro, municipio, uf, cep, sexo, profissao, email)
        {
            Responsavel = responsavel;
        }

        public Paciente() { }

    }
}
