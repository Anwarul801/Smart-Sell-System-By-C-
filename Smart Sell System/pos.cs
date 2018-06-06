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
    public partial class pos : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        SqlDataAdapter pda;
        SqlCommandBuilder sc;
        DataTable dt;
        public pos()
        {
            InitializeComponent();
            pda = new SqlDataAdapter(@"SELECT * FROM Product1", con);
            dt = new DataTable();
            pda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
        }
    }
}
