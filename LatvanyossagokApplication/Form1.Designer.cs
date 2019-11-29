namespace LatvanyossagokApplication
{
    partial class Form1
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
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.nudLakossag = new System.Windows.Forms.NumericUpDown();
            this.btnVarosHozzaad = new System.Windows.Forms.Button();
            this.textBoxLatvanyossagNev = new System.Windows.Forms.TextBox();
            this.nudAr = new System.Windows.Forms.NumericUpDown();
            this.btnLatvanyossagHozzaad = new System.Windows.Forms.Button();
            this.comboBoxVarosok = new System.Windows.Forms.ComboBox();
            this.textBoxLatvanyossagAr = new System.Windows.Forms.TextBox();
            this.listBoxVarosok = new System.Windows.Forms.ListBox();
            this.listBoxLatvanyossagok = new System.Windows.Forms.ListBox();
            this.buttonVarosTorles = new System.Windows.Forms.Button();
            this.buttonLatvanyossagTorles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLakossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(30, 27);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(120, 20);
            this.textBoxNev.TabIndex = 0;
            // 
            // nudLakossag
            // 
            this.nudLakossag.Location = new System.Drawing.Point(30, 67);
            this.nudLakossag.Name = "nudLakossag";
            this.nudLakossag.Size = new System.Drawing.Size(120, 20);
            this.nudLakossag.TabIndex = 1;
            // 
            // btnVarosHozzaad
            // 
            this.btnVarosHozzaad.Location = new System.Drawing.Point(30, 111);
            this.btnVarosHozzaad.Name = "btnVarosHozzaad";
            this.btnVarosHozzaad.Size = new System.Drawing.Size(120, 23);
            this.btnVarosHozzaad.TabIndex = 2;
            this.btnVarosHozzaad.Text = "Hozzáad";
            this.btnVarosHozzaad.UseVisualStyleBackColor = true;
            this.btnVarosHozzaad.Click += new System.EventHandler(this.btnVarosHozzaad_Click);
            // 
            // textBoxLatvanyossagNev
            // 
            this.textBoxLatvanyossagNev.Location = new System.Drawing.Point(195, 27);
            this.textBoxLatvanyossagNev.Name = "textBoxLatvanyossagNev";
            this.textBoxLatvanyossagNev.Size = new System.Drawing.Size(120, 20);
            this.textBoxLatvanyossagNev.TabIndex = 3;
            // 
            // nudAr
            // 
            this.nudAr.Location = new System.Drawing.Point(195, 85);
            this.nudAr.Name = "nudAr";
            this.nudAr.Size = new System.Drawing.Size(120, 20);
            this.nudAr.TabIndex = 4;
            // 
            // btnLatvanyossagHozzaad
            // 
            this.btnLatvanyossagHozzaad.Location = new System.Drawing.Point(195, 142);
            this.btnLatvanyossagHozzaad.Name = "btnLatvanyossagHozzaad";
            this.btnLatvanyossagHozzaad.Size = new System.Drawing.Size(120, 23);
            this.btnLatvanyossagHozzaad.TabIndex = 5;
            this.btnLatvanyossagHozzaad.Text = "Hozzáad";
            this.btnLatvanyossagHozzaad.UseVisualStyleBackColor = true;
            this.btnLatvanyossagHozzaad.Click += new System.EventHandler(this.btnLatvanyossagHozzaad_Click);
            // 
            // comboBoxVarosok
            // 
            this.comboBoxVarosok.FormattingEnabled = true;
            this.comboBoxVarosok.Location = new System.Drawing.Point(195, 111);
            this.comboBoxVarosok.Name = "comboBoxVarosok";
            this.comboBoxVarosok.Size = new System.Drawing.Size(120, 21);
            this.comboBoxVarosok.TabIndex = 6;
            // 
            // textBoxLatvanyossagAr
            // 
            this.textBoxLatvanyossagAr.Location = new System.Drawing.Point(195, 53);
            this.textBoxLatvanyossagAr.Name = "textBoxLatvanyossagAr";
            this.textBoxLatvanyossagAr.Size = new System.Drawing.Size(120, 20);
            this.textBoxLatvanyossagAr.TabIndex = 7;
            // 
            // listBoxVarosok
            // 
            this.listBoxVarosok.FormattingEnabled = true;
            this.listBoxVarosok.Location = new System.Drawing.Point(380, 27);
            this.listBoxVarosok.Name = "listBoxVarosok";
            this.listBoxVarosok.Size = new System.Drawing.Size(199, 160);
            this.listBoxVarosok.TabIndex = 8;
            // 
            // listBoxLatvanyossagok
            // 
            this.listBoxLatvanyossagok.FormattingEnabled = true;
            this.listBoxLatvanyossagok.Location = new System.Drawing.Point(650, 27);
            this.listBoxLatvanyossagok.Name = "listBoxLatvanyossagok";
            this.listBoxLatvanyossagok.Size = new System.Drawing.Size(199, 160);
            this.listBoxLatvanyossagok.TabIndex = 9;
            // 
            // buttonVarosTorles
            // 
            this.buttonVarosTorles.Location = new System.Drawing.Point(427, 193);
            this.buttonVarosTorles.Name = "buttonVarosTorles";
            this.buttonVarosTorles.Size = new System.Drawing.Size(89, 23);
            this.buttonVarosTorles.TabIndex = 10;
            this.buttonVarosTorles.Text = "Törlés";
            this.buttonVarosTorles.UseVisualStyleBackColor = true;
            this.buttonVarosTorles.Click += new System.EventHandler(this.buttonVarosTorles_Click);
            // 
            // buttonLatvanyossagTorles
            // 
            this.buttonLatvanyossagTorles.Location = new System.Drawing.Point(699, 193);
            this.buttonLatvanyossagTorles.Name = "buttonLatvanyossagTorles";
            this.buttonLatvanyossagTorles.Size = new System.Drawing.Size(89, 23);
            this.buttonLatvanyossagTorles.TabIndex = 11;
            this.buttonLatvanyossagTorles.Text = "Törlés";
            this.buttonLatvanyossagTorles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(904, 267);
            this.Controls.Add(this.buttonLatvanyossagTorles);
            this.Controls.Add(this.buttonVarosTorles);
            this.Controls.Add(this.listBoxLatvanyossagok);
            this.Controls.Add(this.listBoxVarosok);
            this.Controls.Add(this.textBoxLatvanyossagAr);
            this.Controls.Add(this.comboBoxVarosok);
            this.Controls.Add(this.btnLatvanyossagHozzaad);
            this.Controls.Add(this.nudAr);
            this.Controls.Add(this.textBoxLatvanyossagNev);
            this.Controls.Add(this.btnVarosHozzaad);
            this.Controls.Add(this.nudLakossag);
            this.Controls.Add(this.textBoxNev);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLakossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.NumericUpDown nudLakossag;
        private System.Windows.Forms.Button btnVarosHozzaad;
        private System.Windows.Forms.TextBox textBoxLatvanyossagNev;
        private System.Windows.Forms.NumericUpDown nudAr;
        private System.Windows.Forms.Button btnLatvanyossagHozzaad;
        private System.Windows.Forms.ComboBox comboBoxVarosok;
        private System.Windows.Forms.TextBox textBoxLatvanyossagAr;
        private System.Windows.Forms.ListBox listBoxVarosok;
        private System.Windows.Forms.ListBox listBoxLatvanyossagok;
        private System.Windows.Forms.Button buttonVarosTorles;
        private System.Windows.Forms.Button buttonLatvanyossagTorles;
    }
}

