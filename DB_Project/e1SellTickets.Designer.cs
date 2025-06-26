namespace DB_Project
{
    partial class e1SellTickets
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
            button1 = new Button();
            label2 = new Label();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 77);
            panel1.TabIndex = 27;
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
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(173, 83);
            button1.Name = "button1";
            button1.Size = new Size(307, 36);
            button1.TabIndex = 26;
            button1.Text = "Receptionist/Cashier";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 25;
            label2.Text = "Employee";
            label2.Click += label2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(481, 83);
            button6.Name = "button6";
            button6.Size = new Size(307, 36);
            button6.TabIndex = 28;
            button6.Text = "Selling Of Tickets";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // e1SellTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "e1SellTickets";
            Text = "e1SellTickets";
            Load += e1SellTickets_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button1;
        private Label label2;
        private Button button6;
    }
}