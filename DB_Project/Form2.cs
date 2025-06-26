using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DB_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if this is clicked then new form will be opened named as adminCheckcs.cs
        
            adminCheckcs f2 = new adminCheckcs();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if this is clicked then new form will be opened named as adminMngEmp.cs
           
            adminMngEmp f2 = new adminMngEmp();
            f2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            AdminMngAppointments f2 = new AdminMngAppointments();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if this is clicked then new form will be opened named as AdminGenReport.cs
          
            AdminGenReport f2 = new AdminGenReport();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if this is clicked then new form will be opened named as AdminViewAppointmentscs.cs
           
            AdminViewAppointmentscs f2 = new AdminViewAppointmentscs();
            f2.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if this is clicked then new form will be opened named as AdminAssTask.cs
          
            AdminAssTask f2 = new AdminAssTask();
            f2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if this is clicked then new form will be opened named as AdminViewFeedback.cs
        
            AdminViewFeedback f2 = new AdminViewFeedback();
            f2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if this is clicked then new form will be opened named as AdminDashboard.cs
          
            AdminDashboard f2 = new AdminDashboard();
            f2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
