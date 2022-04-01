// See https://aka.ms/new-console-template for more information
using CellulariConFile;


List<Cellulare> cellulari = new List<Cellulare>();
Console.WriteLine("");
Console.WriteLine("BENVENUTO!!!");

Console.WriteLine("");
Console.WriteLine("INSERIRE UN CELLULARE? (y per continuare, qualunqeu altro tasto per chiudere)");
string inizio = Console.ReadLine();

while (inizio.ToLower().Equals("y"))
{
    Console.WriteLine("");
    Console.WriteLine("INSERISCI LA MARCA");
    string marca = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("INSERISCI LA MODELLO");
    string modello = Console.ReadLine();
    double prezzo = 0;

    bool buonInserimentoPrezzo = false;
    do
    {
        Console.WriteLine("");
        Console.WriteLine("INSERISCI LA PREZZO");
        try
        {
            prezzo = double.Parse(Console.ReadLine());
            buonInserimentoPrezzo = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("HAI INSERITO UN PREZZO NON VALIDO");
        }
        
    } while (!buonInserimentoPrezzo);



    Cellulare cellulare = new Cellulare(marca, modello, prezzo);
    cellulari.Add(cellulare);

    Console.WriteLine("");
    Console.WriteLine("INSERIRE UN ALTRO CELLULARE? (y per continuare, qualunqeu altro tasto per chiudere)");
    inizio = Console.ReadLine();
}

cellulari.ToFile("cellulari.csv");

List<string> str = new List<string> { "ciao", "miao", "ziao" };
str.ToFile("stringhette.txt");

TextReader tr = File.OpenText("cellulari.csv");
string riga = tr.ReadLine();
while (riga != null)
{
    Console.WriteLine(riga);
    riga = tr.ReadLine();
}
tr.Close();

