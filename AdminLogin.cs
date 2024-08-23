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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminPassTb.Text == "")
            {
                MessageBox.Show("Veuillez saisir le mot de passe");
            }
            else if (AdminPassTb.Text == "admin")
            {
                Employee emp = new Employee();
                emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrecte");
                AdminPassTb.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (AdminPassTb.Text == "")
            {
                MessageBox.Show("Veuillez saisir le mot de passe");
            }
            else if (AdminPassTb.Text == "admin")
            {
                Employee emp = new Employee();
                emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrecte");
                AdminPassTb.Text = "";
            }
        }

        private void AdminPassTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
