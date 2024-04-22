using csharp_biblioteca;
using System;
using static csharp_biblioteca.Utente;

class Program
{
    static void Main(string[] args)
    {
        // Creo i nuovi dati utilizzando le classi

        // Creazioni utenti
        Utente utente1 = new Utente("Rossi", "Mario", "mariorossi46@email.com", "p@$$w0Rd", "3421458905");

        // verifiche Utente
        Console.WriteLine("\nDettagli Utente:");
        Console.WriteLine($"Cognome: {utente1.Cognome}");
        Console.WriteLine($"Nome: {utente1.Nome}");
        Console.WriteLine($"Email: {utente1.Email}");
        Console.WriteLine($"Password: {utente1.Password}");
        Console.WriteLine($"Recapito Telefonico: {utente1.RecapitoTelefonico}");

        // Creazioni Autori
        Autore autore = new Autore("Maccio", "Capatonda");
        Autore autore2 = new Autore("Paolo", "Sorrentino");
        Autore autore3 = new Autore("Matteo", "Garrone");

        // Creazione documenti
        Libro libro = new Libro("JHG456", "Libro", 2020, "Storia", "A1", autore, 222);
        Libro libro2 = new Libro("GHF123", "La grande bellezza", 2013, "Romanzo", "C2", autore2, 400);
        DVD dvd = new DVD("CBY762", "Italiano medio", 2015, "Film", "B1", autore, 100);
        DVD dvd2 = new DVD("DEF789", "È stata la mano di Dio", 2021, "Drammatico", "D3", autore3, 130);

        // Creazione di un'istanza di biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Aggiunta dei documenti alla biblioteca
        biblioteca.AggiungiDocumento(libro);
        biblioteca.AggiungiDocumento(libro2);
        biblioteca.AggiungiDocumento(dvd);
        biblioteca.AggiungiDocumento(dvd2);

        // Stampa dei dettagli dei documenti aggiunti
        Console.WriteLine("\nDettagli dei documenti aggiunti:");
        foreach (var documento in biblioteca.documenti)
        {
            Console.WriteLine($"Codice: {documento.Codice}, Titolo: {documento.Titolo}, Autore: {documento.Autore.Nome} {documento.Autore.Cognome}");
        }

        // Aggiunta dell'utente alla biblioteca
        biblioteca.AggiungiUtente(utente1);

        // Ricerca di un documento per codice
        Console.WriteLine("\nRicerca di un documento per codice: codice prova GHF123");
        Documento documentoPerCodice = biblioteca.CercaDocumentoPerCodice("GHF123");
        Console.WriteLine($"Documento trovato: Titolo: {documentoPerCodice.Titolo}, Autore: {documentoPerCodice.Autore.Nome} {documentoPerCodice.Autore.Cognome}");

        // Ricerca di un documento per titolo
        Console.WriteLine("\nRicerca di documenti per titolo: titolo prova Libro");
        var documentiPerTitolo = biblioteca.CercaDocumentiPerTitolo("Libro");
        foreach (var documento in documentiPerTitolo)
        {
            Console.WriteLine($"Documento trovato: Titolo: {documento.Titolo}, Autore: {documento.Autore.Nome} {documento.Autore.Cognome}");
        }

        // Prendere in prestito un documento
        Console.WriteLine("\nPrendere in prestito un documento:");
        biblioteca.PrendiInPrestito("DEF789", utente1, DateTime.Today, DateTime.Today.AddDays(14));
        biblioteca.PrendiInPrestito("CBY762", utente1, DateTime.Today, DateTime.Today.AddDays(7));

        // Ricerca dei prestiti di un utente per nome e cognome
        Console.WriteLine("\nRicerca dei prestiti di un utente per nome e cognome:");
        var prestitiUtente = biblioteca.CercaPrestitiPerUtente("Mario", "Rossi");
        foreach (var prestito in prestitiUtente)
        {
            Console.WriteLine($"Documento in prestito: {prestito.Documento.Titolo}, Prestito dal {prestito.DataInizio.ToShortDateString()} al {prestito.DataFine.ToShortDateString()}");
        }
    }
}