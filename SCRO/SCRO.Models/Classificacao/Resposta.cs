namespace SCRO.Models.Classificacao
{
    public class Resposta
    {
        public int RespostaId { get; set; }
        public string RespostaTexto { get; set; }   
        public string RespostaTextoArea { get; set; }
        public bool[] RespostaCheckBox { get; set; }
        public string RespostaComboBox { get; set; }
        public string RespostaRadioButtom { get; set; }
        public DateTime? RespostaData { get; set; }
        public int ValorResposta { get; set; }
        public enum TipoResposta
        {
            Booleano = 0,
            Numerico = 1,
            Texto = 2,
            SelecaoMultipla = 3
        }
    }
}
