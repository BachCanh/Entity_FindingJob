using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class CompanyAddtionalImageDAO
    {
        FindingJob db = new FindingJob();
        public List<Image> FetchAllPictures(string companyid)
        {
            List<Image> list = new List<Image>();

            var company = db.ImgCompanies.FirstOrDefault(img => img.companyID == companyid);

            // Check if the company exists and if it has an image
            if (company != null)
            {
                if (company.ImgID1 != null && company.ImgID1.Length > 0)
                {
                    list.Add(ImageHandler.ByteArrayToImage(company.ImgID1));
                }
                if (company.ImgID2 != null && company.ImgID2.Length > 0)
                {
                    list.Add(ImageHandler.ByteArrayToImage(company.ImgID2));
                }
                if (company.ImgID3 != null && company.ImgID3.Length > 0)
                {
                    list.Add(ImageHandler.ByteArrayToImage(company.ImgID3));
                }
                if (company.ImgID4 != null && company.ImgID4.Length > 0)
                {
                    list.Add(ImageHandler.ByteArrayToImage(company.ImgID4));
                }
                if (company.ImgID5 != null && company.ImgID5.Length > 0)
                {
                    list.Add(ImageHandler.ByteArrayToImage(company.ImgID5));
                }
            }
            else
            {
                MessageBox.Show("Company not found!");
            }

            return list;
        }

        public void InsertImage(string companyid, List<Image> images)
        {
            DeleteImage(companyid);

            List<byte[]> imageBytes = ImageHandler.ConvertListImgToListByte(images);

            while (imageBytes.Count < 5)
            {
                imageBytes.Add(new byte[0]);
            }

            // Create new ImgCompany entity
            var imgCompany = new ImgCompany
            {
                companyID = companyid,
                ImgID1 = imageBytes.ElementAtOrDefault(0),
                ImgID2 = imageBytes.ElementAtOrDefault(1),
                ImgID3 = imageBytes.ElementAtOrDefault(2),
                ImgID4 = imageBytes.ElementAtOrDefault(3),
                ImgID5 = imageBytes.ElementAtOrDefault(4)
            };

            db.ImgCompanies.Add(imgCompany);
            db.SaveChanges();
        }

        public void DeleteImage(string companyid)
        {
            var imgCompany = db.ImgCompanies.FirstOrDefault(img => img.companyID == companyid);
            if (imgCompany != null)
            {
                db.ImgCompanies.Remove(imgCompany);
                db.SaveChanges();
            }
        }


    }
}
