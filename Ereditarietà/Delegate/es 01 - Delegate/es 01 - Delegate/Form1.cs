using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_01___Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Dichiarazione del Delegate:
        //Accetta 2 parametri e restituisce un valore intero
        public delegate int Operazione(int a, int b);

        //Dichiarazione delle 3 funzioni utilizzate con il delegate
        public int Somma(int x, int y)
        {
            return x + y;
        }
        public int Sottrazione(int x, int y)
        {
            return x - y;
        }
        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        private void btnAddizione_Click(object sender, EventArgs e)
        {
            //Primo metodo per usare un Delegate
            //Istanzio il Delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma);
            //Somma è la "funzione" puntata dal Delegate
            //Richiamo il Delegate che eseguirà la funzione di somma
            MessageBox.Show("Somma : " +op(10,15));
        }

        private void btnProdotto_Click(object sender, EventArgs e)
        {
            //Secondo metodo per usare un Delegate
            //Istanzio il delegate in modo più immediato
            Operazione op = Prodotto;
            //Richiamo il Delegato
            MessageBox.Show("Prodotto :" +op(10,15));
        }
    }
}
