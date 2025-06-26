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
    public partial class Form1 : Form
    {
        public OracleConnection con;
        public Form1()
        {
            InitializeComponent();
            string conStr = "DATA SOURCE = localhost:1521/xe; USER ID=usman;PASSWORD=1234;";
            con = new OracleConnection(conStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login Successful");
     
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (textBox1.Text == "employee" && textBox2.Text == "employee")
            {
                MessageBox.Show("Login Successful");
         
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else if (textBox1.Text == "patient" && textBox2.Text == "patient")
            {
                MessageBox.Show("Login Successful");
          
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
