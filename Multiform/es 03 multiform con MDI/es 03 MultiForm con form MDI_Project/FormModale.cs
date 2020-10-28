using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_03_MultiForm_con_form_MDI_Project
{
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = "";
        public FormModale()
        {
            InitializeComponent();
        }

        private void FormModale_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
        }
    }
}
