using System.Text.Json;

namespace CREARE_UNA_NUOVA_APP_CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Creiamo un client per fare richieste web
            using (var client = new HttpClient())
            {
                try
                {
                    // Facciamo una richiesta GET per ottenere i dati da un sito
                    var response = client.GetAsync("https://jsonplaceholder.typicode.com/posts").Result;

                    // Leggiamo i dati che ci sono arrivati dalla risposta
                    var responseStream = response.Content.ReadAsStreamAsync().Result;

                    // Trasformiamo i dati JSON in una lista di oggetti
                    var responseData = JsonSerializer.DeserializeAsync<List<API_RESPONSE>>(responseStream).Result;

                    // Stampiamo le informazioni di ogni post
                    foreach (var post in responseData)
                    {
                        Console.WriteLine("User ID: " + post.UserId); // Mostra l'ID dell'utente
                        Console.WriteLine("ID: " + post.Id); // Mostra l'ID del post
                        Console.WriteLine("Title: " + post.Title); // Mostra il titolo del post
                        Console.WriteLine("Body: " + post.Body); // Mostra il corpo del post
                        Console.WriteLine("-------------------"); // Linea separatrice tra i post
                    }
                }
                catch (Exception ex) // Se c'è un errore, lo catturiamo
                {
                    // Mostra il messaggio di errore
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
