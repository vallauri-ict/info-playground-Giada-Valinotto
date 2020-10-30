using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Quadrato
    {
        private int lato;

        private Quadrato(int lato)
        {
            this.lato = lato;
        }

        public static Quadrato creaQuadrato(int lato)
        {
            if (lato <= 0)
            {
                throw new Exception("Il lato deve essere maggiore di 0");
            }
            else
            {
                return new Quadrato(lato);
            }
        }
    }
}
