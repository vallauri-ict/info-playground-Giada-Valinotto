using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_12___OOP_Ereditarietà__pt3_
{
    public partial class Form1 : Form
    {
        public class Mostro
        {
            public string nome;
            public Mostro()

            : this("Mostro")

            {
            }
            public Mostro(string nome)
            {
                this.nome = nome;
            }
            public void Rivela()
            {
                System.Windows.Forms.MessageBox.Show(nome);
            }
        }
        public class Mannaro : Mostro
        {
            new public string nome;
            public Mannaro()
            : base()

            {
                this.nome = "Mannaro";
            }
            public Mannaro(string nome)
            : base(nome)

            {
                this.nome = "Mannaro" + nome;
            }
            new public void Rivela()
            {
                string s = nome + (char)(32);
                System.Windows.Forms.MessageBox.Show(s + base.nome);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        public Mostro Clona_V(Mostro p)
        {
            p = new Mostro("Valuex");
            p.nome = "Cambia";
            return p;
        }
        public Mostro Clona_R(ref Mostro p)
        {
            p = new Mostro("Referex");
            p.nome = "Cambia";
            return p;
        }
        public Mostro Clona_O(out Mostro p)
        {
            p = new Mostro("Resulx");
            p.nome = "Cambia";
            return p;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mannaro x = new Mannaro();
            Mostro y;
            y = Clona_V(x);
            x.Rivela();
            y.Rivela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = Clona_R(ref x);
            x.Rivela();
            y.Rivela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = Clona_O(out x);
            x.Rivela();
            y.Rivela();
        }
    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
