using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Entity
{
    public partial class FRate : Form
    {
        Rating Ratings = new Rating();
        string js, com;
        public FRate(string js, string com)
        {
            InitializeComponent();
            this .js = js;
            this .com = com;    
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            using (var db = new FindingJob())
            {
                Ratings = new Rating
                {
                    JobSeekerID = js,
                    CompanyID = com, 
                    rate = (int)rtStars.Value, 
                    TimeRate = DateTime.Now, 
                    content = rtxtContents.Text
                };
            }

            this.Close();
        }

        public Rating RATE
        { get { return Ratings; } }
    }
}
