using System;
using System.Collections.Generic;

namespace CinemaSqlServer.Models
{
    public partial class Generi
    {
        public Generi()
        {
            Films = new HashSet<Film>();
        }

        public int IdGenere { get; set; }
        public string Descrizione { get; set; } = null!;

        public virtual ICollection<Film> Films { get; set; }
    }
}
