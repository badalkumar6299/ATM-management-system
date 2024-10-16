namespace ATM_Managment_System
{
    partial class withdraw
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
            panel2 = new Panel();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            wdamt = new TextBox();
            label12 = new Label();
            balance = new Label();
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
            panel1.Size = new Size(674, 57);
            panel1.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(496, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 31);
            label8.TabIndex = 4;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 10);
            panel2.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(191, 76);
            label2.Name = "label2";
            label2.Size = new Size(147, 24);
            label2.TabIndex = 65;
            label2.Text = "WITHDRAW";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(301, 321);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 64;
            label5.Text = "BACK";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(272, 274);
            button1.Name = "button1";
            button1.Size = new Size(130, 35);
            button1.TabIndex = 63;
            button1.Text = "withdraw";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // wdamt
            // 
            wdamt.Font = new Font("Mongolian Baiti", 13.8F);
            wdamt.Location = new Point(286, 225);
            wdamt.Name = "wdamt";
            wdamt.Size = new Size(196, 34);
            wdamt.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Mongolian Baiti", 14.8F);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(137, 226);
            label12.Name = "label12";
            label12.Size = new Size(128, 26);
            label12.TabIndex = 61;
            label12.Text = "AMOUNT:";
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balance.ForeColor = Color.Black;
            balance.Location = new Point(191, 114);
            balance.Name = "balance";
            balance.Size = new Size(273, 24);
            balance.TabIndex = 66;
            balance.Text = "AVAILABLE BALANCE";
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(674, 443);
            Controls.Add(balance);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(wdamt);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "withdraw";
            Load += withdraw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label5;
        private Button button1;
        private TextBox wdamt;
        private Label label12;
        private Label balance;
        private Label label8;
    }
}