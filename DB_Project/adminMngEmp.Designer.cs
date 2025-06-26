namespace DB_Project
{
    partial class adminMngEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 17;
            label2.Text = "ADMIN";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 71);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(208, 20);
            label1.Name = "label1";
            label1.Size = new Size(404, 32);
            label1.TabIndex = 13;
            label1.Text = "Hospital Management System";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(250, 73);
            button2.Name = "button2";
            button2.Size = new Size(307, 36);
            button2.TabIndex = 20;
            button2.Text = "Manage Employees";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 203);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 22;
            textBox1.Text = "Enter Your Name";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 21;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(12, 147);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 23);
            textBox5.TabIndex = 24;
            textBox5.Text = "Enter Your Name";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 129);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 23;
            label7.Text = "ID";
            label7.Click += label7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(394, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(374, 302);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(271, 260);
            button1.Name = "button1";
            button1.Size = new Size(93, 24);
            button1.TabIndex = 26;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(271, 290);
            button3.Name = "button3";
            button3.Size = new Size(93, 24);
            button3.TabIndex = 27;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(271, 320);
            button4.Name = "button4";
            button4.Size = new Size(93, 24);
            button4.TabIndex = 28;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(271, 350);
            button5.Name = "button5";
            button5.Size = new Size(93, 24);
            button5.TabIndex = 29;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // adminMngEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 380);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "adminMngEmp";
            Text = "adminMngEmp";
            Load += adminMngEmp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox5;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}