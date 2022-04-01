// See https://aka.ms/new-console-template for more information

class Program
{

    //dichiaro il main asincrono. Cioé posso lanciare i thread agilmente
    //senza richiamare la classe thread
    static async Task Main(string[] args)
    {
        int i = Test();
        Console.WriteLine("Ciao dal main");
    }

    static async Task<int> Test()
    {
        int i = 0;
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("Test, step: " + i);
            Thread.Sleep(500);
        }
        return i;
    }
}