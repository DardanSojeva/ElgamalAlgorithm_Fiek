namespace ElgamalAgoritmi
{
    partial class Elgamal_Dekriptimi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elgamalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutCryptographyAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelCiphertext = new System.Windows.Forms.Label();
            this.LabelFirstPartOfTheCipgertext = new System.Windows.Forms.Label();
            this.LabelSecondPartOfTheCipgertext = new System.Windows.Forms.Label();
            this.TextBoxFirstPartOfTheCipgertext = new System.Windows.Forms.TextBox();
            this.TextBoxSecondPartOfTheCipgertext = new System.Windows.Forms.TextBox();
            this.LabelSecretKey = new System.Windows.Forms.Label();
            this.TextBoxSecretKey = new System.Windows.Forms.TextBox();
            this.LabelFirstPartOfThePublicKey = new System.Windows.Forms.Label();
            this.TextBoxFirstPartOfThePublicKey = new System.Windows.Forms.TextBox();
            this.btnDektripto = new System.Windows.Forms.Button();
            this.lblMesazhi = new System.Windows.Forms.Label();
            this.LabelMessageOutput = new System.Windows.Forms.Label();
            this.LabelNameForm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elgamalToolStripMenuItem});
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // elgamalToolStripMenuItem
            // 
            this.elgamalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyGenerationToolStripMenuItem,
            this.EncryptionToolStripMenuItem,
            this.DecryptionToolStripMenuItem});
            this.elgamalToolStripMenuItem.Name = "elgamalToolStripMenuItem";
            this.elgamalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.elgamalToolStripMenuItem.Text = "Elgamal";
            // 
            // KeyGenerationToolStripMenuItem
            // 
            this.KeyGenerationToolStripMenuItem.Name = "KeyGenerationToolStripMenuItem";
            this.KeyGenerationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.KeyGenerationToolStripMenuItem.Text = "Key generation";
            this.KeyGenerationToolStripMenuItem.Click += new System.EventHandler(this.KeyGenerationToolStripMenuItem_Click);
            // 
            // EncryptionToolStripMenuItem
            // 
            this.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem";
            this.EncryptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.EncryptionToolStripMenuItem.Text = "Encryption";
            this.EncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // DecryptionToolStripMenuItem
            // 
            this.DecryptionToolStripMenuItem.Name = "DecryptionToolStripMenuItem";
            this.DecryptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.DecryptionToolStripMenuItem.Text = "Decryption";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutCryptographyAlgorithmsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // AboutCryptographyAlgorithmsToolStripMenuItem
            // 
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Name = "AboutCryptographyAlgorithmsToolStripMenuItem";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Text = "About Cryptography Algorithms";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Click += new System.EventHandler(this.AboutCryptographyAlgorithmsToolStripMenuItem_Click);
            // 
            // LabelCiphertext
            // 
            this.LabelCiphertext.AutoSize = true;
            this.LabelCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCiphertext.Location = new System.Drawing.Point(15, 109);
            this.LabelCiphertext.Name = "LabelCiphertext";
            this.LabelCiphertext.Size = new System.Drawing.Size(183, 25);
            this.LabelCiphertext.TabIndex = 1;
            this.LabelCiphertext.Text = "Teskti i enkriptuar";
            // 
            // LabelFirstPartOfTheCipgertext
            // 
            this.LabelFirstPartOfTheCipgertext.AutoSize = true;
            this.LabelFirstPartOfTheCipgertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstPartOfTheCipgertext.Location = new System.Drawing.Point(44, 157);
            this.LabelFirstPartOfTheCipgertext.Name = "LabelFirstPartOfTheCipgertext";
            this.LabelFirstPartOfTheCipgertext.Size = new System.Drawing.Size(133, 25);
            this.LabelFirstPartOfTheCipgertext.TabIndex = 2;
            this.LabelFirstPartOfTheCipgertext.Text = "Pjesa e pare";
            // 
            // LabelSecondPartOfTheCipgertext
            // 
            this.LabelSecondPartOfTheCipgertext.AutoSize = true;
            this.LabelSecondPartOfTheCipgertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSecondPartOfTheCipgertext.Location = new System.Drawing.Point(44, 226);
            this.LabelSecondPartOfTheCipgertext.Name = "LabelSecondPartOfTheCipgertext";
            this.LabelSecondPartOfTheCipgertext.Size = new System.Drawing.Size(131, 25);
            this.LabelSecondPartOfTheCipgertext.TabIndex = 3;
            this.LabelSecondPartOfTheCipgertext.Text = "Pjesa e dyte";
            // 
            // TextBoxFirstPartOfTheCipgertext
            // 
            this.TextBoxFirstPartOfTheCipgertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFirstPartOfTheCipgertext.Location = new System.Drawing.Point(9, 185);
            this.TextBoxFirstPartOfTheCipgertext.Name = "TextBoxFirstPartOfTheCipgertext";
            this.TextBoxFirstPartOfTheCipgertext.Size = new System.Drawing.Size(246, 31);
            this.TextBoxFirstPartOfTheCipgertext.TabIndex = 4;
            // 
            // TextBoxSecondPartOfTheCipgertext
            // 
            this.TextBoxSecondPartOfTheCipgertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSecondPartOfTheCipgertext.Location = new System.Drawing.Point(5, 254);
            this.TextBoxSecondPartOfTheCipgertext.Name = "TextBoxSecondPartOfTheCipgertext";
            this.TextBoxSecondPartOfTheCipgertext.Size = new System.Drawing.Size(250, 31);
            this.TextBoxSecondPartOfTheCipgertext.TabIndex = 5;
            // 
            // LabelSecretKey
            // 
            this.LabelSecretKey.AutoSize = true;
            this.LabelSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSecretKey.Location = new System.Drawing.Point(425, 226);
            this.LabelSecretKey.Name = "LabelSecretKey";
            this.LabelSecretKey.Size = new System.Drawing.Size(138, 25);
            this.LabelSecretKey.TabIndex = 6;
            this.LabelSecretKey.Text = "Qelesi sekret";
            // 
            // TextBoxSecretKey
            // 
            this.TextBoxSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSecretKey.Location = new System.Drawing.Point(362, 254);
            this.TextBoxSecretKey.Name = "TextBoxSecretKey";
            this.TextBoxSecretKey.Size = new System.Drawing.Size(278, 31);
            this.TextBoxSecretKey.TabIndex = 7;
            // 
            // LabelFirstPartOfThePublicKey
            // 
            this.LabelFirstPartOfThePublicKey.AutoSize = true;
            this.LabelFirstPartOfThePublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstPartOfThePublicKey.Location = new System.Drawing.Point(357, 157);
            this.LabelFirstPartOfThePublicKey.Name = "LabelFirstPartOfThePublicKey";
            this.LabelFirstPartOfThePublicKey.Size = new System.Drawing.Size(283, 25);
            this.LabelFirstPartOfThePublicKey.TabIndex = 8;
            this.LabelFirstPartOfThePublicKey.Text = "Pjesa e pare e qelesit publik";
            // 
            // TextBoxFirstPartOfThePublicKey
            // 
            this.TextBoxFirstPartOfThePublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFirstPartOfThePublicKey.Location = new System.Drawing.Point(362, 185);
            this.TextBoxFirstPartOfThePublicKey.Name = "TextBoxFirstPartOfThePublicKey";
            this.TextBoxFirstPartOfThePublicKey.Size = new System.Drawing.Size(278, 31);
            this.TextBoxFirstPartOfThePublicKey.TabIndex = 9;
            // 
            // btnDektripto
            // 
            this.btnDektripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDektripto.Location = new System.Drawing.Point(137, 329);
            this.btnDektripto.Name = "btnDektripto";
            this.btnDektripto.Size = new System.Drawing.Size(349, 41);
            this.btnDektripto.TabIndex = 10;
            this.btnDektripto.Text = "Dekripto";
            this.btnDektripto.UseVisualStyleBackColor = true;
            this.btnDektripto.Click += new System.EventHandler(this.ButtonDecryption_Click);
            // 
            // lblMesazhi
            // 
            this.lblMesazhi.AutoSize = true;
            this.lblMesazhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesazhi.Location = new System.Drawing.Point(15, 427);
            this.lblMesazhi.Name = "lblMesazhi";
            this.lblMesazhi.Size = new System.Drawing.Size(93, 25);
            this.lblMesazhi.TabIndex = 11;
            this.lblMesazhi.Text = "Mesazhi";
            // 
            // LabelMessageOutput
            // 
            this.LabelMessageOutput.AutoSize = true;
            this.LabelMessageOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessageOutput.Location = new System.Drawing.Point(114, 410);
            this.LabelMessageOutput.Name = "LabelMessageOutput";
            this.LabelMessageOutput.Size = new System.Drawing.Size(0, 25);
            this.LabelMessageOutput.TabIndex = 12;
            // 
            // LabelNameForm
            // 
            this.LabelNameForm.AutoSize = true;
            this.LabelNameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameForm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelNameForm.Location = new System.Drawing.Point(203, 47);
            this.LabelNameForm.Name = "LabelNameForm";
            this.LabelNameForm.Size = new System.Drawing.Size(234, 31);
            this.LabelNameForm.TabIndex = 13;
            this.LabelNameForm.Text = "Elgamal dekriptimi";
            // 
            // Elgamal_Dekriptimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(667, 478);
            this.Controls.Add(this.LabelNameForm);
            this.Controls.Add(this.LabelMessageOutput);
            this.Controls.Add(this.lblMesazhi);
            this.Controls.Add(this.btnDektripto);
            this.Controls.Add(this.TextBoxFirstPartOfThePublicKey);
            this.Controls.Add(this.LabelFirstPartOfThePublicKey);
            this.Controls.Add(this.TextBoxSecretKey);
            this.Controls.Add(this.LabelSecretKey);
            this.Controls.Add(this.TextBoxSecondPartOfTheCipgertext);
            this.Controls.Add(this.TextBoxFirstPartOfTheCipgertext);
            this.Controls.Add(this.LabelSecondPartOfTheCipgertext);
            this.Controls.Add(this.LabelFirstPartOfTheCipgertext);
            this.Controls.Add(this.LabelCiphertext);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Elgamal_Dekriptimi";
            this.Text = "Algoritmi kriptografik Elgamal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elgamalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutCryptographyAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.Label LabelCiphertext;
        private System.Windows.Forms.Label LabelFirstPartOfTheCipgertext;
        private System.Windows.Forms.Label LabelSecondPartOfTheCipgertext;
        private System.Windows.Forms.TextBox TextBoxFirstPartOfTheCipgertext;
        private System.Windows.Forms.TextBox TextBoxSecondPartOfTheCipgertext;
        private System.Windows.Forms.Label LabelSecretKey;
        private System.Windows.Forms.TextBox TextBoxSecretKey;
        private System.Windows.Forms.Label LabelFirstPartOfThePublicKey;
        private System.Windows.Forms.TextBox TextBoxFirstPartOfThePublicKey;
        private System.Windows.Forms.Button btnDektripto;
        private System.Windows.Forms.Label lblMesazhi;
        private System.Windows.Forms.Label LabelMessageOutput;
        private System.Windows.Forms.Label LabelNameForm;
    }
}