using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory
{
    public enum TipoVeicolo { Auto, Moto}
    internal class FabbricaVeicoli
    {
        private int id = 0;

        public IVeicolo GetVeicolo(TipoVeicolo tipo, string descrizione)
        {
            //Centralizzo ka new e creo gli oggetti in base ad un parametro
            
            switch (tipo)
            {
                case TipoVeicolo.Auto:
                    id++;
                    return new Automobile(id, descrizione);
                    break;
                case TipoVeicolo.Moto: 
                    id++;
                    return new Moto(id, descrizione);
                    break ;
                default: return null;
            }

        }
    }
}
