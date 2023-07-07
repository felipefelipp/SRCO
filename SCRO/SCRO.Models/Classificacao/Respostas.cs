using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Classificacao
{
    [Table("Respostas")]
    public class Respostas
    {
        [Key]
        public int IdResposta { get; set; }
        public string Descricao { get; set; }   
        public int Valor { get; set; }
        public enum TipoResposta
        {
            Booleano = 0,
            Numerico = 1,
            Texto = 2,
            SelecaoMultipla = 3
        }
    }
}
