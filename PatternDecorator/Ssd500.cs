namespace PatternDecorator
{
    internal class Ssd500 : ComputerDecorator
    {
        private Computer computer;
        private string descrizione;
        private int prezzo;

        public Ssd500(Computer c)
        {
            this.computer = c;
            this.descrizione = "SSD 500GB";
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
