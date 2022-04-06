﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaDecorator
{
    internal class AriaEsterna : AutoDecorator
    {
        private Automobile auto;
        private string descrizione;
        private int prezzo;

        public AriaEsterna(Automobile a)
        {
            this.auto = a;
            this.descrizione = "Aria Standard ";
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
