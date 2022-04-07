

using System.Data.SqlClient;

//per trovare il path da inserire cerca il sito: https://manpower.webex.com/manpower-it/url.php?frompanel=false&gourl=https%3A%2F%2Fwww.connectionstrings.com
//per cercare uno dei tanti server a cui connettersi (SQL Server) e seguire le istruzioni
//
//STRING CON NOME E PASSWORD
//string connString = "Server=;Database=Biblioteca;User_Id=root;Password=Piero2412";

//STRINGA CON ACCOUNT WINDOWS
string connString = "Server=DESKTOP-7J82TJQ;Database=Biblioteca;Trusted_Connection=true";

SqlConnection sqlConnection = new SqlConnection(connString);

try
{
    //provo a collegarmi
    sqlConnection.Open();
    Console.WriteLine("Connesso");

    //inserisco elementi
    //SqlCommand cmd = sqlConnection.CreateCommand();
    //cmd.CommandText = "insert into Autori (nome, cognome) values ('Agatha', 'Christie')";
    //int num = cmd.ExecuteNonQuery();
    //Console.WriteLine("Autore inserito");

    //leggo elementi
    //SqlCommand cmd = sqlConnection.CreateCommand();
    //cmd.CommandText = "select * from Autori";
    //SqlDataReader dr = cmd.ExecuteReader();
    //while (dr.Read())
    //{
    //    Console.WriteLine($"{dr["Nome"]}, {dr["Cognome"]}");
    //}


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    sqlConnection.Close();
}