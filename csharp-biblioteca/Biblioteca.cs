using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        // Lista dei documenti presenti nella biblioteca.
        public List<Documento> documenti = new List<Documento>();

        // Lista degli utenti della biblioteca.
        public List<Utente> utenti = new List<Utente>();

        // Lista dei prestiti effettuati nella biblioteca.
        public List<Prestito> prestiti = new List<Prestito>();

        // Metodo per aggiungere un documento alla biblioteca.
        public void AggiungiDocumento(Documento documento)
        {
            documenti.Add(documento);
        }

        // Metodo per aggiungere un utente alla biblioteca.
        public void AggiungiUtente(Utente utente)
        {
            utenti.Add(utente);
        }

        // Metodo per aggiungere un prestito alla biblioteca.
        public void AggiungiPrestito(Prestito prestito)
        {
            prestiti.Add(prestito);
        }

        // Metodo per cercare un documento per codice.
        public Documento CercaDocumentoPerCodice(string codice)
        {
            return documenti.Find(doc => doc.Codice == codice);
        }

        // Metodo per cercare documenti per titolo.
        public List<Documento> CercaDocumentiPerTitolo(string titolo)
        {
            return documenti.FindAll(doc => doc.Titolo.Contains(titolo));
        }

        // Metodo per cercare i prestiti di un utente per nome e cognome.
        public List<Prestito> CercaPrestitiPerUtente(string nome, string cognome)
        {
            return prestiti.FindAll(prestito => prestito.Utente.Nome == nome && prestito.Utente.Cognome == cognome);
        }

        // Metodo per prendere in prestito un documento.
        public void PrendiInPrestito(string codiceDocumento, Utente utente, DateTime dal, DateTime al)
        {
            Documento documento = CercaDocumentoPerCodice(codiceDocumento);
            if (documento != null)
            {
                Prestito prestito = new Prestito(documento, utente, dal, al);
                AggiungiPrestito(prestito);
                Console.WriteLine($"Documento: {documento.Titolo}, preso in prestito da {utente.Nome} {utente.Cognome} dal {dal.ToShortDateString()} al {al.ToShortDateString()}.");
            }
            else
            {
                Console.WriteLine("Documento non trovato (┬┬﹏┬┬).");
            }
        }
    }
}
