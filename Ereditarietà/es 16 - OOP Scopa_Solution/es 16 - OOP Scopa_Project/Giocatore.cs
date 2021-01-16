using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_16___OOP_Scopa_Project
{
    class Giocatore : Mano
    {
        private string nome;
        private Mano mano;
        private Mano prese;
        public Giocatore()
        {
            nome = "Giada";
            mano = null;
            prese = null;
        }
        void Lettura()
        {
            mano.Leggi();
        }
        void Prese()
        {
            prese.Leggi();
        }
        public void Gioca(Mazzo m)
        {
            mano.mano.Add(m.Estrai());
        }
    }
}
