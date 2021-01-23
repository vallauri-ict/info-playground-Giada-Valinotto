using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_19___OOP_MondoAnimale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Cavallo c = new Cavallo("Furia del West");
            Uomo h = new Uomo("Johnny");
            Corvo w = new Corvo("Il corvo dell'uva");
            Tonno t = new Tonno("Palmera");
            // AnimaleMarino p = new AnimaleMarino("x");
            // ERRATO: classe astratta!
            Uccello u = new Uccello("Gabbiano");
            Pinguino p = new Pinguino("Tweety");
            c.mostra(); h.mostra();
            w.mostra(); t.mostra();
            u.mostra(); p.mostra();
        }
    }
}
