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
    public partial class AddDepartment : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void deparmentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                
             SqlDataAdapter sda2 = new SqlDataAdapter(@"INSERT INTO Department(Name) VALUES('" + deparmentText.Text + "')", con);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                
                MessageBox.Show("Successfully New Department");

            }
            catch (Exception )
            {
                MessageBox.Show("Something wrong or you entered a Department that is already registered !");
            }

        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
