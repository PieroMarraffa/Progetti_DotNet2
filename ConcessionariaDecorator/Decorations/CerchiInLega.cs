using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaDecorator
{
    internal class CerchiInLega : AutoDecorator
    {
        private Automobile auto;
        private string descrizione;
        private int prezzo;

        public CerchiInLega(Automobile a)
        {
            this.auto = a;
            this.descrizione = "Cerchi in Lega ";
            this.prezzo = 400;
        }

        public override string Descrizione()
        {
            return this.auto.Descrizione() + " e " + this.descrizione;
        }

        public override int Prezzo()
        {
            return this.auto.Prezzo() + this.prezzo;
        }
    }
}
