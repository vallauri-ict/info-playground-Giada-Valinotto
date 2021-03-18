namespace es_03___IComparer
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
            this.btnOrdinaPerNome = new System.Windows.Forms.Button();
            this.btnOrdinaPerCognome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdinaPerNome
            // 
            this.btnOrdinaPerNome.Location = new System.Drawing.Point(0, 0);
            this.btnOrdinaPerNome.Name = "btnOrdinaPerNome";
            this.btnOrdinaPerNome.Size = new System.Drawing.Size(174, 23);
            this.btnOrdinaPerNome.TabIndex = 0;
            this.btnOrdinaPerNome.Text = "Ordina per nome";
            this.btnOrdinaPerNome.UseVisualStyleBackColor = true;
            this.btnOrdinaPerNome.Click += new System.EventHandler(this.btnOrdinaPerNome_Click);
            // 
            // btnOrdinaPerCognome
            // 
            this.btnOrdinaPerCognome.Location = new System.Drawing.Point(0, 29);
            this.btnOrdinaPerCognome.Name = "btnOrdinaPerCognome";
            this.btnOrdinaPerCognome.Size = new System.Drawing.Size(174, 23);
            this.btnOrdinaPerCognome.TabIndex = 1;
            this.btnOrdinaPerCognome.Text = "Ordina per cognome";
            this.btnOrdinaPerCognome.UseVisualStyleBackColor = true;
            this.btnOrdinaPerCognome.Click += new System.EventHandler(this.btnOrdinaPerCognome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 53);
            this.Controls.Add(this.btnOrdinaPerCognome);
            this.Controls.Add(this.btnOrdinaPerNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdinaPerNome;
        private System.Windows.Forms.Button btnOrdinaPerCognome;
    }
}

