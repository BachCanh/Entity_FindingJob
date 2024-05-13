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
            if (FetchInterview(interview.IdJSeeker, interview.companyID, interview.IdJob).Status.Trim().ToLower() == "waiting")
            {
                MessageBox.Show("There are a interview have already schedule with this jobseeker!!");
                return;
            }
            db.Interviews.Add(interview);
            db.SaveChanges();
        }

        public List<Interview> FetchInterviewByID(string companyID)
        {
            List<Interview> lst = new List<Interview>();
            lst = db.Interviews.Where(i => i.companyID == companyID).ToList();
            return lst;
        }

        public Interview FetchInterview(string jsID, string companyID, string jobID)
        {
            return db.Interviews.FirstOrDefault(i => i.IdJob == jobID && i.companyID == companyID && i.IdJSeeker == jsID);
        }

        public void SetStatusForInterview(string jobseekerid, string jobid, string status, string companyID)
        {
            var inter = db.Interviews.FirstOrDefault(i => i.IdJSeeker == jobseekerid && i.IdJob == jobid && i.companyID == companyID);
            if (inter != null)
            {
                inter.Status = status;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Interview not found.");
            }
        }

        public void DeletedNewInterview(string jobseekerid, string jobid, string companyid)
        {
            var inter = db.Interviews.FirstOrDefault(i => i.IdJSeeker == jobseekerid && i.IdJob == jobid && i.companyID == companyid);
            if (inter != null)
            {
                db.Interviews.Remove(inter);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Interview not found.");
            }
        }
    }
}
