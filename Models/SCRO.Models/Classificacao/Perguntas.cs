using Models.SCRO.Models.Classificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Classificacao
{
    public class Perguntas
    {
        public string Texto { get; set; }   

        public enum tipoResposta
        {
            Booleano,
            Numerico,
            Texto,
            SelecaoMultipla
        }

        public List<string> Opcoes { get; set; }    

        public CategoriaPergunta CategoriaPergunta { get; set; }
         

    }
}
