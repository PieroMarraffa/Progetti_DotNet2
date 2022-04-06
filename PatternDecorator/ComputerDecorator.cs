namespace PatternDecorator
{
    abstract class ComputerDecorator : Computer
    {
        public ComputerDecorator()
        {

        }

        public abstract override string Descrizione();
        public abstract override int Prezzo();
    }
}
