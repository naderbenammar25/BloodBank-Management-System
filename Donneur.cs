using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjetFrame
{
    public partial class Donneur : Form
    {
        public Donneur()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void reset()
        {
            DNameTb.Text = "";
            DPhoneTb.Text = "";
            DAgeTb.Text = "";
            DAddressTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DBGroupCb.SelectedIndex = -1;

        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAddressTb.Text == "" || DAgeTb.Text == "" || DGenCb.SelectedIndex == -1 || DBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Informations Manquantes");
            }
            else
            {
                try
                {
                    String query = "insert into DonorTbl values ('" + DNameTb.Text + "'," + DAgeTb.Text + ",'" + DGenCb.SelectedItem.ToString() + "','" + DPhoneTb.Text + "','" + DAddressTb.Text + "','" + DBGroupCb.SelectedItem.ToString() + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donneur enregistré avec succès");
                    reset();
                    Con.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Donneur_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            voirDonneur VD = new voirDonneur();
            VD.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            patient Pt = new patient();
            Pt.Show();
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
            Application.Exit();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            donnerSang donner = new donnerSang();
            donner.Show();
            this.Hide();
        }
    }
}
