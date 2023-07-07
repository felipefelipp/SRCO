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
    [Table("CategoriaPergunta")]
    public class CategoriaPergunta
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
=======
    public class CategoriaPergunta
    {
        public enum Categoria
        {

        }
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
    }
}
