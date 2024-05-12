using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class JobPreferenceDAO
    {
        FindingJob db = new FindingJob();
        public JobPreference FetchJobPreference(string jobseekerid)
        {
            return db.JobPreferences.FirstOrDefault(jp => jp.JobSeekerID == jobseekerid);
        }
        public void FetchAllJobPreference(List<JobPreference> list)
        {
            list = db.JobPreferences.ToList();
        }
        public void InsertJobPreference(JobPreference jobPreference)
        {
            db.JobPreferences.Add(jobPreference);
            db.SaveChanges();
        }
        public void UpdateJobPreference(JobPreference jobPreference)
        {
            using (var db = new FindingJob()) // Replace FindingJob with your generated context class
            {
                var existingJobPreference = db.JobPreferences.FirstOrDefault(jp => jp.JobSeekerID == jobPreference.JobSeekerID);

                if (existingJobPreference != null)
                {
                    // Update properties of the existing JobPreference entity
                    existingJobPreference.Title = jobPreference.Title;
                    existingJobPreference.Position = jobPreference.Position;
                    existingJobPreference.CompanyType = jobPreference.CompanyType;
                    existingJobPreference.WorkingForm = jobPreference.WorkingForm;
                    existingJobPreference.CompanySize = jobPreference.CompanySize;
                    existingJobPreference.Location = jobPreference.Location;
                    existingJobPreference.Salary = jobPreference.Salary;
                    existingJobPreference.Deadline = jobPreference.Deadline;
                    existingJobPreference.Skill1 = jobPreference.Skill1;
                    existingJobPreference.Skill2 = jobPreference.Skill2;
                    existingJobPreference.Skill3 = jobPreference.Skill3;

                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("JobSeeker's job preference not found.");
                }
            }
        }


    }
}
