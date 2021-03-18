using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_03___IComparer
{
    public partial class Form1 : Form
    {

        Persona[] vect = new Persona[] {  new Persona("Mario", "Rossi", "Cuneo"),
                                          new Persona("Enrico", "Bonavia", "Fossano"),
                                          new Persona("Samuele", "Bonelli", "Alba"),
                                          new Persona("Antonio", "Stefirca", "Savigliano")};
        public Form1()
        {
            InitializeComponent();
            MostraPersona();
        }
        public void MostraPersona()
        {
            string s = "";
            foreach (var persona in vect)
            {
                s += persona.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnOrdinaPerCognome_Click(object sender, EventArgs e)
        {
            Array.Sort(vect, new Persona.confrontaCognome());
            MostraPersona();
        }

        private void btnOrdinaPerNome_Click(object sender, EventArgs e)
        {
            Array.Sort(vect, new Persona.confrontaNome());
            MostraPersona();
        }
    }
}
