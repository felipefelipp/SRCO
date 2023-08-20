using SCRO.Models.Cliente;
using SCRO.SCRO.Models.Classificacao;

namespace SCRO.Models.Classificacao
{
    public class Classificacao
    {
        public int ClassificacaoId { get; set; }
        public Paciente Paciente { get; set; }
        public PerguntaSelecionadaPaciente PerguntaSelecionadaPaciente { get; set; }
        public RespostaSelecionadaPaciente RespostaSelecionadaPaciente { get; set; }
        public int ValorClassificacao { get; set; }
        public ResultadoClassificacaoCor Resultado { get; set; }
        public enum ResultadoClassificacaoCor
        {
            vermelho,
            laranja,
            amarelo,
            verde,
            azul
        }
    }
}
