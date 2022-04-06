using ConcessionariaDecorator;

Automobile auto = new Automobile();

Console.WriteLine("Vuoi cerchi in lega (L) o cerchi standard (S)?");
string ris = Console.ReadLine();

if (ris.ToUpper().Equals("L"))
{
    auto = new CerchiInLega(auto);
}
else
{
    auto = new CerchiStandard(auto);
}

Console.WriteLine("Vuoi l'aria condizionata (C) o  l'aria standard (S)?");
string ris2 = Console.ReadLine();

if (ris2.ToUpper().Equals("C"))
{
    auto = new AriaCondizionata(auto);
}
else
{
    auto = new AriaEsterna(auto);
}

Console.WriteLine("Vuoi un tetto apribile (A) o uno standard (S)?");
string ris3 = Console.ReadLine();

if (ris3.ToUpper().Equals("A"))
{
    auto = new TettoApribile(auto);
}
else
{
    auto = new TettoStandard(auto);
}

Console.WriteLine("Configurazione finale: ");
Console.WriteLine(auto.Descrizione());
Console.WriteLine("prezzo finale: " + auto.Prezzo() + " euro");