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
using System.ComponentModel.DataAnnotations;
namespace ProjetFrame
{
    public partial class voirPateint : Form
    {
        public voirPateint()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void reset()
        {
            PNameTb.Text = "";
            PPhoneTb.Text = "";
            PAgeTb.Text = "";
            PAddressTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            key = 0;
        }
        private void populate()
        {
            Con.Open();
            String Query = "select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAddressTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Informations introuvales");

            }
            else
            {
                try
                {
                    String query = "update PatientTbl set PName = '" + PNameTb.Text + "',PAge ='" + PAgeTb.Text + "',PPhone='" + PPhoneTb.Text + "',PGender='" + PGenCb.SelectedItem.ToString() + "',PBGroup='" + PBGroupCb.SelectedItem.ToString() + "',PAdrress = '" + PAddressTb.Text + "' where PNum = " + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient modifié avec succès");
                    Con.Close();
                    reset();
                    populate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Veuillez selectionner un patient à supprimer");

            }
            else
            {
                try
                {
                    String query = "Delete from PatientTbl where PNum = " + key + "; ";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient supprimé avec succès");
                    Con.Close();
                    reset();
                    populate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        int key = 0;
        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PPhoneTb.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PGenCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PBGroupCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = PatientsDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (PNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void voirPateint_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            patient PAT = new patient();
            PAT.Show();
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

        private void label6_Click(object sender, EventArgs e)
        {
            stockDuSang sds = new stockDuSang();
            sds.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            transfertDeSang tfs = new transfertDeSang();
            tfs.Show();
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
