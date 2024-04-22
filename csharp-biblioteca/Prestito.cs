using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        // Proprietà che rappresenta il documento in prestito.
        public Documento Documento { get; set; }

        // Proprietà che rappresenta l'utente che ha preso in prestito il documento.
        public Utente Utente { get; set; }

        // Proprietà che rappresenta la data di inizio del prestito.
        public DateTime DataInizio { get; set; }

        // Proprietà che rappresenta la data di fine del prestito.
        public DateTime DataFine { get; set; }

        // Costruttore della classe Prestito.
        public Prestito(Documento documento, Utente utente, DateTime dataInizio, DateTime dataFine)
        {
            Documento = documento;
            Utente = utente;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }
    }
}
