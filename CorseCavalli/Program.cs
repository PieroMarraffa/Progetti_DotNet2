using CorsaCavalli;
internal class Program
{

    //CON THREAD E MAIN SINCRONO
    //public static void Main(string[] args)
    //{

    //    Cavallo pippo = new Cavallo("Pippo");
    //    Cavallo paperino = new Cavallo("Paperino");
    //    Cavallo pluto = new Cavallo("Pluto");
    //    Cavallo topolino = new Cavallo("Topolino");


    //    Console.WriteLine("Start: " + DateTime.Now.ToLongTimeString());
    //    Thread th1 = new Thread(pippo.DoWork);
    //    Thread th2 = new Thread(paperino.DoWork);
    //    Thread th3 = new Thread(pluto.DoWork);
    //    Thread th4 = new Thread(topolino.DoWork);
    //    th1.Start();
    //    th2.Start();
    //    th3.Start();
    //    th4.Start();
    //    th1.Join();
    //    th2.Join();
    //    th3.Join();
    //    th4.Join();
        
    //}

    private static void EventCallback(string message)
    {
        Console.WriteLine("Main: " + message);
    }

    //CON TASK E MAIN ASINCRONO
    //static async Task Main(string[] args)
    //{

    //    Cavallo pippo = new Cavallo("Pippo");
    //    Cavallo paperino = new Cavallo("Paperino");
    //    Cavallo pluto = new Cavallo("Pluto");
    //    Cavallo topolino = new Cavallo("Topolino");


    //    Console.WriteLine("Start: " + DateTime.Now.ToLongTimeString());

    //    Task t1 = Task.Factory.StartNew(() => pippo.DoWork());
    //    Task t2 = Task.Factory.StartNew(() => paperino.DoWork());
    //    Task t3 = Task.Factory.StartNew(() => pluto.DoWork());
    //    Task t4 = Task.Factory.StartNew(() => topolino.DoWork());

    //    await Task.WhenAll(t1, t2, t3, t4);
    //    //Task.WhenAll(t1, t2, t3, t4);

    //    Console.WriteLine("Finish: " + DateTime.Now.ToLongTimeString());
    //}

    static void Main(string[] args)
    {

        //con il CTS posso decidere di mandare i task in funzionamento finché non clicco
        //su un tasto o finché "evento"
        CancellationTokenSource cts = new CancellationTokenSource();
        var token = cts.Token;

        Cavallo pippo = new Cavallo("Pippo");
        Cavallo paperino = new Cavallo("Paperino");
        Cavallo pluto = new Cavallo("Pluto");
        Cavallo topolino = new Cavallo("Topolino");


        Console.WriteLine("Start: " + DateTime.Now.ToLongTimeString());

        Task t1 = Task.Factory.StartNew(() => pippo.DoWork(), token);
        Task t2 = Task.Factory.StartNew(() => paperino.DoWork(), token);
        Task t3 = Task.Factory.StartNew(() => pluto.DoWork(), token);
        Task t4 = Task.Factory.StartNew(() => topolino.DoWork(), token);

        //await Task.WhenAll(t1, t2, t3, t4);
        Task.WhenAll(t1, t2, t3, t4);

        //servizio per bloccare i task
        Console.WriteLine("clicca un tasto oer stoppare il processo");
        Console.ReadKey();

        //a tasto premuto:
        cts.Cancel();


        Console.WriteLine("Finish: " + DateTime.Now.ToLongTimeString());
    }
}