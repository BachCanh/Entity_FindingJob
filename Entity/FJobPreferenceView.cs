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
    public partial class FJobPreferenceView : Form
    {
        JobPreference jobPreference = new JobPreference();
        JobPreferenceDAO jobPreferenceDAO = new JobPreferenceDAO();
        string companyid;
        public event EventHandler SendCLickHandle;
        public FJobPreferenceView(string jobseekerid, string companyid)
        {
            InitializeComponent();
            jobPreference = jobPreferenceDAO.FetchJobPreference(jobseekerid);
            FillInformation();
            this.companyid = companyid;
           
        }
        private void FillInformation()
        {
            lblTitle.Text = jobPreference.Title;
            lblTitle.Enabled = false;
            txtSalary.Text = jobPreference.Salary.ToString();
            txtLocation.Text = jobPreference.Location;
            cbbCompanySize.Text = jobPreference.CompanySize;
            cbbCompanyType.Text = jobPreference.CompanyType;
            cbbExperience.Text = jobPreference.Position;
            cbbWorkingForm.Text = jobPreference.WorkingForm;
            FillSkill();
            Disable();
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
                    flPBtnSkills.Controls.Add(btnSkillShow);
                    flPBtnSkills.Width += btnSkillShow.Width + 20;
                }
            }
        }
        private void Disable()
        {
            lblTitle.Enabled = false;
            txtSalary.Enabled = false;
            txtLocation.Enabled = false;
            cbbCompanySize.Enabled = false;
            cbbCompanyType.Enabled = false;
            cbbExperience.Enabled = false;
            cbbWorkingForm.Enabled = false;
        }
        private void pnBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            CV cv = new CV();
            CVDao cVDao = new CVDao();
            cVDao.FetchAllInformationOfCV(jobPreference.JobSeekerID,ref cv);
            FCompanyCVView fCompanyCVView = new FCompanyCVView(cv, companyid);
            fCompanyCVView.Show();
        }

        private void btnOffer_Click(object sender, EventArgs e)
        {
            FOffer fOffter = new FOffer(companyid, jobPreference);
            fOffter.SendClick += SendClick_Handle; 
            fOffter.Show();
        }
        private void SendClick_Handle(object sender, EventArgs e)
        {
            this.Close();
            SendCLickHandle?.Invoke(this, EventArgs.Empty);
        }
        
    }
}
