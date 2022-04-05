using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteFactory
{

    public enum TipoPortata { Primo, Secondo, Dolce}
    internal class Factory
    {
        private int id = 0;

        public IPortata GetPortata(TipoPortata portata, string nome, double prezzo)
        {
            switch (portata)
            {
                case TipoPortata.Primo:
                    {
                        id++;
                        return new Primo(id,1, prezzo, nome);
                    };
                    break;
                case TipoPortata.Secondo:
                {
                        id++;
                        return new Secondo(id,2, prezzo, nome);
                }; 
                    break;
                case TipoPortata.Dolce:
                    {
                        id++;
                        return new Dolce(id,3, prezzo, nome);
                    }; 
                    break;
                default: return null;
                    break;
            }
        }
    }
}
