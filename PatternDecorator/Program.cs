using PatternDecorator;




//QUESTO PATTERN MI EVITA DI PROGETTARE LE CLASSI IN MODO TROPPO INTRICATO
//LASCIANDO AD OGNUNA UN SOLO COMPITO.
//IN PARTICOLARE AGGIUNGE DEI METODI ALLA CLASSE DI BASE (computer) IN RUNTIME




Computer pc = new Computer();

Console.WriteLine("Vuoi 8gb di ram (a) o 16gb di ram (b)?");
string ris = Console.ReadLine();

if (ris.Equals("a"))
{
    pc = new Ram8GB(pc);
}
else
{
    pc = new Ram16GB(pc);
}

Console.WriteLine("Vuoi un Hard Disk da 500GB (a) o una SSD da 500GB (b)?");
string ris2 = Console.ReadLine();

if (ris2.Equals("a"))
{
    pc = new HardDisk500(pc);
}
else
{
    pc = new Ssd500(pc);
}

Console.WriteLine("Vuoi un monitor standard (a), uno Full HD (b) o un 4k(c)?");
string ris3 = Console.ReadLine();

if (ris3.Equals("a"))
{
    pc = new PatternDecorator.Monitor(pc);
}
else if(ris3.Equals("b"))
{
    pc = new MonitorFHD(pc);
}
else
{
    pc = new Monitor4K(pc);
}

Console.WriteLine("Configurazione finale: ");
Console.WriteLine(pc.Descrizione());
Console.WriteLine("prezzo finale: " + pc.Prezzo() + " euro");
