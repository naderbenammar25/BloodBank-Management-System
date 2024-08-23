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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void reset()
        {
            EmpNameTb.Text = "";
            EmpPassTb.Text = "";
            key = 0;
        }

        private void populate()
        {
            Con.Open();
            String Query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Informations Manquantes");
            }
            else
            {
                try
                {
                    String query = "insert into EmployeeTbl values ('" + EmpNameTb.Text + "','" + EmpPassTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employé enregistré avec succès");
                    Con.Close();
                    reset();
                    populate();


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPassTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();


            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Veuillez selectionner l'employé à supprimer");

            }
            else
            {
                try
                {
                    String query = "Delete from EmployeeTbl where EmpNum = " + key + "; ";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employé supprimé avec succès");
                    Con.Close();
                    reset();
                    populate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Informations Manquantes");

            }
            else
            {
                try
                {
                    String query = "update EmployeeTbl set EmpId = '" + EmpNameTb.Text + "',EmpPass ='" + EmpPassTb.Text + "' where EmpNum = " + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employé modifié avec succès");
                    Con.Close();
                    reset();
                    populate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class Con
    {
    }
}
