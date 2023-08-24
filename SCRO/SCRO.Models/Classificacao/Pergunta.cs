using SCRO.SCRO.Models.Classificacao;
using SCRO.SCRO.Models.Enums;

namespace SCRO.Models.Classificacao
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public string TextoPergunta { get; set; }
        public CategoriaPergunta Categoria { get; set; }       
    }
}
