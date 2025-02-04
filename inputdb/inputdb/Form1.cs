using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace inputdb
{
    public partial class Form1 : Form
    {
        private IMongoCollection<BsonDocument> collection;
        public Form1()
        {
            InitializeComponent();
            InitializeMongoDB();
        }
        private void InitializeMongoDB()
        {
            // Koneksi ke database MongoDB
            var connectionString = "mongodb://localhost:27017/";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("HealthRecords");
            collection = database.GetCollection<BsonDocument>("PatientData");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mengambil nilai dari input pengguna
                string nama = textBox1.Text;
                int umur = int.Parse(textBox2.Text);
                string jenisKelamin = comboBox1.Text;
                double beratBadan = double.Parse(textBox3.Text);
                double tinggiBadanCm = double.Parse(textBox4.Text);

                // Mengubah tinggi badan dari cm ke meter
                double tinggiBadanMeter = tinggiBadanCm / 100;

                // Menghitung BMI
                double bmi = beratBadan / (tinggiBadanMeter * tinggiBadanMeter);

                // Menentukan kategori berat badan berdasarkan BMI
                string kategori;
                if (bmi < 40)
                {
                    kategori = "Berat badan kurang";
                }
                else if (bmi >= 45.5 && bmi <= 50.5)
                {
                    kategori = "Berat badan ideal";
                }
                else if (bmi >= 55.5 && bmi <= 60.5)
                {
                    kategori = "Berat badan berlebih";
                }
                else
                {
                    kategori = "Obesitas";
                }

                // Membuat dokumen Bson dari input pengguna dan hasil BMI
                var document = new BsonDocument
                {
                    { "Nama", nama },
                    { "Umur", umur },
                    { "JenisKelamin", jenisKelamin },
                    { "BeratBadan", beratBadan },
                    { "TinggiBadanMeter", tinggiBadanMeter },
                    { "BMI", bmi },
                    { "Kategori", kategori }
                };

                // Menyimpan dokumen ke koleksi
                collection.InsertOne(document);

                // Menampilkan pesan sukses
                MessageBox.Show("Data kesehatan telah berhasil dimasukkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Menampilkan pesan kesalahan
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
