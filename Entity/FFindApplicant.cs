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
    public partial class FFindApplicant : Form
    {
        string companyid;
        List<JobPreference> jobpreference = new List<JobPreference>();
        JobPreferenceDAO jobpreferenceDAO = new JobPreferenceDAO();
        CompanySendOfferDAO companysendOffer = new CompanySendOfferDAO();
        public FFindApplicant(string companyid)
        {
            this.companyid = companyid;
            InitializeComponent();
            jobpreferenceDAO.FetchAllJobPreference(ref jobpreference);
            FillCandicate(jobpreference);
        }
        private void FillCandicate(List<JobPreference> lst)
        {
            pnSubBody.Controls.Clear();
            foreach (JobPreference jp in lst)
            {
                //if (companysendOffer.AlreadySent(jp.JobSeekerID, companyid) == false)
                //{
                    UCCandidate uCCandidate = new UCCandidate(jp, companyid);
                    uCCandidate.SendClickHandleHandle += HandleLast;
                    pnSubBody.Controls.Add(uCCandidate);
                //}

            }
        }
        private void HandleLast(object sender, EventArgs e)
        {
            UCCandidate uCCandidate = sender as UCCandidate;
            jobpreference.Remove(uCCandidate.jobPreference);
            pnSubBody.Controls.Remove(uCCandidate);
        }
        private List<JobPreference> SearchNameJS(string search)
        {
            JobSeekerDAO jsDAO = new JobSeekerDAO();
            return jobpreference.Where(jp => jsDAO.FetchName(jp.JobSeekerID).ToLower().Contains(search)).ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillCandicate(SearchNameJS(txtSearch.Text.ToLower()));
            }
        }
    }
}
