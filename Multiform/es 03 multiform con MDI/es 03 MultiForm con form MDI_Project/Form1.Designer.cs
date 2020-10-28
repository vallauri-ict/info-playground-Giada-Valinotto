namespace es_03_MultiForm_con_form_MDI_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnApriF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApriF2b = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaggioTxtFormF2 = new System.Windows.Forms.ToolStripButton();
            this.btnEsci = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.f2SenzaParametroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2ConParametroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEtaFM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnPassaggioTxtFormF2,
            this.btnEsci,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnApriF2,
            this.btnApriF2b});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripDropDownButton1.Text = "Apri Form";
            // 
            // btnApriF2
            // 
            this.btnApriF2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f2SenzaParametroToolStripMenuItem,
            this.f2ConParametroToolStripMenuItem});
            this.btnApriF2.Name = "btnApriF2";
            this.btnApriF2.Size = new System.Drawing.Size(206, 22);
            this.btnApriF2.Text = "Apri Form F2 da designer";
            this.btnApriF2.Click += new System.EventHandler(this.btnApriF2_Click);
            // 
            // btnApriF2b
            // 
            this.btnApriF2b.Name = "btnApriF2b";
            this.btnApriF2b.Size = new System.Drawing.Size(206, 22);
            this.btnApriF2b.Text = "Apri Form f2b dinamica";
            this.btnApriF2b.Click += new System.EventHandler(this.btnApriF2b_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(0, 269);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(100, 20);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaggioTxtFormF2
            // 
            this.btnPassaggioTxtFormF2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPassaggioTxtFormF2.Image = ((System.Drawing.Image)(resources.GetObject("btnPassaggioTxtFormF2.Image")));
            this.btnPassaggioTxtFormF2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPassaggioTxtFormF2.Name = "btnPassaggioTxtFormF2";
            this.btnPassaggioTxtFormF2.Size = new System.Drawing.Size(108, 22);
            this.btnPassaggioTxtFormF2.Text = "Passa TextBox a F2";
            this.btnPassaggioTxtFormF2.Click += new System.EventHandler(this.btnPassaggioTxtFormF2_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEsci.Image = ((System.Drawing.Image)(resources.GetObject("btnEsci.Image")));
            this.btnEsci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(31, 22);
            this.btnEsci.Text = "Esci";
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(715, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(115, 17);
            this.statusStrip.Text = "Applicazione avviata";
            // 
            // f2SenzaParametroToolStripMenuItem
            // 
            this.f2SenzaParametroToolStripMenuItem.Name = "f2SenzaParametroToolStripMenuItem";
            this.f2SenzaParametroToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.f2SenzaParametroToolStripMenuItem.Text = "F2 senza parametro";
            this.f2SenzaParametroToolStripMenuItem.Click += new System.EventHandler(this.f2SenzaParametroToolStripMenuItem_Click);
            // 
            // f2ConParametroToolStripMenuItem
            // 
            this.f2ConParametroToolStripMenuItem.Name = "f2ConParametroToolStripMenuItem";
            this.f2ConParametroToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.f2ConParametroToolStripMenuItem.Text = "F2 con parametro";
            this.f2ConParametroToolStripMenuItem.Click += new System.EventHandler(this.f2ConParametroToolStripMenuItem_Click);
            // 
            // txtEtaFM
            // 
            this.txtEtaFM.Location = new System.Drawing.Point(601, 269);
            this.txtEtaFM.Name = "txtEtaFM";
            this.txtEtaFM.ReadOnly = true;
            this.txtEtaFM.Size = new System.Drawing.Size(100, 20);
            this.txtEtaFM.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Età";
            // 
            // txtNomeFM
            // 
            this.txtNomeFM.Location = new System.Drawing.Point(389, 269);
            this.txtNomeFM.Name = "txtNomeFM";
            this.txtNomeFM.ReadOnly = true;
            this.txtNomeFM.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFM.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton1.Text = "Apri form modale";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 320);
            this.Controls.Add(this.txtEtaFM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnApriF2;
        private System.Windows.Forms.ToolStripMenuItem btnApriF2b;
        private System.Windows.Forms.ToolStripButton btnPassaggioTxtFormF2;
        private System.Windows.Forms.ToolStripButton btnEsci;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
        private System.Windows.Forms.ToolStripMenuItem f2SenzaParametroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f2ConParametroToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtEtaFM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFM;
        private System.Windows.Forms.Label label1;
    }
}

