using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AntrianPembelianBibit
{
    public partial class Form1 : Form
    {
        private Queue<string> antrianPembeli = new Queue<string>();

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaPembeli = new System.Windows.Forms.TextBox();
            this.btnTambahAntrian = new System.Windows.Forms.Button();
            this.lstAntrian = new System.Windows.Forms.ListBox();
            this.btnPanggilPembeli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pembeli:";
            // 
            // txtNamaPembeli
            // 
            this.txtNamaPembeli.Location = new System.Drawing.Point(96, 10);
            this.txtNamaPembeli.Name = "txtNamaPembeli";
            this.txtNamaPembeli.Size = new System.Drawing.Size(176, 20);
            this.txtNamaPembeli.TabIndex = 1;
            // 
            // btnTambahAntrian
            // 
            this.btnTambahAntrian.Location = new System.Drawing.Point(278, 8);
            this.btnTambahAntrian.Name = "btnTambahAntrian";
            this.btnTambahAntrian.Size = new System.Drawing.Size(75, 23);
            this.btnTambahAntrian.TabIndex = 2;
            this.btnTambahAntrian.Text = "Tambah";
            this.btnTambahAntrian.UseVisualStyleBackColor = true;
            this.btnTambahAntrian.Click += new System.EventHandler(this.btnTambahAntrian_Click);
            // 
            // lstAntrian
            // 
            this.lstAntrian.FormattingEnabled = true;
            this.lstAntrian.Location = new System.Drawing.Point(16, 47);
            this.lstAntrian.Name = "lstAntrian";
            this.lstAntrian.Size = new System.Drawing.Size(337, 147);
            this.lstAntrian.TabIndex = 3;
            // 
            // btnPanggilPembeli
            // 
            this.btnPanggilPembeli.Location = new System.Drawing.Point(16, 200);
            this.btnPanggilPembeli.Name = "btnPanggilPembeli";
            this.btnPanggilPembeli.Size = new System.Drawing.Size(337, 23);
            this.btnPanggilPembeli.TabIndex = 4;
            this.btnPanggilPembeli.Text = "Panggil Pembeli Berikutnya";
            this.btnPanggilPembeli.UseVisualStyleBackColor = true;
            this.btnPanggilPembeli.Click += new System.EventHandler(this.btnPanggilPembeli_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(368, 235);
            this.Controls.Add(this.btnPanggilPembeli);
            this.Controls.Add(this.lstAntrian);
            this.Controls.Add(this.btnTambahAntrian);
            this.Controls.Add(this.txtNamaPembeli);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Antrian Pembelian Bibit Tanaman";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnTambahAntrian_Click(object sender, EventArgs e)
        {
            string namaPembeli = txtNamaPembeli.Text.Trim();
            if (!string.IsNullOrEmpty(namaPembeli))
            {
                antrianPembeli.Enqueue(namaPembeli);
                lstAntrian.Items.Add(namaPembeli);
                txtNamaPembeli.Clear();
            }
            else
            {
                MessageBox.Show("Masukkan nama pembeli terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPanggilPembeli_Click(object sender, EventArgs e)
        {
            if (antrianPembeli.Count > 0)
            {
                string pembeliDipanggil = antrianPembeli.Dequeue();
                lstAntrian.Items.RemoveAt(0);
                MessageBox.Show($"Pembeli dengan nama {pembeliDipanggil} silakan menuju ke kasir.", "Panggilan Pembeli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tidak ada pembeli dalam antrian.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaPembeli;
        private System.Windows.Forms.Button btnTambahAntrian;
        private System.Windows.Forms.ListBox lstAntrian;
        private System.Windows.Forms.Button btnPanggilPembeli;
    }
}
