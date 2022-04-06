namespace PatternDecorator
{
    internal class Ram16GB : ComputerDecorator
    {
        private Computer computer;
        private string descrizione;
        private int prezzo;

        public Ram16GB(Computer c)
        {
            this.computer = c;
            this.descrizione = "Ram 16GB";
            this.prezzo = 160;
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
