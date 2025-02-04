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

namespace WindowsFormsApp9
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
            var database = client.GetDatabase("user");
            _userCollection = database.GetCollection<BsonDocument>("user");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if(AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Berhasil");
                Form2 mainForm = new Form2();
                mainForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("nama", username) & Builders<BsonDocument>.Filter.Eq("password", password);
            var user = _userCollection.Find(filter).FirstOrDefault();
            return user != null;
        }
    }
}
