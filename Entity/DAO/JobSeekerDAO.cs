using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class JobSeekerDAO
    {
        FindingJob db = new FindingJob();
        public JobSeeker FetchJobseekerWithEmail(string email)
        {
            return db.JobSeekers.FirstOrDefault(x => x.Email == email);
        }

        public string FetchName(string id)
        {
            string name = string.Empty;
            name = db.JobSeekers.Where(c => c.ID == id)
                               .Select(c => c.Name).FirstOrDefault();
            return name;
        }
        public string FetchJSEmail(string id)
        {
            string email = string.Empty;
            email = db.JobSeekers.Where(c => c.ID == id)
                               .Select(c => c.Email).FirstOrDefault();
            return email;
        }
        public DateTime FetchBdate(string id)
        {
            DateTime dateOfBirth;
            var dateOfBirthNullable = db.JobSeekers.Where(c => c.ID == id)
                                                   .Select(c => c.DateOfBirth)
                                                   .FirstOrDefault();
            dateOfBirth = dateOfBirthNullable ?? DateTime.MinValue;
            return dateOfBirth;
        }

        public Image FetchImg(string id, string whattotake)
        {
            IQueryable<byte[]> query = null;

            query = db.JobSeekers.Where(c => c.ID == id)
                                .Select(c => c.Avatar);
            return ImageHandler.ByteArrayToImage(query.FirstOrDefault());
        }


        public byte[] FetchCV(string id)
        {
            IQueryable<byte[]> query = null;

            query = db.JobSeekers.Where(c => c.ID == id)
                                .Select(c => c.Avatar);
            return query.FirstOrDefault();
        }
        public void UpdateJobSeeker(JobSeeker jobseeker)
        {
            var existingJobSeeker = db.JobSeekers.FirstOrDefault(j => j.ID == jobseeker.ID);
            if (existingJobSeeker != null)
            {
                existingJobSeeker.Name = jobseeker.Name;
                existingJobSeeker.Email = jobseeker.Email;
                existingJobSeeker.Address = jobseeker.Address;
                existingJobSeeker.PhoneNumber = jobseeker.PhoneNumber;
                existingJobSeeker.DateOfBirth = jobseeker.DateOfBirth;
                existingJobSeeker.NationalID = jobseeker.NationalID;
                existingJobSeeker.Avatar = jobseeker.Avatar;
                existingJobSeeker.Gender = jobseeker.Gender;

                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("JobSeeker not found.");
            }
        }

    }
}
