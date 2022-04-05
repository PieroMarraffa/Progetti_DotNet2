using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory
{
    internal class Automobile : IVeicolo
    {
        private int telaio;
        private string descrizione;

        public Automobile(int telaio, string desc)
        {
            this.telaio = telaio;
            this.descrizione = desc;
        }

        public override string ToString()
        {
            return ($"Auto telaio: {this.telaio}, Descrizione: {this.descrizione}");
        }
    }
}
