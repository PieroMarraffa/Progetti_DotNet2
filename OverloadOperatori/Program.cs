// See https://aka.ms/new-console-template for more information
using OverloadOperatori;
Console.WriteLine("BENVENUTO!!!");
Console.WriteLine("");
Console.WriteLine("INSERISCI IL LATO DEL PRIMO QUADRATO:");

Quadrato quadrato1 = new Quadrato();
bool avanti = false;
do
{
    try
    {
        double lato1 = double.Parse(Console.ReadLine());
        quadrato1 = new Quadrato(lato1);
        avanti = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("");
        Console.WriteLine("INSERISCI UN NUMERO VALIDO: ");
    }
} while (!avanti);


Console.WriteLine("");
Console.WriteLine("INSERISCI IL LATO DEL SECONDO QUADRATO:");
Quadrato quadrato2 = new Quadrato();
bool avanti2 = false;
do
{
    try
    {
        double lato2 = double.Parse(Console.ReadLine());
        quadrato2 = new Quadrato(lato2);
        avanti2 = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("");
        Console.WriteLine("INSERISCI UN NUMERO VALIDO: ");
    }
} while (!avanti2);

Console.WriteLine("");
Console.WriteLine("LA SOMMA DEI DUE QUADRATI RESTITUISCE UN QUADRATO DI LATO: ");
Console.WriteLine((quadrato1 + quadrato2).getLato());