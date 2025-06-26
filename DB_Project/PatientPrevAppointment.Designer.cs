namespace DB_Project
{
    partial class PatientPrevAppointment
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
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-23, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 68);
            panel1.TabIndex = 27;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(215, 18);
            label1.Name = "label1";
            label1.Size = new Size(404, 32);
            label1.TabIndex = 6;
            label1.Text = "Hospital Management System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 83);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 26;
            label2.Text = "Patient";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(238, 79);
            button3.Name = "button3";
            button3.Size = new Size(307, 36);
            button3.TabIndex = 29;
            button3.Text = "Previous Appointments";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // PatientPrevAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "PatientPrevAppointment";
            Text = "PatientPrevAppointment";
            Load += PatientPrevAppointment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}