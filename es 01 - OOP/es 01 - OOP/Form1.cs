using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_01___OOP
{
    public partial class Form1 : Form
    {
        Rectangle r;
        public Form1()
        {
            InitializeComponent();
           // r = new Rectangle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void creaRettangolo_Click(object sender, EventArgs e)
        {
            r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            /* r.side1 = Convert.ToInt32(txtBase.Text);
             r.side2 = Convert.ToInt32(txtAltezza.Text);
             MessageBox.Show("Base: "+ r.side1 + "\nAltezza: " +r.side2);
             Rectangle t;
             t = r;
             MessageBox.Show("Oggetto t: \nBase: "+t.side1 + "\nAltezza: "+t.side2);
             t.side1 = 10;
             MessageBox.Show("Oggetto r post modifiche su t:\nBase: "+r.side1+"\nAltezza: "+ r.side2);   /// t ed r puntano alla stessa area di memoria */
            r.color = Color.White;
            MessageBox.Show(r.getSide());

        }
    }
}
