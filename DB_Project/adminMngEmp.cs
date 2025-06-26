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
    public partial class adminMngEmp : Form
    {
        public OracleConnection con;

        public adminMngEmp()
        {
            InitializeComponent();
            string conStr = "DATA SOURCE = localhost:1521/xe; USER ID=usman;PASSWORD=1234;";
            con = new OracleConnection(conStr);
        }

        private void adminMngEmp_Load(object sender, EventArgs e)
        {
            try
            {
                // Open the Oracle connection
                con.Open();

                // Close the connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Check if the column "AID" exists before accessing its value
                if (row.Cells["AID"].Value != null)
                {
                    textBox1.Text = row.Cells["AID"].Value.ToString();
                    // Similarly, add more textboxes and populate them with other column values as needed
                }
            }
        }

    }
}
