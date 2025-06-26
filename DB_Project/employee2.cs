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
    public partial class employee2 : Form
    {
        public employee2()
        {
            InitializeComponent();
        }

        private void employee2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e2Check
            e2Check e2 = new e2Check();
            e2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e2ViewPat
            employee3 emp = new employee3();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e2ViewPat
            e2ViewPat emp = new e2ViewPat();
            emp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e2MngApp
            e2MngApp emp = new e2MngApp();
            emp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e2GenPresc
            e2GenPresc emp = new e2GenPresc();
            emp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if clicked on the button, new form will be opened named as e2UpdateMedRec
            e2UpdateMedRec emp = new e2UpdateMedRec();
            emp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
