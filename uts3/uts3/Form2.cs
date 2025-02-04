using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uts3
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
            var client = new MongoClient("mongodb://localhost:27017"); 
            var database = client.GetDatabase("uts");
            userCollection = database.GetCollection<BsonDocument>("Users");
        }
        private bool AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username) & Builders<BsonDocument>.Filter.Eq("password", password);
            var user = userCollection.Find(filter).FirstOrDefault();
            return user != null;
        }

        private void log_Click(object sender, EventArgs e)
        {
            string username = usnBox.Text; 
            string password = pwBox.Text; 

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
