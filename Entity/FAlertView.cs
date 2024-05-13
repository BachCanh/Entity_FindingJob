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
    public partial class FAlertView : Form
    {
        private JobAlert alert = new JobAlert();
        private JobOffer JobOffer = new JobOffer();
        private CompanySendOfferDAO companySendOfferDAO = new CompanySendOfferDAO();
        private InterviewDAO interviewDAO = new InterviewDAO();
        private JobOfferDAO jobOfferDAO = new JobOfferDAO();
        private string jsID;
        private string companyID;
        private string jobID; 
        public FAlertView(JobAlert alert)
        {
            InitializeComponent();
            this.alert = alert;
            jsID = alert.recipientID;
            companyID = alert.senderID;
            jobID = alert.jobID;
            CompanyDAO companyDAO = new CompanyDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = companyDAO.FetchName(alert.senderID);
            lblContentT.Text = alert.content;
            lblDateT.Text = alert?.DateReply?.ToString("dd/MM/yyyy");
            lblSubjectT.Text = alert.Subject;
            lblJobT.Text = jobDAO.FetchName(alert.jobID);
            CheckStatus();
        }
        public FAlertView(JobOffer jobOffer)
        {
            InitializeComponent();
            this.JobOffer = jobOffer;
            jsID = jobOffer.recipientID;
            companyID = jobOffer.senderID;
            jobID = "";
            StartUp(jobOffer);
        }
        private void StartUp(JobOffer jobOffer)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = companyDAO.FetchName(JobOffer.senderID);
            lblContentT.Text = JobOffer.content;
            lblDateT.Text = jobOffer?.DateReply?.ToString("dd/MM/yyyy");
            lblSubjectT.Text = jobOffer.Subject;
            lblJobT.Text = "JOB OFFER!!";
            CheckStatus();
            EnableButton(jobOffer.Status);
        }
        private void EnableButton(string status)
        {
            if (status.Trim() == "Offering") 
            {
                btnAccept.Visible = true;
                btnReject.Visible = true;
                lblResponse.Visible = true;
                lblResponseT.Visible = true;
                lblResponseT.Text = "You have not reponsed yet!";
            }
            if (status.Trim() == "Accepted")
            {
                lblResponse.Visible = true;
                lblResponseT.Visible = true;
                lblResponseT.Text = "You have accepted this deal!";
            }
            if (status.Trim() == "Rejected")
            {
                lblResponse.Visible = true;
                lblResponseT.Visible = true;
                lblResponseT.Text = "You have rejected this deal";
            }
        }
        private void CheckStatus()
        {
            if (lblSubjectT.Text.ToLower() != "decline" || lblSubjectT.Text.ToLower() != "rejected")
            {

                btnInterview.Visible = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            FInterview fInterview;
            fInterview = new FInterview(jsID, companyID, jobID);
            fInterview.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            jobOfferDAO.OfferSetStatus(JobOffer.senderID, JobOffer.recipientID, "Accepted");
            companySendOfferDAO.OfferSetStatus(JobOffer.senderID, JobOffer.recipientID, "Accepted");
            interviewDAO.SetStatusForInterview(JobOffer.recipientID, "", "Accepted", JobOffer.senderID);
            this.JobOffer.Status = "Accepted";
            StartUp(this.JobOffer);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            jobOfferDAO.OfferSetStatus(JobOffer.senderID, JobOffer.recipientID, "Rejected");
            companySendOfferDAO.OfferSetStatus(JobOffer.senderID, JobOffer.recipientID, "Rejected");
            interviewDAO.SetStatusForInterview(JobOffer.recipientID, "", "Rejected", JobOffer.senderID);
            this.JobOffer.Status = "Rejected";
            this.btnAccept.Visible = false;
            this.btnReject.Visible = false;
            StartUp(this.JobOffer);
        }
    }
}
