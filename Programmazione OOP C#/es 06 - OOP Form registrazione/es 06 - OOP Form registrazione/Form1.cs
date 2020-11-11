using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_06___OOP_Form_registrazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;
            ///se una delle regex non è rispettata vado a false

            ///CONTROLLO VALIDITA' DEL COGNOME
            //Prima lettera maiuscola e altri caratteri alfabetici
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$"); ///[a-z]+ vuol dire "uno o più caratteri alfabetici minuscoli"
            Regex regNome = new Regex(@"^[A-Z]{1}[a-z]+$");
            Regex regIndirizzo = new Regex(@"^[A-Z]{1}[a-z]+$"); ///TODO
            Regex regCitta = new Regex(@" ^[A-Z]{1}[a-z]+$");
            Regex regCAP = new Regex(@"^[0-9]{5}$");
            Regex regMail = new Regex(@"/^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$/");
            Regex regCodiceFiscale = new Regex(@"/^ (?:[A - Z][AEIOU][AEIOUX] |[B - DF - HJ - NP - TV - Z]{ 2 }[A - Z]){ 2} (?:[\dLMNP - V]{ 2} (?:[A - EHLMPR - T](?:[04LQ][1 - 9MNP - V] |[15MR][\dLMNP - V] |[26NS][0 - 8LMNP - U]) |[DHPS][37PT][0L] |[ACELMRT][37PT][01LM] |[AC - EHLMPR - T][26NS][9V])| (?:[02468LNQSU][048LQU] |[13579MPRTV][26NS])B[26NS][9V])(?:[A - MZ][1 - 9MNP - V][\dLMNP - V]{ 2}|[A - M][0L](?:[1 - 9MNP - V][\dLMNP - V] |[0L][1 - 9MNP - V]))[A-Z]$/i");
            Regex regUsername = new Regex(@"^[A-Z]{1}[a-z]+$"); ///TODO
            Regex regPassword = new Regex(@"^[A-Z]{1}[a-z]+$"); ///TODO

            if (txtCognome.Text == "")
            {
                MessageBox.Show("Campo cognome vuoto");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else
            {
                if (!(regCognome.IsMatch(txtCognome.Text)))
                {
                    MessageBox.Show("Campo cognome non valido");
                    valido = false;
                    txtCognome.BackColor = Color.Salmon;
                }
                else
                {
                    //test nome
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Campo nome vuoto");
                        valido = false;
                        txtNome.BackColor = Color.Salmon;
                    }
                    else
                    {
                        if (!(regNome.IsMatch(txtNome.Text)))
                        {
                            MessageBox.Show("Campo nome non valido");
                            valido = false;
                            txtNome.BackColor = Color.Salmon;
                        }
                        else
                        {
                            //test Indirizzo
                            if (txtIndirizzo.Text == "")
                            {
                                MessageBox.Show("Campo indirizzo vuoto");
                                valido = false;
                                txtIndirizzo.BackColor = Color.Salmon;
                            }
                            else
                            {
                                if (!(regIndirizzo.IsMatch(txtIndirizzo.Text)))
                                {
                                    MessageBox.Show("Campo indirizzo non valido");
                                    valido = false;
                                    txtIndirizzo.BackColor = Color.Salmon;
                                }
                                else
                                {
                                    //test città
                                    if (txtCitta.Text == "")
                                    {
                                        MessageBox.Show("Campo città vuoto");
                                        valido = false;
                                        txtCitta.BackColor = Color.Salmon;
                                    }
                                    else
                                    {
                                        if (!(regCitta.IsMatch(txtCitta.Text)))
                                        {
                                            MessageBox.Show("Campo città non valido");
                                            valido = false;
                                            txtCitta.BackColor = Color.Salmon;
                                        }
                                        else
                                        {
                                            //test CAP
                                            if (txtCAP.Text == "")
                                            {
                                                MessageBox.Show("Campo CAP vuoto");
                                                valido = false;
                                                txtCAP.BackColor = Color.Salmon;
                                            }
                                            else
                                            {
                                                if (!(regCAP.IsMatch(txtCAP.Text)))
                                                {
                                                    MessageBox.Show("Campo CAP non valido");
                                                    valido = false;
                                                    txtCAP.BackColor = Color.Salmon;
                                                }
                                                else
                                                {
                                                    //Test mail
                                                    if (txtMail.Text == "")
                                                    {
                                                        MessageBox.Show("Campo mail vuoto");
                                                        valido = false;
                                                        txtMail.BackColor = Color.Salmon;
                                                    }
                                                    else
                                                    {
                                                        if (!(regMail.IsMatch(txtMail.Text)))
                                                        {
                                                            MessageBox.Show("Campo cognome non valido");
                                                            valido = false;
                                                            txtMail.BackColor = Color.Salmon;
                                                        }
                                                        else
                                                        {
                                                            //test codice fiscale
                                                            if (txtCodiceFiscale.Text == "")
                                                            {
                                                                MessageBox.Show("Campo codice fiscale vuoto");
                                                                valido = false;
                                                                txtCodiceFiscale.BackColor = Color.Salmon;
                                                            }
                                                            else
                                                            {
                                                                if (!(regCodiceFiscale.IsMatch(txtCodiceFiscale.Text)))
                                                                {
                                                                    MessageBox.Show("Campo codice fiscale non valido");
                                                                    valido = false;
                                                                    txtCodiceFiscale.BackColor = Color.Salmon;
                                                                }
                                                                else
                                                                {
                                                                    //test Username
                                                                    if (txtUsername.Text == "")
                                                                    {
                                                                        MessageBox.Show("Campo username vuoto");
                                                                        valido = false;
                                                                        txtUsername.BackColor = Color.Salmon;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (!(regUsername.IsMatch(txtUsername.Text)))
                                                                        {
                                                                            MessageBox.Show("Campo username non valido");
                                                                            valido = false;
                                                                            txtUsername.BackColor = Color.Salmon;
                                                                        }
                                                                        else
                                                                        {
                                                                            //test password
                                                                            if (txtPassword.Text == "")
                                                                            {
                                                                                MessageBox.Show("Campo password vuoto");
                                                                                valido = false;
                                                                                txtPassword.BackColor = Color.Salmon;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (!(regPassword.IsMatch(txtPassword.Text)))
                                                                                {
                                                                                    MessageBox.Show("Campo password non valido");
                                                                                    valido = false;
                                                                                    txtPassword.BackColor = Color.Salmon;
                                                                                }
                                                                                else
                                                                                {
                                                                                    ///Aggiunta alla classe
                                                                                    MessageBox.Show("Utente inserito correttamente");
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
