using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bank
{
    public partial class Transaction : Form
    {
        static string cnStr = (new clsConnection()).cnStr;
        static string QRY = string.Empty;
        SqlConnection CNN;
        SqlCommand CMD;


        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            cmbCashCheque.SelectedIndex = 0;
            cmbTypeOfAcc.SelectedIndex = 0;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
     

        private void Calculate_Currency(object sender, EventArgs e)
        {
            lbl_Rs_1.Text = (int.Parse(txt_1.Tag.ToString()) * int.Parse(txt_1.Text)).ToString();
            lbl_Rs_2.Text = (int.Parse(txt_2.Tag.ToString()) * int.Parse(txt_2.Text)).ToString();
            lbl_Rs_5.Text = (int.Parse(txt_5.Tag.ToString()) * int.Parse(txt_5.Text)).ToString();
            lbl_Rs_10.Text = (int.Parse(txt_10.Tag.ToString()) * int.Parse(txt_10.Text)).ToString();
            lbl_Rs_20.Text = (int.Parse(txt_20.Tag.ToString()) * int.Parse(txt_20.Text)).ToString();
            lbl_Rs_50.Text = (int.Parse(txt_50.Tag.ToString()) * int.Parse(txt_50.Text)).ToString();
            lbl_Rs_100.Text = (int.Parse(txt_100.Tag.ToString()) * int.Parse(txt_100.Text)).ToString();
            lbl_Rs_200.Text = (int.Parse(txt_200.Tag.ToString()) * int.Parse(txt_200.Text)).ToString();
            lbl_Rs_500.Text = (int.Parse(txt_500.Tag.ToString()) * int.Parse(txt_500.Text)).ToString();
            lbl_Rs_1000.Text = (int.Parse(txt_1000.Tag.ToString()) * int.Parse(txt_1000.Text)).ToString();
            lbl_Rs_2000.Text = (int.Parse(txt_2000.Tag.ToString()) * int.Parse(txt_2000.Text)).ToString();

                        
            lblTotalAmount.Text = (int.Parse(lbl_Rs_1.Text) + int.Parse(lbl_Rs_2.Text) + int.Parse(lbl_Rs_5.Text) + int.Parse(lbl_Rs_10.Text) + int.Parse(lbl_Rs_20.Text)
                                + (int.Parse(lbl_Rs_50.Text) + (int.Parse(lbl_Rs_100.Text) + (int.Parse(lbl_Rs_200.Text) + (int.Parse(lbl_Rs_500.Text)
                                + (int.Parse(lbl_Rs_1000.Text) + (int.Parse(lbl_Rs_2000.Text)))))))).ToString();
            
            
        }
        void TransMyData(string myQRY)
        {
            SqlConnection CON = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(myQRY, CON);
            CON.Open();
            cmd.ExecuteNonQuery();
            CON.Close();
        }       

        private void cmbCashCheque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCashCheque.SelectedIndex == 2)
            {
                txtchqNo.Enabled = true;

                rb_credit.Enabled = false;
                rb_debit.Enabled = false;
                rb_debit.Checked = true;
            }
            else
            {
                txtchqNo.Enabled = false;

                rb_credit.Enabled = true;
                rb_debit.Enabled = true;
                rb_credit.Checked = false;
                rb_debit.Checked = false;
            }            
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblCustID.Text = "0";
            QRY = "SELECT Customer_id, Name_NameofEntity, Type_of_Account FROM Customer_Detail WHERE Account_Number = '" + txtAccNo.Text.Trim() + "'";
            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            if (DR.Read())
            {
                lblCustID.Text = DR["Customer_id"].ToString();
                lblCustName.Text = DR["Name_NameofEntity"].ToString();
                //cmbTypeOfAcc.SelectedItem = DR["Type_of_Account"].ToString();
                cmbTypeOfAcc.SelectedIndex = ReturnTypeOfAccIndex(DR["Type_of_Account"].ToString());
            }
            DR.Close();
            CNN.Close();
            if (lblCustID.Text == "0")
            {
                lblCustName.Text = "No Account Found";
                cmbTypeOfAcc.SelectedIndex = 0;
                btnSubmit.Enabled = false;
            }
            else
            {                
                btnSubmit.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int TransID = 0;            
            QRY = "SELECT  MAX(Transaction_id) FROM tbl_Transaction";
            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            if (DR.Read())
            {
                try
                {
                    TransID = int.Parse(DR.GetValue(0).ToString());
                }
                catch { }
            }
            DR.Close();
            CMD.Dispose();            
            TransID++;



        
            DateTime Date = DateTime.Parse(dtpTransDate.Text);
            string date1 = Date.ToString("yyyy-MM-dd");

            QRY = "INSERT INTO tbl_Transaction VALUES(";
            QRY += ""+ TransID.ToString() +", ";
            QRY += "'" + date1 + "', ";
            QRY += "" + lblCustID.Text + ", ";
            if (rb_credit.Checked) QRY += "'False', ";
            else QRY += "'True', ";
            QRY += "" + lblTotalAmount.Text + "";
            QRY += ")";
            CMD = new SqlCommand(QRY, CNN);
            CMD.ExecuteNonQuery();
            CMD.Dispose();


            
                if (txt_1.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += ""+ TransID.ToString() +", ";
                    QRY += "" + txt_1.Tag.ToString() + ", ";
                    QRY += "" + txt_1.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_1.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }

                if (txt_2.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_2.Tag.ToString() + ", ";
                    QRY += "" + txt_2.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_2.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_5.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_5.Tag.ToString() + ", ";
                    QRY += "" + txt_5.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_5.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }

                if (txt_10.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_10.Tag.ToString() + ", ";
                    QRY += "" + txt_10.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_10.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_20.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_20.Tag.ToString() + ", ";
                    QRY += "" + txt_20.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_20.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_50.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_50.Tag.ToString() + ", ";
                    QRY += "" + txt_50.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_50.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_100.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_100.Tag.ToString() + ", ";
                    QRY += "" + txt_100.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_100.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_200.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_200.Tag.ToString() + ", ";
                    QRY += "" + txt_200.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_200.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_500.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_500.Tag.ToString() + ", ";
                    QRY += "" + txt_500.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_500.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_1000.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_1000.Tag.ToString() + ", ";
                    QRY += "" + txt_1000.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_1000.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }
                if (txt_2000.Text != "0")
                {
                    QRY = "INSERT INTO tbl_CashMaster ";
                    QRY += "SELECT MAX(Cash_Master_id) + 1, ";
                    QRY += "" + TransID.ToString() + ", ";
                    QRY += "" + txt_2000.Tag.ToString() + ", ";
                    QRY += "" + txt_2000.Text.ToString() + ", ";
                    QRY += "" + lbl_Rs_2000.Text.ToString() + " ";
                    QRY += "FROM tbl_CashMaster";
                    CMD = new SqlCommand(QRY, CNN);
                    CMD.ExecuteNonQuery();
                    CMD.Dispose();
                }

            CNN.Close();            
            MessageBox.Show("Transaction Successfully Completed","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void lblCustID_Click(object sender, EventArgs e)
        {

        }

        private void dtpTransDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTypeOfAcc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtAccNo.Text = "";
            lblCustName.Text = "";
            cmbCashCheque.SelectedIndex = 0;
            cmbTypeOfAcc.SelectedIndex = 0;
            txt_1.Text = "";
            txt_2.Text = "";
            txt_5.Text = "";
            txt_10.Text = "";
            txt_20.Text = "";
            txt_50.Text = "";
            txt_100.Text = "";
            txt_200.Text = "";
            txt_500.Text = "";
            txt_1000.Text = "";
            txt_2000.Text = "";
            lbl_Rs_1.Text = "";
            lbl_Rs_2.Text = "";
            lbl_Rs_5.Text = "";
            lbl_Rs_10.Text = "";
            lbl_Rs_20.Text = "";
            lbl_Rs_50.Text = "";
            lbl_Rs_100.Text = "";
            lbl_Rs_200.Text = "";
            lbl_Rs_500.Text = "";
            lbl_Rs_1000.Text = "";
            lbl_Rs_2000.Text = "";
            lblTotalAmount.Text = ""; 
        }
    }
}
