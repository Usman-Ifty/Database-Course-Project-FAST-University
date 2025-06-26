namespace DB_Project
{
    partial class e2UpdateMedRec
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
            button6 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-8, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 77);
            panel1.TabIndex = 39;
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
            label4.Location = new Point(19, 85);
            label4.Name = "label4";
            label4.Size = new Size(145, 32);
            label4.TabIndex = 38;
            label4.Text = "Employee";
            label4.Click += label4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(168, 81);
            button6.Name = "button6";
            button6.Size = new Size(307, 36);
            button6.TabIndex = 37;
            button6.Text = "Update Medical Record";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(469, 81);
            button1.Name = "button1";
            button1.Size = new Size(307, 36);
            button1.TabIndex = 40;
            button1.Text = "Update Medical Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // e2UpdateMedRec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button6);
            Name = "e2UpdateMedRec";
            Text = "e2UpdateMedRec";
            Load += e2UpdateMedRec_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label4;
        private Button button6;
        private Button button1;
    }
}