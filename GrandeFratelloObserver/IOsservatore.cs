using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeFratelloObserver
{
    internal interface IOsservatore
    {
        void Aggiorna(string msg);
    }
}
