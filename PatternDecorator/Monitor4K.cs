using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator
{
    internal class Monitor4K : ComputerDecorator
    {
        private Computer computer;
        private string descrizione;
        private int prezzo;

        public Monitor4K(Computer c)
        {
            this.computer = c;
            this.descrizione = "Monitor 4k";
            this.prezzo = 350;
        }

        public override string Descrizione()
        {
            return this.computer.Descrizione() + " e " + this.descrizione;
        }

        public override int Prezzo()
        {
            return this.computer.Prezzo() + this.prezzo;
        }
    }
}
