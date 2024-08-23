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
    public partial class donnerSang : Form
    {
        public donnerSang()
        {
            InitializeComponent();
            populate();
            bloodStock();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void populate()
        {
            Con.Open();
            String Query = "select * from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
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
        private void donnerSang_Load(object sender, EventArgs e)
        {

        }
        int oldstock;
        private void GetStock(String Bgroup)
        {
            Con.Open();
            string query = "select * from BloodTbl where BGroup = '" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();
        }
        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DonorDGV.SelectedRows[0].Cells[1].Value.ToString();
            BGroupTb.Text = DonorDGV.SelectedRows[0].Cells[6].Value.ToString();
            GetStock(BGroupTb.Text);
        }
        private void reset()
        {
            DNameTb.Text = "";
            BGroupTb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un donneur");

            }
            else
            {
                try
                {
                    int stock = oldstock + 1;
                    String query = "update BloodTbl set BStock = " + stock + " where BGroup = '" + BGroupTb.Text + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Don effectué avec succès");
                    Con.Close();
                    reset();
                    bloodStock();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void label14_Click(object sender, EventArgs e)
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
            patient pat = new patient();
            pat.Show();
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
            stockDuSang st = new stockDuSang();
            st.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            transfertDeSang ts = new transfertDeSang();
            ts.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
