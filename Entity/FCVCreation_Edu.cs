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
    public partial class FCVCreation_Edu : Form
    {
        private Education education = new Education();
        public FCVCreation_Edu()
        {
            InitializeComponent();
        }

        public FCVCreation_Edu(Education edu)
        {
            InitializeComponent();
            this.education = edu;
            FillInfor();
        }

        private void FillInfor()
        {
            txtSchool.Text = education.School;
            txtLocation.Text = education.Location;
            txtDegree.Text = education.Degree;
            rtxtDecription.Text = education.Description;
            dtpStartDate.Value = education.Datestart;
            dtpEndDate.Value = education.Dateend;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            education = new Education(txtSchool.Text, txtDegree.Text, txtLocation.Text, rtxtDecription.Text, dtpStartDate.Value, dtpEndDate.Value);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Education EDU
        { get { return education; } }
    }
}
