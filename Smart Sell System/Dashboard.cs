using Csharp_Project;
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
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection(Connection.con);
        SqlDataAdapter pda;
        SqlCommandBuilder sc;
        DataTable dt;
        private object sidemenu;
        private object panel1Animator;
        private object button4Animator;
        private object logoAnimator;

        public Dashboard()
        {
            InitializeComponent();
           
            pda = new SqlDataAdapter(@"SELECT COUNT(*) FROM Product1", con);
           
            dt = new DataTable();
            pda.Fill(dt);
            dataGridView1.DataSource = dt;
            panel2.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product AddProduct = new Add_Product();
            AddProduct.Show();
        }

        private void deparToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment adddepartment = new AddDepartment();
            adddepartment.Show();
        }

        private void editDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Department viewdepartment = new View_Department();
            viewdepartment.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCustomar addCustomar = new AddCustomar();
            addCustomar.Show();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProduct showProduct = new ShowProduct();
            showProduct.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddType addtype = new AddType();
            addtype.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewType viewtype = new viewType();
            viewtype.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            systemsell Systemsell = new systemsell();
            Systemsell.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pos poss = new pos();
            poss.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rules_Click(object sender, EventArgs e)
        {
            userRules userrules = new userRules();
            userrules.Show();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Management_Click(object sender, EventArgs e)
        {
            management Management = new management();
            Management.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            
        }
    }
}
