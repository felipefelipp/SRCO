﻿using SCRO.SCRO.Models.Enums;
using SCRO.SCRO.Models.Extensions;

namespace SCRO.Models.Classificacao
{
    public class Resposta
    {
        public int RespostaId { get; set; }
        public bool  RespostaTexto { get; set; }  //trocar para bool 
        public bool RespostaTextoArea { get; set; } //trocar para bool
        public string RespostaCheckBox { get; set; }
        public string RespostaComboBox { get; set; }
        public string RespostaRadioButtom { get; set; }
        public DateTime? RespostaData { get; set; }
        public int ValorTipoResposta { get; private set; } // Tipo da resposta 
        public TipoResposta TipoResposta 
        {
            get { return ValorTipoResposta.ParaValor(); }
            set { ValorTipoResposta = value.ParaInt(); }
        }
        public int ValorResposta { get; set; } // Valor da resposta

    }
}
