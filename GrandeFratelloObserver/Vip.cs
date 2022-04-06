using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeFratelloObserver
{
    internal class Vip
    {

        private string _name, _messaggio;

        private List<IOsservatore> followers = new List<IOsservatore>();

        public Vip(string nome)
        {
            _name = nome;
            _messaggio = _name + " sta fumando";
        }

        public void addOsservatore(IOsservatore oss)
        {
            followers.Add(oss);
            oss.Aggiorna(_messaggio);
        }

        public void removeOsservatore(IOsservatore oss)
        {
            followers.Remove(oss);
        }

        //Quando capita un evento rilevante, lo notifico a tutti gli osservatori
        public void Notifica(string notizia)
        {
            _messaggio = notizia;
            foreach (var oss in followers)
                oss.Aggiorna(notizia);
        }
    }
}
