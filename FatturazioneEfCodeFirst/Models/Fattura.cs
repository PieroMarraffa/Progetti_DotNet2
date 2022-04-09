using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatturazioneEfCodeFirst.Models
{
    internal class Fattura
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descrizione { get; set; }

        [Required]
        public int Importo { get; set; }

        [Required]
        public DateTime DataFattura { get; set; }

        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
