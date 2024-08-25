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
    
    public partial class AccountDetails : Form
    {
        static string cnStr = (new clsConnection()).cnStr;
        static string QRY = string.Empty;
        public AccountDetails()
        {
            InitializeComponent();
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            typecb.SelectedIndex = 0;
        }
        void TransMyData(string myQRY)
        {
            SqlConnection CON = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(myQRY, CON);
            CON.Open();
            cmd.ExecuteNonQuery();
            CON.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }
        int ReturnTypeOfAccIndex(string AccType)
        {
            int i = 0;
            if (AccType == "Savings") i = 1;
            else if (AccType == "Current") i = 2;
            else if (AccType == "Salary") i = 3;
            else if (AccType == "Jan Dhan") i = 4;
            else if (AccType == "Mahila Mitra") i = 5;
            else if (AccType == "Noor") i = 6;
            else i = 0;
            return i;
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            QRY = "SELECT * FROM Customer_Detail WHERE Account_Number=" + accnotxt.Text;
            SqlConnection CON = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(QRY, CON);
            CON.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.Read())
            {
                typecb.SelectedIndex = ReturnTypeOfAccIndex(DR["Type_of_Account"].ToString());
            }
            DR.Close();
            CON.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_accdetail.DataSource = dt;
            CON.Open();
            if ( typecb.Text == "0")
            {
                
                typecb.SelectedIndex = 0;
                MessageBox.Show("Incorrect Account Number");
                searchbtn.Enabled = false;
            }
            else
            {
                searchbtn.Enabled = true;
            }
        }

        private void typecb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
