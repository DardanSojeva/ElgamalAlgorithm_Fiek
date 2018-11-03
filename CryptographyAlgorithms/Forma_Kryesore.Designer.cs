namespace CryptographyAlgorithms
{
    partial class FormaStartuese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaStartuese));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Algoritmi_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Elgamal_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GjenerimiQelesave_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Enkriptimi_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Dekriptimi_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.info_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.rreth_algoritmit_toolstripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lime;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Algoritmi_toolstrip_menu,
            this.info_toolstrip_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Algoritmi_toolstrip_menu
            // 
            this.Algoritmi_toolstrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Elgamal_toolstrip_menu});
            this.Algoritmi_toolstrip_menu.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Algoritmi_toolstrip_menu.Name = "Algoritmi_toolstrip_menu";
            this.Algoritmi_toolstrip_menu.Size = new System.Drawing.Size(98, 29);
            this.Algoritmi_toolstrip_menu.Text = "Algoritmi";
            // 
            // Elgamal_toolstrip_menu
            // 
            this.Elgamal_toolstrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GjenerimiQelesave_toolstrip_menu,
            this.Enkriptimi_toolstrip_menu,
            this.Dekriptimi_toolstrip_menu});
            this.Elgamal_toolstrip_menu.Name = "Elgamal_toolstrip_menu";
            this.Elgamal_toolstrip_menu.Size = new System.Drawing.Size(147, 30);
            this.Elgamal_toolstrip_menu.Text = "ElGamal";
            this.Elgamal_toolstrip_menu.Click += new System.EventHandler(this.ElGamalToolStripMenuItem_Click);
            // 
            // GjenerimiQelesave_toolstrip_menu
            // 
            this.GjenerimiQelesave_toolstrip_menu.Name = "GjenerimiQelesave_toolstrip_menu";
            this.GjenerimiQelesave_toolstrip_menu.Size = new System.Drawing.Size(237, 30);
            this.GjenerimiQelesave_toolstrip_menu.Text = "Gjenerimi i çelësave";
            this.GjenerimiQelesave_toolstrip_menu.Click += new System.EventHandler(this.EGKeyGenerationToolStripMenuItem_Click);
            // 
            // Enkriptimi_toolstrip_menu
            // 
            this.Enkriptimi_toolstrip_menu.Name = "Enkriptimi_toolstrip_menu";
            this.Enkriptimi_toolstrip_menu.Size = new System.Drawing.Size(237, 30);
            this.Enkriptimi_toolstrip_menu.Text = "Enkriptimi";
            this.Enkriptimi_toolstrip_menu.Click += new System.EventHandler(this.EGEncryptionToolStripMenuItem_Click);
            // 
            // Dekriptimi_toolstrip_menu
            // 
            this.Dekriptimi_toolstrip_menu.Name = "Dekriptimi_toolstrip_menu";
            this.Dekriptimi_toolstrip_menu.Size = new System.Drawing.Size(237, 30);
            this.Dekriptimi_toolstrip_menu.Text = "Dekriptimi";
            this.Dekriptimi_toolstrip_menu.Click += new System.EventHandler(this.EGDecryptionToolStripMenuItem_Click);
            // 
            // info_toolstrip_menu
            // 
            this.info_toolstrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rreth_algoritmit_toolstripmenu});
            this.info_toolstrip_menu.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.info_toolstrip_menu.Name = "info_toolstrip_menu";
            this.info_toolstrip_menu.Size = new System.Drawing.Size(56, 29);
            this.info_toolstrip_menu.Text = "Info";
            // 
            // rreth_algoritmit_toolstripmenu
            // 
            this.rreth_algoritmit_toolstripmenu.Name = "rreth_algoritmit_toolstripmenu";
            this.rreth_algoritmit_toolstripmenu.Size = new System.Drawing.Size(305, 30);
            this.rreth_algoritmit_toolstripmenu.Text = "Rreth algoritmit kriptografik";
            this.rreth_algoritmit_toolstripmenu.Click += new System.EventHandler(this.AboutCryptographyAlgorithmsToolStripMenuItem_Click);
            // 
            // FormaStartuese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 168);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormaStartuese";
            this.Opacity = 0.9D;
            this.Text = "Forma kryesore";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Algoritmi_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem Elgamal_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem GjenerimiQelesave_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem Enkriptimi_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem Dekriptimi_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem info_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem rreth_algoritmit_toolstripmenu;
    }
}