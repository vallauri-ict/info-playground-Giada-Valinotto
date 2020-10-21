using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace es_01___OOP
{
    class Rectangle
    {
        //lati 1 e 2
        private int side1, side2;
        private string descrizione;
        public Color color;

        public Rectangle()
        {
            side1 = 1;
            side2 = 1;
        }

        public Rectangle(int baseRettangolo, int AltezzaRettangolo)
        {
            side1 = baseRettangolo;
            side2 = AltezzaRettangolo;
        }

        public string getSide()
        {
            return ("Base: "+side1.ToString() + "\nAltezza: " + side2.ToString());
        }
    }
}
