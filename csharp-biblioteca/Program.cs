using csharp_biblioteca;
using System;
using static csharp_biblioteca.Utente;

class Program
{
    static void Main(string[] args)
    {
        Utente utente1 = new Utente("Rossi", "Mario", "mario@email.com", "password123", "3421458905");
        Console.WriteLine($"Nome Utente: {utente1.Nome}");
        Console.WriteLine($"Cognome Utente: {utente1.Cognome}");
        Console.WriteLine($"Email Utente: {utente1.Email}");
        Console.WriteLine($"Password Utente: {utente1.Password}");
        Console.WriteLine($"Recapito Telefonico: {utente1.RecapitoTelefonico}");
    }
}