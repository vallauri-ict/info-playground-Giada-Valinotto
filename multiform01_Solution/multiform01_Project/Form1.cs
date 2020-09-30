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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            ///Creazione dinamica Form
            Form f2b = new Form();
            f2b.Show();

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2();
            f2b.Text = "Aperta Form dinamica";
            f2b.Show(); ///visualizza la form  
        }
    }
}
