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
            // Ambil input dari TextBox
            string name = txtName.Text;
            string systolicInput = txtSystolic.Text;
            string diastolicInput = txtDiastolic.Text;

            // Validasi input untuk tekanan sistolik dan diastolik
            if (int.TryParse(systolicInput, out int systolic) && int.TryParse(diastolicInput, out int diastolic))
            {
                // Klasifikasi tekanan darah
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

                // Tambahkan hasil ke ListBox
                listBoxResults.Items.Add($"Pasien dengan Nama: {name} Memiliki Tekanan darah {result}");
            }
            else
            {
                MessageBox.Show("Masukkan nilai yang valid untuk tekanan sistolik dan diastolik.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
