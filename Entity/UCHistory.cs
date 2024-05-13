using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class UCHistory : UserControl
    {
        Job job = new Job();
        JobDAO jobDAO = new JobDAO();

        public UCHistory(Job job)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(550, 421);
            this.job = job;
        }


        private void btnApplicants_Click(object sender, EventArgs e)
        {
            //FApplicant fApplicant = new FApplicant(job);
            //fApplicant.Show();
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            DateTime datePublished = job.DatePublish ?? DateTime.MinValue;
            DateTime dateEnd = job.DateEnd?? DateTime.MinValue;


            lblDateEnd.Text = "Expired at: " + dateEnd.ToString("dd/MM/yyyy");
            lblDatePuslish.Text = "Publish at: " + datePublished.ToString("dd/MM/yyyy");
            lblNameJob.Text = job.JobName;
            lblStatus.Text = job.status.ToUpper();
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
    }
}
