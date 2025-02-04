using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BloodPressureApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Mengambil input dari TextBox
            string userName = txtName.Text;
            string systolicInput = txtSystolic.Text;
            string diastolicInput = txtDiastolic.Text;

            // Validasi input
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(systolicInput) || string.IsNullOrEmpty(diastolicInput))
            {
                MessageBox.Show("Semua field harus diisi.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(systolicInput, out int systolic) || !int.TryParse(diastolicInput, out int diastolic))
            {
                MessageBox.Show("Nilai tekanan darah harus berupa angka.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kategorisasi tekanan darah
            string result;
            if (systolic < 90 || diastolic < 60)
            {
                result = "rendah";
            }
            else if (systolic <= 120 && diastolic <= 80)
            {
                result = "normal";
            }
            else
            {
                result = "tinggi";
            }

            // Menambahkan hasil ke ListBox
            listBoxResults.Items.Add($"Pasien dengan Nama: {userName} memiliki Tekanan darah {result}");
        }
    }
}
