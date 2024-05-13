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
    public partial class UCAlert : UserControl
    {
        JobAlert alert = new JobAlert();
        JobOffer jobOffer = new JobOffer();
        Image companyAvatar;
        JobDAO jobDAO = new JobDAO();
        string type = "";
        public UCAlert(JobAlert alert)
        {
            InitializeComponent();
            this.alert = alert;
            this.MaximumSize = new System.Drawing.Size(531, 206);
            lblDateT.Text = alert?.DateReply?.ToString("dd/MM/yyyy");
            CompanyDAO companyDAO = new CompanyDAO();
            companyAvatar = companyDAO.FetchImg(alert.senderID, "Avatar");
            if (companyAvatar != null)  ptbCompanyPicture.Image = companyAvatar;
            lblJobNameT.Text = jobDAO.FetchName(alert.jobID);
            lblFromT.Text = companyDAO.FetchName(alert.senderID);
            lblSubjectT.Text = alert.Subject;
            type = "Alert";
        }
        public UCAlert(JobOffer jobOffer)
        {
            InitializeComponent();
            this.jobOffer = jobOffer;
            this.MaximumSize = new System.Drawing.Size(531, 206);
            lblDateT.Text = jobOffer.DateReply?.ToString("dd/MM/yyyy");
            CompanyDAO companyDAO = new CompanyDAO();
            companyAvatar = companyDAO.FetchImg(jobOffer.senderID, "Avatar");
            if (companyAvatar != null) ptbCompanyPicture.Image = companyAvatar;
            lblJobNameT.Text = "JOB OFFER!!!!!";
            lblFromT.Text = companyDAO.FetchName(jobOffer.senderID);
            lblSubjectT.Text = jobOffer.Subject;
            type = "Offer";

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            FAlertView fAlertView;
            if (type == "Alert")
            {
                fAlertView = new FAlertView(alert);
            }
            else fAlertView = new FAlertView(jobOffer);
            fAlertView.Show();
        }
    }
}
