﻿namespace es_20___OOP_Classi_Astratte
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSezione = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtPosizione = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Città:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(89, 76);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 4;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(89, 44);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Classe:";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbClasse.Location = new System.Drawing.Point(89, 107);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(100, 21);
            this.cmbClasse.TabIndex = 7;
            // 
            // cmbSpec
            // 
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Items.AddRange(new object[] {
            "INF",
            "ELT",
            "MEC",
            "MEN",
            "LIC"});
            this.cmbSpec.Location = new System.Drawing.Point(316, 44);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(121, 21);
            this.cmbSpec.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Specializzazione:";
            // 
            // cmbSezione
            // 
            this.cmbSezione.FormattingEnabled = true;
            this.cmbSezione.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSezione.Location = new System.Drawing.Point(316, 12);
            this.cmbSezione.Name = "cmbSezione";
            this.cmbSezione.Size = new System.Drawing.Size(121, 21);
            this.cmbSezione.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sezione:";
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.AutoCompleteCustomSource.AddRange(new string[] {
            "Azienda1",
            "Azienda2",
            "Azienda3"});
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Items.AddRange(new object[] {
            "INF",
            "ELT",
            "MEC",
            "MEN",
            "LIC"});
            this.cmbAzienda.Location = new System.Drawing.Point(316, 102);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(121, 21);
            this.cmbAzienda.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Azienda:";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(316, 129);
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(100, 20);
            this.txtOre.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ore:";
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(137, 183);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(75, 23);
            this.btnRicerca.TabIndex = 16;
            this.btnRicerca.Text = "Ricerca";
            this.btnRicerca.UseVisualStyleBackColor = true;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(37, 183);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 17;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(27, 212);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(240, 150);
            this.dgvStudenti.TabIndex = 18;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(27, 368);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(248, 23);
            this.btnElimina.TabIndex = 19;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // txtPosizione
            // 
            this.txtPosizione.Location = new System.Drawing.Point(374, 371);
            this.txtPosizione.Name = "txtPosizione";
            this.txtPosizione.Size = new System.Drawing.Size(100, 20);
            this.txtPosizione.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Posizione:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 438);
            this.Controls.Add(this.txtPosizione);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.txtOre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSezione);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSezione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtPosizione;
        private System.Windows.Forms.Label label9;
    }
}

