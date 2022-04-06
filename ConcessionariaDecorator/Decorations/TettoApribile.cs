using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaDecorator
{
    internal class TettoApribile : AutoDecorator
    {
        private Automobile auto;
        private string descrizione;
        private int prezzo;

        public TettoApribile(Automobile a)
        {
            this.auto = a;
            this.descrizione = "Tetto Apribile ";
            this.prezzo = 2500;
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
