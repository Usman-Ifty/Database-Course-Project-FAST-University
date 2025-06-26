using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form anme PatientCheck
            PatientCheck pc = new PatientCheck();
            pc.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //form anme PatientBookAppointment
            PatientBookAppointment pba = new PatientBookAppointment();
            pba.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //form anme PatientPrevAppointment
            PatientPrevAppointment ppa = new PatientPrevAppointment();
            ppa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //form anme PatientCustSupport
            PatientCustSupport pcs = new PatientCustSupport();
            pcs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //form anme PatientTrackAppointment
            PatientTrackAppointment pta = new PatientTrackAppointment();
            pta.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
