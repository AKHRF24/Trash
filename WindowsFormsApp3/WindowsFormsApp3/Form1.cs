using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<Appointment> appointments = new List<Appointment>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up form controls on load.
            dtpAppointmentDate.MinDate = DateTime.Today;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            string patientName = txtPatientName.Text;
            DateTime appointmentDate = dtpAppointmentDate.Value;
            string appointmentTime = txtAppointmentTime.Text;
            string doctorName = txtDoctorName.Text;

            if (string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(appointmentTime) || string.IsNullOrEmpty(doctorName))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Appointment newAppointment = new Appointment()
            {
                PatientName = patientName,
                AppointmentDate = appointmentDate,
                AppointmentTime = appointmentTime,
                DoctorName = doctorName
            };

            appointments.Add(newAppointment);
            UpdateAppointmentList();
            ClearInputFields();
        }

        private void UpdateAppointmentList()
        {
            lstAppointments.Items.Clear();
            foreach (var appointment in appointments)
            {
                lstAppointments.Items.Add($"{appointment.PatientName} - {appointment.AppointmentDate.ToShortDateString()} {appointment.AppointmentTime} with Dr. {appointment.DoctorName}");
            }
        }

        private void ClearInputFields()
        {
            txtPatientName.Clear();
            txtAppointmentTime.Clear();
            txtDoctorName.Clear();
        }
    }

    public class Appointment
    {
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string DoctorName { get; set; }
    }

    // Designer code
    partial class Form1
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtAppointmentTime = new System.Windows.Forms.TextBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.lstAppointments = new System.Windows.Forms.ListBox();

            // txtPatientName
            this.txtPatientName.Location = new System.Drawing.Point(15, 25);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 20);
            this.txtPatientName.TabIndex = 0;

            // txtDoctorName
            this.txtDoctorName.Location = new System.Drawing.Point(15, 70);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorName.TabIndex = 1;

            // txtAppointmentTime
            this.txtAppointmentTime.Location = new System.Drawing.Point(15, 115);
            this.txtAppointmentTime.Name = "txtAppointmentTime";
            this.txtAppointmentTime.Size = new System.Drawing.Size(200, 20);
            this.txtAppointmentTime.TabIndex = 2;

            // dtpAppointmentDate
            this.dtpAppointmentDate.Location = new System.Drawing.Point(15, 160);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentDate.TabIndex = 3;

            // btnAddAppointment
            this.btnAddAppointment.Location = new System.Drawing.Point(15, 205);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(200, 23);
            this.btnAddAppointment.TabIndex = 4;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);

            // lstAppointments
            this.lstAppointments.Location = new System.Drawing.Point(230, 25);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(300, 160);
            this.lstAppointments.TabIndex = 5;

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtAppointmentTime);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lstAppointments);
            this.Text = "Medical Appointment Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ListBox lstAppointments;
    }
}
