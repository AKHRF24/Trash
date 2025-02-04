namespace uts2
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
            this.namaBox = new System.Windows.Forms.TextBox();
            this.usiaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.usnBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confpw = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namaBox
            // 
            this.namaBox.Location = new System.Drawing.Point(35, 164);
            this.namaBox.Multiline = true;
            this.namaBox.Name = "namaBox";
            this.namaBox.Size = new System.Drawing.Size(369, 36);
            this.namaBox.TabIndex = 0;
            this.namaBox.TextChanged += new System.EventHandler(this.namaBox_TextChanged);
            // 
            // usiaBox
            // 
            this.usiaBox.Location = new System.Drawing.Point(35, 235);
            this.usiaBox.Multiline = true;
            this.usiaBox.Name = "usiaBox";
            this.usiaBox.Size = new System.Drawing.Size(369, 36);
            this.usiaBox.TabIndex = 1;
            this.usiaBox.TextChanged += new System.EventHandler(this.usiaBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logLink
            // 
            this.logLink.AutoSize = true;
            this.logLink.Font = new System.Drawing.Font("Goudy Stout", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLink.Location = new System.Drawing.Point(167, 597);
            this.logLink.Name = "logLink";
            this.logLink.Size = new System.Drawing.Size(76, 16);
            this.logLink.TabIndex = 3;
            this.logLink.TabStop = true;
            this.logLink.Text = "Login";
            this.logLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usnBox
            // 
            this.usnBox.Location = new System.Drawing.Point(35, 309);
            this.usnBox.Multiline = true;
            this.usnBox.Name = "usnBox";
            this.usnBox.Size = new System.Drawing.Size(369, 36);
            this.usnBox.TabIndex = 5;
            this.usnBox.TextChanged += new System.EventHandler(this.usnBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(35, 388);
            this.pwBox.Multiline = true;
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(369, 36);
            this.pwBox.TabIndex = 7;
            this.pwBox.TextChanged += new System.EventHandler(this.pwBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 6F);
            this.label5.Location = new System.Drawing.Point(92, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sudah Punya Akun?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "Register";
            // 
            // regis
            // 
            this.regis.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regis.Location = new System.Drawing.Point(35, 512);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(369, 38);
            this.regis.TabIndex = 11;
            this.regis.Text = "Register";
            this.regis.UseVisualStyleBackColor = true;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 114);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(397, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 461);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(369, 36);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // confpw
            // 
            this.confpw.AutoSize = true;
            this.confpw.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confpw.Location = new System.Drawing.Point(65, 436);
            this.confpw.Name = "confpw";
            this.confpw.Size = new System.Drawing.Size(313, 22);
            this.confpw.TabIndex = 14;
            this.confpw.Text = "Confirm Password";
            this.confpw.Click += new System.EventHandler(this.confpw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(438, 682);
            this.Controls.Add(this.confpw);
            this.Controls.Add(this.textBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namaBox;
        private System.Windows.Forms.TextBox usiaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel logLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usnBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button regis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label confpw;
        private System.Windows.Forms.Button btnCancel;
    }
}

