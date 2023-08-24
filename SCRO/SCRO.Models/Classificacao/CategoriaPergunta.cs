namespace SCRO.Models.Classificacao
{
    public class CategoriaPergunta
    {
        public int CategoriaPerguntaId { get; set; }
        public Pergunta Pergunta { get; set; }
        public int PerguntaId { get; set; }
        public string Descricao { get; set; }
    }
}
