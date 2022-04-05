using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteFactory
{
    internal class Primo : IPortata
    {
        private int id, tipo;
        private double prezzo;
        private string nome;

        public Primo(int id, int tipo, double prezzo, string nome)
        {
            this.id = id;
            this.tipo = tipo;
            this.prezzo = prezzo;
            this.nome = nome;
        }

        public int getTipo()
        {
            return tipo;
        }

        public override string ToString()
        {
            return ($"Nome del Piatto: {nome},    ${prezzo}");
        }
    }
}
