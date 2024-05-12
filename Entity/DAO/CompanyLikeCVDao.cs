using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CompanyLikeCVDao
    {
        FindingJob db = new FindingJob();
        public HashSet<JobSeeker> FetchCompayLikeCV(string companyid)
        {
            Company company = db.Companies.FirstOrDefault(c => c.ID == companyid);
            HashSet<JobSeeker> js = new HashSet<JobSeeker>();
            if(company != null)
            {
                foreach (var jobSeekerCV in company.CompanyLikeJobSeekerCV)
                {
                    js.Add(jobSeekerCV);
                }
            }
            return js;
        }

        public void InserCompanyLikeCV(string companyid, string jsid)
        {
            Company company = db.Companies.FirstOrDefault(c => c.ID == companyid);
            JobSeeker js = db.JobSeekers.FirstOrDefault(c => c.ID == jsid);

            if (company != null && js != null) 
            {
                company.CompanyLikeJobSeekerCV.Add(js);
                db.SaveChanges();
            }
        }

        public void RemoveCompanyLikeCV(string companyid, string jsid)
        {
            Company company = db.Companies.FirstOrDefault(c => c.ID == companyid);
            JobSeeker js = db.JobSeekers.FirstOrDefault(c => c.ID == jsid);

            if (company != null && js != null)
            {
                company.CompanyLikeJobSeekerCV.Remove(js);
                db.SaveChanges();
            }
        }
    }
}
