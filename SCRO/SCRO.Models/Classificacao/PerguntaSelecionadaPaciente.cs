using SCRO.Models.Cliente;

namespace SCRO.Models.Classificacao
{
    public class PerguntaSelecionadaPaciente
    {
        public int PerguntaSelecionadaPacienteId { get; set; }
        public int PerguntaId { get; set; }
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
        public int ClassificacaoPacienteId { get; set; }

    }
}