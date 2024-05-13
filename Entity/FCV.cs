using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace Entity
{
    public partial class FCV : Form
    {
        WebBrowser pdfViewer = new WebBrowser();
        public FCV(JobSeeker jobseeker)
        {
            InitializeComponent();
            this.Controls.Add(pdfViewer);
            pdfViewer.Dock = DockStyle.Fill;
            PDFHandler.DisplayPDFInWebBrowser(jobseeker.CV.CV1, ref pdfViewer);
            this.lblLikeCount.Text = jobseeker.CV.LikeCount.ToString();
        }

        private void FCV_Load(object sender, EventArgs e)
        {

        }
    }
}
