using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class RatingDAO
    {
        FindingJob db = new FindingJob();
        public List<Rating> AllRatings(string comID)
        {
            List<Rating> ret = db.Ratings.Where(r => r.CompanyID == comID).ToList();
            if(ret.Count <= 0)
            {
                MessageBox.Show("There's none rating of this company!");
            }
            return ret;
        }

        public void RateCompany(Rating rate)
        {
            db.Ratings.Add(rate);
            db.SaveChanges();
        }
    }
}
