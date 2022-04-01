using CorsaCavalli;
internal class Program
{

    public static void Main(string[] args)
    {

        Cavallo pippo = new Cavallo("Pippo");
        Cavallo paperino = new Cavallo("Paperino");
        Cavallo pluto = new Cavallo("Pluto");
        Cavallo topolino = new Cavallo("Topolino");


        Console.WriteLine("Start: " + DateTime.Now.ToLongTimeString());
        Thread th1 = new Thread(pippo.DoWork);
        Thread th2 = new Thread(paperino.DoWork);
        Thread th3 = new Thread(pluto.DoWork);
        Thread th4 = new Thread(topolino.DoWork);
        th1.Start();
        th2.Start();
        th3.Start();
        th4.Start();
        th1.Join();
        th2.Join();
        th3.Join();
        th4.Join();
        
    }

    private static void EventCallback(string message)
    {
        Console.WriteLine("Main: " + message);
    }
}