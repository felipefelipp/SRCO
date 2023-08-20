using SCRO.Models.Classificacao;
using SCRO.Models.Cliente;

namespace SCRO.SCRO.Models.Classificacao
{
    public class PerguntaSelecionadaPaciente
    {
        public int PerguntaSelecionadaPacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public IEnumerable<Pergunta> PerguntasSelecionadas { get; set; }
    }
}
