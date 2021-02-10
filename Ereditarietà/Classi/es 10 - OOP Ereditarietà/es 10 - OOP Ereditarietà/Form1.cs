using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_10___OOP_Ereditarietà
{
    public partial class Form1 : Form
    {
        class Mostro
        {
            protected double punti;
            protected string verso;
            public Mostro()
            {
                punti = 25;
                verso = "grugnito";
            }
            public double Valore()
            {
                return punti;
            }
            public string Verso()
            {
                return verso;
            }
        }
        class Mannaro : Mostro
        {
            protected bool mutato;
            public Mannaro()
            {
                punti = 33;
                verso = "ululato";
                mutato = true;
            }
            public double Valore()
            {
                if (mutato)
                {
                    return 2 * base.Valore();
                }
                else
                {
                    return base.Valore();
                }
            }
            public string Verso()
            {
                if (mutato)
                {
                    return verso;
                }
                else
                {
                    return base.verso;
                }
            }
            public void Muta()
            {
                mutato = !mutato;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostro demone = new Mostro();
            MessageBox.Show(demone.Valore()+" "+ demone.Verso());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mannaro umano = new Mannaro();
            MessageBox.Show(umano.Valore()+" "+umano.Verso());
            umano.Muta();
            MessageBox.Show(umano.Valore() + " " + umano.Verso());
        }
    }
}
