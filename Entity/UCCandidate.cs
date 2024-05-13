using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace Entity
{
    public partial class UCCandidate : UserControl
    {
        string companyid;
        public JobPreference jobPreference = new JobPreference();
        public event EventHandler SendClickHandleHandle;
        public UCCandidate(JobPreference jobPreference,string companyid)
        {
            this.jobPreference = jobPreference;
            InitializeComponent();
            FillInformation();
            this.companyid = companyid;
        }
        private void FillInformation()
        {
            lblTitle.Text = jobPreference.Title;
            lblWorkingType.Text = jobPreference.WorkingForm;
            lblLocation.Text = jobPreference.Location;
            FillSkill();
            JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
            lblCandidateName.Text = jobSeekerDAO.FetchName(jobPreference.JobSeekerID);
            ptbCandidateAvatar.Image = jobSeekerDAO.FetchImg(jobPreference.JobSeekerID, "Avatar");


        }
        private void FillSkill()
        {
            List<string> skills = new List<string>();
            skills.Add(jobPreference.Skill1);
            skills.Add(jobPreference.Skill2);
            skills.Add(jobPreference.Skill3);
            foreach (string s in skills)
            {
                if (s != "NULL")
                {
                    BtnSkillShow btnSkillShow = new BtnSkillShow();
                    btnSkillShow.Text = s;
                    btnSkillShow.Enabled = false; // Disable button
                    flpSkills.Controls.Add(btnSkillShow);
                    flpSkills.Width += btnSkillShow.Width + 20;
                }
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FJobPreferenceView fJobPreferenceView = new FJobPreferenceView(jobPreference.JobSeekerID,companyid);
            fJobPreferenceView.SendCLickHandle += SendClickHandle_Handle;
            fJobPreferenceView.Show();
        }
        private void SendClickHandle_Handle(object sender, EventArgs e)
        {
            SendClickHandleHandle?.Invoke(this, e);
        }
    }
}
