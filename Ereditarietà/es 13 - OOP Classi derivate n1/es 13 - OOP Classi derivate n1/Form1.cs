using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_13___OOP_Classi_derivate_n1
{
    public partial class Form1 : Form
    {
        public class Persona
        {
            private string nome;
            private string cognome;
            private string sesso;
            private int eta;
            public string _nome
            {
                get
                {
                  return nome;
                }
                set
                {
                  nome = value;
                }
            }
        }
        public class Studente : Persona
        {
            public int[] voti;
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
