// See https://aka.ms/new-console-template for more information
using SpiegazioneThread;

//Job job = new Job("Job 1", 500);
//Job job2 = new Job("Job 2", 500);

//Console.WriteLine("Start: " + DateTime.Now.ToLongTimeString());
//job.DoWork();
//job2.DoWork();
//Console.WriteLine("Finish: " + DateTime.Now.ToLongTimeString());


//così dovrebbero partire in parallelo
//Console.WriteLine("Start: " + DateTime.Now.ToLongTimeString());
//Thread th1 = new Thread(job.DoWork);
//Thread th2 = new Thread(job2.DoWork);
//th1.Start();
//th2.Start();
//th1.Join();
//th2.Join();
//Console.WriteLine("Finish: " + DateTime.Now.ToLongTimeString());

//stampa start e finish perché girano sul main mentre le altre girano
//in parallelo sui thread

//con il JOIN dico al main di attendere la fine dei due thread

//Job job3 = new Job("Job 3", 500);
//Console.WriteLine("Start: " + DateTime.Now.ToLongTimeString());
//Thread th1 = new Thread(job.DoWork);
//Thread th2 = new Thread(job2.DoWork);
//Thread th3 = new Thread(job3.DoWork);
//th1.Start();
//th2.Start();
//th3.Start();
//th1.Join();
//th2.Join();
//th3.Join();
//Console.WriteLine("Finish: " + DateTime.Now.ToLongTimeString());

//ora ho visto che funziona veramente in parallelo

internal class Program
{

    public static void Main(string [] args)
    {

        Job job1 = new Job("Job 1", 500);
        Job job2 = new Job("Job 2", 500);
        Job job3 = new Job("Job 3", 500);

        job1.Invia += EventCallback;
        job2.Invia += EventCallback;
        job3.Invia += EventCallback;

        Thread th1 = new Thread(job1.DoWork);
        Thread th2 = new Thread(job2.DoWork);
        Thread th3 = new Thread(job3.DoWork);
        th1.Start();
        th2.Start();
        th3.Start();
        th1.Join();
        th2.Join();
        th3.Join();
    }

    private static void EventCallback(string message)
    {
        Console.WriteLine("Main: " + message);
    }
}