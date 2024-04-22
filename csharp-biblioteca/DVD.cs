using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class DVD : Documento
    {
        public int Durata { get; set; }

        // Costruttore della classe DVD.
        public DVD(string codice, string titolo, int anno, string settore, string scaffale, Autore autore, int durata) : base(codice, titolo, anno, settore, scaffale, autore)
        {
            Durata = durata;
        }
    }
}
