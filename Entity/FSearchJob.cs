using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Entity
{
    public partial class FSearchJob : Form
    {
        private List<Job> filterjobs = new List<Job>();
        string jsID;
        FFilter fFilter;
        JobDAO jobDAO = new JobDAO();
        Size oldSize = new Size(1095, 673);
        int limit, offset, totalwaitingjob;
        public FSearchJob(string jsID)
        {
            this.jsID = jsID;
            InitializeComponent();

        }

        private void FSearchJob_Load(object sender, EventArgs e)
        {
            filterjobs = jobDAO.FetchAvailableJobs();
            SetLimit();
            FillJob(this.filterjobs);
            fFilter = new FFilter(filterjobs.Skip(offset).Take(limit).ToList());
            fFilter.ListReady += fFilter_ListReady;
        }

        private void UCInformation_SkillButtonClicked(object sender, string skillText)
        {
            filterjobs = jobDAO.FetchAvailableJobs();
            filterjobs = filterjobs.Where(job => job.JobSkill.Skill1.Contains(skillText) || job.JobSkill.Skill2.Contains(skillText) || job.JobSkill.Skill3.Contains(skillText)).ToList();
            SetLimit();
            FillJob(this.filterjobs);
        }
        private void FillJob(List<Job> jobslist)
        {
            if (jobslist.Count > 0)
            {
                flpJob.Controls.Clear();
                this.Size = oldSize;
                int count = 0;

                // Add job information controls
                foreach (Job job in jobslist)
                {
                    count++;
                    UCInformation uCInformation = new UCInformation(job, jsID);
                    uCInformation.pnBody.FillColor = colorJob(count);
                    flpJob.Controls.Add(uCInformation);
                    if (count % 2 == 1)
                    {
                        flpJob.Height += 500;
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
                btnBack.Visible = true;
                btnNext.Visible = true;
                // Add buttons to a new line after the last element
                if (flpJob.Controls.Count > 0)
                {
                    flpJob.SetFlowBreak(flpJob.Controls[flpJob.Controls.Count - 1], true);
                }
                // Left align the buttons
                btnBack.Anchor = AnchorStyles.Left;
                btnNext.Anchor = AnchorStyles.Left;

                // Add the buttons to the FlowLayoutPanel
                flpJob.Controls.Add(btnBack);
                flpJob.Controls.Add(btnNext);
            }
            else
            {
                btnBack.Visible = false;
                btnNext.Visible = false;
            }

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
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = txtSearch.Text.ToLower();
                List<Job> searchJob = this.filterjobs.Where(job =>
                {
                    CompanyDAO companyDAO = new CompanyDAO();
                    string namecompany = companyDAO.FetchName(job.CompanyID).ToLower();
                    string[] propertiesToSearch = { job.JobName.ToLower(), job.Position.ToLower(), job.requirement.ToLower(), job.description.ToLower(), job.benefit.ToLower(), namecompany };

                    return propertiesToSearch.Any(property => property.Contains(search));
                }).ToList();
                FillJob(searchJob);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            fFilter.Show();
        }
        private void fFilter_ListReady(object sender, List<Job> e)
        {
            filterjobs = e;
            FillJob(this.filterjobs);
        }
        private void SetLimit()
        {
            totalwaitingjob = filterjobs.Count();
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
                FillJob(filterjobs.Skip(offset).Take(limit).ToList());

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
                FillJob(filterjobs.Skip(offset).Take(limit).ToList());
            }
            else
            {
                limit += 4;
                offset += 4;
                FillJob(filterjobs.Skip(offset).Take(limit).ToList());
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            FSearchJob_Load(sender, e);
        }

    }
}

