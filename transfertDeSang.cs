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
    public partial class transfertDeSang : Form
    {
        public transfertDeSang()
        {
            InitializeComponent();
            fillpatientCb();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void fillpatientCb()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(int));
            dt.Load(rdr);
            PatientIdCb.ValueMember = "PNum";
            PatientIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetData()
        {
            Con.Open();
            string query = "select * from PatientTbl where PNum = '" + PatientIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PName"].ToString();
                BloodGroup.Text = dr["PBGroup"].ToString();

            }
            Con.Close();
        }
        int stock = 0;
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
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();
        }
        private void transfertDeSang_Load(object sender, EventArgs e)
        {

        }
        /* int oldstock;
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
         }*/
        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BloodGroup.Text);
            if (stock > 0)
            {
                TransferBtn.Visible = true;
                AvailableLbl.Text = "Valable en stock";
                AvailableLbl.Visible = true;
            }
            else
            {
                AvailableLbl.Text = "Hors Stock";
                AvailableLbl.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            patient Pat = new patient();
            Pat.Show();
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
            stockDuSang BStock = new stockDuSang();
            BStock.Show();
            this.Hide();
        }
        private void reset()
        {
            PatNameTb.Text = "";
            //PatientIdCb.SelectedIndex = -1;
            BloodGroup.Text = "";
            AvailableLbl.Visible = false;
            TransferBtn.Visible = false;
        }
        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                String query = "update BloodTbl set BStock = " + newstock + " where BGroup = '" + BloodGroup.Text + "';";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Patient modifié avec succès");
                Con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "")
            {
                MessageBox.Show("Informations Manquantes");
            }
            else
            {
                try
                {
                    String query = "insert into TransferTbl values ('" + PatNameTb.Text + "','" + BloodGroup.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfert effectué avec succès");


                    Con.Close();
                    GetStock(BloodGroup.Text);
                    updateStock();
                    reset();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
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

        private void label12_Click(object sender, EventArgs e)
        {
            donnerSang donner = new donnerSang();
            donner.Show();
            this.Hide();
        }
    }
}
