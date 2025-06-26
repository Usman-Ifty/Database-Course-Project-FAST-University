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
    public partial class employee3 : Form
    {
        public employee3()
        {
            InitializeComponent();
        }

        private void employee3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form name e3ResCustIssues
            e3ViewFeedback e3ViewFeedback = new e3ViewFeedback();
            e3ViewFeedback.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            e3Check e3Check = new e3Check();
            e3Check.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //form name e3ResCustIssues
            e3ResCustIssues e3ResCustIssues = new e3ResCustIssues();
            e3ResCustIssues.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //form name e3GenCustSupport
            e3GenCustSupport e3GenCustSupport = new e3GenCustSupport();
            e3GenCustSupport.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
