using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Entity
{
    public partial class FHistory : Form
    {
        private List<Job> jobs;
        private string companyid;
        private FFilter fFilter;
        public FHistory(List<Job> jobs, string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
            foreach (Job job in jobs)
            {
                UCHistory uchistory = new UCHistory(job);
                pnSubBody.Controls.Add(uchistory);
                uchistory.Dock = DockStyle.Top;
                pnSubBody.Height += 150;
            }
            fFilter = new FFilter(jobs);
            fFilter.btnApply.Click += btnApply_Click;
            fFilter.btnReset.Click += btnApply_Click;
        }
        private void Job_Load(object sender, EventArgs e)
        {
            JobDAO jobDAO = new JobDAO();
            jobs = jobDAO.FetchCompanyJob(companyid);
            FillInfor(jobs);
        }

        private void FillInfor(List<Job> joblist)
        {
            pnSubBody.Controls.Clear();
            foreach (Job job in joblist)
            {
                UCHistory uchistory = new UCHistory(job);
                pnSubBody.Controls.Add(uchistory);
                uchistory.Dock = DockStyle.Top;
                pnSubBody.Height += 270;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Job_Load(sender, e);
        }

        private void SearchNameJS(string search)
        {
            JobSeekerDAO jsDAO = new JobSeekerDAO();
            jobs = jobs.Where(job => job.JobName.ToLower().Contains(search)).ToList();
        }
        private void SearchStatusJS(string search)
        {
            jobs = jobs.Where(job => job.status.ToLower().Contains(search)).ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchNameJS(txtSearch.Text);
                FillInfor(jobs);
            }
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStatus.SelectedIndex == 0)
            {
                return;
            }
            SearchStatusJS(cbbStatus.Text.ToLower());
            FillInfor(jobs);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            fFilter.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            jobs = fFilter.filterList;
            FillInfor(jobs);
        }
    }
}
