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
    public partial class Records : Form
    {
        static string cnStr = (new clsConnection()).cnStr;
        static string QRY = string.Empty;
        SqlConnection CNN;
        SqlCommand CMD;
        static string id = "";

        public Records()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Records_Load(object sender, EventArgs e)
        {
            string QRY = "SELECT T.Transaction_id, CONVERT(varchar,T.Transaction_Date,105) as Transaction_Date, IIF(T.Is_Debit=0,'Credit','Debit') as Is_Debit,T.Transaction_Amt ";
            QRY += "FROM tbl_Transaction T ";
            QRY += "ORDER BY T.Transaction_Date DESC, T.Transaction_id";

            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataTable DS = new DataTable();
            DA.Fill(DS);
            dgv_records.DataSource = DS;
            //TransMyData(QRY);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void TransMyData(string myQRY)
        {
            SqlConnection CON = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(myQRY, CON);
            CON.Open();
            cmd.ExecuteNonQuery();
            CON.Close();
        }

        void lblData(string Qry,Label l)
        {
            SqlConnection CON = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(Qry, CON);
            CON.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                l.Text = dr["Currency_count"].ToString();
            }
            dr.Close();
            CON.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_records_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Rs_1.Text = "0";
            lbl_Rs_2.Text = "0";
            lbl_Rs_5.Text = "0";
            lbl_Rs_10.Text = "0";
            lbl_Rs_20.Text = "0";
            lbl_Rs_50.Text = "0";
            lbl_Rs_100.Text = "0";
            lbl_Rs_200.Text = "0";
            lbl_Rs_500.Text = "0";
            lbl_Rs_1000.Text = "0";
            lbl_Rs_2000.Text = "0";

           id= dgv_records.Rows[e.RowIndex].Cells[0].Value.ToString();
           if (id != "")
           {
               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id="+id+" AND Currency_item=1";
               lblData(QRY, lbl_Rs_1);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=2";
               lblData(QRY, lbl_Rs_2);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=5";
               lblData(QRY, lbl_Rs_5);


               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=10";
               lblData(QRY, lbl_Rs_10);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=20";
               lblData(QRY, lbl_Rs_20);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=50";
               lblData(QRY, lbl_Rs_50);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=100";
               lblData(QRY, lbl_Rs_100);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=200";
               lblData(QRY, lbl_Rs_200);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=500";
               lblData(QRY, lbl_Rs_500);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=1000";
               lblData(QRY, lbl_Rs_1000);

               QRY = "SELECT Currency_count FROM tbl_CashMaster WHERE Transaction_id=" + id + " AND Currency_item=2000";
               lblData(QRY, lbl_Rs_2000);
          }
        }

        private void lbl_Rs_50_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Rs_100_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Rs_1000_Click(object sender, EventArgs e)
        {

        }

    }
}
