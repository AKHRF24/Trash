using System;

namespace ta_pbo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Nama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NamaLokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeSaatIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KapasitasMaks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(797, 186);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(251, 26);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama Lokasi";
            this.Nama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaLokasi,
            this.VolumeSaatIni,
            this.KapasitasMaks,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(46, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(681, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // NamaLokasi
            // 
            this.NamaLokasi.HeaderText = "NamaLokasi";
            this.NamaLokasi.MinimumWidth = 8;
            this.NamaLokasi.Name = "NamaLokasi";
            this.NamaLokasi.Width = 150;
            // 
            // VolumeSaatIni
            // 
            this.VolumeSaatIni.HeaderText = "VolumeSaatIni";
            this.VolumeSaatIni.MinimumWidth = 8;
            this.VolumeSaatIni.Name = "VolumeSaatIni";
            this.VolumeSaatIni.Width = 150;
            // 
            // KapasitasMaks
            // 
            this.KapasitasMaks.HeaderText = "KapasitasMaks";
            this.KapasitasMaks.MinimumWidth = 8;
            this.KapasitasMaks.Name = "KapasitasMaks";
            this.KapasitasMaks.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(779, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 255);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Penuh",
            "Normal"});
            this.comboBox1.Location = new System.Drawing.Point(18, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Volume Saat Ini";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Kapasitas Maksimal";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISI DATA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-4, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 73);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(30, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 255);
            this.panel3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 26);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cari";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 26);
            this.button4.TabIndex = 8;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 26);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Seacrh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaLokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeSaatIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn KapasitasMaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}