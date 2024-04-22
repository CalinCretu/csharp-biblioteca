using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RecapitoTelefonico { get; set; }

        // Costruttore per inizializzare un nuovo utente
        public Utente(string cognome, string nome, string email, string password, string recapitoTelefonico)
        {
            // Thread.Sleep(1);    //Per evitare il problema dei random duplicati
            Cognome = cognome;
            Nome = nome;
            Email = email;
            Password = password;
            RecapitoTelefonico = recapitoTelefonico;
        }
    }
}