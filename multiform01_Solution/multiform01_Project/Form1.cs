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
           /*Form2 f2 = new Form2();
            f2.Text = "Form 2B aperta senza par";
            f2.Show();*/

            Form2 f2parametro = new Form2(10);
            f2parametro.Text = "Form 2B aperta con par";
            f2parametro.Show();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta Form2 dinamica";
            f2b.Show(); ///visualizza la form  
        }

        private void btnPassaATxt_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form2 con passaggio txt";
            f2b.Show();
        }
    }
}
