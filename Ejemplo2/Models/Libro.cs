using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.Models
{
    [Table("libro")]
    public class Libro
    {
        [Key]
        public int id { get; set; }
        [Column("title")]
        public string? titulo { get; set; }
        [Required]
        public string autor { get; set; }
    }
}
