using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace Entity
{
    public partial class FCompanyCVView : Form
    {
        WebBrowser pdfViewer = new WebBrowser();
        string companyid = string.Empty;
        CompanyLikeCVDao dao = new CompanyLikeCVDao();
        CV cv = new CV();
        CVDao cvDao = new CVDao();
        public FCompanyCVView(CV cv, string companyid)
        {
            InitializeComponent();
            this.Controls.Add(pdfViewer);
            pdfViewer.Dock = DockStyle.Fill;
            PDFHandler.DisplayPDFInWebBrowser(cv.CV1, ref pdfViewer);
            this.companyid = companyid;
            this.cv = cv;
        }
    }
}
