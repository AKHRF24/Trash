namespace uts3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usnBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.usiaBox = new System.Windows.Forms.TextBox();
            this.namaBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regis
            // 
            this.regis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regis.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regis.Location = new System.Drawing.Point(653, 452);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(369, 38);
            this.regis.TabIndex = 25;
            this.regis.Text = "Register";
            this.regis.UseVisualStyleBackColor = false;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 6F);
            this.label5.Location = new System.Drawing.Point(716, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sudah Punya Akun?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Username";
            // 
            // usnBox
            // 
            this.usnBox.Location = new System.Drawing.Point(653, 313);
            this.usnBox.Multiline = true;
            this.usnBox.Name = "usnBox";
            this.usnBox.Size = new System.Drawing.Size(369, 36);
            this.usnBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usia";
            // 
            // logLink
            // 
            this.logLink.AutoSize = true;
            this.logLink.Font = new System.Drawing.Font("Goudy Stout", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLink.Location = new System.Drawing.Point(797, 552);
            this.logLink.Name = "logLink";
            this.logLink.Size = new System.Drawing.Size(76, 16);
            this.logLink.TabIndex = 18;
            this.logLink.TabStop = true;
            this.logLink.Text = "Login";
            this.logLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nama";
            // 
            // usiaBox
            // 
            this.usiaBox.Location = new System.Drawing.Point(653, 239);
            this.usiaBox.Multiline = true;
            this.usiaBox.Name = "usiaBox";
            this.usiaBox.Size = new System.Drawing.Size(369, 36);
            this.usiaBox.TabIndex = 16;
            // 
            // namaBox
            // 
            this.namaBox.Location = new System.Drawing.Point(653, 168);
            this.namaBox.Multiline = true;
            this.namaBox.Name = "namaBox";
            this.namaBox.Size = new System.Drawing.Size(369, 36);
            this.namaBox.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 116);
            this.panel1.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1030, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(679, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "Register";
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(653, 392);
            this.pwBox.Multiline = true;
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(369, 36);
            this.pwBox.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, -18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 665);
            this.panel2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1085, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usnBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usiaBox);
            this.Controls.Add(this.namaBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pwBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usnBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel logLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usiaBox;
        private System.Windows.Forms.TextBox namaBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.Panel panel2;
    }
}

