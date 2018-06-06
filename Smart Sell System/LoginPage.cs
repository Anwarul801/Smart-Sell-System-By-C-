using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Sell_System
{
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        public LoginPage()
        {
            InitializeComponent();
            passText.PasswordChar = '*';
            userText.Text = "Admin";
            passText.Text = "Admin";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username ='" + userText.Text + "' and password= '" + passText.Text + "' and STATUS = '1' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("successfully login");
                this.Hide();
                
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
               


            }
            else
             {
                MessageBox.Show("Incorrect Username or Password !!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

