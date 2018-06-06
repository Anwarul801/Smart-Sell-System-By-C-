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
    public partial class AddType : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        

        public AddType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlDataAdapter sda2 = new SqlDataAdapter(@"INSERT INTO CustomerType(CType,Percentance) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')", con);
                DataTable dt = new DataTable();
                sda2.Fill(dt);

                MessageBox.Show("Successfully New Department");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        
    }
    }
}
