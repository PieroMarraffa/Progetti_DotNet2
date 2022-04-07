using System;
using System.Collections.Generic;

namespace CinemaSqlServer.Models
{
    public partial class Film
    {
        public int IdFilm { get; set; }
        public string Titolo { get; set; } = null!;
        public int AnnoUscita { get; set; }
        public int IdAttore { get; set; }
        public int IdGenere { get; set; }

        public virtual Attori IdAttoreNavigation { get; set; } = null!;
        public virtual Generi IdGenereNavigation { get; set; } = null!;
    }
}
