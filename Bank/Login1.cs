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
    public partial class Login : Form
    {
        static string cnStr = (new clsConnection()).cnStr;
        public Login()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {

        }

        private void logbtn_Click_1(object sender, EventArgs e)
        {

            if (cmb_desig.SelectedIndex == -1)
            {
                MessageBox.Show("Select The Designation");
            }
            else if (cmb_desig.SelectedIndex == 0 || cmb_desig.SelectedIndex == 1)
            {
                if (usertb.Text == "" || passtb.Text == "")
                {
                    MessageBox.Show("Enter Username and Password");
                }
                else
                {
                    SqlConnection cnn = new SqlConnection(cnStr);
                    {
                        cnn.Open(); // Open the connection

                        SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Detail WHERE Employee_Name=@username AND Password=@password",cnn);
                        cmd.Parameters.AddWithValue("@username", usertb.Text);
                        cmd.Parameters.AddWithValue("@password", passtb.Text);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            Home h = new Home();
                            h.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password incorrect");
                        }
                       
                    } // Connection will be automatically closed and disposed here

                    cnn.Close();
                }
            }


            //Ensure that you're handling form closing appropriately
            //Application.Exit();
            
            
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            cmb_desig.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usertb.Text = "";
            passtb.Text = "";
        }

        private void usertb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
