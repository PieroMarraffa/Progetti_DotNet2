using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTemplateEFCF.Models
{
    [Keyless]
    internal class ViewLibri
    {
        public string Titolo { get; set; }
        public int Prezzo { get; set; }
        public string NomeAutore { get; set; }
        public string CognomeAutore { get; set; }
        public string Editore { get; set; }
        public string SedeEditore { get; set; }
    }
}
