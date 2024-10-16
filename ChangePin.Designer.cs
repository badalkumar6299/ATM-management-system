namespace ATM_Managment_System
{
    partial class ChangePin
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
            label2 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            Pin2 = new TextBox();
            Pin1 = new TextBox();
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
            panel1.Size = new Size(660, 57);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(496, 0);
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
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 14.8F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(120, 225);
            label2.Name = "label2";
            label2.Size = new Size(179, 26);
            label2.TabIndex = 48;
            label2.Text = "CONFIRM PIN:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Mongolian Baiti", 14.8F);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(120, 152);
            label12.Name = "label12";
            label12.Size = new Size(122, 26);
            label12.TabIndex = 47;
            label12.Text = "NEW PIN:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 10);
            panel2.TabIndex = 52;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(305, 291);
            button1.Name = "button1";
            button1.Size = new Size(130, 35);
            button1.TabIndex = 55;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pin2
            // 
            Pin2.Font = new Font("Mongolian Baiti", 13.8F);
            Pin2.Location = new Point(305, 217);
            Pin2.Name = "Pin2";
            Pin2.Size = new Size(196, 34);
            Pin2.TabIndex = 54;
            // 
            // Pin1
            // 
            Pin1.Font = new Font("Mongolian Baiti", 13.8F);
            Pin1.Location = new Point(305, 144);
            Pin1.Name = "Pin1";
            Pin1.Size = new Size(196, 34);
            Pin1.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(326, 329);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 56;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(660, 408);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(Pin2);
            Controls.Add(Pin1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label12;
        private Panel panel2;
        private Button button1;
        private TextBox Pin2;
        private TextBox Pin1;
        private Label label5;
        private Label label8;
    }
}