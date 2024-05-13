using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class ApplyDAO
    {
        FindingJob db = new FindingJob();

        public void InsertApply(Apply apply)
        {
            using (var db = new FindingJob())
            {
                db.Applies.Add(apply);
                db.SaveChanges();
            }
        }

        public List<Apply> AllApplies(string jobID)
        {
            List<Apply> applies = new List<Apply>();

            applies = db.Applies.Where(apply => apply.JobID == jobID && apply.Status.Trim().ToLower() != "done").ToList();
            return applies;
        }

        public void UpdateStatus(string status, Apply apply)
        {
            var job = db.Applies.FirstOrDefault(j => j.JobSeekerID == apply.JobSeekerID && j.JobID == apply.JobID);
            if (job != null)
            {
                job.Status = status;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Apply not found.");
            }
        }

        public List<string> FetchStatusApply(string jobID)
        {
            List<string> status = new List<string>();

            var list = db.Applies.Where(apply => apply.JobID == jobID)
                            .Select(apply => apply.Status)
                            .ToList();
            status.AddRange(list);
            return status;
        }

        public bool CheckApply(string jobID, string jsid)
        {
            bool exists = db.Applies.Any(apply => apply.JobID == jobID && apply.JobSeekerID == jsid);

            return exists;
        }

    }
}
