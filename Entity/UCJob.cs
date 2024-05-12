// UCJob.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Entity
{
    public partial class UCJob : UserControl
    {
        public Job job = new Job();
        JobDAO jobDAO = new JobDAO();
        public event EventHandler JobDone;
        SkillListDAO skillListDAO = new SkillListDAO(); 
        public UCJob(Job job)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(550, 421);
            this.job = job;
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            jobDAO.DoneJob(job.JobID);
            JobDone?.Invoke(this,EventArgs.Empty);
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            //FApplicant fApplicant = new FApplicant(job);
            //fApplicant.Show();
        }

        private void UCJob_Load(object sender, EventArgs e)
        {
            lblNameJob.Text = job.JobName;
            lblStatus.Text = job.status.ToUpper();
            lblDatePuslish.Text = "Posted " + PublishTime();
            lblDateEnd.Text = "Expired after " + ExpiredTime();
            lblWorkingType.Text = job.WorkingForm;
            List<string> skills = new List<string>();
            skills.Add(job.JobSkill.Skill2);
            skills.Add(job.JobSkill.Skill3);
            skills.Add(job.JobSkill.Skill1);
            foreach (string s in skills)
            {
                if (s != "NULL")
                {
                    BtnSkill btnSkill = new BtnSkill();
                    btnSkill.Text = s;
                    btnSkill.Show();
                    flpSkills.Width += btnSkill.Width + 10;
                    flpSkills.Controls.Add(btnSkill);
                }
            }
        }

        private string PublishTime()
        {
            DateTime datePublished = job.DatePublish ?? DateTime.MinValue;
            TimeSpan timeDifference = DateTime.Now - datePublished;

            if (timeDifference.TotalMinutes < 1)
            {
                return "Just now";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes} minute(s) ago";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{(int)timeDifference.TotalHours} hour(s) ago";
            }
            else
            {
                return $"{(int)timeDifference.TotalDays} day(s) ago";
            }
        }

        private string ExpiredTime()
        {
            DateTime dateEnd = job.DateEnd ?? DateTime.MinValue;
            TimeSpan timeDifference = dateEnd - DateTime.Now;

            if (timeDifference.TotalMinutes < 0)
            {
                return $"{(int)timeDifference.TotalSeconds} second(s)";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes} minute(s)";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{(int)timeDifference.TotalHours} hour(s)";
            }
            else
            {
                return $"{(int)timeDifference.TotalDays} day(s)";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FJobEdit fJobEdit = new FJobEdit(job, job.CompanyID);
            fJobEdit.Show();
        }

        private void pnWrap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
