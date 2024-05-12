using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Entity
{
    public partial class FJobCreation : Form
    {
        private Form currentFormChild = new Form();
        private FJobSKills fJobSKills;
        private List<Job> jobs;
        private string companyid;
        private JobDAO jobDAO = new JobDAO();
        private SkillListDAO slDAO = new SkillListDAO();
        private List<string> skills = new List<string>();
        public FJobCreation(List<Job> jobs, string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
            fJobSKills = new FJobSKills(skills);
            fJobSKills.ListReady += FJobSkills_ListReady;
            dtpDateEnd.MinDate = DateTime.Now;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            List<string> skills = new List<string>();
            foreach (BtnSkill button in flpSkills.Controls.OfType<BtnSkill>())
            {
                skills.Add(button.Text);
            }
            while(skills.Count < 3)
            {
                skills.Add("NULL");
            }
            Job job = new Job(companyid, txtJobName.Text, cbbExperience.Text, txtSalary.Text, rtxtjobrequirement.Text, rtxtdescription.Text, rtxtBenefit.Text, cbbWorkingForm.Text, dtpDateEnd.Value);
            string jobID = jobDAO.AddNewJob(job);
            job.JobSkill = new JobSkill();
            // Assuming skills is an array containing skill values
            job.JobSkill.Skill1 = skills[0];
            job.JobSkill.Skill2 = skills[1];
            job.JobSkill.Skill3 = skills[2];
            job.JobSkill.jobID = jobID;
            slDAO.AddSkillList(job.JobSkill);
            jobs = jobDAO.FetchCompanyJob(companyid);
            this.Close();
        }

        private void btnPostJob_Click_Error(object sender, EventArgs e)
        {
            SetError(txtJobName);
            SetError(txtSalary);
            SetError(cbbExperience);
            SetError(cbbWorkingForm);
            SetError(rtxtBenefit);
            SetError(rtxtdescription);
            SetError(rtxtjobrequirement);
            if(flpSkills.Controls.Count < 1)
            {
                MessageBox.Show("Choose the Main Skill!!");
                return;
            }
            foreach(Control control in this.Controls)
            {
                if (AnyErrors(control))
                {
                    return;
                }
            }
            btnPostJob_Click(sender, e);
        }

        public bool AnyErrors(Control control)
        {
            // Check if the control has an ErrorProvider and if it has any errors
            if (control is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                if (!string.IsNullOrEmpty(epTextbox.GetError(txt)))
                {
                    return true;
                }
            }

            if (control is Guna.UI2.WinForms.Guna2ComboBox cbb)
            {
                if (!string.IsNullOrEmpty(epCbb.GetError(cbb)))
                {
                    return true;
                }
            }

            if (control is RichTextBox rtxt)
            {
                if (!string.IsNullOrEmpty(epTextbox.GetError(rtxt)))
                {
                    return true;
                }
            }

            foreach (Control childControl in control.Controls)
            {
                if (AnyErrors(childControl))
                {
                    return true;
                }
            }

            return false;
        }

        private void FillSkills()
        {
            flpSkills.Controls.Clear();
            flpSkills.Width = 0;
            foreach (string s in skills)
            {
                if (s != "NULL")
                {
                    BtnSkill btnSkill = new BtnSkill();
                    btnSkill.Text = s;
                    btnSkill.Show();
                    flpSkills.Controls.Add(btnSkill);
                    flpSkills.Width += btnSkill.Width + 20;
                }
            }
        }

        private void FJobSkills_ListReady(object sender, List<string> e)
        {
            skills = e;
            FillSkills();
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fJobSKills.Show();
        }

        private void txtJobName_Leave(object sender, EventArgs e)
        {
            SetError(txtJobName);
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            SetError(txtSalary);
        }

        private void SetError(Guna.UI2.WinForms.Guna2TextBox txt)
        {
            if (txt.Text.Length == 0)
            {
                epTextbox.SetError(txt, "Textbox cannot be empty");
            }
            else
            {
                epTextbox.SetError(txt, "");
            }
        }
        private void SetError(Guna.UI2.WinForms.Guna2ComboBox cbb)
        {
            if (cbb.SelectedIndex < 0)
            {
                epCbb.SetError(cbb, "Must choose something!!!");
            }
            else
            {
                epCbb.SetError(cbb, "");
            }
        }
        private void SetError(RichTextBox rtxt)
        {
            if (rtxt.Text.Length < 1)
            {
                epTextbox.SetError(rtxt, "Textbox cannot be empty");
            }
            else
            {
                epTextbox.SetError(rtxt, "");
            }
        }
    }
}
