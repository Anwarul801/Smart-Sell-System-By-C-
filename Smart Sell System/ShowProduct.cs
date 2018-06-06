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
    public partial class ShowProduct : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        SqlDataAdapter pda;
        SqlCommandBuilder sc;
        DataTable dt;
        public ShowProduct()
        {
            InitializeComponent();
            pda = new SqlDataAdapter(@"SELECT * FROM Product", con);
            dt = new DataTable();
            pda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                sc = new SqlCommandBuilder(pda);
                pda.Update(dt);
                MessageBox.Show("Updated");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ProductName LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = DV;
        }
    }
}
