using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatori
{
    internal class Quadrato
    {
        private double lato;

        public Quadrato() { }

        public Quadrato(double l)
        {
            lato = l;
        }

        public double getLato()
        {
            return lato;
        }

        public void setLato(double l)
        {
            this.lato = l;
        }

        public double getPerimetro()
        {
            return (lato * 4);
        }

        public double getArea()
        {
            return (lato * lato);
        }

        public static Quadrato operator +(Quadrato q1, Quadrato q2)
        {
            return (new Quadrato(Math.Sqrt(q1.getArea() + q2.getArea())));
        }

    }
}
