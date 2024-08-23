namespace ProjetFrame
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            EmpIdTb = new TextBox();
            EmpPassTb = new TextBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(478, 12);
            label1.Name = "label1";
            label1.Size = new Size(114, 27);
            label1.TabIndex = 1;
            label1.Text = "DonSang";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(737, 389);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(441, 128);
            label2.Name = "label2";
            label2.Size = new Size(172, 23);
            label2.TabIndex = 3;
            label2.Text = "Nom D'utilisateur";
            // 
            // EmpIdTb
            // 
            EmpIdTb.Location = new Point(441, 154);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(195, 27);
            EmpIdTb.TabIndex = 4;
            // 
            // EmpPassTb
            // 
            EmpPassTb.Location = new Point(441, 237);
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.PasswordChar = '●';
            EmpPassTb.Size = new Size(195, 27);
            EmpPassTb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(441, 195);
            label3.Name = "label3";
            label3.Size = new Size(142, 23);
            label3.TabIndex = 5;
            label3.Text = "Mot De Passe";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(506, 291);
            button1.Name = "button1";
            button1.Size = new Size(68, 41);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 452);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(262, 12);
            label4.Name = "label4";
            label4.Size = new Size(83, 27);
            label4.TabIndex = 9;
            label4.Text = "LOGIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(262, 420);
            label5.Name = "label5";
            label5.Size = new Size(307, 21);
            label5.TabIndex = 10;
            label5.Text = "Continuer en tant qu'administrateur";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(767, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 34);
            label6.TabIndex = 11;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(EmpPassTb);
            Controls.Add(label3);
            Controls.Add(EmpIdTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox EmpIdTb;
        private TextBox EmpPassTb;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}