using SCRO.Models.Classificacao;
using SCRO.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.SCRO.Models.Classificacao
{
    public class RespostaSelecionadaPaciente
    {
        public int RespostaSelecionadaPacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public IEnumerable<Resposta> RespostasSelecionadas { get; set; }

    }
}
