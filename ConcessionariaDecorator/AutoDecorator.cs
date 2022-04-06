using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcessionariaDecorator;

namespace ConcessionariaDecorator
{
    internal abstract class AutoDecorator : Automobile
    {
        public AutoDecorator()
        {

        }

        public abstract override string Descrizione();

        public abstract override int Prezzo();
    }
}
