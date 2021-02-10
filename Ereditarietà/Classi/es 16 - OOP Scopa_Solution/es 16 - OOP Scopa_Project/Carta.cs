using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_16___OOP_Scopa_Project
{
    class Carta
    {
        private int valore;

        private string seme;

        public Carta(int valore, string seme)
        {
            Seme = seme;
            Valore = valore;
        }

        public string Seme { get => seme; set => seme = value; }

        public int Valore { get => valore; set => valore = value; }

        public void ReadCard()
        {
            System.Windows.Forms.MessageBox.Show("Carta :  " + valore.ToString() + " di " + seme);
        }
    }
}
