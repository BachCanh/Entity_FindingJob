using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class JobDAO
    {
        FindingJob db = new FindingJob();
        public List<Job> FetchAvailableJobs()
        {
            List<Job> jobs = new List<Job>();

            var availableJobs = db.Jobs.Where(j => j.status == "waiting")
                                        .OrderByDescending(j => j.DatePublish)
                                        .ToList();

            jobs.AddRange(availableJobs);

            return jobs;
        }

        public List<Job> FetchCompanyJob(string companyId)
        {
            List<Job> jobs = new List<Job>();

            // Retrieve jobs associated with the specified company ID
            jobs = db.Jobs.Where(j => j.CompanyID == companyId)
                          .ToList();

            return jobs;
        }

        public string FetchName(string id)
        {
            string name = string.Empty;
            name = db.Jobs.Where(c => c.JobID == id)
                               .Select(c => c.JobName).FirstOrDefault();
            return name;
        }

        private string GenerateJobID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 4);
        }


        public string AddNewJob(Job job)
        {
            job.JobID = GenerateJobID();

            db.Jobs.Add(job);

            db.SaveChanges();

            return job.JobID;
        }

        public void DoneJob(string jobid)
        {
            var job = db.Jobs.FirstOrDefault(j => j.JobID == jobid);
            if (job != null)
            {
                job.status = "done";
                job.DateEnd = DateTime.Now;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Job not found.");
            }
        }

        public void EditJob(Job job)
        {
            var existingJob = db.Jobs.FirstOrDefault(j => j.JobID == job.JobID);
            if (existingJob != null)
            {
                existingJob.JobName = job.JobName;
                existingJob.Position = job.Position;
                existingJob.Salary = job.Salary;
                existingJob.description = job.description;
                existingJob.requirement = job.requirement;
                existingJob.benefit = job.benefit;
                existingJob.DateEnd = job.DateEnd;
                existingJob.WorkingForm = job.WorkingForm;

                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Job not found.");
            }
        }

        private static List<string> JobNameLike(string jobName)
        {
            // Split the job name into individual words
            string[] wordsArray = jobName.Split(' ');

            // Trim each word in the array
            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordsArray[i] = wordsArray[i].Trim();
            }

            // Convert the array to a list
            List<string> wordsList = new List<string>(wordsArray);

            return wordsList;
        }

        public void FetchRelatedJob(string jobname, List<Job> relatedJobs, string jobid)
        {
            foreach (string name in JobNameLike(jobname))
            {
                // Query jobs with similar names but exclude the current job
                var jobs = db.Jobs
                    .Where(j => j.status == "waiting" && j.JobID != jobid && j.JobName.Contains(name))
                    .ToList();

                relatedJobs.AddRange(jobs);
            }
        }
    }
}
