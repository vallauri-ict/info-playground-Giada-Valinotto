namespace multiform01_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeggiValore = new System.Windows.Forms.Button();
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.btnInviaAF1 = new System.Windows.Forms.Button();
            this.btnFormFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeggiValore
            // 
            this.btnLeggiValore.Location = new System.Drawing.Point(0, 0);
            this.btnLeggiValore.Name = "btnLeggiValore";
            this.btnLeggiValore.Size = new System.Drawing.Size(75, 23);
            this.btnLeggiValore.TabIndex = 0;
            this.btnLeggiValore.Text = "Leggi valore";
            this.btnLeggiValore.UseVisualStyleBackColor = true;
            this.btnLeggiValore.Click += new System.EventHandler(this.btnLeggiValore_Click);
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(0, 48);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(100, 20);
            this.txtForm2.TabIndex = 1;
            // 
            // btnInviaAF1
            // 
            this.btnInviaAF1.Location = new System.Drawing.Point(106, 45);
            this.btnInviaAF1.Name = "btnInviaAF1";
            this.btnInviaAF1.Size = new System.Drawing.Size(75, 23);
            this.btnInviaAF1.TabIndex = 2;
            this.btnInviaAF1.Text = "Invia";
            this.btnInviaAF1.UseVisualStyleBackColor = true;
            this.btnInviaAF1.Click += new System.EventHandler(this.btnInviaAF1_Click);
            // 
            // btnFormFiglia
            // 
            this.btnFormFiglia.Location = new System.Drawing.Point(0, 89);
            this.btnFormFiglia.Name = "btnFormFiglia";
            this.btnFormFiglia.Size = new System.Drawing.Size(124, 23);
            this.btnFormFiglia.TabIndex = 3;
            this.btnFormFiglia.Text = "Apri form figlia";
            this.btnFormFiglia.UseVisualStyleBackColor = true;
            this.btnFormFiglia.Click += new System.EventHandler(this.btnFormFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormFiglia);
            this.Controls.Add(this.btnInviaAF1);
            this.Controls.Add(this.txtForm2);
            this.Controls.Add(this.btnLeggiValore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiValore;
        private System.Windows.Forms.TextBox txtForm2;
        private System.Windows.Forms.Button btnInviaAF1;
        private System.Windows.Forms.Button btnFormFiglia;
    }
}