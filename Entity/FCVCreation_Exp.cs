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
    public partial class FCVCreation_Exp : Form
    {
        private Experience exp = new Experience();
        public FCVCreation_Exp()
        {
            InitializeComponent();
        }

        public FCVCreation_Exp(Experience exp)
        {
            InitializeComponent();
            this.exp = exp;
            FillInfor();
        }

        private void FillInfor()
        {
            txtCompany.Text = exp.Company;
            txtJobName.Text = exp.Title;
            txtLocation.Text = exp.Location;
            rtxtAchieve.Text = exp.Achieve;
            dtpStartDate.Value = exp.Datestart;
            dtpEndDate.Value = exp.Dateend;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            exp = new Experience(txtJobName.Text, txtCompany.Text, txtLocation.Text, rtxtAchieve.Text, dtpStartDate.Value, dtpEndDate.Value);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Experience EXP
        { get { return exp; } }

    }

}
