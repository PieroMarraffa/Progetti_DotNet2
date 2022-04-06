namespace PatternDecorator
{
    internal class Ram8GB : ComputerDecorator
    {
        private Computer computer;
        private string descrizione;
        private int prezzo;

        public Ram8GB(Computer c)
        {
            this.computer = c;
            this.descrizione = "Ram 8GB";
            this.prezzo = 90;
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
