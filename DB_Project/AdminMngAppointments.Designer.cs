namespace DB_Project
{
    partial class AdminMngAppointments
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(261, 353);
            button5.Name = "button5";
            button5.Size = new Size(93, 24);
            button5.TabIndex = 41;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(261, 323);
            button4.Name = "button4";
            button4.Size = new Size(93, 24);
            button4.TabIndex = 40;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(261, 293);
            button3.Name = "button3";
            button3.Size = new Size(93, 24);
            button3.TabIndex = 39;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(261, 263);
            button1.Name = "button1";
            button1.Size = new Size(93, 24);
            button1.TabIndex = 38;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(384, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(374, 302);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(2, 150);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 23);
            textBox5.TabIndex = 36;
            textBox5.Text = "Enter Your Name";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(-25, 137);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 35;
            label7.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(2, 206);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 34;
            textBox1.Text = "Enter Your Name";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 188);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 33;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-18, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 71);
            panel1.TabIndex = 31;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(5, 86);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 30;
            label2.Text = "ADMIN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 42;
            label3.Text = "ID";
            label3.Click += label3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(237, 76);
            button6.Name = "button6";
            button6.Size = new Size(307, 36);
            button6.TabIndex = 43;
            button6.Text = "Manage Appointment Schedual";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // AdminMngAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "AdminMngAppointments";
            Text = "AdminMngAppointments";
            Load += AdminMngAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox1;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button6;
    }
}