using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_04___OOP_code_Queue
{
    public partial class Form1 : Form
    {
        Queue<singleton> codaLibri = new Queue<singleton>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtTitolo.Text != "" && txtTitolo.Text != "")
            {
                try
                {
                    singleton libro = singleton.GetInstance(txtTitolo.Text, txtAutore.Text);
                    MessageBox.Show("Libro " + libro.titolo + " di " + libro.autore + " aggiunto");
                    codaLibri.Enqueue(libro);
                    txtTitolo.Text = null;
                    txtAutore.Text = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Compilare correttamente entrambi i campi");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            singleton primoLibroQueue = codaLibri.Dequeue();
            MessageBox.Show("Primo libro in coda: "+primoLibroQueue.titolo+" di "+primoLibroQueue.autore);
        }
    }
}
