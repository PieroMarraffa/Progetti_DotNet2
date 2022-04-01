using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellulariConFile
{
    internal class Cellulare
    {
        //ATTRIBUTI
        private string marca, modello;
        private double prezzo;

        public Cellulare()
        {

        }

        public Cellulare(string Marca, string Modello, double Prezzo)
        {
            this.marca = Marca;
            this.modello = Modello;
            this.prezzo = Prezzo;
        }

        public string getMarca()
        {
            return marca;
        }

        public string getModello()
        {
            return modello;
        }

        public double getPrezzo()
        {
            return prezzo;
        }

        public void setMarca(string str)
        {
            this.marca = str;
        }

        public void setModello(string str)
        {
            this.modello = str;
        }

        public void setPrezzo(double pr)
        {
            this.prezzo=pr;
        }

        public override string ToString()
        {
            return ($"Marca: {marca}; Modello: {modello}; Prezzo: {prezzo}");
        }
    }
}
