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
    public partial class employee1 : Form
    {
        public employee1()
        {
            InitializeComponent();
        }

        private void employee1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e1Check
            e1Check e1 = new e1Check();
            e1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e1ViewSal
            e1ViewSal e1 = new e1ViewSal();
            e1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e1MngTask
            e1MngTask e1 = new e1MngTask();
            e1.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e1CustSupport
            e1CustSupport e1 = new e1CustSupport();
            e1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e1SellTickets
            e1SellTickets e1 = new e1SellTickets();
            e1.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
