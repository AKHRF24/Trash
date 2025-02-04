using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using BCrypt.Net;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace uts2
{
    public partial class Form1 : Form
    {
        private IMongoCollection<BsonDocument> userCollection;
        public Form1()
        {
            InitializeComponent();
            InitializeMongoDB();
        }
        private void InitializeMongoDB()
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("uts");
            userCollection = database.GetCollection<BsonDocument>("Users");
        }
        private void regis_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = namaBox.Text;
                int umur = int.Parse(usiaBox.Text);
                string username = usnBox.Text;
                string password = pwBox.Text;

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                

                var document = new BsonDocument()
               {
                    { "Nama", nama },
                    { "Umur", umur },
                    {"username", username},
                    {"password", hashedPassword}

               };

                userCollection.InsertOne(document);

                MessageBox.Show($"Berhasil register",
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confpw_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usiaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pwBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
