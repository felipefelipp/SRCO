using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Models.Classificacao
{
    [Table("CategoriaPergunta")]
    public class CategoriaPergunta
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
    }
}
