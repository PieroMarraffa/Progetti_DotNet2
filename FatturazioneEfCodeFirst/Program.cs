using FatturazioneEfCodeFirst;
using FatturazioneEfCodeFirst.Models;

public class Program
{
    static void Main( string [] args)
    {
        fatturazioneContext ctx = new fatturazioneContext();

        ctx.Add(new Cliente() { Descrizione = "Apple" });
        ctx.Add(new Cliente() { Descrizione = "Microsoft" });
        ctx.Add(new Cliente() { Descrizione = "Google" });

        ctx.SaveChanges();

        var micr = ctx.Clienti.Where(x => x.Descrizione == "Microsoft").First();
        ctx.Add(new Fattura()
        {
            Descrizione = "Surface",
            Importo = 1100,
            DataFattura = new DateTime(2022, 4, 9),
            IdCliente = micr.Id,
        });
        ctx.SaveChanges();
    }
}