namespace DB_Project
{
    partial class employee3
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
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(235, 88);
            button3.Name = "button3";
            button3.Size = new Size(307, 36);
            button3.TabIndex = 26;
            button3.Text = "Customer Support Staff";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(235, 288);
            button5.Name = "button5";
            button5.Size = new Size(307, 36);
            button5.TabIndex = 32;
            button5.Text = "Generate Customer Support";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(235, 246);
            button4.Name = "button4";
            button4.Size = new Size(307, 36);
            button4.TabIndex = 31;
            button4.Text = "Resolve Customer Issues";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(235, 204);
            button1.Name = "button1";
            button1.Size = new Size(307, 36);
            button1.TabIndex = 30;
            button1.Text = "View Feedback";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(235, 162);
            button2.Name = "button2";
            button2.Size = new Size(307, 36);
            button2.TabIndex = 29;
            button2.Text = "Check Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-8, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 77);
            panel1.TabIndex = 35;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(208, 20);
            label3.Name = "label3";
            label3.Size = new Size(404, 32);
            label3.TabIndex = 13;
            label3.Text = "Hospital Management System";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 86);
            label4.Name = "label4";
            label4.Size = new Size(145, 32);
            label4.TabIndex = 34;
            label4.Text = "Employee";
            label4.Click += label4_Click;
            // 
            // employee3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Name = "employee3";
            Text = "employee3";
            Load += employee3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Label label4;
    }
}