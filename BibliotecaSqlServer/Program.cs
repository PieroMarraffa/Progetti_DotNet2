using BibliotecaSqlServer.Models;

class Program
{
    public static void Main(string [] args)
    {

        //STRING DI CONNESSIONE
        //Scaffold-DbContext "Server=DESKTOP-7J82TJQ;Database=Biblioteca;Trusted_Connection=True;MultipleActiveResultSets=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f


        BibliotecaContext ctx = new BibliotecaContext();

        //Autori a = new Autori() { Nome = "Jules", Cognome= "Verne"};
        //ctx.Autoris.Add(a);
        //ctx.SaveChanges();

        //Libri l = new Libri();
        //l.Titolo = "20000 leghe sotto i mari";
        //l.Prezzo = 20;
        //l.IdAutore = a.IdAutore;
        //l.IdEditore = ctx.Editoris.Where(e => e.Descrizione.Equals("Mondadori")).First().IdEditori;

        //ctx.Libris.Add(l);
        //ctx.SaveChanges();

        #region SELECT ALL CON VISTA
        foreach (var l in ctx.VistaLibris)
        {
            Console.WriteLine($"Titolo: {l.Titolo}, Prezzo: {l.Prezzo}, Autore: {l.NomeAutore} {l.CognomeAutore}, Editore: {l.Editore}"); ;
        }
        #endregion

        #region SIMULO LA VISTA E LEGGO TUTTO

        //NEL foreach va messo il to list perché deve chiudere il DataReader interno...
        //altrimenti nella string adi connessione bisogna mettere il MultipleActiveResultSets=true;
        //Scaffold-DbContext "Server=DESKTOP-7J82TJQ;Database=Biblioteca;Trusted_Connection=True;MultipleActiveResultSets=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f
        foreach (var l in ctx.Libris.ToList())
        {
            var autore = ctx.Autoris.Where(a => a.IdAutore == l.IdAutore).First();
            var editore = ctx.Editoris.Where(e => e.IdEditori == l.IdEditore).First();

            Console.WriteLine($"Titolo: {l.Titolo}, Prezzo: {l.Prezzo}, Autore: {autore.Nome} {autore.Cognome}, Editore: {editore.Descrizione}");
        }

        #endregion
    }
}