using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ad_Click(object sender, EventArgs e)
        {
            displaypanel.Controls.Clear();
            displaypanel.Visible = true;
            var acc = new AccountDetails();
            acc.TopLevel = false;
            acc.Show();
            displaypanel.Controls.Add(acc);
        }

        private void na_Click(object sender, EventArgs e)
        {
            displaypanel.Controls.Clear();
            displaypanel.Visible = true;
            var acc = new NewAccount();
            acc.TopLevel = false;
            acc.Show();
            displaypanel.Controls.Add(acc);
        }

        private void ts_Click(object sender, EventArgs e)
        {
             displaypanel.Controls.Clear();
            displaypanel.Visible = true;
            var acc = new Transaction();
            acc.TopLevel = false;
            acc.Show();
            displaypanel.Controls.Add(acc);
        }

        private void ed_Click(object sender, EventArgs e)
        {
            displaypanel.Controls.Clear();
            displaypanel.Visible = true;
            var acc = new Employee_Detail();
            acc.TopLevel = false;
            acc.Show();
            displaypanel.Controls.Add(acc);
        }

        private void cl_Click(object sender, EventArgs e)
        {
            displaypanel.Controls.Clear();
            displaypanel.Visible = true;
            var acc = new Customer_List();
            acc.TopLevel = false;
            acc.Show();
            displaypanel.Controls.Add(acc);
        }

        private void rc_Click(object sender, EventArgs e)
        {
            displaypanel.Controls.Clear();
            displaypanel.Visible = true;
            var acc = new Records();
            acc.TopLevel = false;
            acc.Show();
            displaypanel.Controls.Add(acc);
        }

        private void cb_Click(object sender, EventArgs e)
        {

            displaypanel.Controls.Clear();
            displaypanel.Visible = true;
            var acc = new CheckBal();
            acc.TopLevel = false;
            acc.Show();
            displaypanel.Controls.Add(acc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void menupanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displaypanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
