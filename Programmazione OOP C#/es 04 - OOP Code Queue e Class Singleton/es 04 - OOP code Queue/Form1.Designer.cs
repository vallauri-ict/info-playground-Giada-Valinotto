namespace es_04___OOP_code_Queue
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
            this.labelTitolo = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.labelAutore = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.btnStampa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitolo
            // 
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.Location = new System.Drawing.Point(0, 9);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.Size = new System.Drawing.Size(33, 13);
            this.labelTitolo.TabIndex = 0;
            this.labelTitolo.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(63, 6);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(185, 4);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(100, 23);
            this.btnInserisci.TabIndex = 2;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAutore
            // 
            this.labelAutore.AutoSize = true;
            this.labelAutore.Location = new System.Drawing.Point(0, 42);
            this.labelAutore.Name = "labelAutore";
            this.labelAutore.Size = new System.Drawing.Size(38, 13);
            this.labelAutore.TabIndex = 3;
            this.labelAutore.Text = "Autore";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(63, 39);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 4;
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(185, 42);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(100, 23);
            this.btnStampa.TabIndex = 5;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 261);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.labelAutore);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.labelTitolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Label labelAutore;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Button btnStampa;
    }
}

