using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace Entity
{
    public partial class FCompany : Form
    {
        private Guna.UI2.WinForms.Guna2Button selectedButton;
        CompanyDAO com = new CompanyDAO();
        private Image imageclicked;
        private Form currentFormChild;
        private Account account;
        private Company company = new Company();
        public FCompany(Account account)
        {
            InitializeComponent();
            this.account = account;
            GetAllButtons(panel2);
            this.company = com.FetchCompanyInformationBasedEmail(account.Email);
            SetStatusJobs();
        }

        private void SetStatusJobs()
        {
            JobDAO jDAO = new JobDAO();
            foreach(Job job in company.Jobs)
            {
                if(job.DateEnd < DateTime.Now)
                {
                    jDAO.DoneJob(job.JobID);
                }
            }
        }

        void GetAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)c;
                    button.Click += button_Click;
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to log out?", "Alert!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using our service!\nGoodbye and See you again");
                this.Hide();
                FLogin fLogin = new FLogin();
                fLogin.Closed += (s, args) => this.Close();
                fLogin.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                selectedButton.BackColor = Color.Transparent;
                selectedButton.Font = new Font("Cooper Black", 12f);
                selectedButton.ForeColor = Color.White;
                selectedButton.Enabled = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clickedButton = (Guna.UI2.WinForms.Guna2Button)sender;
            if (clickedButton == selectedButton)
                return;

            if (selectedButton != null)
            {
                selectedButton.FillColor = Color.Transparent;
                selectedButton.Font = new Font("Cooper Black", 12f);
                selectedButton.ForeColor = Color.White;
                selectedButton.Image = imageclicked;
                selectedButton.Enabled = true;
            }

            imageclicked = clickedButton.Image;
            clickedButton.FillColor = Color.FromArgb(220, 251, 251);
            clickedButton.Font = new Font("Cooper Black", 16.2f);
            clickedButton.ForeColor = Color.Black;
            clickedButton.Image = clickedButton.HoverState.Image;
            clickedButton.Enabled = true;

            selectedButton = clickedButton;
            //clickedButton.Enabled = false;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            company = com.FetchCompanyInformationBasedEmail(account.Email);
            List<Job> jobs = company.Jobs.ToList();
            OpenChildForm(new FPostJob(jobs, company.ID));
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            company = com.FetchCompanyInformationBasedEmail(account.Email);
            OpenChildForm(new FProfileCompany(company));
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            company = com.FetchCompanyInformationBasedEmail(account.Email);
            List<Job> jobs = company.Jobs.ToList();
            OpenChildForm(new FHistory(jobs, company.ID));
        }

        private void btnInterviewView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FViewInterview(company));
        }
        private void btnApplicant_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FFindApplicant(company.ID));
        }

        
    }
}