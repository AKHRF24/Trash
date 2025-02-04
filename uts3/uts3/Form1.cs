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
using System.Security.Cryptography;

namespace uts3
{
    public partial class Form1 : Form
    {
        IMongoCollection<BsonDocument> userCollection;
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

        private void logLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
