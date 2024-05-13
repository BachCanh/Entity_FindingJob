using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Entity
{
    public partial class FRatings : Form
    {
        private string js;
        private Company com;
        FRate frate;
        List<Rating> ratings =new List<Rating>();
        Rating rating = new Rating();
        RatingDAO ratingDAO = new RatingDAO();
        public FRatings(string js, Company com)
        {
            InitializeComponent();
            this.js = js;
            this.com = com;
            ratings = ratingDAO.AllRatings(com.ID);
            FillInfor();
            frate = new FRate(js, com.ID);
            frate.btnRate.Click += btnRates_CLick;
        }


        public void FillInfor()
        {
            CompanyDAO companyDAO = new CompanyDAO();
            ptbAvatar.Image = companyDAO.FetchImg(com.ID, "Avatar");
            lblCompanyNameLeft.Text = com.Name;
            flpRatings.Controls.Clear();
            int count = 0;
            int total = 0;
            foreach (Rating rate in ratings)
            {
                count++;
                total += (int)rate.rate;
                UCRates uc = new UCRates(rate);
                flpRatings.Controls.Add(uc);
            }
            if(count == 0)
            {
                return;
            }
            decimal rates = ((decimal)total / (decimal)count);

            lblRate.Text = Math.Round(rates, 1).ToString();
            btnRatings.Text = count.ToString() + " Rating (s)";
            frate = new FRate(js, com.ID);
            frate.btnRate.Click += btnRates_CLick;
        }

        private void btnRates_CLick(object sender, EventArgs e)
        {
            rating = frate.RATE;
            ratingDAO.RateCompany(rating);
            ratings.Add(rating);
            FillInfor();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            frate.Show();
        }
    }
}
