namespace uts2
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
            this.log = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usnBox = new System.Windows.Forms.TextBox();
            this.regLink = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(36, 330);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(367, 41);
            this.log.TabIndex = 25;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 6F);
            this.label5.Location = new System.Drawing.Point(95, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sudah Punya Akun?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Username";
            // 
            // usnBox
            // 
            this.usnBox.Location = new System.Drawing.Point(36, 200);
            this.usnBox.Multiline = true;
            this.usnBox.Name = "usnBox";
            this.usnBox.Size = new System.Drawing.Size(367, 39);
            this.usnBox.TabIndex = 20;
            // 
            // regLink
            // 
            this.regLink.AutoSize = true;
            this.regLink.Font = new System.Drawing.Font("Goudy Stout", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLink.Location = new System.Drawing.Point(165, 422);
            this.regLink.Name = "regLink";
            this.regLink.Size = new System.Drawing.Size(123, 16);
            this.regLink.TabIndex = 18;
            this.regLink.TabStop = true;
            this.regLink.Text = "Register";
            this.regLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regLink_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 117);
            this.panel1.TabIndex = 26;
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login";
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(36, 267);
            this.pwBox.Multiline = true;
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(367, 39);
            this.pwBox.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(441, 681);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usnBox);
            this.Controls.Add(this.regLink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pwBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usnBox;
        private System.Windows.Forms.LinkLabel regLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pwBox;
    }
}