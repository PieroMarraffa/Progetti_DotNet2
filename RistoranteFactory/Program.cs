using RistoranteFactory;
using System.Collections.Generic;


class Program
{

    private static Dictionary<TipoPortata, List<IPortata>> menu = new Dictionary<TipoPortata, List<IPortata>>();
    //private static  List<IPortata> menu = new List<IPortata>();

    public static void Main(string [] args)
    {
        menu.Add(TipoPortata.Primo, new List<IPortata>());
        menu.Add(TipoPortata.Secondo, new List<IPortata>());
        menu.Add(TipoPortata.Dolce, new List<IPortata>());
        Console.WriteLine("Benvenuto chef, crea il menu...");
        sceltaAggiunta();
    }

    private static void sceltaAggiunta()
    {
        Console.WriteLine("");
        Console.WriteLine("cosa vuoi inserire?");
        Console.WriteLine("1) Primo");
        Console.WriteLine("2) Secondo");
        Console.WriteLine("3) Dolce");
        Console.WriteLine("4) Esci");
        try
        {
            int inserimento = int.Parse(Console.ReadLine());
            switch (inserimento)
            {
                case 1:
                    {
                        aggiungiPiatto(TipoPortata.Primo);
                    };
                    break;
                case 2:
                    {
                        aggiungiPiatto(TipoPortata.Secondo);
                    }
                    break;
                case 3:
                    {
                        aggiungiPiatto(TipoPortata.Dolce);
                    }
                    break;
                case 4:
                    {
                        arrivederci();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("hai inserito un codice non riconosciuto");
                        sceltaAggiunta();
                    }
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("hai inserito un codice non riconosciuto");
            sceltaAggiunta();
        }
    }

    private static void aggiungiPiatto(TipoPortata tipo)
    {
        Factory factory = new Factory();
        Console.WriteLine("");
        Console.WriteLine("inserisci il nome del piatto");
        string nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("inserisci il prezzo del piatto");
        try
        {
            double prezzo = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("stai inserendo nel menu il seguente piatto");
            IPortata portata = factory.GetPortata(tipo, nome, prezzo);
            Console.WriteLine(portata);
            Console.WriteLine("Continuare? (y per continuare altro per uscire)");
            string continuare = Console.ReadLine();
            if (continuare.ToLower().Equals("y")){
                IPortata piatto = factory.GetPortata(tipo, nome, prezzo);
                menu[tipo].Add(piatto);
                //menu.Add(piatto);
                sceltaAggiunta();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("richiesta annullata!");
                sceltaAggiunta();
            }
        } 
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("hai inserito un valore non riconosciuto");
            aggiungiPiatto(tipo);
        }
    }

    //VERSIONE MENU =  LISTA
    //private static void arrivederci()
    //{
    //    Console.WriteLine("");
    //    Console.WriteLine("Primi Piatti del menu:");
    //    foreach (var item in menu)
    //    {
    //        if (item.getTipo() == 1)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //    Console.WriteLine("");
    //    Console.WriteLine("Secondi Piatti del menu:");
    //    foreach (var item in menu)
    //    {
    //        if (item.getTipo() == 2)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //    Console.WriteLine("");
    //    Console.WriteLine("Dolci del menu:");
    //    foreach (var item in menu)
    //    {
    //        if (item.getTipo() == 3)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}


    //VERSIONE MENU = DIZIONARIO
    private static void arrivederci()
    {

        Console.WriteLine("");
        Console.WriteLine("primi piatti del menu: ");
        foreach(var item in menu[TipoPortata.Primo])
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("");
        Console.WriteLine("secondi piatti del menu: ");
        foreach (var item in menu[TipoPortata.Secondo])
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("");
        Console.WriteLine("dolci del menu: ");
        foreach (var item in menu[TipoPortata.Dolce])
        {
            Console.WriteLine(item.ToString());
        }
    }
}

