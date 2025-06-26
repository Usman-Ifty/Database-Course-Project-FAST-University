namespace DB_Project
{
    partial class e2MngApp
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
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-7, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 77);
            panel1.TabIndex = 37;
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
            label4.Location = new Point(20, 86);
            label4.Name = "label4";
            label4.Size = new Size(145, 32);
            label4.TabIndex = 36;
            label4.Text = "Employee";
            label4.Click += label4_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(471, 82);
            button4.Name = "button4";
            button4.Size = new Size(307, 36);
            button4.TabIndex = 35;
            button4.Text = "Manage Appointments";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(170, 82);
            button2.Name = "button2";
            button2.Size = new Size(307, 36);
            button2.TabIndex = 32;
            button2.Text = "Medical Staff - Doctor/Nurse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // e2MngApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button2);
            Name = "e2MngApp";
            Text = "e2MngApp";
            Load += e2MngApp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label4;
        private Button button4;
        private Button button2;
    }
}