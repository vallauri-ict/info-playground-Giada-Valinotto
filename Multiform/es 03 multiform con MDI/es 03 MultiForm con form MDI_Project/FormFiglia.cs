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
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void FormFiglia_Load(object sender, EventArgs e)
        {

        }

        private void btnFigliaDiChi_Click(object sender, EventArgs e)
        {
            if (Owner != null)
                MessageBox.Show("Form figlia di " + Owner.Text);
        }
    }
}
