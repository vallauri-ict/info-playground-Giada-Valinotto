using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_01___Interfacce_base
{
    public partial class Form1 : Form
    {
        MyComponent comp = new MyComponent();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            comp.connetti("Componente 1");
        }

        private void btnDIsconnetti_Click(object sender, EventArgs e)
        {
            comp.disconnetti("Componente 1");
        }

        private void btnStato_Click(object sender, EventArgs e)
        {
            comp.Stato();
        }
    }
}
