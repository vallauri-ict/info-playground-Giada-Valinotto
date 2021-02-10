using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_14___OOP_Persone_e_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Studente> lstStudenti = new List<Studente>();

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s.GetAttributes(txtNome.Text,txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
            lstStudenti.Add(s);
            listStudenti.Items.Add(s.GetCognome());
        }

        private void listStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cognome = listStudenti.SelectedItems[0].Text;
            foreach (Studente i in lstStudenti)
            {
                if (i.GetCognome()==cognome)
                {
                    i.voti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            foreach (Studente i in lstStudenti)
            {
                if (i.GetCognome() == listStudenti.SelectedItems[0].Text)
                    i.voti.Add(Convert.ToInt32(txtVoto.Text));
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStudenti.Find(stud => stud.GetCognome() == listStudenti.SelectedItems[0].Text);
            MessageBox.Show("Lo studente " + s.GetCognome() + " " + s.GetNome() + " ha " + s.GetEta() + " anni e ha preso " + s.Media());
        }
    }
}
