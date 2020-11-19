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

namespace es_08____OOP_DictionaryNegozio
{
    public partial class Form1 : Form
    {
        public struct libro
        {
            public int key;
            public string nome;
        }
        Dictionary<int, libro> dizionarioLibri = new Dictionary<int, libro>();
        
        public int item = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTextItem.Visible = false;
            lblItem.Visible = false;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if ((txtKey.Text != "") && (txtNome.Text != ""))
            {
                try
                {
                    libro l;
                    l.key = Convert.ToInt32(txtKey.Text);
                    l.nome = txtNome.Text;
                    MessageBox.Show("Libro aggiunto correttamente");
                    foreach (TextBox txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Text = "";
                    }
                    item++;
                    //Parte relativa al dizionario
                    dizionarioLibri.Add(l.key, l);
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
            lblItem.Text = item.ToString();
            lblTextItem.Visible = true;
            lblItem.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
