using ProgettoSqlServer.Models;

public class Program
{
    //FONDAMENTALE AVERE IL MAIN!!!
    public static void Main(string[] args)
    {
        //inserisci la seguente riga di comando in Console Gestione pacchetti
        //Scaffold-DbContext "Server=DESKTOP-7J82TJQ;Database=prova;Trusted_Connection=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


        provaContext ctx = new provaContext();

        #region INSERT
        //Persona persona = new Persona();

        //persona.Id = 3;
        //persona.Nome = "Piero";
        //persona.Cognome = "Marraffa";

        //ctx.Add(persona);

        //ctx.SaveChanges();
        #endregion

        #region SELECT
        ////linq
        //var riga = (from c in ctx.Personas
        //            where c.Id == 4
        //            select c).First();

        ////lambda
        //var riga2 = ctx.Personas.Where(f => f.Id == 4).First();
        #endregion

        #region UPDATE
        //riga.Nome = "Piero";
        //riga.Cognome = "Marraffa";
        //ctx.SaveChanges();
        #endregion

        #region DELETE
        //linq
        var delRiga = (from c in ctx.Personas
                       where c.Nome.Equals("Gabriele")
                       select c).First();

        //lambda
        var delRiga2 = ctx.Personas.Where(f => f.Nome.Equals("Gabriele"));

        ctx.Personas.Remove(delRiga);
        ctx.SaveChanges();
        #endregion

        #region SELECT ALL
        var all = from f in ctx.Fattures select f;
        foreach (var f in all)
        {
            Console.WriteLine($"{f.Id}) {f.Descrizione} Data: {f.DataFattura} Importo: {f.Importo}");
        }
        #endregion
    }
}