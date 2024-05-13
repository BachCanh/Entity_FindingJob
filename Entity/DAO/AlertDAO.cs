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
            alert.id = GenerateID();
            db.JobAlerts.Add(alert);
            db.SaveChanges();
        }

        private string GenerateID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 4);
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
