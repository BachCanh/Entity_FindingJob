using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject;

namespace Entity
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            txtemail.KeyDown += new KeyEventHandler(YourForm_KeyDown);
            txtpassword.KeyDown += new KeyEventHandler(YourForm_KeyDown);
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            
        }
        private void btnforgotpw_Click(object sender, EventArgs e)
        {
            
        }
        private void btnsignin_Click(object sender, EventArgs e)
        {
            AccountDAO a = new AccountDAO();
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string type = (rdocompany.Checked) ? "company" : "jobseeker";
            type = (rdojobseeker.Checked) ? "jobseeker" : "company";
            Account acc = new Account(email, password, type);
            Form form = new Form();
            if (type == "company")
            {
                form = new FCompany(acc);
            }
            else if(type == "jobseeker")
            {
                form = new FJobSeeker(acc);
            }
            if (a.GetAccount(acc))
            {
                MessageBox.Show("Login success!");
                form.Closed += (s, args) => this.Close();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login fail!");
            }
        }
        private void YourForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsignin_Click(sender, e);
            }
        }
    }
}