using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class CompanySendOfferDAO
    {
        FindingJob db = new FindingJob();
        public void Insert(CompanySendOffer entity)
        {
            entity.Status = "Offering";
            db.CompanySendOffers.Add(entity);
            db.SaveChangesAsync();
        }

        public bool AlreadySent(string jobseekerId, string companyId)
        {
            using (var db = new FindingJob()) // Replace FindingJob with your generated context class
            {
                // Retrieve the status for the given jobseekerId and companyId
                var status = db.CompanySendOffers
                    .Where(cso => cso.JobSeekerID == jobseekerId && cso.CompanyID == companyId)
                    .Select(cso => cso.Status)
                    .FirstOrDefault();

                // Check if the status is "Rejected" or empty
                if (string.IsNullOrEmpty(status) || status == "Rejected")
                {
                    return false;
                }

                return true;
            }
        }

        public void OfferSetStatus(string companyid, string jobseekerid, string status)
        {
            var cso = db.CompanySendOffers.FirstOrDefault(c => c.CompanyID == companyid && c.JobSeekerID == jobseekerid);
            if (cso != null)
            {
                if(status.ToLower() == "rejected")
                {
                    db.CompanySendOffers.Remove(cso);
                    db.SaveChangesAsync();
                }
            }
            else
            {
                MessageBox.Show("Offer not found");
            }
        }   

    }
}
