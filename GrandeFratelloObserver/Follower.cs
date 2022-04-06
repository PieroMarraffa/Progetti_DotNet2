using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeFratelloObserver
{
    internal class Follower : IOsservatore
    {

        private string _name;

        public Follower(string nome)
        {
            _name = nome;
        }

        public void Aggiorna(string msg)
        {
            Console.WriteLine( _name + " riceve notifica: " + msg);
        }
    }
}
