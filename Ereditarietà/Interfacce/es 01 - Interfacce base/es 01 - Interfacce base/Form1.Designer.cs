namespace es_01___Interfacce_base
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
            this.btnConnetti = new System.Windows.Forms.Button();
            this.btnDIsconnetti = new System.Windows.Forms.Button();
            this.btnStato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnetti
            // 
            this.btnConnetti.Location = new System.Drawing.Point(0, 0);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(75, 23);
            this.btnConnetti.TabIndex = 0;
            this.btnConnetti.Text = "Connetti";
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // btnDIsconnetti
            // 
            this.btnDIsconnetti.Location = new System.Drawing.Point(91, 0);
            this.btnDIsconnetti.Name = "btnDIsconnetti";
            this.btnDIsconnetti.Size = new System.Drawing.Size(75, 23);
            this.btnDIsconnetti.TabIndex = 1;
            this.btnDIsconnetti.Text = "Disconnetti";
            this.btnDIsconnetti.UseVisualStyleBackColor = true;
            this.btnDIsconnetti.Click += new System.EventHandler(this.btnDIsconnetti_Click);
            // 
            // btnStato
            // 
            this.btnStato.Location = new System.Drawing.Point(191, 0);
            this.btnStato.Name = "btnStato";
            this.btnStato.Size = new System.Drawing.Size(75, 23);
            this.btnStato.TabIndex = 2;
            this.btnStato.Text = "Stato";
            this.btnStato.UseVisualStyleBackColor = true;
            this.btnStato.Click += new System.EventHandler(this.btnStato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 26);
            this.Controls.Add(this.btnStato);
            this.Controls.Add(this.btnDIsconnetti);
            this.Controls.Add(this.btnConnetti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.Button btnDIsconnetti;
        private System.Windows.Forms.Button btnStato;
    }
}

