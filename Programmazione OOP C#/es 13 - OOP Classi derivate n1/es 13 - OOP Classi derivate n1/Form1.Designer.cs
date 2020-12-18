namespace es_13___OOP_Classi_derivate_n1
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
            this.btnMostraMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostraMedia
            // 
            this.btnMostraMedia.Location = new System.Drawing.Point(12, 12);
            this.btnMostraMedia.Name = "btnMostraMedia";
            this.btnMostraMedia.Size = new System.Drawing.Size(260, 33);
            this.btnMostraMedia.TabIndex = 0;
            this.btnMostraMedia.Text = "Mostra media";
            this.btnMostraMedia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 58);
            this.Controls.Add(this.btnMostraMedia);
            this.Name = "Form1";
            this.Text = "Valinotto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostraMedia;
    }
}

