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
        public int ValorResultadoClassificacao { get; set; }
        public int ResultadoCor { get; private set; } 
        public ResultadoClassificacaoCor ResultadoClassificacaoCor
        {
            get { return ResultadoCor.ParaValorClassificacao(); }
            set { ResultadoCor = value.ParaIntClassificacao(); }
        }
    }
}
