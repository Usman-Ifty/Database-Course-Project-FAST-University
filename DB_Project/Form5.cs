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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //progress the bar as the fields are being filled
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //progress the bar as the fields are being filled
        


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progress the bar as the fields are being filled
            progressBar1.Value = 0;
            if (textBox1.Text != "")
            {
                progressBar1.Value += 20;
            }
            if (textBox2.Text != "")
            {
                progressBar1.Value += 20;
            }
            if (textBox3.Text != "")
            {
                progressBar1.Value += 20;
            }
            if (textBox4.Text != "")
            {
                progressBar1.Value += 20;
            }
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                progressBar1.Value += 20;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //check if all the fields are filled do not allow to proceed if not
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                //check if the password and confirm password are same
                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("Password and Confirm Password do not match");
                }
                else
                {
                    //check if the password is strong
                    if (textBox3.Text.Length < 8)
                    {
                        MessageBox.Show("Password should be atleast 8 characters long");
                    }
                    else
                    {
                        //check if the password contains atleast one uppercase letter
                        if (!textBox3.Text.Any(char.IsUpper))
                        {
                            MessageBox.Show("Password should contain atleast one uppercase letter");
                        }
                        else
                        {
                            //check if the password contains atleast one lowercase letter
                            if (!textBox3.Text.Any(char.IsLower))
                            {
                                MessageBox.Show("Password should contain atleast one lowercase letter");
                            }
                            else
                            {
                                //check if the password contains atleast one digit
                                if (!textBox3.Text.Any(char.IsDigit))
                                {
                                    MessageBox.Show("Password should contain atleast one digit");
                                }
                                else
                                {
                                    //check if the password contains atleast one special character
                                    if (!textBox3.Text.Any(ch => !Char.IsLetterOrDigit(ch)))
                                    {
                                        MessageBox.Show("Password should contain atleast one special character");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Registeration Successful");

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
