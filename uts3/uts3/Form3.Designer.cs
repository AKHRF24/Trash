namespace uts3
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kgd = new System.Windows.Forms.TextBox();
            this.td = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.TextBox();
            this.tgl = new System.Windows.Forms.DateTimePicker();
            this.umur = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbLink = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Berat Badan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tekanan Darah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kadar Gula Darah";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(526, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.kgd);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.td);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bb);
            this.panel2.Controls.Add(this.tgl);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.umur);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nama);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(651, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 335);
            this.panel2.TabIndex = 8;
            // 
            // kgd
            // 
            this.kgd.Location = new System.Drawing.Point(183, 280);
            this.kgd.Multiline = true;
            this.kgd.Name = "kgd";
            this.kgd.Size = new System.Drawing.Size(298, 32);
            this.kgd.TabIndex = 7;
            // 
            // td
            // 
            this.td.Location = new System.Drawing.Point(183, 225);
            this.td.Multiline = true;
            this.td.Name = "td";
            this.td.Size = new System.Drawing.Size(298, 32);
            this.td.TabIndex = 6;
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(183, 172);
            this.bb.Multiline = true;
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(298, 32);
            this.bb.TabIndex = 4;
            // 
            // tgl
            // 
            this.tgl.Location = new System.Drawing.Point(183, 125);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(298, 26);
            this.tgl.TabIndex = 5;
            // 
            // umur
            // 
            this.umur.Location = new System.Drawing.Point(183, 72);
            this.umur.Multiline = true;
            this.umur.Name = "umur";
            this.umur.Size = new System.Drawing.Size(298, 32);
            this.umur.TabIndex = 3;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(183, 22);
            this.nama.Multiline = true;
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(298, 32);
            this.nama.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(646, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 40);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Uts";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1245, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 38);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dbLink);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 136);
            this.panel1.TabIndex = 1;
            // 
            // dbLink
            // 
            this.dbLink.AutoSize = true;
            this.dbLink.Font = new System.Drawing.Font("Goudy Stout", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dbLink.Location = new System.Drawing.Point(614, 96);
            this.dbLink.Name = "dbLink";
            this.dbLink.Size = new System.Drawing.Size(143, 16);
            this.dbLink.TabIndex = 28;
            this.dbLink.TabStop = true;
            this.dbLink.Text = "Dashboard";
            this.dbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dbLink_LinkClicked);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(608, 104);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(250, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(332, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(-4, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1328, 560);
            this.panel3.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 198);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(606, 306);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1300, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "akhrf";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox umur;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.DateTimePicker tgl;
        private System.Windows.Forms.TextBox td;
        private System.Windows.Forms.TextBox kgd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel dbLink;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}