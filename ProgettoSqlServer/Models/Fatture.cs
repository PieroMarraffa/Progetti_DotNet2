using System;
using System.Collections.Generic;

namespace ProgettoSqlServer.Models
{
    public partial class Fatture
    {
        public int Id { get; set; }
        public int Importo { get; set; }
        public string Descrizione { get; set; } = null!;
        public DateTime DataFattura { get; set; }
        public int IdCliente { get; set; }

        public virtual Persona IdNavigation { get; set; } = null!;
    }
}
