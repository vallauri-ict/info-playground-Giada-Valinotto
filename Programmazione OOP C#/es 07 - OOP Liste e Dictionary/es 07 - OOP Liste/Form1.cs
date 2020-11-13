using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace es_07___OOP_Liste
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int id;
            public string titolo;
            public string autore;
        }
        
        //Dichiarazione dizionario
        Dictionary<int, Libro> dizionarioLibri = new Dictionary<int, Libro>();
        //DIchiarazione lista
        List<Libro> miaLista = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtAutore.Text!="")&&(txtTitolo.Text!="")&&(txtID.Text!=""))
            {
                try
                {
                    Libro l;
                    l.id = Convert.ToInt32(txtID.Text);
                    l.autore = txtAutore.Text;
                    l.titolo = txtTitolo.Text;
                    MessageBox.Show("Libro aggiunto correttamente");
                    miaLista.Add(l);
                    foreach (TextBox txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Text = "";
                    }

                    //Parte relativa al dizionario
                    dizionarioLibri.Add(l.id, l);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserire tutti i campi");
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s="";
            foreach(Libro libro in miaLista)
            {
                s += libro.titolo.ToString() + "\n";
            }
            MessageBox.Show(s.ToString());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Inserisci il titolo del libro da cercare: ");
            //Questa sintassi ritorna un solo elemento
            Libro ris = miaLista.Find(titoloLibro => titoloLibro.titolo == x);
            MessageBox.Show(ris.titolo+", "+ris.autore);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Inserisci l'autore: ");
            List<Libro> miaListaAppoggio = new List<Libro>();
            miaListaAppoggio = miaLista.FindAll(autoreLIbri => autoreLIbri.autore == x);

            string s = "";
            foreach (Libro libro in miaListaAppoggio)
            {
                s += libro.titolo.ToString() + "\n";
            }
            MessageBox.Show(s.ToString());
        }

        private void btnVisualizzaDizionario_Click(object sender, EventArgs e)
        {
            foreach (int id in dizionarioLibri.Keys)
                MessageBox.Show(Convert.ToString(id));
            foreach (Libro l in dizionarioLibri.Values)
                MessageBox.Show(l.titolo + ", " + l.autore);
        }

        private void btnCercaLibroID_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Interaction.InputBox("Inserisci l'ID del libro: "));
            Libro lf = dizionarioLibri[x];
            MessageBox.Show(lf.titolo+", "+lf.autore);
        }
    }
}
