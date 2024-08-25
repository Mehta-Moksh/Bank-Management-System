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
    public partial class CheckBal : Form
    {
        static string cnStr = (new clsConnection()).cnStr;
        static string QRY = string.Empty;
        public CheckBal()
        {
            InitializeComponent();
        }

        private void CheckBal_Load(object sender, EventArgs e)
        {
           
        }
        void TransMyData(string myQRY)
        {
            SqlConnection CON = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(myQRY, CON);
            CON.Open();
            cmd.ExecuteNonQuery();
            CON.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
           
       
string cid="";

QRY = "SELECT Customer_id,Name_NameofEntity FROM Customer_Detail WHERE Account_Number=" + txtacc.Text;
SqlConnection CON = new SqlConnection(cnStr);
SqlCommand cmd = new SqlCommand(QRY,CON);

CON.Open();
SqlDataReader dr = cmd.ExecuteReader();
if(dr.Read())
{
	cid=dr["Customer_id"].ToString();
    lblcustname.Text = dr["Name_NameofEntity"].ToString();
}
else{
	MessageBox.Show(" Incorrect Account Number !");
}
dr.Close();
CON.Close();

QRY="SELECT Transaction_Amt FROM tbl_Transaction WHERE Customer_id="+cid;

SqlCommand CMD = new SqlCommand(QRY,CON);
SqlDataAdapter da = new SqlDataAdapter(CMD);
DataTable dt = new DataTable();
da.Fill(dt);
dgv_checkbal.DataSource=dt;

        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
