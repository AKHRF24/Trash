namespace WindowsFormsApp8
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
            this.btnHitung = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtSistolik = new System.Windows.Forms.TextBox();
            this.txtDiastolik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(777, 117);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(154, 58);
            this.btnHitung.TabIndex = 0;
            this.btnHitung.Text = "Cek Hasil";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click_1);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(557, 85);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(196, 26);
            this.txtNama.TabIndex = 1;
            // 
            // txtSistolik
            // 
            this.txtSistolik.Location = new System.Drawing.Point(557, 117);
            this.txtSistolik.Name = "txtSistolik";
            this.txtSistolik.Size = new System.Drawing.Size(196, 26);
            this.txtSistolik.TabIndex = 2;
            // 
            // txtDiastolik
            // 
            this.txtDiastolik.Location = new System.Drawing.Point(557, 149);
            this.txtDiastolik.Name = "txtDiastolik";
            this.txtDiastolik.Size = new System.Drawing.Size(196, 26);
            this.txtDiastolik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(388, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(388, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tekanan Sistolik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(388, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tekanan Diastolik";
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.ItemHeight = 20;
            this.lstHasil.Location = new System.Drawing.Point(392, 181);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(539, 324);
            this.lstHasil.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1613, 627);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiastolik);
            this.Controls.Add(this.txtSistolik);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnHitung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtSistolik;
        private System.Windows.Forms.TextBox txtDiastolik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstHasil;
    }
}

