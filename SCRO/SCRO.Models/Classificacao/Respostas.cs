using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Classificacao
{
<<<<<<< HEAD
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
=======
    internal class Respostas
    {
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
    }
}
