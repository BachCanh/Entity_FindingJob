using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Entity
{
    public partial class FJobPreference : Form
    {
        JobPreference jobpreference;
        JobPreferenceDAO JobPreferenceDAO = new JobPreferenceDAO();
        FJobSKills fJobSKills;
        string jobseekerid;
        List<string> list = new List<string>();
        public FJobPreference(string jobseekerid)
        {
            jobpreference = JobPreferenceDAO.FetchJobPreference(jobseekerid);
            InitializeComponent();
            if(jobpreference.Skill1.Trim() != "NULL")
            {
                list.Add(jobpreference.Skill1);
            }
            if (jobpreference.Skill2.Trim() != "NULL")
            {
                list.Add(jobpreference.Skill2);
            }
            if (jobpreference.Skill3.Trim() != "NULL")
            {
                list.Add(jobpreference.Skill3);
            }
            fJobSKills = new FJobSKills(list);
            this.jobseekerid = jobseekerid;
            FillInformation();
            fJobSKills.ListReady += FJobSkills_ListReady;
            fJobSKills.btnSave.Click += btnSave_CLick;

        }
        private void FillInformation()
        {
            this.txtJobName.Text = jobpreference.Title;
            this.txtJobName.Enabled = false; // Disable text box

            this.txtSalary.Text = jobpreference.Salary.ToString();
            this.txtSalary.Enabled = false; // Disable text box

            this.txtLocation.Text = jobpreference.Location;
            this.txtLocation.Enabled = false; // Disable text box

            this.cbbCompanySize.Text = jobpreference.CompanySize;
            this.cbbCompanySize.Enabled = false; // Disable combo box

            this.cbbCompanyType.Text = jobpreference.CompanyType;
            this.cbbCompanyType.Enabled = false; // Disable combo box

            this.cbbExperience.Text = jobpreference.Position;
            this.cbbExperience.Enabled = false; // Disable combo box

            this.cbbWorkingForm.Text = jobpreference.WorkingForm;
            this.cbbWorkingForm.Enabled = false; // Disable combo box
            FillSkill();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable or disable text boxes
            this.txtJobName.Enabled = true;
            this.txtSalary.Enabled = true;
            this.txtLocation.Enabled = true;

            // Enable or disable combo boxes
            this.cbbCompanySize.Enabled = true;
            this.cbbCompanyType.Enabled = true;
            this.cbbExperience.Enabled = true;
            this.cbbWorkingForm.Enabled = true;

            // Enable or disable skill buttons
            foreach (Control control in flpSkills.Controls)
            {
                if (control is BtnSkillShow btnSkillShow)
                {
                    btnSkillShow.Enabled = true;
                }
            }
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fJobSKills.Show();
        }
        private void FJobSkills_ListReady(object sender, List<string> e)
        {
            list = e;
            while(list.Count < 3)
            {
                list.Add("NULL");
            }
            FillSkill();
            jobpreference.Skill1 = list[0];
            jobpreference.Skill2 = list[1];
            jobpreference.Skill3 = list[2];
        }

        private void btnSave_CLick(object sender, EventArgs e)
        {
            //list.Clear();
            //list = fJobSKills.Skills;
            //FillSkill();
            //while (list.Count < 3)
            //{
            //    list.Add("NULL");
            //}
            //jobpreference.Skill1 = list[0];
            //jobpreference.Skill2 = list[1];
            //jobpreference.Skill3 = list[2];
        }

        private void FillSkill()
        {
            flpSkills.Controls.Clear();
            foreach (string s in list)
            {
                if (s != "NULL")
                {
                    BtnSkillShow btnSkillShow = new BtnSkillShow();
                    btnSkillShow.Text = s;
                    btnSkillShow.Enabled = false;
                    flpSkills.Controls.Add(btnSkillShow);
                    flpSkills.Width += btnSkillShow.Width + 20;
                }
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            
            jobpreference.Title = txtJobName.Text;
            jobpreference.Salary = int.Parse(txtSalary.Text); // Assuming salary is entered as an integer
            jobpreference.Location = txtLocation.Text;
            jobpreference.CompanySize = cbbCompanySize.Text;
            jobpreference.CompanyType = cbbCompanyType.Text;
            jobpreference.Position = cbbExperience.Text;
            jobpreference.WorkingForm = cbbWorkingForm.Text;
            // Update the deadline property (assuming the deadline is entered through a DateTimePicker)
            jobpreference.Deadline = dtpDateEnd.Value;
            if(jobpreference.JobSeekerID == "")
            {
                jobpreference.JobSeekerID = jobseekerid;
                JobPreferenceDAO.InsertJobPreference(jobpreference);
            } else
            {
                JobPreferenceDAO.UpdateJobPreference(jobpreference);
            }
            
        }
    }
}
