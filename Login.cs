using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppManager.DAL;

namespace AppManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if(txtuser.Text =="")
            {
                MessageBox.Show("Not Empty Here");
                txtuser.Focus();
            }
            if(txtpass.Text =="")
            {
                MessageBox.Show("Not Empty Here");
                txtpass.Focus();
            }


        }
    }
}
