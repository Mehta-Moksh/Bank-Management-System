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
        public Login()
        {
            InitializeComponent();
        }

        //SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-OI1A39Q;Initial Catalog=Bank;Integrated Security=True");
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void label1_Click(object sender, EventArgs e)
        {
        
        }

         public  void label2_Click(object sender, EventArgs e)
        {
        
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        public void logbtn_Click(object sender, EventArgs e)
        {
            
            if (design.SelectedIndex == -1)
            {
                MessageBox.Show("Select The Designation");
            }
            else if (design.SelectedIndex == 0)
            {
                if (usertb.Text == "" || passtb.Text == "")
                {
                    MessageBox.Show("Enter Username and Password");
                }
                else
                {
                    SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-OI1A39Q;Initial Catalog=Bank;Integrated Security=True");
                    {
                        cnn.Open(); // Open the connection

                        SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Detail WHERE Employee_Name=@username AND Password=@password", cnn);
                        cmd.Parameters.AddWithValue("@username", usertb.Text);
                        cmd.Parameters.AddWithValue("@password", passtb.Text);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Username or Password incorrect");
                        }
                        frmHome h = new frmHome();
                        h.ShowDialog();
                    } // Connection will be automatically closed and disposed here
                    
                    cnn.Close();
                }
            }

            
             //Ensure that you're handling form closing appropriately
            this.Hide();

            
        }
        
        public void desigcmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void passtb_TextChanged(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            usertb.Text = "";
            passtb.Text = "";


        }
        

        }
    
    }

