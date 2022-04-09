

using ProvaTemplateEFCF.Models;

public class Program
{

    static ApplicationDbContext ctx = new ApplicationDbContext();

    static void Main(string [] args)
    {
        #region INIZIO

        Console.WriteLine("Benvenuto nella bibioteca!");
        inizio();

        #endregion

    }

    private static void inizio()
    {
        Console.WriteLine("");
        Console.WriteLine("scegli cosa fare: ");
        Console.WriteLine("1) aggiungi un libro");
        Console.WriteLine("2) aggiungi un autore");
        Console.WriteLine("3) aggiungi un editore");
        Console.WriteLine("4) vedi il catalogo");
        Console.WriteLine("5) esci");

        try
        {
            int sceltaIniziale = int.Parse(Console.ReadLine());
            switch (sceltaIniziale)
            {
                case 1:
                    {
                        aggiungiLibro();
                        inizio();
                    }
                    break;
                case 2:
                    {
                        aggiungiAutore();
                        inizio();
                    }
                    break;
                case 3:
                    {
                        aggiungiEditore();
                        inizio();
                    }
                    break;
                case 4:
                    {
                        visualizzaTutti();
                        inizio();
                    }
                    break;
                case 5:
                    {
                        arrivederci();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
                        inizio();
                    }
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
            inizio();
        }
    }

    private static void aggiungiLibro()
    {
        Console.WriteLine("");
        Console.WriteLine("inserisci il titolo del libro: ");
        string nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("inserisci il prezzo: ");
        try
        {

            int prezzo = int.Parse(Console.ReadLine());

            int idAutore = sceltaAutore();

            int idEditore = sceltaEditore();

            Libro libro = new Libro();
            libro.Titolo = nome;
            libro.Prezzo = prezzo;
            libro.IdEditore = idEditore;
            libro.IdAutore = idAutore;

            ctx.Add(libro);

            ctx.SaveChanges();


        }
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
            inizio();
        }
    }

    private static int sceltaAutore()
    {
        int i = 1;
        var all = from a in ctx.Autori.ToArray() select a;

        Console.WriteLine("");
        Console.WriteLine("scegli l'autore");

        Console.WriteLine($"{i}) Inserisci nuovo Autore");
        i++;

        foreach (var b in all)
        {
            Console.WriteLine($"{i}) {b.Nome} {b.Cognome}");
            i++;
        }

        try
        {
            int scegliAutore = int.Parse(Console.ReadLine());

            if (scegliAutore == 0 || scegliAutore > i)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
                sceltaAutore();
            }
            else if (scegliAutore == 1)
            {
                return aggiungiAutore();
            }
            else
            {
                int idToReturn = all.ToArray()[scegliAutore - 2].ID;
                return idToReturn;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
            sceltaAutore();
        }
        return 0;
    }

    private static int aggiungiAutore()
    {
        Autore autore = new Autore();

        Console.WriteLine("");
        Console.WriteLine("inserisci il nome dell'autore");
        string nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("inserisci il cognome dell'autore");
        string cognome = Console.ReadLine();

        autore.Cognome = cognome;
        autore.Nome = nome;


        ctx.Add(autore);

        ctx.SaveChanges();

        var IdToReturn = (from c in ctx.Autori
                          where c.Nome.Equals(nome) && c.Cognome.Equals(cognome)
                          select c).First().ID;

        return IdToReturn;
    }

    private static int sceltaEditore()
    {
        int i = 1;
        var all = from g in ctx.Editori.ToArray() select g;

        Console.WriteLine("");
        Console.WriteLine("scegli l'editore");

        Console.WriteLine($"{i}) Inserisci nuovo Editore");
        i++;

        foreach (var b in all)
        {
            Console.WriteLine($"{i}) {b.Descrizione}");
            i++;
        }

        try
        {
            int scegliEditore = int.Parse(Console.ReadLine());

            if (scegliEditore == 0 || scegliEditore > i)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
                sceltaAutore();
            }
            else if (scegliEditore == 1)
            {
                return aggiungiEditore();
            }
            else
            {
                int idToReturn = all.ToArray()[scegliEditore - 2].ID;
                return idToReturn;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
            sceltaEditore();
        }
        return 0;
    }

    private static int aggiungiEditore()
    {
        Editore editore = new Editore();

        Console.WriteLine("");
        Console.WriteLine("inserisci l'editore");
        string nome = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("inserisci la sede");
        string sede = Console.ReadLine();

        editore.Descrizione = nome;
        editore.Sede = sede;

        ctx.Add(editore);

        ctx.SaveChanges();

        var IdToReturn = (from c in ctx.Editori
                          where c.Descrizione.Equals(nome)
                          select c).First().ID;

        return IdToReturn;
    }

    private static void visualizzaTutti()
    {
        Console.WriteLine("");
        //foreach (var l in ctx.VistaFilms)
        //{
        //    Console.WriteLine($"Titolo: {l.Titolo}, Anno di Uscita: {l.AnnoUscita}, Attore: {l.NomeAttore} {l.CognomeAttore}, Genere: {l.Genere}"); ;
        //}
    }

    private static void arrivederci()
    {
        Console.WriteLine("");
        Console.WriteLine("Arrivederci!!!");
    }
}