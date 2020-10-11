using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_03_MultiForm_con_form_MDI_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            statusStrip.Text = "Premuto Apri Form F2";
            Form2 f2 = new Form2();
            f2.Text = "Form 2 da Design";
            f2.MdiParent = this;
            f2.Size = new Size(210, 180);
            f2.StartPosition = FormStartPosition.Manual; //Serve per far funzionare il Location
            f2.Location = new Point(0, 20);
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da Design con parametro";
            f2b.MdiParent = this;
            f2b.Size = new Size(210, 180);
            f2b.StartPosition = FormStartPosition.Manual; //Serve per far funzionare il Location
            f2b.Location = new Point(215, 20);
            f2b.Show();
            f2b.Show();
        }

        private void btnApriF2b_Click(object sender, EventArgs e)
        {
            statusStrip.Text = "Premuto Apri Form F2b";
            Form f2b = new Form();
            f2b.Text = "Form 2 Dinamica";
            f2b.Show();
        }

        private void f2SenzaParametroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Text = "Premuto Apri Form F2";
            Form2 f2 = new Form2();
            f2.Text = "Form 2 da Design";
            f2.MdiParent = this;
            f2.Size = new Size(210, 180);
            f2.StartPosition = FormStartPosition.Manual; //Serve per far funzionare il Location
            f2.Location = new Point(0, 20);
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void f2ConParametroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da Design con parametro";
            f2b.MdiParent = this;
            f2b.Size = new Size(210, 180);
            f2b.StartPosition = FormStartPosition.Manual; //Serve per far funzionare il Location
            f2b.Location = new Point(215, 20);
            f2b.Show();
        }

        private void btnPassaggioTxtFormF2_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form 2 con passaggio di TextBox";
            f2b.MdiParent = this;
            f2b.Size = new Size(210, 180);
            f2b.StartPosition = FormStartPosition.Manual; //Serve per far funzionare il Location
            f2b.Location = new Point(430, 20);
            f2b.Show();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNomeFM.Text = fm.nome;
                txtEtaFM.Text = fm.eta;
                MessageBox.Show("Premuto OK!");
            }
            else
            {
                txtNomeFM.Text = "";
                txtEtaFM.Text = "";
                MessageBox.Show("Premuto Annulla!");
            }
        }
    }
}
