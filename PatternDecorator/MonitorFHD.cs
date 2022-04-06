namespace PatternDecorator
{
    internal class MonitorFHD : ComputerDecorator
    {
        private Computer computer;
        private string descrizione;
        private int prezzo;

        public MonitorFHD(Computer c)
        {
            this.computer = c;
            this.descrizione = "Monitor Full HD";
            this.prezzo = 200;
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
