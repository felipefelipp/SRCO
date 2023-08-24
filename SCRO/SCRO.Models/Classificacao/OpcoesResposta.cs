using SCRO.Models.Classificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.SCRO.Models.Classificacao
{
    public class OpcoesResposta
    {
        public int OpcoesRespostaId { get; set; }
        public Pergunta Pergunta { get; set; }
        public string DescricaoResposta { get; set; }
    }
}
