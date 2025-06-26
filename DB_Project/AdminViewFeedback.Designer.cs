namespace DB_Project
{
    partial class AdminViewFeedback
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
            button7 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 68);
            panel1.TabIndex = 19;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 78);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 17;
            label2.Text = "ADMIN";
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(247, 74);
            button7.Name = "button7";
            button7.Size = new Size(307, 36);
            button7.TabIndex = 20;
            button7.Text = "View Feedback";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // AdminViewFeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "AdminViewFeedback";
            Text = "AdminViewFeedback";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button7;
    }
}