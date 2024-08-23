namespace ProjetFrame
{
    partial class Employee
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            EmpPassTb = new Guna.UI2.WinForms.Guna2TextBox();
            EmpDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label17 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            button1 = new Button();
            label16 = new Label();
            label11 = new Label();
            EmpNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EmpPassTb
            // 
            EmpPassTb.CustomizableEdges = customizableEdges1;
            EmpPassTb.DefaultText = "";
            EmpPassTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmpPassTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmpPassTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmpPassTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmpPassTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpPassTb.Font = new Font("Segoe UI", 9F);
            EmpPassTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpPassTb.Location = new Point(895, 506);
            EmpPassTb.Margin = new Padding(3, 4, 3, 4);
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.PasswordChar = '\0';
            EmpPassTb.PlaceholderText = "";
            EmpPassTb.SelectedText = "";
            EmpPassTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EmpPassTb.Size = new Size(202, 34);
            EmpPassTb.TabIndex = 78;
            // 
            // EmpDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmpDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmpDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmpDGV.ColumnHeadersHeight = 25;
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmpDGV.DefaultCellStyle = dataGridViewCellStyle3;
            EmpDGV.GridColor = Color.MistyRose;
            EmpDGV.Location = new Point(409, 144);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersVisible = false;
            EmpDGV.RowHeadersWidth = 51;
            EmpDGV.Size = new Size(872, 314);
            EmpDGV.TabIndex = 77;
            EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmpDGV.ThemeStyle.BackColor = Color.White;
            EmpDGV.ThemeStyle.GridColor = Color.MistyRose;
            EmpDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 192, 192);
            EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmpDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmpDGV.ThemeStyle.HeaderStyle.Height = 25;
            EmpDGV.ThemeStyle.ReadOnly = false;
            EmpDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmpDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmpDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            EmpDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmpDGV.ThemeStyle.RowsStyle.Height = 29;
            EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(263, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1188, 61);
            panel2.TabIndex = 70;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(1144, 9);
            label6.Name = "label6";
            label6.Size = new Size(32, 34);
            label6.TabIndex = 81;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(548, 13);
            label1.Name = "label1";
            label1.Size = new Size(140, 34);
            label1.TabIndex = 1;
            label1.Text = "DonSang";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 655);
            panel1.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 612);
            label2.Name = "label2";
            label2.Size = new Size(197, 34);
            label2.TabIndex = 34;
            label2.Text = "Déconnexion";
            label2.Click += label2_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(15, 171);
            label17.Name = "label17";
            label17.Size = new Size(143, 34);
            label17.TabIndex = 33;
            label17.Text = "Employés";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(47, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 665);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(47, 677);
            label9.Name = "label9";
            label9.Size = new Size(188, 27);
            label9.TabIndex = 15;
            label9.Text = "Se Séconnecter";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(-1, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 63);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(269, 64);
            label10.Name = "label10";
            label10.Size = new Size(139, 34);
            label10.TabIndex = 71;
            label10.Text = "EMPLOYE";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(590, 579);
            button1.Name = "button1";
            button1.Size = new Size(162, 61);
            button1.TabIndex = 75;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(895, 478);
            label16.Name = "label16";
            label16.Size = new Size(142, 23);
            label16.TabIndex = 74;
            label16.Text = "Mot de passe";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(590, 478);
            label11.Name = "label11";
            label11.Size = new Size(57, 23);
            label11.TabIndex = 73;
            label11.Text = "Nom";
            // 
            // EmpNameTb
            // 
            EmpNameTb.CustomizableEdges = customizableEdges3;
            EmpNameTb.DefaultText = "";
            EmpNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmpNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmpNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmpNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmpNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpNameTb.Font = new Font("Segoe UI", 9F);
            EmpNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpNameTb.Location = new Point(590, 506);
            EmpNameTb.Margin = new Padding(3, 4, 3, 4);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.PasswordChar = '\0';
            EmpNameTb.PlaceholderText = "";
            EmpNameTb.SelectedText = "";
            EmpNameTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EmpNameTb.Size = new Size(202, 34);
            EmpNameTb.TabIndex = 72;
            EmpNameTb.TextChanged += EmpNameTb_TextChanged;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(758, 579);
            button2.Name = "button2";
            button2.Size = new Size(162, 61);
            button2.TabIndex = 79;
            button2.Text = "Editer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.ForeColor = Color.DarkRed;
            button3.Location = new Point(926, 579);
            button3.Name = "button3";
            button3.Size = new Size(162, 61);
            button3.TabIndex = 80;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1451, 655);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(EmpPassTb);
            Controls.Add(EmpDGV);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(EmpNameTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox EmpPassTb;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDGV;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label17;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private Button button1;
        private Label label16;
        private Label label11;
        private Guna.UI2.WinForms.Guna2TextBox EmpNameTb;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label6;
    }
}