using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click_1(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string sistolikText = txtSistolik.Text;
            string diastolikText = txtDiastolik.Text;

            if (!int.TryParse(sistolikText, out int sistolik) || !int.TryParse(diastolikText, out int diastolik))
            {
                MessageBox.Show("Masukkan nilai numerik yang valid untuk tekanan sistolik dan diastolik.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string kategori;
            if (sistolik < 90 || diastolik < 60)
            {
                kategori = "rendah";
            }
            else if (sistolik <= 120 && diastolik <= 80)
            {
                kategori = "normal";
            }
            else
            {
                kategori = "tinggi";
            }

            lstHasil.Items.Add($"Pasien dengan Nama : {nama} Memiliki Tekanan darah {kategori}");
        }
    }
}
