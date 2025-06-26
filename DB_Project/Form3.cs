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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as employee1
            employee1 emp = new employee1();
            emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as employee2
            employee2 emp2 = new employee2();
            emp2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as employee3
            employee3 emp3 = new employee3();
            emp3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
