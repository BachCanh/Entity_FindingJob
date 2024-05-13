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
    public partial class FViewInterview : Form
    {
        Company company = new Company();
        public FViewInterview(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void FViewInterview_Load(object sender, EventArgs e)
        {
            flpBody.Controls.Clear();
            InterviewDAO interviewDAO = new InterviewDAO();
            List<Interview> interviews = new List<Interview>();
            interviews = interviewDAO.FetchInterviewByID(company.ID);
            foreach (Interview interview in interviews)
            {
                if (interview.DateInterview == mcpSchdule.SelectionRange.Start)
                {
                    UCInterview uc = new UCInterview(interview);
                    flpBody.Controls.Add(uc);
                    flpBody.Height += 85;
                }
            }
        }

        private void mcpSchdule_DateChanged(object sender, DateRangeEventArgs e)
        {
            FViewInterview_Load(sender, e);
        }
    }
}
