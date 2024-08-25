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
    public partial class NewAccount : Form
    {
        
        static string cnStr = (new clsConnection()).cnStr;
        static string QRY = string.Empty;
        public NewAccount()
        {
            InitializeComponent();
            
        }
        DataTable DT = new DataTable();
        int indexRow;
        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maillbl_Click(object sender, EventArgs e)
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

        private void submitbtn_Click(object sender, EventArgs e)
        {
            QRY = "INSERT INTO Customer_Detail ";
            QRY += "SELECT MAX(Customer_id)+1, ";
            QRY += "'" + cmb_typeofacc.Text.Trim() + "', ";
            QRY += "'" + txt_name.Text + "', ";
            QRY += "'" + txt_add.Text + "', ";
            QRY += "" + txt_mob.Text + ",";
            QRY += "'" + txt_email.Text + "', ";
            QRY += "'" + dob.Text + "', ";
            QRY += rb_female.Checked ? "'Female', " : "'Male', ";
            QRY += rb_unmarried.Checked ? "'Unmarried', " : "'Married', ";
            QRY += "'" + cmb_country.Text.Trim() + "', ";
            QRY += "'" + cmb_state.Text.Trim() + "', ";
            QRY += "'" + cmb_city.Text.Trim() + "', ";
            QRY += "'" + cmb_monthlyincome.Text.Trim() + "', ";
            QRY += "'" + cmb_occupation.Text.Trim() + "', ";
            QRY += "'" + cmb_kyc.Text.Trim() + "', ";
            QRY += "'" + txt_accno.Text + "' ";
            QRY += "FROM Customer_Detail";
            TransMyData(QRY);
            MessageBox.Show("Customer Added Successfully...", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        

        private void genderrb1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kyclbl_Click(object sender, EventArgs e)
        {

        }

        private void Namelbl_Click(object sender, EventArgs e)
        {

        }

        private void genderlbl_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow DGVR = dgv_custlist.Rows[indexRow];
            string t = DGVR.Cells[1].Value.ToString();
            cmb_typeofacc.Text = t;
            DGVR.Cells[2].Value = txt_name.Text;
            DGVR.Cells[3].Value = txt_add.Text;
            DGVR.Cells[4].Value = txt_mob.Text;
            DGVR.Cells[5].Value = txt_email.Text;
            string s = DGVR.Cells[6].Value.ToString();
            if (s == "MALE")
            {
                rb_male.Checked = true;
            }
            else
                rb_male.Checked = true;
            string m = DGVR.Cells[8].Value.ToString();
            if (m == "married")
            {
                rb_married.Checked = true;
            }
            else
                rb_married.Checked = true;
            //string c = DGVR.Cells[9].Value.ToString();
            //cmb_country.SelectedItem = c;
            //string st = DGVR.Cells[10].Value.ToString();
            //cmb_state.SelectedItem = st;
            //string ci = DGVR.Cells[11].Value.ToString();
            //cmb_city.SelectedItem = ci;
            //string mi = DGVR.Cells[12].Value.ToString();
            //cmb_monthlyincome.SelectedItem = mi;
            //string oc = DGVR.Cells[13].Value.ToString();
            //cmb_occupation.SelectedItem = oc;
            //string kyc = DGVR.Cells[14].Value.ToString();
            //cmb_kyc.SelectedItem = kyc;
            //txt_accno.Text = DGVR.Cells[15].Value.ToString();

            QRY = "UPDATE Customer_Detail SET ";
            QRY += " Type_of_Account = '" + cmb_typeofacc.SelectedItem
 + "',";
            QRY += " Name_NameofEntity = '" + txt_name.Text + "',";
            QRY += " Address = '" + txt_add.Text + "',";
            QRY += " Mobile_No = '" + txt_mob.Text + "',";
            QRY += " Email = '" + txt_email.Text + "',";
            QRY += " Country = '" + cmb_country.SelectedItem + "',";
            QRY += " State = '" + cmb_state.SelectedItem + "',";
            QRY += " City = '" + cmb_city.SelectedItem + "',";
            QRY += " Monthly_Income = '" + cmb_monthlyincome.SelectedItem + "',";
            QRY += " Occupation = '" + cmb_occupation.SelectedItem + "',";
            QRY += " KYC = '" + cmb_kyc.SelectedItem + "'";
            QRY += " WHERE Account_Number = '" + txt_accno.Text
 + "'";
            
        //    MessageBox.Show(QRY);
            TransMyData(QRY);
            MessageBox.Show("Customer Updated Successfully...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            NewAccount_Load(sender, e);
            
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cnStr);
            SqlCommand CMD = new SqlCommand("select *FROM Customer_Detail order by Customer_id", con);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_custlist.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                 }

        private void dgv_custlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_custlist.Rows[indexRow];
            string S = row.Cells[1].Value.ToString();
            cmb_typeofacc.Text = S;
            txt_name.Text = row.Cells[2].Value.ToString();
            txt_add.Text = row.Cells[3].Value.ToString();
            txt_mob.Text = row.Cells[4].Value.ToString();
            txt_email.Text = row.Cells[5].Value.ToString();
            string s = row.Cells[6].Value.ToString();
            if (s == "MALE")
            {
                rb_male.Checked = true;
            }
            else
                rb_male.Checked = true;
            string m = row.Cells[8].Value.ToString();
            if (m == "married")
            {
                rb_married.Checked = true;
            }
            else
                rb_married.Checked = true;
            string c = row.Cells[9].Value.ToString();
            cmb_country.Text = c;
            string st = row.Cells[10].Value.ToString();
            cmb_state.Text = st;
            string ci = row.Cells[11].Value.ToString();
            cmb_city.Text = ci;
            string mi = row.Cells[12].Value.ToString();
            cmb_monthlyincome.Text = mi;
            string oc = row.Cells[13].Value.ToString();
            cmb_occupation.Text = oc;
            string kyc = row.Cells[14].Value.ToString();
            cmb_kyc.Text = kyc;
            txt_accno.Text = row.Cells[15].Value.ToString();
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_typeofacc.Text = "";
            txt_name.Text = "";
            txt_add.Text = "";
            txt_mob.Text = "";
            txt_email.Text = "";
            cmb_country.Text = "";
            cmb_state.Text = "";
            cmb_city.Text = "";
            cmb_monthlyincome.Text = "";
            cmb_occupation.Text = "";
            cmb_kyc.Text = "";
            txt_accno.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            QRY = "DELETE  FROM Customer_Detail where  Account_Number = " + txt_accno.Text + "";
            TransMyData(QRY);
            MessageBox.Show("Customer Deleted Successfully...", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnStr);
            SqlCommand CMD = new SqlCommand("select *FROM Customer_Detail order by Customer_id", con);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_custlist.DataSource = dt;
        }

        private void cust_id_Click(object sender, EventArgs e)
        {
            
        }
    }
}
