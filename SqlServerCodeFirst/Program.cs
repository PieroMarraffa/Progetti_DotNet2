//in questa modalità partiamo dal codice e dalla generazione delle tabelle
//per poi derivarne la creazione del DB su SQL Server

using SqlServerCodeFirst.Models;

class Program
{
    private static void Main(string [] args)
    {
        //installo i pacchetti nuGet
        //Microsoft.EntityFrameworkCore
        //Microsoft.EntityFrameworkCore.Tools
        //Microsoft.EntityFrameworkCore.SqlServer

        //1) creo le classo Model (Fondamentale DEFINISCI CHIAVE PRIMARIA o chiama unn attributo "int ID"!!!)
        //2) creo poi il context che deve ereditare da DbContext!!!
        //      ne context definisco le classi che saranno tabelle nel DB
        //      faccio  l'override del metodo OnConfiguring(DbContextOptionsBuilder opt)
        //      dove do all'utente i permessi per creare il DB
        //3) scrivo nella console nuget "add-migration Iniziale" 
        //4) scrivo nella console nuget "update-database" per caricare il DB sul server

        //


        //OGNI VOLTA CHE VADO A FARE UN CAMBIAMENTO DEVO ESEGUIRE UNA MIGRATION E POI ESEGUIRE UN UPDATE-DATABASE

        NegozioContext ctx = new NegozioContext();

        Prodotto p = new Prodotto() { Descrizione = "Pasta Barilla", Prezzo = 3 };

        ctx.Prodotti.Add(p);
        ctx.SaveChanges();
    }
}