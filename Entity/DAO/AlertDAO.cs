using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AlertDAO
    {
        FindingJob db = new FindingJob();
        public void InsertAlert(JobAlert alert)
        {
            db.JobAlerts.Add(alert);
            db.SaveChanges();
        }

        public List<JobAlert> FetchAlert(string recipientID)
        {
            List<JobAlert> alerts = new List<JobAlert>();
            var availableAlerts = db.JobAlerts.Where(j => j.recipientID == recipientID).ToList();
            alerts.AddRange(availableAlerts);
            return alerts;
        }

    }
}
