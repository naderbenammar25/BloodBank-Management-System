namespace ProjetFrame
{
    partial class splashScreen
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            label1 = new Label();
            Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(301, 48);
            label1.Name = "label1";
            label1.Size = new Size(140, 34);
            label1.TabIndex = 0;
            label1.Text = "DonSang";
            label1.Click += label1_Click;
            // 
            // Myprogress
            // 
            Myprogress.BackColor = Color.Transparent;
            Myprogress.Controls.Add(pictureBox1);
            Myprogress.FillColor = Color.FromArgb(200, 213, 218, 223);
            Myprogress.FillThickness = 10;
            Myprogress.Font = new Font("Segoe UI", 12F);
            Myprogress.ForeColor = Color.White;
            Myprogress.Location = new Point(270, 106);
            Myprogress.Maximum = 30;
            Myprogress.Minimum = 0;
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressColor = Color.FromArgb(255, 128, 128);
            Myprogress.ProgressColor2 = Color.FromArgb(255, 128, 128);
            Myprogress.ProgressThickness = 10;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogress.Size = new Size(212, 212);
            Myprogress.TabIndex = 1;
            Myprogress.Text = "guna2CircleProgressBar1";
            Myprogress.ValueChanged += Myprogress_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(744, 2);
            label5.Name = "label5";
            label5.Size = new Size(32, 34);
            label5.TabIndex = 5;
            label5.Text = "X";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // splashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 386);
            Controls.Add(label5);
            Controls.Add(Myprogress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += splashScreen_Load;
            Myprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private PictureBox pictureBox1;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}
