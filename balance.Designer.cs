namespace ATM_Managment_System
{
    partial class balance
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
            label8 = new Label();
            label1 = new Label();
            label12 = new Label();
            label2 = new Label();
            Balance1 = new Label();
            AccNumber = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 57);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(562, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 31);
            label8.TabIndex = 62;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Mongolian Baiti", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(93, 135);
            label12.Name = "label12";
            label12.Size = new Size(203, 26);
            label12.TabIndex = 41;
            label12.Text = "Account number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(93, 215);
            label2.Name = "label2";
            label2.Size = new Size(171, 26);
            label2.TabIndex = 42;
            label2.Text = "Your Balance:";
            // 
            // Balance1
            // 
            Balance1.AutoSize = true;
            Balance1.Font = new Font("Mongolian Baiti", 14.8F);
            Balance1.ForeColor = Color.FromArgb(0, 0, 64);
            Balance1.Location = new Point(298, 215);
            Balance1.Name = "Balance1";
            Balance1.Size = new Size(140, 26);
            Balance1.TabIndex = 44;
            Balance1.Text = "BalanceinRs";
            // 
            // AccNumber
            // 
            AccNumber.AutoSize = true;
            AccNumber.Font = new Font("Mongolian Baiti", 14.8F);
            AccNumber.ForeColor = Color.FromArgb(0, 0, 64);
            AccNumber.Location = new Point(298, 135);
            AccNumber.Name = "AccNumber";
            AccNumber.Size = new Size(102, 26);
            AccNumber.TabIndex = 43;
            AccNumber.Text = "AccNum";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 10);
            panel2.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(237, 293);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 46;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // balance
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 327);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(Balance1);
            Controls.Add(AccNumber);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "balance";
            Load += balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label12;
        private Label label2;
        private Label Balance1;
        private Label AccNumber;
        private Panel panel2;
        private Label label5;
        private Label label8;
    }
}