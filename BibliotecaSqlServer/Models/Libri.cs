using System;
using System.Collections.Generic;

namespace BibliotecaSqlServer.Models
{
    public partial class Libri
    {
        public int IdLibri { get; set; }
        public string Titolo { get; set; } = null!;
        public int Prezzo { get; set; }
        public int IdAutore { get; set; }
        public int IdEditore { get; set; }

        public virtual Autori IdAutoreNavigation { get; set; } = null!;
        public virtual Editori IdEditoreNavigation { get; set; } = null!;
    }
}
