using SCRO.Models.Cliente;
using SCRO.SCRO.Models.Enums;
using SCRO.SCRO.Models.Extensions;

namespace SCRO.Models.Classificacao
{
    public class ClassificacaoPaciente
    {
        public int ClassificacaoPacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
        /// <summary>
        /// É necessário a classe pergunta selecionada e resposta selecionada
        /// pois se for criado uma lista de pergunta e resposta selecionada na classe
        /// classificacao, será duplicado o registro de classificação para cada pergunta
        /// e resposta selecionada.
        /// Obs. Relacionamento de 0 : N entre pergunta selecionada e pergunta
        /// O mesmo se aplica as classes Respostas
        /// </summary>
        public PerguntaSelecionadaPaciente PerguntasSelecionadaPaciente { get; set; }
        public RespostaSelecionadaPaciente RespostasSelecionadaPaciente { get; set; }
        public int ResultadoClassificacao { get; set; }
        public int ResultadoCor { get; private set; } 
        public ResultadoClassificacaoCor ResultadoClassificacaoCor
        {
            get { return ResultadoCor.ParaValorClassificacao(); }
            set { ResultadoCor = value.ParaIntClassificacao(); }
        }
    }
}
