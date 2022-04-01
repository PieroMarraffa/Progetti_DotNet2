using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiegazioneThread
{

    public delegate void JobMessage(string message);
    internal class Job
    {
        private string nome;
        private int delay;

        public event JobMessage Invia;

        public Job(string Nome, int Delay)
        {
            nome = Nome;
            delay = Delay;
        }

        public void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Invia(this.nome + ": " + this.delay);
                Thread.Sleep(delay);
            }
        }
    }
}
