using Guna.UI2.WinForms;
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
using WinFormProject.OOPCODE;

namespace Entity
{
    public partial class UCApplicant : UserControl
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        JobDAO jobDAO = new JobDAO();
        Apply apply = new Apply();
        Job job = new Job();
        Image applicantAvatar = null;
        public event EventHandler SendClickHandle;
        public UCApplicant(Apply apply, Job job)
        {
            InitializeComponent();
            this.apply = apply;
            this.job = job;
            this.MaximumSize = new System.Drawing.Size(469, 543);
            FillInfor();
        }
        public void FillInfor()
        {
            lblApplicantNameT.Text = jsDAO.FetchName(apply.JobSeekerID);
            DateTime dateApply = apply.TimeApply ?? DateTime.MinValue;
            lblDateT.Text = "Apply at " + dateApply.ToString("dd/MM/yyyy");
            applicantAvatar = jsDAO.FetchImg(apply.JobSeekerID, "Avatar");
            if (applicantAvatar != null) ptbApplicantPicture.Image = applicantAvatar;
            lblEmailT.Text = jsDAO.FetchJSEmail(apply.JobSeekerID);
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            CVDao cVDao = new CVDao();
            CV cv = new CV();
            cVDao.FetchAllInformationOfCV(apply.JobSeekerID,ref cv);
            FCompanyCVView fCompanyCVView = new FCompanyCVView(cv,job.CompanyID);
            fCompanyCVView.Show();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {;
            FAnswer fAnswer = new FAnswer(apply, job);
            fAnswer.SendClick += SendClick_Handle;
            fAnswer.Show();
        }
        private void SendClick_Handle(object sender, EventArgs e)
        {
            SendClickHandle?.Invoke(this,e);
        }

    }
}
