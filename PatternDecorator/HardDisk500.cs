namespace PatternDecorator
{
    internal class HardDisk500 : ComputerDecorator
    {
        private Computer computer;
        private string descrizione;
        private int prezzo;

        public HardDisk500(Computer c)
        {
            this.computer = c;
            this.descrizione = "Hard Disk 500GB";
            this.prezzo = 80;
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
