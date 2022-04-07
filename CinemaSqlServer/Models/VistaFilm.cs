using System;
using System.Collections.Generic;

namespace CinemaSqlServer.Models
{
    public partial class VistaFilm
    {
        public int IdFilm { get; set; }
        public string Titolo { get; set; } = null!;
        public int AnnoUscita { get; set; }
        public string NomeAttore { get; set; } = null!;
        public string CognomeAttore { get; set; } = null!;
        public string Genere { get; set; } = null!;
    }
}
