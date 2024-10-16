namespace ATM_Managment_System
{
    partial class HOME
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            AccNum = new Label();
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
            panel1.Size = new Size(583, 63);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(516, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 31);
            label8.TabIndex = 63;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 19);
            label1.Name = "label1";
            label1.Size = new Size(388, 31);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(74, 94);
            button1.Name = "button1";
            button1.Size = new Size(144, 35);
            button1.TabIndex = 8;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(323, 94);
            button2.Name = "button2";
            button2.Size = new Size(145, 35);
            button2.TabIndex = 9;
            button2.Text = "WITHDRAW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(74, 183);
            button3.Name = "button3";
            button3.Size = new Size(144, 35);
            button3.TabIndex = 10;
            button3.Text = "FAST CASH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(323, 183);
            button4.Name = "button4";
            button4.Size = new Size(145, 35);
            button4.TabIndex = 11;
            button4.Text = "MINI STATEMENT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 64);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(74, 267);
            button5.Name = "button5";
            button5.Size = new Size(144, 35);
            button5.TabIndex = 12;
            button5.Text = "CHANGE PIN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 0, 64);
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(323, 267);
            button6.Name = "button6";
            button6.Size = new Size(145, 35);
            button6.TabIndex = 13;
            button6.Text = "BALANCE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 11);
            panel2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(215, 334);
            label5.Name = "label5";
            label5.Size = new Size(110, 24);
            label5.TabIndex = 15;
            label5.Text = "LOGOUT";
            label5.Click += label5_Click;
            // 
            // AccNum
            // 
            AccNum.AutoSize = true;
            AccNum.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNum.ForeColor = SystemColors.ActiveCaptionText;
            AccNum.Location = new Point(184, 66);
            AccNum.Name = "AccNum";
            AccNum.Size = new Size(171, 24);
            AccNum.TabIndex = 3;
            AccNum.Text = "Account Number";
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 424);
            Controls.Add(AccNum);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            Load += HOME_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private Label label5;
        private Label AccNum;
        private Label label8;
    }
}