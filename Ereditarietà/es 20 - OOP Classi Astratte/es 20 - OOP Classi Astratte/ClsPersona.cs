using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_20___OOP_Classi_Astratte
{
    abstract class ClsPersona
    {
        #region attributi
        private string nome;
        private string cognome;
        private string citta;

        public string Nome {
            get => nome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Nome non valido");
                }
            }
        }
        public string Cognome {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Cognome non valido");
                }
            }
        }
        public string Citta {
            get => citta;
            set
            {
            if(value.Trim().Length>=2)
                {
                    citta = value;
                }
            else
                {
                    throw new Exception("Città non valida");
                }
            }
        }
        #endregion
        protected ClsPersona (string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }
    }
}
