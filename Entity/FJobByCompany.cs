using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Entity
{
    public partial class FJobByCompany : Form
    {
        private List<Job> companyJobs = new List<Job>();
        JobDAO jobDAO = new JobDAO();
        private string companyID;
        Size oldSize = new Size(1251, 894);
        string jsID;
        int limit, offset, totalwaitingjob;

        public FJobByCompany(string companyID, string jsID)
        {
            this.companyID = companyID;
            this.jsID = jsID;
            InitializeComponent();
            FetchCompanyJobs();
            SetLimit();
            FillJob(companyJobs);
        }

        private void FetchCompanyJobs()
        {
            JobDAO jobDAO = new JobDAO();
            companyJobs = jobDAO.FetchCompanyJob(companyID);
        }

        private void FillJob(List<Job> jobslist)
        {
            flpJob.Controls.Clear();
            this.Size = oldSize;
            int count = 0;

            // Add job information controls
            foreach (Job job in jobslist)
            {
                if (job.status == "waiting")
                {
                    count++;
                    UCInformation uCInformation = new UCInformation(job, jsID);
                    uCInformation.pnBody.FillColor = colorJob(count);
                    flpJob.Controls.Add(uCInformation);
                    if (count % 2 == 1)
                    {
                        flpJob.Height += 500;
                    }
                }
                if (count == 4)
                {
                    count = 0;
                }
            }

            // Attach event handler for skill button click
            foreach (Control control in flpJob.Controls)
            {
                if (control is UCInformation ucInfo)
                {
                    ucInfo.SkillButtonClicked += UCInformation_SkillButtonClicked;
                }
            }
            // Add buttons to a new line after the last element
            flpJob.SetFlowBreak(flpJob.Controls[flpJob.Controls.Count - 1], true);

            // Left align the buttons
            btnBack.Anchor = AnchorStyles.Left;
            btnNext.Anchor = AnchorStyles.Left;

            // Add the buttons to the FlowLayoutPanel
            flpJob.Controls.Add(btnBack);
            flpJob.Controls.Add(btnNext);

        }
        private void UCInformation_SkillButtonClicked(object sender, string skillText)
        {
            companyJobs = jobDAO.FetchCompanyJob(companyID);
            companyJobs = companyJobs.Where(job => job.JobSkill.Skill1.Contains(skillText) || job.JobSkill.Skill2.Contains(skillText) || job.JobSkill.Skill3.Contains(skillText)).ToList();
            SetLimit();
            FillJob(this.companyJobs);
        }
        private Color colorJob(int count)
        {
            if (count == 1)
                return Color.FromArgb(227, 219, 250);
            else if (count == 2)
                return Color.FromArgb(251, 226, 244);
            else if (count == 3)
                return Color.FromArgb(255, 225, 204);
            else return Color.FromArgb(212, 246, 237);
        }
        private void SetLimit()
        {
            totalwaitingjob = companyJobs.Count();
            if (limit > totalwaitingjob)
            {
                limit = totalwaitingjob;
                offset = 0;
            }
            else
            {
                limit = 4;
                offset = 0;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (offset == 0)
            {
                MessageBox.Show("You're already at the beginning of the job list.");
            }
            else
            {
                if (limit == totalwaitingjob)
                {
                    limit -= 4;
                    offset -= 4;
                }
                else
                {
                    offset -= 4;

                }
                FillJob(companyJobs.Skip(offset).Take(limit).ToList());

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (limit == totalwaitingjob)
            {
                MessageBox.Show("No more job for you to next");
            }
            else if ((limit + 4) > totalwaitingjob)
            {
                int space = totalwaitingjob - limit;
                limit += space;
                offset += space;
                FillJob(companyJobs.Skip(offset).Take(limit).ToList());
            }
            else
            {
                limit += 4;
                offset += 4;
                FillJob(companyJobs.Skip(offset).Take(limit).ToList());
            }
        }
    }
}
