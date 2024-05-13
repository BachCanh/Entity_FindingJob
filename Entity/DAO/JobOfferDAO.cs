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
            offer.id = GenerateID();
            db.JobOffers.Add(offer);
            db.SaveChanges();
        }

        private string GenerateID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 4);
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
                db.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Offer not found");
            }
        }
    }
}
