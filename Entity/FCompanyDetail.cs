using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Entity
{
    public partial class FCompanyDetail : Form
    {
        Company company = new Company();
        CompanyDAO companyDAO = new CompanyDAO();
        public FCompanyDetail(string companyid)
        {
            InitializeComponent();
            Turnoff();
            company = companyDAO.FetchCompanyInformationBasedOnID(companyid);
            FillInfor();
        }
        private void Turnoff()
        {
            txtCompanyName.Enabled = false;
            txtAddress.Enabled = false;
            cbbCompanyType.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtDetail.Enabled = false;
            txtWebsiteLink.Enabled = false;
            cbbWTB.Enabled = false;
            cbbWTEnd.Enabled = false;
            cbbCompanySize.Enabled = false;
        }
        private void FillInfor()
        {
            this.txtCompanyName.Text = company.Name;
            this.txtAddress.Text = company.Address;
            this.txtPhoneNumber.Text = company.Phonenumber;
            this.txtEmail.Text = company.Email;
            this.cbbCompanyType.Text = company.CompanyType;
            this.cbbCompanySize.Text = company.CompanySize;
            this.cbbWTB.Text = company.WorkingTimeBegin;
            this.cbbWTEnd.Text = company.WorkingTimeEnd;
            this.txtWebsiteLink.Text = company.WebsiteLink;
            if (company.Avatar != null) ptbAvatar.Image = ImageHandler.ByteArrayToImage(company.Avatar);
        }
    }
}
