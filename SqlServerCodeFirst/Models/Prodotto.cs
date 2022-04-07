using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerCodeFirst.Models
{
    internal class Prodotto
    {
        [Key]
        public int IdProdotto{ get; set; } 
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Descrizione { get; set; }
        public int Prezzo { get; set; }

        [NotMapped]//la porporietà resta dell'oggetto, ma non viene caricata sul db
        public string ProprietaBella { get; set; }
    }
}
