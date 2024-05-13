using ReaLTaiizor.Controls;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class FScheduleInterview : Form
    {
        Apply apply = new Apply();
        List<Interview> interviews = new List<Interview>();
        Interview interview;
        InterviewDAO InterviewDAO = new InterviewDAO();
        List<string> times = new List<string>();
        string jobseekerid, jobid, companyID;
        public FScheduleInterview(Apply apply, string companyID)
        {
            InitializeComponent();
            this.apply = apply;
            this.companyID = companyID;
            jobseekerid = apply.JobSeekerID;
            jobid = apply.JobID;
            interviews = InterviewDAO.FetchInterviewByID(companyID);
            times.AddRange(cbbTimeIv.Items.Cast<string>());
        }
        public FScheduleInterview(JobPreference jobPreference, string companyID)
        {
            InitializeComponent();
            this.companyID = companyID;
            this.jobseekerid = jobPreference.JobSeekerID;
            this.jobid = string.Empty;
            interviews = InterviewDAO.FetchInterviewByID(companyID);
            times.AddRange(cbbTimeIv.Items.Cast<string>());
        }
        private void mcpSchdule_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblDateTime.Text = "Interview schedule: " + mcpSchdule.SelectionRange.Start.ToString("dd/MM/yyyy");
            cbbTimeIv.Items.Clear();
            cbbTimeIv.Items.AddRange(times.ToArray());
            FScheduleInterview_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            interview = new Interview(jobseekerid, jobid, cbbTimeIv.Text, mcpSchdule.SelectionRange.Start, companyID);
            InterviewDAO.InsertInterview(interview);
            interviews.Add(interview);
            FScheduleInterview_Load(sender, e);
        }

        private void FScheduleInterview_Load(object sender, EventArgs e)
        {
            flpBody.Controls.Clear();
            foreach (Interview interview in interviews)
            {
                if (interview.DateInterview == mcpSchdule.SelectionRange.Start)
                {
                    if(interview.Status.ToLower() != "rejected")
                    {
                        cbbTimeIv.Items.Remove(interview.TimeInterview);
                    }
                    UCInterview uc = new UCInterview(interview);
                    flpBody.Controls.Add(uc);
                    flpBody.Height += 85;
                }
            }
        }
        public Interview INTER
        { get { return interview; } }
    }
}
