namespace SCRO.Models.Paciente
{
    public class Responsavel : Pessoa
    {
        public int? ResponsavelId { get;  set; }
        public int? PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public Responsavel(string nome, int idade, string cpf, string rg, string celular, string email) : base(nome, idade, cpf, rg, celular, email)
        {
        }
        public Responsavel() { }
    }
}
