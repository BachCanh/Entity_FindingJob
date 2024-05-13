using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class FAnswer : Form
    {
        Apply apply = new Apply();
        Interview interview;
        FScheduleInterview fScheduleInterview;
        Job job = new Job();
        InterviewDAO interviewDAO = new InterviewDAO();
        public event EventHandler SendClick;
        public FAnswer(Apply apply, Job job)
        {
            InitializeComponent();
            this.apply = apply;
            this.job = job;
            JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
            JobDAO jobDAO = new JobDAO();
            fScheduleInterview = new FScheduleInterview(apply, job.CompanyID);
            lblToT.Text = jobSeekerDAO.FetchName(apply.JobSeekerID);
            fScheduleInterview.btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.interview = fScheduleInterview.INTER;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(interview.Status.ToLower() != "waiting")
            {
                AlertDAO dAO = new AlertDAO();
                JobAlert alert = new JobAlert(job.CompanyID, apply.JobSeekerID, cbbSubject.Text, txtContent.Text, job.JobID);
                ApplyDAO applyDAO = new ApplyDAO();
                applyDAO.UpdateStatus(cbbSubject.Text, apply);
                dAO.InsertAlert(alert);
                this.Close();
                SendClick?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please Schedule the Interview!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            interviewDAO.DeletedNewInterview(apply.JobSeekerID,job.JobID,job.CompanyID);
            this.Close();
        }

        private void cbbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbSubject.SelectedIndex == 0)
            {
                btnInterview.Visible = true;
            }
            else btnInterview .Visible = false;
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            fScheduleInterview.Show();
        }
    }
}
