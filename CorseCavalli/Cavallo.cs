using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaCavalli
{
    internal class Cavallo
    {
        private string nome;
        Random random = new Random();

        public Cavallo(string Nome)
        {
            nome = Nome;
        }

        public void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                int delay = random.Next(250, 750);
                //Console.WriteLine(this.nome + ": " + delay);
                Thread.Sleep(delay);
            }
            Console.WriteLine("");
            Console.WriteLine($"{nome} E' ARRIVATO!!!");
            Console.WriteLine("TEMPO IMPIEGATO: " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("");
        }
    }
}
