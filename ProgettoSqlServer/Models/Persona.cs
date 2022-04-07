using System;
using System.Collections.Generic;

namespace ProgettoSqlServer.Models
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;

        public virtual Fatture Fatture { get; set; } = null!;
    }
}
