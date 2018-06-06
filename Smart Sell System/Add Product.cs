using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Sell_System
{
    public partial class Add_Product : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        private SqlDataAdapter sd;
        private object dt;
        private SqlCommandBuilder sc;
        private string ms;

        public Add_Product()
        {
            InitializeComponent();
            getDepartments();

        }

        private void Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Enter The Product Name Code", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Enter The Product Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBox3.Text == string.Empty)
                {
                    MessageBox.Show("Enter The Product Name Price", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBox4.Text == string.Empty)
                {
                    MessageBox.Show("Enter The Product Name Quantity", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (comboBox1.Text == string.Empty)
                {
                    MessageBox.Show("Enter The Product Name Category", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlDataAdapter sda2 = new SqlDataAdapter(@"INSERT INTO Product(ProductCode,ProductName,PurchasePrice,Quantity,Category) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda2.Fill(dt);

                    MessageBox.Show("Successfully New Product");
                }


                

            }
            catch (Exception )
            {
                MessageBox.Show("Something wrong or you entered a Product that is already registered !");
            }
        }
         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        ///CODE OF COMBO
        ///
        private void getDepartments()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Select Name from Department", con);
            try
            {
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["Name"]);

                }
                dr.Close();
                dr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
