using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        public int NumeroPagine { get; set; }

        // Costruttore della classe Libro.
        public Libro(string codice, string titolo, int anno, string settore, string scaffale, Autore autore, int numeroPagine) : base(codice, titolo, anno, settore, scaffale, autore)
        {
            NumeroPagine = numeroPagine;
        }
    }
}
