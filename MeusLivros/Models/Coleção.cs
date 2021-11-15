using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivros.Models
{
    [Table("Coleção")]
    public class Coleção
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Ano { get; set; }
    }
}
