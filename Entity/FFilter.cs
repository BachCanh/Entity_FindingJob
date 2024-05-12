using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class FFilter : Form
    {
        int from = 500;
        int to = 10000;
        private int buttonClickCount = 0;
        string salary = string.Empty;
        List<Job> jobs = new List<Job>();
        List<Job> jobsdefault = new List<Job>();
        public event EventHandler<List<Job>> ListReady;

        public FFilter(List<Job> jobs)
        {
            InitializeComponent();
            this.jobsdefault = jobs;
            this.jobs = jobs;

            salary = @"${from} - ${to}";
            SetAllButtonClick(pnBody);
        }

        public void SetAllButtonClick(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += button_Click;
                }
                else if (control is Panel)
                    SetAllButtonClick((Panel)control);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Tag == null)
            {
                clickedButton.Tag = 0;
            }

            int buttonClickCount = (int)clickedButton.Tag;

            buttonClickCount++;

            if (buttonClickCount == 2)
            {
                clickedButton.Image = Properties.Resources.plus;
                clickedButton.BackColor = Color.Transparent;
                buttonClickCount = 0;
            }
            else if (buttonClickCount == 1)
            {
                clickedButton.Image = Properties.Resources.approve;
                clickedButton.BackColor = Color.FromArgb(248, 212, 187);
            }
            clickedButton.Tag = buttonClickCount;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            from = 500 + tbFrom.Value * 500;
            if (from >= to)
            {
                from = to - 500;

            }
            salary = @"${from} - ${to}";
            lblSalaryRange.Text = salary;
            if (from >= to)
            {
                tbTo.Value = tbFrom.Value + 1;
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            to = 10000 - Math.Abs(10 - tbTo.Value) * 500;
            if (to <= from)
            {
                to = from + 500;

            }
            salary = @"${from} - ${to}";
            lblSalaryRange.Text = salary;
            if (to <= from)
            {
                tbFrom.Value = tbTo.Value - 1;
            }
        }

        private List<string> LevelSearch()
        {
            List<string> search = new List<string>();
            foreach (Control control in pnLevel.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    if (btn.Tag != null)
                        if (btn.Tag.ToString() == "1")
                            search.Add(btn.Text);
                }
            }
            return search;
        }

        private List<string> TypeSearch()
        {
            List<string> search = new List<string>();
            foreach (Control control in pnType.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    if (btn.Tag != null)
                        if (btn.Tag.ToString() == "1")
                            search.Add(btn.Text);
                }
            }
            return search;
        }
        private void PassListBackToListener()
        {
            ListReady?.Invoke(this, jobs);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            jobs = jobsdefault;
            List<string> Search = LevelSearch();
            if (Search.Count > 0)
            {
                jobs = jobs.Where(job => Search.Contains(job.Position)).ToList();
            }
            Search = TypeSearch();
            CompanyDAO companyDAO = new CompanyDAO();
            if (Search.Count > 0)
            {
                jobs = jobs.Where(job => Search.Contains(companyDAO.FetchCompanyInformationBasedOnID(job.CompanyID).CompanyType)).ToList();
            }
            jobs = jobs.Where(job =>
            {
                float salary;
                if (float.TryParse(job.Salary.ToString(), out salary))
                {
                    return salary <= to && salary >= from;
                }
                else
                {
                    return false;
                }
            }).ToList();
            PassListBackToListener();
            this.Hide();
        }
        private void ResetAllControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Button button)
                {
                    button.Image = Properties.Resources.plus; // Assuming this is the default image
                    button.BackColor = Color.Transparent; // Assuming this is the default background color
                    button.Tag = 0;
                }
                else if (control is Panel)
                {
                    ResetAllControls(control);
                }
            }

            tbFrom.Value = 0; // Assuming 0 is the default value
            tbTo.Value = 10; // Assuming 10 is the default value

            from = 500; // Assuming 500 is the default value for 'from'
            to = 10000; // Assuming 10000 is the default value for 'to'

            salary = @"${from} - ${to}"; // Assuming this is the default salary range
            lblSalaryRange.Text = salary; // Update the label text

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            jobs = jobsdefault;
            ResetAllControls(pnBody);
            PassListBackToListener();
            this.Hide();
        }

        public List<Job> filterList
        { get { return jobs; } }
    }
}
