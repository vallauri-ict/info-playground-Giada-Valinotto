﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005__Classi_Indexate
{
    public partial class Form1 : Form
    {
        MyIndexedClass indexedVect;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            indexedVect = new MyIndexedClass(Convert.ToInt32(txtElementi.Text));
            for (int i = 0; i < (Convert.ToInt32(txtElementi.Text))-1; i++)
            {
                indexedVect[i] = i.ToString();
            }
            MessageBox.Show("Classe indexata di "+indexedVect.returnLength()+" elementi creata");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i <indexedVect.returnLength() ; i++)
            {
                s += indexedVect[i] + "\n";
            }
            MessageBox.Show("Elementi: \n"+s);
        }
    }
}
