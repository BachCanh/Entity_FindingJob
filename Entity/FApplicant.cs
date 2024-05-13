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
    public partial class FApplicant : Form
    {
        Company company;
        ApplyDAO applyDAO = new ApplyDAO();
        List<Apply> applies = new List<Apply> { };
        Job job;
        public FApplicant(Job job)
        {
            InitializeComponent();
            this.job = job;
            applies = applyDAO.AllApplies(job.JobID);
            FillInfor(applies);
        }

        private void FillInfor(List<Apply> applylist)
        {
            flpApplicant.Controls.Clear();
            foreach (Apply apply in applylist)
            {
                UCApplicant uCApplicant = new UCApplicant(apply, job);
                uCApplicant.SendClickHandle += SendClickHandle_Handle;
                flpApplicant.Controls.Add(uCApplicant);
                flpApplicant.Height += 600;
            }
        }
        private void SendClickHandle_Handle(object sender, EventArgs e)
        {
            UCApplicant uCApplicant = sender as UCApplicant;
            flpApplicant.Controls.Remove(uCApplicant);
        }
        private List<Apply> SearchNameJS(string search)
        {
            JobSeekerDAO jsDAO = new JobSeekerDAO();
            return applies.Where(apply => jsDAO.FetchName(apply.JobSeekerID).ToLower().Contains(search)).ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillInfor(SearchNameJS(txtSearch.Text));
            }
        }

        private void FApplicant_Load(object sender, EventArgs e)
        {

        }
    }
}
