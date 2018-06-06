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
    public partial class View_Department : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        SqlDataAdapter sd;
        SqlCommandBuilder sc;
        DataTable dt;


        public View_Department()
        {
            InitializeComponent();
            sd = new SqlDataAdapter(@"SELECT * FROM Department", con);
            dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sc = new SqlCommandBuilder(sd);
                sd.Update(dt);
                MessageBox.Show("Updated");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void View_Department_Load(object sender, EventArgs e)
        {

        }
    }
}
