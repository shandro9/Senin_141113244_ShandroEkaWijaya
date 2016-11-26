namespace volleyball_problem
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.buttonhitung = new System.Windows.Forms.Button();
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HASIL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(58, 94);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 0;
            this.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // Txt2
            // 
            this.Txt2.BackColor = System.Drawing.SystemColors.Window;
            this.Txt2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt2.Location = new System.Drawing.Point(58, 153);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 1;
            this.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt2_KeyPress);
            // 
            // buttonhitung
            // 
            this.buttonhitung.Location = new System.Drawing.Point(179, 115);
            this.buttonhitung.Name = "buttonhitung";
            this.buttonhitung.Size = new System.Drawing.Size(75, 23);
            this.buttonhitung.TabIndex = 2;
            this.buttonhitung.Text = "Hitung";
            this.buttonhitung.UseVisualStyleBackColor = true;
            this.buttonhitung.Click += new System.EventHandler(this.button1_Click);
            this.buttonhitung.Enter += new System.EventHandler(this.button1_Click);
            this.buttonhitung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonhitung_KeyPress);
            // 
            // TxtHasil
            // 
            this.TxtHasil.AccessibleName = "hasil";
            this.TxtHasil.Location = new System.Drawing.Point(283, 115);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.Size = new System.Drawing.Size(55, 20);
            this.TxtHasil.TabIndex = 3;
            this.TxtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score B";
            // 
            // HASIL
            // 
            this.HASIL.AutoSize = true;
            this.HASIL.Location = new System.Drawing.Point(283, 100);
            this.HASIL.Name = "HASIL";
            this.HASIL.Size = new System.Drawing.Size(30, 13);
            this.HASIL.TabIndex = 6;
            this.HASIL.Text = "Hasil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 264);
            this.Controls.Add(this.HASIL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.buttonhitung);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Button buttonhitung;
        private System.Windows.Forms.TextBox TxtHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HASIL;
    }
}

