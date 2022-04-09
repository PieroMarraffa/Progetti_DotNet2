using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTemplateEFCF.Models
{
    internal class Libro
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Titolo { get; set; }

        [Required]
        public int Prezzo { get; set; }

        [Required]
        public int IdAutore { get; set; }
        [ForeignKey("IdAutore")]

        public Autore Autore { get; set; }

        [Required]
        public int IdEditore { get; set; }

        [ForeignKey("IdEditore")]
        public Editore Editore { get; set; }
    }
}
