namespace ATM_Managment_System
{
    partial class front
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(front));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Myprogress = new ProgressBar();
            Percentage = new Label();
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 9);
            label1.Name = "label1";
            label1.Size = new Size(536, 40);
            label1.TabIndex = 0;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Myprogress
            // 
            Myprogress.Dock = DockStyle.Bottom;
            Myprogress.Location = new Point(0, 252);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(800, 18);
            Myprogress.TabIndex = 2;
            Myprogress.Click += Myprogress_Click;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Mongolian Baiti", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Percentage.Location = new Point(362, 209);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(48, 40);
            Percentage.TabIndex = 3;
            Percentage.Text = "%";
            Percentage.Click += label2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(765, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 31);
            label8.TabIndex = 62;
            label8.Text = "X";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // front
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 270);
            Controls.Add(label8);
            Controls.Add(Percentage);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "front";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += front_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar Myprogress;
        private Label Percentage;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}
