using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Entity
{
    public partial class UCRates : UserControl
    {
        Rating rate;
        public UCRates(Rating rate)
        {
            InitializeComponent();
            this.rate = rate;
            FillInfor();
        }

        private void FillInfor()
        {
            JobSeekerDAO js = new JobSeekerDAO();
            ptbAvatar.Image = js.FetchImg(rate.JobSeekerID, "Avatar");
            lblNames.Text = js.FetchName(rate.JobSeekerID);
            lblTimeRates.Text = rate.TimeRate.ToString("dd/MM/yyyy hh/mm/ss");
            lblContents.Text = rate.content;
            rtStars.Value = (int)rate.rate;
        }

    }
}
