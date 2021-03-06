using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaDecorator
{
    internal class CerchiStandard : AutoDecorator
    {
        private Automobile auto;
        private string descrizione;
        private int prezzo;

        public CerchiStandard(Automobile a)
        {
            this.auto = a;
            this.descrizione = "Cerchi standard";
            this.prezzo = 0;
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
