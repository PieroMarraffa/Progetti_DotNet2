using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatturazioneEfCodeFirst.Models
{
    internal class Cliente
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descrizione { get; set; }
    }
}
