using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_06___OOP_Form_registrazione
{
    class Utente
    {
        public string cognome;
        public string nome;
        public string indirizzo;
        public string citta;
        public string cap;
        public string email;
        public string codiceFiscale;
        public string username;
        public string password;

        private Utente(string cognome, string nome, string indirizzo, string citta, string cap, string mail,string codiceFiscale, string username, string password)
        {
            this.cognome = cognome;
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.citta = citta;
            this.cap = cap;
            this.email = mail;
            this.codiceFiscale = codiceFiscale;
            this.username = username;
            this.password = password;
        }

      public static Utente creaUtente(string cognome, string nome, string indirizzo, string citta, string cap, string mail,string codiceFiscale, string username, string password)
        {
                Utente utente = new Utente(cognome, nome, indirizzo, citta, cap, mail,codiceFiscale, username, password);
                return utente;
        }
    }
}
