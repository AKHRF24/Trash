using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace uts2
{
    public partial class Form2 : Form
    {
        private IMongoCollection<BsonDocument> userCollection;
        public Form2()
        {
            InitializeComponent();
            InitializeComponentMongoDB();
        }
        private void InitializeComponentMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017"); //sesuaikan dengan koneksi data
            var database = client.GetDatabase("uts"); // Nama database 
            userCollection = database.GetCollection<BsonDocument>("Users");//koleksi pengguna
        }
        private bool AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username) & Builders<BsonDocument>.Filter.Eq("password", password);
            var user = userCollection.Find(filter).FirstOrDefault();
            return user != null;
        }
        private void log_Click(object sender, EventArgs e)
        {
            string username = usnBox.Text; // ambil data dari textbox username
            string password = pwBox.Text; // ambil data dari textbox password

            if (AuthenticateUser(username, password))
            {

                Form3 mainForm = new Form3();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("username atau password salah.");
            }
        }

        private void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
            // kalo berhasil class form2

        }
    }
}
