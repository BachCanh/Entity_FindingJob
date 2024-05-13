using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entity
{
    public partial class FProfileCompany : Form
    {
        Company company = new Company();
        CompanyDAO companyDao = new CompanyDAO();
        List<Image> imageList;
        CompanyAddtionalImageDAO addtional = new CompanyAddtionalImageDAO();
        UCCarousel uCCarousel;
        public FProfileCompany(Company company)
        {
            InitializeComponent();
            Enable_Save_Click();
            this.company = companyDao.FetchCompanyInformationBasedEmail(company.Email);
            imageList = addtional.FetchAllPictures(company.ID);
            FillInfor();
        }
        private void FillInfor()
        {
            this.txtCompanyName.Text = company.Name;
            this.txtAddress.Text = company.Address;
            this.txtPhoneNumber.Text = company.Phonenumber;
            this.txtEmail.Text = company.Email;
            this.cbbCompanyType.Text = company.CompanyType;
            this.cbbCompanySize.Text = company.CompanySize;
            this.txtTaxIdentification.Text = company.TaxIdentification;
            this.cbbWTB.Text = company.WorkingTimeBegin;
            this.cbbWTEnd.Text = company.WorkingTimeEnd;
            this.txtWebsiteLink.Text = company.WebsiteLink;
            this.txtDetail.Text = company.Detail;
            if (company.Avatar != null) ptbAvatar.Image = ImageHandler.ByteArrayToImage(company.Avatar);
            if (company.BusinessLicense != null) ptbLicense.Image = ImageHandler.ByteArrayToImage(company.BusinessLicense);

            // Position and size of the UCCarousel control
            uCCarousel = new UCCarousel(imageList);
            this.Controls.Add(uCCarousel);
            uCCarousel.Location = new Point(43, 868);
        }
        private void Enable_Save_Click()
        {
            this.btnEdit.Visible = true;
            this.btnChoosePicture.Visible = false;
            this.btnSave.Visible = false;
            this.btnCancel.Visible = false;
            this.btnChooseLicense.Visible = false;
            txtCompanyName.Enabled = false;
            txtAddress.Enabled = false;
            cbbCompanyType.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtDetail.Enabled = false;
            txtTaxIdentification.Enabled = false;
            txtWebsiteLink.Enabled = false;
            cbbWTB.Enabled = false;
            cbbWTEnd.Enabled = false;
            cbbCompanySize.Enabled = false;
            btnAdd.Visible = false;
            btnRemove.Visible = false;
        }
        private void Enable_Edit_Click()
        {
            this.btnChoosePicture.Location = new Point(975, 269);
            this.btnChoosePicture.Visible = true;
            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;
            this.btnCancel.Visible = true;
            this.btnChooseLicense.Visible = true;
            txtCompanyName.Enabled = true;
            txtAddress.Enabled = true;
            cbbCompanyType.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNumber.Enabled = true;
            cbbCompanySize.Enabled = true;
            txtDetail.Enabled = true;
            txtTaxIdentification.Enabled = true;
            txtWebsiteLink.Enabled = true;
            cbbWTB.Enabled = true;
            cbbWTEnd.Enabled = true;
            btnAdd.Visible = true;
            btnRemove.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Edit_Click();
        }
        private Company CompanyCreation()
        {
            byte[] AvatarData = null;
            byte[] BusinessData = null;
            List<Image> Images = new List<Image>();
            if (ptbAvatar.Image != null)
            {
                AvatarData =ImageHandler.ImageToByteArray( ptbAvatar.Image);
            }
            if (ptbLicense.Image != null)
            {
                BusinessData = ImageHandler.ImageToByteArray(ptbLicense.Image);
            }
            Company cpn = new Company(company.ID, txtCompanyName.Text, txtEmail.Text, txtAddress.Text, cbbCompanyType.Text, cbbCompanySize.Text,txtPhoneNumber.Text,

                                     cbbWTB.Text,AvatarData,cbbWTEnd.Text, txtTaxIdentification.Text,BusinessData,txtDetail.Text,txtWebsiteLink.Text);

            return cpn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Enable_Save_Click();
            Company newcompany = CompanyCreation();
            companyDao.UpdateCompany(newcompany);
            addtional.InsertImage(company.ID, uCCarousel.images);
            imageList = uCCarousel.images;
            this.company = newcompany;
        }

        private void btnSave_Click_Error(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is Guna2TextBox txt)
                {
                    SetError(txt);
                }
                if(control is Guna2ComboBox cbb)
                {
                    SetError(cbb);
                }
            }
            foreach (Control control in this.Controls)
            {
                if (AnyErrors(control))
                {
                    return;
                }
            }
            btnSave_Click(sender, e);
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            ImageHandler.ChoosePicture(ref ptbAvatar);
        }

        private void btnChooseLicense_Click(object sender, EventArgs e)
        {
            ImageHandler.ChoosePicture(ref ptbLicense);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FillInfor(); // Reload tshe form with the original data
            Enable_Save_Click(); // Re-enable the form for editing
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uCCarousel.Add();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uCCarousel.Delete();
        }

        private void FProfileCompany_Load(object sender, EventArgs e)
        {

        }

        public bool AnyErrors(Control control)
        {
            // Check if the control has an ErrorProvider and if it has any errors
            if (control is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                if (!string.IsNullOrEmpty(epTxt.GetError(txt)))
                {
                    return true;
                }
            }

            if (control is Guna.UI2.WinForms.Guna2ComboBox cbb)
            {
                if (!string.IsNullOrEmpty(epCbb.GetError(cbb)))
                {
                    return true;
                }
            }


            foreach (Control childControl in control.Controls)
            {
                if (AnyErrors(childControl))
                {
                    return true;
                }
            }

            return false;
        }

        private void SetError(Guna2TextBox txt)
        {
            if(txt.Text.Length < 1)
            {
                epTxt.SetError(txt, "Textbox cannot be empty");
            }
            else
            {
                epTxt.SetError(txt, "");
            }
        }

        private void SetError(Guna2ComboBox cbb)
        {
            if (cbb.SelectedIndex < 0)
            {
                epTxt.SetError(cbb, "Must choose something!!!");
            }
            else
            {
                epTxt.SetError(cbb, "");
            }
        }

    }
}
