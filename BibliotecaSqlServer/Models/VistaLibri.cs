using System;
using System.Collections.Generic;

namespace BibliotecaSqlServer.Models
{
    public partial class VistaLibri
    {
        public int IdLibri { get; set; }
        public string Titolo { get; set; } = null!;
        public int Prezzo { get; set; }
        public string NomeAutore { get; set; } = null!;
        public string CognomeAutore { get; set; } = null!;
        public string Editore { get; set; } = null!;
    }
}
