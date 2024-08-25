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
    public partial class Employee_Detail : Form
    {
        static string cnStr = (new clsConnection()).cnStr;
        static string QRY = string.Empty;

        public Employee_Detail()
        {
            InitializeComponent();

        }
        DataTable DT = new DataTable();
        int indexRow;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ee_Click(object sender, EventArgs e)
        {

        }

        private void eg_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            QRY = "INSERT INTO Employee_Detail (User_id,Employee_Name,Password,Address,Mobile_Number,Designation,Email,Gender)VALUES(";
            QRY += "(SELECT ISNULL(MAX(User_id),0)+1 from Employee_Detail),";
            QRY += "'" + txtempname.Text + "',";
            QRY += "'" + txtpass.Text + "',";
            QRY += "'" + txtadd.Text + "',";
            QRY += "" + txtmob.Text + ",";
            QRY += "'" + cmb_desig.Text.Trim() + "',";
            QRY += "'" + txtemail.Text + "',";
            QRY += rb_female.Checked ? "'Female'" : "'Male'";
            QRY += ")";
            TransMyData(QRY);
            MessageBox.Show("Employee Added Successfully...", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Employee_Detail_Load(object sender, EventArgs e)
        {

        }

        private void lblempname_Click(object sender, EventArgs e)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {

            
            DataGridViewRow DGVR = dgv_empdetail.Rows[indexRow];
            DGVR.Cells[0].Value = txt_userid.Text;
            DGVR.Cells[1].Value = txtempname.Text;
            DGVR.Cells[2].Value = txtpass.Text;
            DGVR.Cells[3].Value = txtadd.Text;
            DGVR.Cells[4].Value = txtmob.Text;
            string d = DGVR.Cells[5].Value.ToString();
            cmb_desig.Text = d;
            DGVR.Cells[6].Value = txtemail.Text;
            string s = DGVR.Cells[7].Value.ToString();
            if (s == "MALE")
            {
                rb_male.Checked = true;
            }
            else
                rb_male.Checked = true;
            QRY = "UPDATE Employee_Detail SET ";

            QRY += "Employee_Name = '" + txtempname.Text + "' ,";

            QRY += "Password = '" + txtpass.Text + "' ,";

            QRY += "Address = '" + txtadd.Text + "' ,";

            QRY += "Mobile_Number = '" + txtmob.Text + "' , ";

            QRY += "Designation = '" + cmb_desig.Text.Trim() + "' , ";

            QRY += "Email = '" + txtemail.Text + "' ";

            QRY += "WHERE User_id = '" + txt_userid.Text + "'";
            TransMyData(QRY);
            
            MessageBox.Show("Employee Updated Successfully...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnclear_Click(object sender, EventArgs e)
        {
            txt_userid.Text = "";
            txtempname.Text = "";
            txtpass.Text = "";
            txtadd.Text = "";
            txtmob.Text = "";
            cmb_desig.Text = "";
            txtemail.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            QRY = "DELETE  FROM Employee_Detail where  User_id = " + txt_userid.Text + "";
            TransMyData(QRY);
            MessageBox.Show("Employee Deleted Successfully...", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_empdetail.Rows[indexRow];
            txt_userid.Text = row.Cells[0].Value.ToString();
            txtempname.Text = row.Cells[1].Value.ToString();
            txtpass.Text = row.Cells[2].Value.ToString();
            txtadd.Text = row.Cells[3].Value.ToString();
            txtmob.Text = row.Cells[4].Value.ToString();
            string d = row.Cells[5].Value.ToString();
            cmb_desig.Text = d;
            txtemail.Text = row.Cells[6].Value.ToString();
            string s = row.Cells[7].Value.ToString();
            if (s == "MALE")
            {
                rb_male.Checked = true;
            }
            else
                rb_male.Checked = true;

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnStr);
            SqlCommand CMD = new SqlCommand("select *FROM Employee_Detail", con);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_empdetail.DataSource = dt;
        }

        private void dgv_empdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


