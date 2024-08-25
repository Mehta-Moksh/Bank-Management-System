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

namespace Bank
{
    public partial class Customer_List : Form
    {
        
        static string cnStr = (new clsConnection()).cnStr;
        static string QRY = string.Empty;
        
        
        
        public Customer_List()
        {
            InitializeComponent();

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void Customer_List_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnStr);
            SqlCommand CMD = new SqlCommand("select *FROM Customer_Detail", con);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcustlist.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dgvcustlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvcustlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
