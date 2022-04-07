using CinemaSqlServer.Models;

public class Program
{
    private static CinemaContext ctx = new CinemaContext();
    public static void Main(string [] args)
    {
        //installa pèacchetti nuGet
        //Microsoft.EntityFrameworkCore
        //Microsoft.EntityFrameworkCore.Tools
        //Microsoft.EntityFrameworkCore.SqlServer

        //nella console di Gestione dei pacchetti inserisci la seguente stringa:
        //Scaffold-DbContext "Server=DESKTOP-7J82TJQ;Database=Cinema;Trusted_Connection=True;MultipleActiveResultSets=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f


        #region INIZIO

        Console.WriteLine("Benvenuto nel cinema!");
        inizio();

        #endregion

    }

    private static void inizio()
    {
        Console.WriteLine("");
        Console.WriteLine("scegli cosa fare: ");
        Console.WriteLine("1) aggiungi un film");
        Console.WriteLine("2) aggiungi un attore");
        Console.WriteLine("3) aggiungi un genere");
        Console.WriteLine("4) vedi il catalogo");
        Console.WriteLine("5) esci");

        try
        {
            int sceltaIniziale = int.Parse(Console.ReadLine());
            switch (sceltaIniziale)
            {
                case 1:
                    {
                        aggiungiFilm();
                        inizio();
                    }
                    break;
                case 2:
                    {
                        aggiungiAttore();
                        inizio();
                    }
                    break;
                case 3:
                    {
                        aggiungiGenere();
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

    private static void aggiungiFilm()
    {
        Console.WriteLine("");
        Console.WriteLine("inserisci il nome del film");
        string nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("inserisci l'anno di uscita del film (in numeri)");
        try
        {

            int annoUscita = int.Parse(Console.ReadLine());

            int idAttore = sceltaAttore();

            int idGenere = sceltaGenere();

            Film film = new Film();
            film.Titolo = nome;
            film.AnnoUscita = annoUscita;
            film.IdAttore = idAttore;
            film.IdGenere = idGenere;

            ctx.Add(film);

            ctx.SaveChanges();


        }
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
            inizio();
        }
    }

    private static int sceltaAttore()
    {
        int i = 1;
        var all = from a in ctx.Attoris.ToArray() select a;

        Console.WriteLine("");
        Console.WriteLine("scegli l'attore");

        Console.WriteLine($"{i}) Inserisci nuovo Attore");
        i++;

        foreach(var b in all)
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
                sceltaAttore();
            }
            else if (scegliAutore == 1)
            {
                return aggiungiAttore();
            }
            else
            {
                //Console.WriteLine(all.ToArray()[scegliAutore - 2].IdAttore);
                int idToReturn = all.ToArray()[scegliAutore - 2].IdAttore;
                return idToReturn;
            }
        } catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
            sceltaAttore();
        }
        return 0;
    } 

    private static int aggiungiAttore()
    {
        Attori attore = new Attori();

        Console.WriteLine("");
        Console.WriteLine("inserisci il nome dell'attore");
        string nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("inserisci il cognome dell'attore");
        string cognome = Console.ReadLine();

        attore.Cognome = cognome;
        attore.Nome = nome;


        ctx.Add(attore);

        ctx.SaveChanges();

        var IdToReturn = (from c in ctx.Attoris
                    where c.Nome.Equals(nome) && c.Cognome.Equals(cognome)
                    select c).First().IdAttore;

        return IdToReturn;
    }

    private static int sceltaGenere()
    {
        int i = 1;
        var all = from g in ctx.Generis.ToArray() select g;

        Console.WriteLine("");
        Console.WriteLine("scegli il genere");

        Console.WriteLine($"{i}) Inserisci nuovo Genere");
        i++;

        foreach (var b in all)
        {
            Console.WriteLine($"{i}) {b.Descrizione}");
            i++;
        }

        try
        {
            int scegliGenere = int.Parse(Console.ReadLine());

            if (scegliGenere == 0 || scegliGenere > i)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
                sceltaAttore();
            }
            else if (scegliGenere == 1)
            {
                return aggiungiGenere();
            }
            else
            {
                int idToReturn = all.ToArray()[scegliGenere - 2].IdGenere;
                return idToReturn;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("");
            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO.");
            sceltaGenere();
        }
        return 0;
    }

    private static int aggiungiGenere()
    {
        Generi genere = new Generi();

        Console.WriteLine("");
        Console.WriteLine("inserisci il genere");
        string nome = Console.ReadLine();

        genere.Descrizione = nome;

        ctx.Add(genere);

        ctx.SaveChanges();

        var IdToReturn = (from c in ctx.Generis
                          where c.Descrizione.Equals(nome)
                          select c).First().IdGenere;

        return IdToReturn;
    }

    private static void visualizzaTutti()
    {
        Console.WriteLine("");
        foreach (var l in ctx.VistaFilms)
        {
            Console.WriteLine($"Titolo: {l.Titolo}, Anno di Uscita: {l.AnnoUscita}, Attore: {l.NomeAttore} {l.CognomeAttore}, Genere: {l.Genere}"); ;
        }
    }

    private static void arrivederci()
    {
        Console.WriteLine("");
        Console.WriteLine("Arrivederci!!!");
    }

}
