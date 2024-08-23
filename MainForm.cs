using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFrame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donneur D = new Donneur();
            D.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            voirDonneur VD = new voirDonneur();
            VD.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            patient P = new patient();
            P.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            voirPateint VP = new voirPateint();
            VP.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            stockDuSang sds = new stockDuSang();
            sds.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            transfertDeSang tds = new transfertDeSang();
            tds.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            donnerSang donner = new donnerSang();
            donner.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
