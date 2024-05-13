using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class CVDao
    {
        FindingJob db = new FindingJob();
        public void FetchAllInformationOfCV(string jobseekerid,ref CV cv)
        {
            cv = db.CVs.FirstOrDefault(c => c.JobSeekerID == jobseekerid);
        }

        public void UpdateCV(CV cv)
        {
            CV oldCV = db.CVs.FirstOrDefault(c => c.JobSeekerID == cv.JobSeekerID);
            if (oldCV != null)
            {
                oldCV.CV1 = cv.CV1;
                oldCV.CVPicture = cv.CVPicture;
                oldCV.LikeCount = cv.LikeCount;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("JobSeerek CV not found");
            }
        }

    }
}
