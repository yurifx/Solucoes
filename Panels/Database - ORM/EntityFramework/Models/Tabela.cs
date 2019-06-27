using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{

    //Necessário adicionar o atributo abaixo para não criar uma tbl nova no banco de dados pluralizada.

    [Table("Tabela")]
    class Tabela
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
