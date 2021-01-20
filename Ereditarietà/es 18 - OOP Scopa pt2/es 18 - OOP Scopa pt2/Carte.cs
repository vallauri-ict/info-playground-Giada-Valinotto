using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_18___OOP_Scopa_pt2
{
    class Carte
    {
        private string seme;
        private string valore;

        public string Seme {
            get
            {
                return seme;
            }
            set
            {
                if(seme=="Cuori" || seme == "Picche" || seme == "Quadri" || seme == "Fiori")
                {
                    seme = value;
                }
                else
                {
                    throw new Exception("Formato carta non valido");
                }
            }
        }

        public string Valore {
            get
            {
                return valore;
            }
            set
            {
                if (valore == "Asso" || valore == "2" || valore == "3" || valore == "4" || valore == "5" || valore == "6" || valore == "7" || valore == "Fante" || valore == "Regina" || valore == "Re")
                {
                    valore = value;
                }
                else
                {
                    throw new Exception("Formato valore non valido");
                }
            }
        }

        private void Proponi()
        {
            string[] Carta = new string[2];

        }
    }
}
