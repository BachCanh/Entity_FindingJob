using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class UCEducation : UserControl
    {
        Education edu;
        FCVCreation_Edu fCV;
        public UCEducation(Education edu)
        {
            InitializeComponent();
            this.edu = edu;
            FillInfor();
            this.MaximumSize = new System.Drawing.Size(695, 120);
            this.MinimumSize = new System.Drawing.Size(695, 120);
            fCV = new FCVCreation_Edu(edu);
            fCV.btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            edu = fCV.EDU;
            FillInfor();
        }

        private void FillInfor()
        {
            lblDegreeAndSchool.Text = edu.Degree + ", " + edu.School;
            lblLocationAndPeriod.Text = edu.Location + " - " + "(" + edu.Datestart.ToString("dd/MM/yyyy") + " - " + edu.Dateend.ToString("dd/MM/yyyy") + ")";
            rtxtDescription.Text = edu.Description;
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            fCV.Show();
        }
    }
}
