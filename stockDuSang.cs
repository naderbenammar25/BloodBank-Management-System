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
    public partial class stockDuSang : Form
    {
        public stockDuSang()
        {
            InitializeComponent();
            bloodStock();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void bloodStock()
        {
            Con.Open();
            String Query = "select * from BloodTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStockDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void stockDuSang_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            transfertDeSang BT = new transfertDeSang();
            BT.Show();
            this.Hide();
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
            patient pat = new patient();
            pat.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            voirPateint Vpat = new voirPateint();
            Vpat.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            donnerSang donner = new donnerSang();
            donner.Show();
            this.Hide();
        }

        private void BloodStockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
