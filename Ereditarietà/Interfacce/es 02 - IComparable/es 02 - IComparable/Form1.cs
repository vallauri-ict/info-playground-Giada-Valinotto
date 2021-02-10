using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_02___IComparable
{
    public partial class Form1 : Form
    {
        Persona[] vect = new Persona[] {  new Persona("Mario", "Rossi", "Cuneo"),
                                          new Persona("Enrico", "Bonavia", "Fossano"),
                                          new Persona("Antonio", "Bonelli", "Alba"),
                                          new Persona("Samuele", "Stefirca", "Savigliano")};
        public Form1()
        {
            InitializeComponent(); 
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

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            Array.Sort(vect);
            MostraPersona();
        }
    }
}
