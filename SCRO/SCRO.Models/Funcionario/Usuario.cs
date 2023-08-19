using SCRO.Models.Paciente;

namespace SCRO.Models.Funcionario
{
    public class Usuario : Pessoa
    {
        public int UsuarioId { get; set; }
        public string COREN { get; set; }
        public string CRM { get; set; }     
        public string Senha { get; private set; }
        public Usuario(string nome,
                       int idade,
                       string CPF,
                       string RG,
                       string celular,
                       string email,
                       string senha,
                       string coren,
                       string crm) : base(nome, idade, CPF, RG, celular, email)
        {
            COREN = coren;
            CRM = crm;
            Senha = senha;
        }

        public Usuario() { }
    }
}
