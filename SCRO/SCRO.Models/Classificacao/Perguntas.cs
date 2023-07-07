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
using SCRO.Models.Classificacao;
namespace Models.Classificacao
{
<<<<<<< HEAD
    [Table("Perguntas")]
    public class Perguntas
    {
        [Key]
        public int IdPergunta { get; set; }
        public string Descricao { get; set; }   
        public CategoriaPergunta CategoriaPergunta { get; set; }
         
=======
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
         

>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
    }
}
