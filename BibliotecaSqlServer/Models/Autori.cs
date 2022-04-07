using System;
using System.Collections.Generic;

namespace BibliotecaSqlServer.Models
{
    public partial class Autori
    {
        public Autori()
        {
            Libris = new HashSet<Libri>();
        }

        public int IdAutore { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;

        public virtual ICollection<Libri> Libris { get; set; }
    }
}
