using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Entity

{
    public partial class FPostJob : Form
    {
        private int locaX = 62;
        private int locaY = 0;
        private List<string> jobNames = new List<string>();
        private List<Job> jobs;
        private FFilter fFilter;
        private string companyid;

        public FPostJob(List<Job> jobs, string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
        }

        private void PostJob_Load(object sender, EventArgs e)
        {
            JobDAO jobDAO = new JobDAO();
            jobs = jobDAO.FetchCompanyJob(companyid);
            fFilter = new FFilter(jobs);
            fFilter.btnApply.Click += btnApply_Click;
            fFilter.btnReset.Click += btnApply_Click;
            FillInfor(jobs);
        }

        private void FillInfor(List<Job> joblist)
        {
            pnSubBody.Controls.Clear();
            foreach (Job job in joblist)
            {
                if (job.status.Trim().ToLower() == "Waiting".ToLower())
                {
                    UCJob uCJob = new UCJob(job);
                    uCJob.JobDone += JobDone_Handle;
                    pnSubBody.Controls.Add(uCJob);
                    pnSubBody.Height += 270;
                }
            }
        }
        private void JobDone_Handle(object sender, EventArgs e)
        {
            UCJob ucjob = sender as UCJob;
            jobs.Remove(ucjob.job);
            pnSubBody.Controls.Remove(ucjob);
        }
        private void btnPostingJob_Click(object sender, EventArgs e)
        {
            FJobCreation fJobCreation = new FJobCreation(jobs, companyid);
            fJobCreation.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            PostJob_Load(sender, e);
        }
        private void SearchNameJS(string search)
        {
            JobSeekerDAO jsDAO = new JobSeekerDAO();
            //jobs = jobs.Where(job => job.Name.ToLower().Contains(search)).ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchNameJS(txtSearch.Text.ToLower());
                FillInfor(jobs);
            }
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            jobs = fFilter.filterList;
            FillInfor(jobs);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            fFilter.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            PostJob_Load(sender, e);
        }
    }
}

