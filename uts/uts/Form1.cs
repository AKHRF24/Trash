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

namespace uts
{
    public partial class Form1 : Form
    {
        private IMongoCollection<BsonDocument> _userCollection;
        public Form1()
        {
            InitializeComponent();
            InitializeMongoDB();
        }
        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("uts");
            _userCollection = database.GetCollection<BsonDocument>("user");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textusn.Text;
            string password = textpw.Text;

            if (AuthenticateUser(name, password))
            {
                MessageBox.Show("Login Berhasil!");
                Form2 mainform = new Form2();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
        }
        private bool AuthenticateUser(string name, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("name",name) & Builders<BsonDocument>.Filter.Eq("password", password);
            var user = _userCollection.Find(filter).FirstOrDefault();
            return user != null;
        }
    }
}
