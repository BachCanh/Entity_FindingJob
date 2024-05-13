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
    public partial class FAlert : Form
    {
        public Job job = new Job();
        List<JobAlert> alerts = new List<JobAlert>();
        List<JobOffer> jobOffers = new List<JobOffer>();
        JobSeeker seeker = new JobSeeker();
        public FAlert(JobSeeker jobSeeker)
        {
            InitializeComponent();
            seeker = jobSeeker;
            AlertDAO alertDAO = new AlertDAO();
            this.alerts = alertDAO.FetchAlert(jobSeeker.ID);
            JobOfferDAO jobOfferDAO = new JobOfferDAO();
            this.jobOffers = jobOfferDAO.FetchOffers(jobSeeker.ID);
            FillInformation();
            
        }
        public void FillInformation()
        {
            foreach (JobAlert alert in alerts)
            {
                UCAlert uCAlert = new UCAlert(alert);
                flpAlert.Controls.Add(uCAlert);
                flpAlert.Height += 255;
            }
            foreach (JobOffer offer in jobOffers)
            {
                UCAlert uCAlert = new UCAlert(offer);
                flpAlert.Controls.Add(uCAlert);
                flpAlert.Height += 255;
            }
        }
        private void FillInfor(List<JobAlert> alertlist)
        {
            flpAlert.Controls.Clear();
            foreach (JobAlert alert in alertlist)
            {
                UCAlert uCAlert = new UCAlert(alert);
                flpAlert.Controls.Add(uCAlert);
                flpAlert.Height += 255;
            }
        }

        private List<JobAlert> SearchAlert(string search)
        {
            JobDAO jDAO = new JobDAO();
            return alerts.Where(alert => jDAO.FetchName(alert.jobID).ToLower().Contains(search)).ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillInfor(SearchAlert(txtSearch.Text.ToLower()));
            }
        }
    }
}
