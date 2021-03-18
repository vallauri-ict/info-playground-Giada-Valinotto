using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_02___IComparable
{
    class Persona : IComparable
    {
        private string nome;
        private string cognome;
        private string citta;

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Citta { get => citta; set => citta = value; }

        public Persona(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }

        int IComparable.CompareTo(Object obj)
        {
            // Ogni oggetto non null viene considerato > di null
            if (obj == null) return 1; // io sono maggiore
            Persona p = (Persona)obj;
            return String.Compare(this.Nome, p.Nome, true);
        }

        public override string ToString()
        {
            return Cognome+" "+Nome+" "+Citta;
        }
    }
}
