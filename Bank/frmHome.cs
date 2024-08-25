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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void cl_Click(object sender, EventArgs e)
        {

        }

        private void rc_Click(object sender, EventArgs e)
        {

        }

        private void na_Click(object sender, EventArgs e)
        {
                      
        }

        private void ad_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Visible = true;
            var acc = new AccountDetails();
            acc.TopLevel = false;
            acc.Show();
            panel2.Controls.Add(acc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
