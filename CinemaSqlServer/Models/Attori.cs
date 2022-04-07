using System;
using System.Collections.Generic;

namespace CinemaSqlServer.Models
{
    public partial class Attori
    {
        public Attori()
        {
            Films = new HashSet<Film>();
        }

        public int IdAttore { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;

        public virtual ICollection<Film> Films { get; set; }
    }
}
