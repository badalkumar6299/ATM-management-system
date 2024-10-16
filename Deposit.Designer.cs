namespace ATM_Managment_System
{
    partial class Deposit
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
            DepoAmt = new TextBox();
            label12 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label5 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DepoAmt
            // 
            DepoAmt.Font = new Font("Mongolian Baiti", 13.8F);
            DepoAmt.Location = new Point(233, 141);
            DepoAmt.Name = "DepoAmt";
            DepoAmt.Size = new Size(196, 34);
            DepoAmt.TabIndex = 55;
            DepoAmt.TextChanged += DepoAmt_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Mongolian Baiti", 14.8F);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(77, 149);
            label12.Name = "label12";
            label12.Size = new Size(128, 26);
            label12.TabIndex = 54;
            label12.Text = "AMOUNT:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 57);
            panel1.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(498, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 31);
            label8.TabIndex = 61;
            label8.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 10);
            panel2.TabIndex = 57;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(233, 222);
            button1.Name = "button1";
            button1.Size = new Size(130, 35);
            button1.TabIndex = 58;
            button1.Text = "deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(262, 290);
            label5.Name = "label5";
            label5.Size = new Size(61, 24);
            label5.TabIndex = 59;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(211, 69);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 60;
            label2.Text = "DEPOSIT";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(532, 327);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DepoAmt);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DepoAmt;
        private Label label12;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Label label5;
        private Label label2;
        private Label label8;
    }
}