using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform01_Project
{
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int n) ///Costruttore con passaggio del parametro
        {
            InitializeComponent();
            this.n = n; ///This è l'oggetto della Form2 this.variabile
        }
        public Form2(TextBox txt1) ///Costruttore con passaggio del parametro
        {
            InitializeComponent();
            this.txt1= txt1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLeggiValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore = " + this.n);
        }

        private void btnInviaAF1_Click(object sender, EventArgs e)
        {
            txt1.Text = txtForm2.Text;
        }

        private void btnFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia(); ///Creazione Form dinamica
            this.AddOwnedForm(f); ///Aggiunta form figlia
            f.Show(); ///Mostro la form
        }
    }
}
