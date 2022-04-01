// See https://aka.ms/new-console-template for more information

class Program
{

    //dichiaro il main asincrono. Cioé posso lanciare i thread agilmente
    //senza richiamare la classe thread
    static async Task Main(string[] args)
    {
        Task<int> z = Test(); //parte in un thread
        // int i = await Test(); 
        Console.WriteLine("Ciao dal main"); 
        Console.WriteLine("res =  " + z.Result); //la result mi costringe ad aspettare

        int i = await Test(); 
        Console.WriteLine("Ciao dal main");//ora invece aspetta già da qui per l'AWAIT
        Console.WriteLine("res =  " + i);
    }

    static async Task<int> Test()
    {
        int i = 0;

        await Task.Run(() =>
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Test, step: " + i);
                Thread.Sleep(500);
            }
        });
        return i;
    }
}