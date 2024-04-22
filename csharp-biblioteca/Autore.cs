using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        // Costruttore della classe Autore.
        public Autore(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
    }
}
