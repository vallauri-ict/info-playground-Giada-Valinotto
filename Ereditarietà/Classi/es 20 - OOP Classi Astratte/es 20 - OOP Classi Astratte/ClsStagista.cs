using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_20___OOP_Classi_Astratte
{
    class ClsStagista : ClsAlunno
    {
        #region attributi
        private string azienda;
        private int ore;
        #endregion

        internal string Azienda { get => azienda; set => azienda = value; }
        internal string Ore {
            get { return ore.ToString(); }
            set {
                if (Convert.ToInt32(value) < 1)
                {
                    throw new Exception("Numero ore non valido");
                }
                else
                {
                    ore = Convert.ToInt32(value);
                }
            }
        }

        public ClsStagista(string nome, string cognome, string città, string classe, string sezione, string specializazione, string azienda, string ore) : base (nome, cognome,città, classe, sezione, specializazione)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string visualizza()
        {
            return base.visualizza()+" "+Azienda+" "+Ore;
        }
    }
}
