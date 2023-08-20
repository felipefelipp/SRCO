namespace SCRO.Models.Classificacao
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public string TextoPergunta { get; set; }
        public List<string> OpcoesResposta { get; set; }
        public TipoResposta Tipo { get; set; }
        public CategoriaPergunta Categoria { get; set; }
        public enum TipoResposta
        {
            Text,
            TextArea,
            CheckBox,
            ComboBox,
            Radiobutton,
            Data
        }
         
    }
}
