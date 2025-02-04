using System;
using System.Windows.Forms;

namespace PenjadwalanJanjiMedis
{
    public partial class FormPenjadwalanJanji : Form
    {
        private System.ComponentModel.IContainer components = null;

        public FormPenjadwalanJanji()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Aplikasi Penjadwalan Janji Medis";
            this.Size = new System.Drawing.Size(800, 600);

            // Label Judul
            Label labelTitle = new Label();
            labelTitle.Text = "Penjadwalan Janji Medis";
            labelTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Location = new System.Drawing.Point(300, 20);
            this.Controls.Add(labelTitle);

            // Data Grid View untuk daftar janji
            DataGridView dgvJanji = new DataGridView();
            dgvJanji.Location = new System.Drawing.Point(50, 70);
            dgvJanji.Size = new System.Drawing.Size(700, 250);
            dgvJanji.ColumnCount = 4;
            dgvJanji.Columns[0].Name = "Nama Pasien";
            dgvJanji.Columns[1].Name = "Tanggal";
            dgvJanji.Columns[2].Name = "Waktu";
            dgvJanji.Columns[3].Name = "Dokter";
            this.Controls.Add(dgvJanji);

            // Label Nama Pasien
            Label labelNamaPasien = new Label();
            labelNamaPasien.Text = "Nama Pasien:";
            labelNamaPasien.Location = new System.Drawing.Point(50, 350);
            labelNamaPasien.AutoSize = true;
            this.Controls.Add(labelNamaPasien);

            // Textbox Nama Pasien
            TextBox txtNamaPasien = new TextBox();
            txtNamaPasien.Location = new System.Drawing.Point(150, 350);
            txtNamaPasien.Size = new System.Drawing.Size(200, 22);
            this.Controls.Add(txtNamaPasien);

            // Label Tanggal
            Label labelTanggal = new Label();
            labelTanggal.Text = "Tanggal (dd/mm/yyyy):";
            labelTanggal.Location = new System.Drawing.Point(50, 390);
            labelTanggal.AutoSize = true;
            this.Controls.Add(labelTanggal);

            // DateTimePicker Tanggal
            DateTimePicker dtpTanggal = new DateTimePicker();
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new System.Drawing.Point(200, 390);
            dtpTanggal.Size = new System.Drawing.Size(150, 22);
            this.Controls.Add(dtpTanggal);

            // Label Waktu
            Label labelWaktu = new Label();
            labelWaktu.Text = "Waktu (HH:MM):";
            labelWaktu.Location = new System.Drawing.Point(50, 430);
            labelWaktu.AutoSize = true;
            this.Controls.Add(labelWaktu);

            // Textbox Waktu
            TextBox txtWaktu = new TextBox();
            txtWaktu.Location = new System.Drawing.Point(150, 430);
            txtWaktu.Size = new System.Drawing.Size(100, 22);
            this.Controls.Add(txtWaktu);

            // Label Dokter
            Label labelDokter = new Label();
            labelDokter.Text = "Dokter:";
            labelDokter.Location = new System.Drawing.Point(50, 470);
            labelDokter.AutoSize = true;
            this.Controls.Add(labelDokter);

            // Textbox Dokter
            TextBox txtDokter = new TextBox();
            txtDokter.Location = new System.Drawing.Point(150, 470);
            txtDokter.Size = new System.Drawing.Size(200, 22);
            this.Controls.Add(txtDokter);

            // Tombol Tambah Janji
            Button btnTambahJanji = new Button();
            btnTambahJanji.Text = "Tambah Janji";
            btnTambahJanji.Location = new System.Drawing.Point(50, 510);
            btnTambahJanji.Size = new System.Drawing.Size(100, 30);
            btnTambahJanji.Click += (sender, e) =>
            {
                // Tambah data ke DataGridView
                dgvJanji.Rows.Add(txtNamaPasien.Text, dtpTanggal.Text, txtWaktu.Text, txtDokter.Text);

                // Kosongkan input setelah ditambahkan
                txtNamaPasien.Clear();
                txtWaktu.Clear();
                txtDokter.Clear();
            };
            this.Controls.Add(btnTambahJanji);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPenjadwalanJanji());
        }
    }
}
