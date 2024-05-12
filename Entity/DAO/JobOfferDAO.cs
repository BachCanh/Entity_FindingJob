using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class JobOfferDAO
    {
        FindingJob db = new FindingJob();
        public void InsertOffer(JobOffer offer)
        {
            db.JobOffers.Add(offer);
            db.SaveChanges();
        }

        public List<JobOffer> FetchOffers(string jobseekerid)
        {
            List<JobOffer> offers = db.JobOffers.Where(o => o.recipientID == jobseekerid).ToList();
            return offers;
        }
        public void OfferSetStatus(string companyid, string jobseekerid, string status)
        {
            var jo = db.JobOffers.FirstOrDefault(c => c.senderID == companyid && c.recipientID == jobseekerid);
            if (jo != null)
            {
                jo.Status = status;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Offer not found");
            }
        }
    }
}
