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
using MongoDB.Bson;

namespace uts3
{
    public partial class HealthDataForm : Form
    {
        

        public HealthDataForm( )
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HealthDataForm mainForm = new HealthDataForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
