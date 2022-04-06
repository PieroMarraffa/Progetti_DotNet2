using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaDecorator
{
    internal class Automobile
    {
        private string descrizione;
        private int prezzo;

        public Automobile()
        {
            this.descrizione = "Automobile di base ";
            this.prezzo = 5000;
        }

        public virtual string Descrizione()
        {
            return this.descrizione;
        }

        public virtual int Prezzo()
        {
            return this.prezzo;
        }
    }
}
