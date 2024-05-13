using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entity
{
    public class InterviewDAO
    {
        FindingJob db = new FindingJob();

        public void InsertInterview(Interview interview)
        {
            Interview inter = FetchInterview(interview.IdJSeeker, interview.companyID, interview.IdJob);
            if (inter is null)
            {
                db.Interviews.Add(interview);
                db.SaveChangesAsync();
                return;
            }
            else if (inter.Status.Trim().ToLower() == "waiting")
            {
                MessageBox.Show("There are a interview have already schedule with this jobseeker!!");
                return;
            }
        }

        public List<Interview> FetchInterviewByID(string companyID)
        {
            List<Interview> lst = new List<Interview>();
            lst = db.Interviews.Where(i => i.companyID == companyID).ToList();
            return lst;
        }

        public Interview FetchInterview(string jsID, string companyID, string jobID)
        {
            Interview interview = new Interview();
            interview = db.Interviews.FirstOrDefault(i => i.IdJob == jobID && i.companyID == companyID && i.IdJSeeker == jsID);
            return interview;
        }

        public void SetStatusForInterview(string jobseekerid, string jobid, string status, string companyID)
        {
            var inter = db.Interviews.FirstOrDefault(i => i.IdJSeeker == jobseekerid && i.IdJob == jobid && i.companyID == companyID);
            if (inter != null)
            {
                inter.Status = status;
                db.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Interview not found.");
            }
        }

        public void DeletedNewInterview(string jobseekerid, string jobid, string companyid)
        {
            db = new FindingJob();
            var inter = db.Interviews.FirstOrDefault(i => i.IdJSeeker == jobseekerid && i.IdJob == jobid && i.companyID == companyid && i.Status.Trim().ToLower() == "waiting");
            if (inter != null)
            {
                db.Interviews.Remove(inter);
                db.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Interview not found.");
            }
        }
    }
}
