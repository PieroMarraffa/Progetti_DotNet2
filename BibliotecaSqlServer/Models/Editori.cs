using System;
using System.Collections.Generic;

namespace BibliotecaSqlServer.Models
{
    public partial class Editori
    {
        public Editori()
        {
            Libris = new HashSet<Libri>();
        }

        public int IdEditori { get; set; }
        public string Descrizione { get; set; } = null!;
        public string Sede { get; set; } = null!;

        public virtual ICollection<Libri> Libris { get; set; }
    }
}
