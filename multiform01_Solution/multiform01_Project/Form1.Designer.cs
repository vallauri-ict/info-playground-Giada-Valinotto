namespace multiform01_Project
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
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaATxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(102, 12);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(75, 23);
            this.btnForm1.TabIndex = 0;
            this.btnForm1.Text = "Apri Form2B";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(12, 12);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 1;
            this.btnForm2.Text = "Apri Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(197, 15);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(100, 20);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaATxt
            // 
            this.btnPassaATxt.Location = new System.Drawing.Point(197, 41);
            this.btnPassaATxt.Name = "btnPassaATxt";
            this.btnPassaATxt.Size = new System.Drawing.Size(75, 23);
            this.btnPassaATxt.TabIndex = 3;
            this.btnPassaATxt.Text = "passa";
            this.btnPassaATxt.UseVisualStyleBackColor = true;
            this.btnPassaATxt.Click += new System.EventHandler(this.btnPassaATxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPassaATxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassaATxt;
    }
}

