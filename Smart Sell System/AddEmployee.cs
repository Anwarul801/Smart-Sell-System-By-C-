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
    public partial class AddEmployee : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        private readonly int yyyy;
        private int dd;
        private int MM;

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                SqlDataAdapter sda2 = new SqlDataAdapter(@"INSERT INTO Employee(FirstName,LastName,Address,PhoneNo,Merital,Religion,Dateof,Country,Possition,Department,Email,UserId,Password,JoinDate) VALUES('" + textBox16.Text + "','" + textBox13.Text + "','" + textBox1.Text + "','" + textBox14.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + textBox17.Text + "','" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "','" + textBox2.Text + "','" + textBox15.Text + "','" + textBox19.Text + "')", con);
                DataTable dt = new DataTable();
                sda2.Fill(dt);

                MessageBox.Show("Successfully New Department");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open opf = new Open();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
