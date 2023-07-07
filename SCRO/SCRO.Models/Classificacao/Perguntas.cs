using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCRO.Models.Classificacao;
namespace Models.Classificacao
{
    [Table("Perguntas")]
    public class Perguntas
    {
        [Key]
        public int IdPergunta { get; set; }
        public string Descricao { get; set; }   
        public CategoriaPergunta CategoriaPergunta { get; set; }
         
    }
}
