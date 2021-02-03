using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_20___OOP_Classi_Astratte
{
    public partial class Form1 : Form
    {
        ClsElenco elencoStudenti;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new ClsElenco();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            ClsAlunno stu;
            if (txtOre.Text.Trim()=="")
            {
                stu = new ClsAlunno(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString());
            }
            else
            {
                stu = new ClsStagista(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString(), cmbAzienda.SelectedItem.ToString(), txtOre.Text);
            }
            elencoStudenti.insersci(stu);
            elencoStudenti.visualzzaDgv(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                //Scansione tutti gli elem della Form
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex=-1;
                }
            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedItem.ToString();
            int ore = elencoStudenti.oreAzienda(azienda);

            if (ore!=0)
            {
                MessageBox.Show("Gli stagisti hanno effettuato "+ore+ " in azienda", "Info:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gli stagisti non hanno effettuato ore in azienda", "Info:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
