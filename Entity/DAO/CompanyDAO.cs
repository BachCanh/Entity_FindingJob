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
    public class CompanyDAO
    {
        FindingJob db = new FindingJob();
        public Company FetchCompanyInformationBasedOnID(string companyId)
        {
            return db.Companies.FirstOrDefault(c => c.ID == companyId);
        }

        public Company FetchCompanyInformationBasedEmail(string email)
        {
            return db.Companies.FirstOrDefault(c => c.Email == email);
        }

        public void UpdateCompany(Company updatedCompany)
        {
            var existingCompany = db.Companies.FirstOrDefault(c => c.ID == updatedCompany.ID);
            if (existingCompany != null)
            {
                // Update all properties of the existing company with the values from the updated company
                existingCompany.Name = updatedCompany.Name;
                existingCompany.Email = updatedCompany.Email;
                existingCompany.Address = updatedCompany.Address;
                existingCompany.CompanyType = updatedCompany.CompanyType;
                existingCompany.CompanySize = updatedCompany.CompanySize;
                existingCompany.Phonenumber = updatedCompany.Phonenumber;
                existingCompany.WorkingTimeBegin = updatedCompany.WorkingTimeBegin;
                existingCompany.WorkingTimeEnd = updatedCompany.WorkingTimeEnd;
                existingCompany.Detail = updatedCompany.Detail;
                existingCompany.WebsiteLink = updatedCompany.WebsiteLink;
                existingCompany.Avatar = updatedCompany.Avatar;
                existingCompany.BusinessLicense = updatedCompany.BusinessLicense;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Company not found.");
            }
        }

        public string FetchName(string companyID)
        {
            string name = string.Empty;

            name = db.Companies.Where(c => c.ID == companyID)
                               .Select(c => c.Name).FirstOrDefault();
            return name;
        }

        public Image FetchImg(string companyId, string whattotake)
        {
            IQueryable<byte[]> query = null;

            switch (whattotake)
            {
                case "Avatar":
                    query = db.Companies.Where(c => c.ID == companyId)
                                        .Select(c => c.Avatar);
                    break;
                case "BusinessLicense":
                    query = db.Companies.Where(c => c.ID == companyId)
                                        .Select(c => c.BusinessLicense);
                    break;
                default:
                    throw new ArgumentException("Invalid value for whattotake parameter.");
            }
            return ImageHandler.ByteArrayToImage(query.FirstOrDefault());
        }

        public string GetCompanyWithMostRecruitedCandidates()
        {
            string companyId = null;

            // Execute the SQL query to call the function and retrieve the result
            var result = db.Database.SqlQuery<int>("SELECT TOP(1) IDcompany FROM GetCompanyWithMostRecruitedCandidates()").FirstOrDefault();

            // Assign the result to the companyId variable
            companyId = result.ToString();

            return companyId;
        }

    }
}
