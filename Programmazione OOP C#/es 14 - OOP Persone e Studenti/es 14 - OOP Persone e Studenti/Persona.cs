using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_14___OOP_Persone_e_Studenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void SetAttributes(string nome, string cognome, string sesso, int eta)
        {
            if (String.IsNullOrWhiteSpace(nome) || String.IsNullOrWhiteSpace(cognome) || String.IsNullOrWhiteSpace(sesso) || eta < 0)
            {
                throw new Exception("Inserire i campi corretti!");
            }
            else
            {
                GetAttributes( nome,  cognome,  sesso,  eta);
            }
        }

        public string GetNome()
        {
            return this.nome;
        }
        public string GetCognome()
        {
            return this.cognome;
        }
        public string GetSesso()
        {
            return this.sesso;
        }
        public int GetEta()
        {
            return this.eta;
        }
        public void GetAttributes(string nome, string cognome, string sesso, int eta)
        {
            nome = this.nome;
            cognome = this.cognome;
            sesso = this.sesso;
            eta = this.eta;
        }
    }
}
