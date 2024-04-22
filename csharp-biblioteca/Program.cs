using csharp_biblioteca;
using System;
using static csharp_biblioteca.Utente;

class Program
{
    static void Main(string[] args)
    {
        // Creo i nuovi dati utilizzando le classi
        Autore autore = new Autore("Maccio", "Capatonda");
        Utente utente1 = new Utente("Rossi", "Mario", "mariorossi46@email.com", "p@$$w0Rd", "3421458905");
        Libro libro = new Libro("JHG456", "Libro", 2020, "Storia", "A1", autore, 222);
        DVD dvd = new DVD("CBY762", "Italiano medio", 2015, "Film", "B1", autore, 100);

        // verifiche Utente
        Console.WriteLine("Dettagli Utente:");
        Console.WriteLine($"Cognome: {utente1.Cognome}");
        Console.WriteLine($"Nome: {utente1.Nome}");
        Console.WriteLine($"Email: {utente1.Email}");
        Console.WriteLine($"Password: {utente1.Password}");
        Console.WriteLine($"Recapito Telefonico: {utente1.RecapitoTelefonico}");

        // verifiche Libro
        Console.WriteLine("\nDettagli del libro:");
        Console.WriteLine($"Codice: {libro.Codice}");
        Console.WriteLine($"Titolo: {libro.Titolo}");
        Console.WriteLine($"Anno: {libro.Anno}");
        Console.WriteLine($"Settore: {libro.Settore}");
        Console.WriteLine($"Scaffale: {libro.Scaffale}");
        Console.WriteLine($"Autore: {libro.Autore.Nome} {libro.Autore.Cognome}");
        Console.WriteLine($"Numero Pagine: {libro.NumeroPagine}");

        // verifiche DVD
        Console.WriteLine("\nDettagli del DVD:");
        Console.WriteLine($"Codice: {dvd.Codice}");
        Console.WriteLine($"Titolo: {dvd.Titolo}");
        Console.WriteLine($"Anno: {dvd.Anno}");
        Console.WriteLine($"Settore: {dvd.Settore}");
        Console.WriteLine($"Scaffale: {dvd.Scaffale}");
        Console.WriteLine($"Autore: {dvd.Autore.Nome} {dvd.Autore.Cognome}");
        Console.WriteLine($"Durata: {dvd.Durata} minuti");
    }
}