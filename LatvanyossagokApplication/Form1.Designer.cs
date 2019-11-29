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
            ((System.ComponentModel.ISupportInitialize)(this.nudLakossag)).BeginInit();
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(656, 379);
            this.Controls.Add(this.btnVarosHozzaad);
            this.Controls.Add(this.nudLakossag);
            this.Controls.Add(this.textBoxNev);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLakossag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.NumericUpDown nudLakossag;
        private System.Windows.Forms.Button btnVarosHozzaad;
    }
}

