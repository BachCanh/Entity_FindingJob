using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class UCExperience : UserControl
    {
        Experience exp;
        FCVCreation_Exp fCV;
        public UCExperience(Experience exp)
        {
            InitializeComponent();
            this.exp = exp;
            this.MaximumSize = new System.Drawing.Size(695, 120);
            this.MinimumSize = new System.Drawing.Size(695, 120);
            FillInfor();
            fCV = new FCVCreation_Exp(exp);
            fCV.btnAdd.Click += btnAdd_Click;
        }

        private void FillInfor()
        {
            lblTitleAndCompany.Text = exp.Title + ", " + exp.Company;
            lblLocationAndPeriod.Text = exp.Location + " - " + "(" + exp.Datestart.ToString("dd/MM/yyyy") + " - " + exp.Dateend.ToString("dd/MM/yyyy") + ")";
            rtxtAchieve.Text = exp.Achieve;
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            fCV.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            exp = fCV.EXP;
            FillInfor();
        }
    }
}
