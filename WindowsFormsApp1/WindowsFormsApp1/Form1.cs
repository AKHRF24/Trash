using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number)) // Menggunakan textBox1 sebagai input
            {
                if (number % 2 == 0)
                {
                    label1.Text = number + " adalah Genap"; // Mengatur teks label1 untuk hasil genap
                }
                else
                {
                    label1.Text = number + " adalah Ganjil"; // Mengatur teks label1 untuk hasil ganjil
                }
            }
            else
            {
                label1.Text = "Input tidak valid, masukkan angka yang benar."; // Pesan jika input tidak valid
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Tidak perlu mengubah apa pun di sini
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Tidak perlu mengubah apa pun di sini
        }
    }
}
