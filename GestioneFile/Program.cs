//// See https://aka.ms/new-console-template for more information

//if (File.Exists("file2.txt"))
//    {
//        Console.WriteLine("sì esiste!");
//        string testo = File.ReadAllText("file2.txt");
//        Console.WriteLine(testo);
//}
//else Console.WriteLine("non esisteva");

////creo il file
////File.AppendAllText("file.txt", "ciao come va?");

//if (File.Exists("file.txt"))
//{
//    Console.WriteLine("sì esiste!");
//    string testo = File.ReadAllText("file.txt");
//    Console.WriteLine(testo);
//}
//else Console.WriteLine("non esisteva");

////VOGLIO LEGGERE RIGA PER RIGA UN FILE:
////questo file strea rappresenta il file stesso
//FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Read);

//StreamReader sr = null;

//try
//{
//    sr = new StreamReader(fs);

//    //voglio leggere riga per riga
//    while (!sr.EndOfStream)
//    {
//        Console.WriteLine(sr.ReadLine());
//    }

//} catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
////il finally viene sempre eseguito sia che si risolva il try che se salto al catch
//finally
//{
//    if (sr != null) sr.Close();
//    if(fs != null) fs.Close();
//}

//FileStream fs = new FileStream("file3.txt", FileMode.Append, FileAccess.Write);
//StreamWriter sw = null;
//try
//{
//    sw = new StreamWriter(fs);
//    string qualcosa = "";
//    while(qualcosa != "q")
//    {
//        Console.WriteLine("Scrivi qualcosa... (q per uscire)");
//        qualcosa = Console.ReadLine();
//        if (qualcosa.ToLower() == "q")
//        {
//            break;
//        }
//        else
//        {
//            sw.WriteLine(qualcosa);
//        }
//    }
    

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    if (sw != null) sw.Close();
//    if(fs != null) fs.Close();
//}

TextWriter tw = File.CreateText("impiegati.csv"); //csv = comma separated values
tw.WriteLine("ugo; fantozzi; 1200");
tw.WriteLine("piero; marraffa; 1600");
tw.Close();

TextReader tr = File.OpenText("impiegati.csv");
string riga = tr.ReadLine();
while(riga != null)
{
    //Console.WriteLine(riga);
    string[] dati = riga.Split(";");
    string nome = dati[0];
    string cognome = dati[1];
    string stipendio = dati[2];
    Console.WriteLine($"Nome: {nome}, Cognome: {cognome}, Stipendio: {stipendio}");
    riga = tr.ReadLine();
}
tr.Close();

