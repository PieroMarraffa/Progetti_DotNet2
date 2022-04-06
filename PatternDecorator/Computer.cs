namespace PatternDecorator
{
    internal class Computer
    {
        private string descrizione;
        private int prezzo;

        public Computer()
        {
            descrizione = "Computer Base";
            prezzo = 300;
        }

        public virtual string Descrizione()
        {
            return descrizione;
        }

        public virtual int Prezzo()
        {
            return prezzo;
        }
    }
}
