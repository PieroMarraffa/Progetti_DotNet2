using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory
{
    internal class Moto : IVeicolo
    {
        private int telaio;
        private string descrizione;

        public Moto(int telaio, string desc)
        {
            this.telaio = telaio;
            this.descrizione = desc;
        }

        public override string ToString()
        {
            return ($"Moto telaio: {this.telaio}, Descrizione: {this.descrizione}");
        }
    }
}
