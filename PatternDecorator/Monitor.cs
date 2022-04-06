namespace PatternDecorator
{
    internal class Monitor : ComputerDecorator
    {
        private Computer computer;
        private string descrizione;
        private int prezzo;

        public Monitor(Computer c)
        {
            this.computer = c;
            this.descrizione = "Monitor Standard";
            this.prezzo = 100;
        }

        public override string Descrizione()
        {
            return this.computer.Descrizione() + " e " + this.descrizione;
        }

        public override int Prezzo()
        {
            return this.computer.Prezzo() + this.prezzo;
        }
    }
}
