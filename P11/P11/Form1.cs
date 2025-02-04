using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace P11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void buttonGetData_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Mengirim permintaan GET ke URL API yang ditentukan
                    HttpResponseMessage response = await client.GetAsync("https://1z9j60pb-5000.asse.devtunnels.ms//data");

                    // Memastikan permintaan berhasil dengan kode status 2xx
                    response.EnsureSuccessStatusCode();

                    // Membaca respons sebagai string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mengurai string respons menjadi array JSON
                    var data = JArray.Parse(responseBody);

                    // Membuat objek DataTable untuk menyimpan data
                    DataTable dt = new DataTable();

                    // Memeriksa apakah ada data dalam array JSON
                    if (data.Count > 0)
                    {
                        // Menambahkan kolom ke DataTable berdasarkan properti pertama dalam array JSON
                        foreach (var key in data[0].Children<JProperty>())
                        {
                            dt.Columns.Add(key.Name);
                        }

                        // Menambahkan baris ke DataTable untuk setiap item dalam array JSON
                        foreach (var item in data)
                        {
                            // Membuat baris baru di DataTable
                            DataRow row = dt.NewRow();

                            // Mengisi nilai baris dengan nilai properti dari item JSON
                            foreach (var prop in item.Children<JProperty>())
                            {
                                row[prop.Name] = prop.Value.ToString();
                            }

                            // Menambahkan baris yang telah diisi ke DataTable
                            dt.Rows.Add(row);
                        }
                    }

                    // Mengikat DataTable ke DataGridView untuk menampilkan data
                    dataGridViewData.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Menampilkan pesan kesalahan jika terjadi pengecualian
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
