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
    public partial class systemsell : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        SqlDataAdapter pda;
        SqlCommandBuilder sc;
        DataTable dt;
        
        
        public systemsell()
        {
            InitializeComponent();
        }

        private void systemsell_Load(object sender, EventArgs e)
        {

        }

        private void Refesh_Click(object sender, EventArgs e)
        {
            pda = new SqlDataAdapter(@"SELECT * FROM Product", con);
            dt = new DataTable();
            pda.Fill(dt);
            //dataGridView1.DataSource = dt;
            dataGridView1.Rows.Clear();



            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["ProductName"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["PurchasePrice"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Quantity"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Category"].ToString();

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void Addtosell_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Clear();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    dataGridView2.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    DataView DV = new DataView(dt);
        //    DV.RowFilter = string.Format("ProductName LIKE '%{0}%'", textBox1.Text);
        //    dataGridView1.DataSource = DV;





     
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
          


        //}

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter pda = new SqlDataAdapter(@"SELECT * FROM Product WHERE ProductName LIKE '%" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            pda.Fill(dt);

            dataGridView1.Rows.Clear();

            //DataView DV = new DataView(dt);
            //DV.RowFilter = string.Format("ProductName LIKE '%{0}%'", textBox1.Text);
            //dataGridView1.DataSource = DV;




            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["ProductName"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["PurchasePrice"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Quantity"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Category"].ToString();

            }
        }
    }
}
