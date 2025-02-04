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
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsChart = System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace uts3
{
    
    public partial class Form3 : Form
    {
        private IMongoCollection<BsonDocument> uts;
        public Form3()
        {
            InitializeComponent();
            InitializeMongoDB();
        }
        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("uts");
            uts = database.GetCollection<BsonDocument>("data");
            LoadData();
            RefreshChart();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var document = new BsonDocument
            {
                { "Name", nama.Text },
                { "Age", int.Parse(umur.Text) },
                { "Date", tgl.Value.ToString("yyyy-MM-dd") },
                { "Weight", double.Parse(bb.Text) },
                { "BloodPressure", td.Text },
                { "BloodSugarLevel", double.Parse(kgd.Text) }
            };

            uts.InsertOne(document);
            LoadData();
            RefreshChart();
            MessageBox.Show("Data added successfully.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            var selected = listBox1.SelectedItem.ToString();
            var id = selected.Split('|')[0].Trim();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var document = uts.Find(filter).FirstOrDefault();

            if (document != null)
            {
                nama.Text = document["Name"].ToString();
                umur.Text = document["Age"].ToString();
                tgl.Value = DateTime.Parse(document["Date"].ToString());
                bb.Text = document["Weight"].ToString();
                td.Text = document["BloodPressure"].ToString();
                kgd.Text = document["BloodSugarLevel"].ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            var selected = listBox1.SelectedItem.ToString();
            var id = selected.Split('|')[0].Trim();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var update = Builders<BsonDocument>.Update
                .Set("Name", nama.Text)
                .Set("Age", int.Parse(umur.Text))
                .Set("Date", tgl.Value.ToString("yyyy-MM-dd"))
                .Set("Weight", double.Parse(bb.Text))
                .Set("BloodPressure", td.Text)
                .Set("BloodSugarLevel", double.Parse(kgd.Text));

            uts.UpdateOne(filter, update);
            LoadData();
            RefreshChart();
            MessageBox.Show("Data updated successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            var selected = listBox1.SelectedItem.ToString();
            var id = selected.Split('|')[0].Trim();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            uts.DeleteOne(filter);

            LoadData();
            RefreshChart();
            MessageBox.Show("Data deleted successfully.");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            var documents = uts.Find(new BsonDocument()).ToList();
            listBox1.Items.Clear();

            foreach (var doc in documents)
            {
                listBox1.Items.Add($"{doc["_id"]} | {doc["Name"]} | {doc["Date"]}");
            }
        }
        private void RefreshChart()
        {
            chart1.Series.Clear();

            var documents = uts.Find(new BsonDocument()).ToList();

            var series = new WinFormsChart.Series("Weight vs Blood Sugar")
            {
                ChartType = WinFormsChart.SeriesChartType.Line,
                BorderWidth = 2
            };

            foreach (var doc in documents)
            {
                if (doc.Contains("Weight") && doc.Contains("BloodSugarLevel"))
                {
                    double weight = doc["Weight"].ToDouble();
                    double bloodSugarLevel = doc["BloodSugarLevel"].ToDouble();

                    series.Points.AddXY(weight, bloodSugarLevel);
                }
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].RecalculateAxesScale();
        }
        private void dbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HealthDataForm mainForm = new HealthDataForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
