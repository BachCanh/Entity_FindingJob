using PdfSharp.Fonts;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using TheArtOfDevHtmlRenderer.Adapters;
using System.IO;
using PdfSharp.Drawing;



namespace Entity
{
    public partial class FCVCreation : Form
    {
        JobSeeker seeker;
        List<Experience> explist = new List<Experience>();
        List<Education> edulist = new List<Education>();
        List<Project> prolist = new List<Project>();
        List<string> skilllist = new List<string>();
        FCVCreation_Edu FCVCreation_Edu;
        FCVCreation_Exp FCVCreation_Exp;
        FCVCreation_Project FCVCreation_Project;
        FJobSKills fSkills;
        public FCVCreation(JobSeeker js)
        {
            InitializeComponent();
            this.seeker = js;
            FillInfor();
        }

        private void FillInfor()
        {
            txtFullName.Text = seeker.Name;
            txtAddress.Text = seeker.Address;
            txtPhoneNumber.Text = seeker.PhoneNumber;
            txtEmail.Text = seeker.Email;
        }

        private void AddEdu_Click(object sender, EventArgs e)
        {
            edulist.Add(FCVCreation_Edu.EDU);
            flpEdu.Controls.Clear();
            foreach (Education edu in edulist)
            {
                UCEducation uCEducation = new UCEducation(edu);
                uCEducation.MaximumSize = new System.Drawing.Size(695, 120);
                flpEdu.Controls.Add(uCEducation);
            }
            FCVCreation_Load(sender, e);
        }

        private void AddExp_Click(object sender, EventArgs e)
        {
            explist.Add(FCVCreation_Exp.EXP);
            flpExp.Controls.Clear();
            foreach (Experience exp in explist)
            {
                UCExperience uc = new UCExperience(exp);
                uc.MaximumSize = new System.Drawing.Size(695, 120);
                flpExp.Controls.Add(uc);
            }
            FCVCreation_Load(sender, e);
        }

        private void AddPro_Click(object sender, EventArgs e)
        {
            prolist.Add(FCVCreation_Project.PRO);
            flpProjects.Controls.Clear();
            foreach (Project pro in prolist)
            {
                UCProject uc = new UCProject(pro);
                uc.MaximumSize = new System.Drawing.Size(582, 120);
                flpProjects.Controls.Add(uc);
            }
            FCVCreation_Load(sender, e);
        }

        private void btnAddExperience_Click(object sender, EventArgs e)
        {
            FCVCreation_Exp.Show();
        }
        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            FCVCreation_Edu.Show();
        }
        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fSkills.Show();
        }
        private void btnAddProjects_Click(object sender, EventArgs e)
        {
            FCVCreation_Project.Show();
        }

        private void FCVCreation_Load(object sender, EventArgs e)
        {
            FCVCreation_Edu = new FCVCreation_Edu();
            FCVCreation_Exp = new FCVCreation_Exp();
            FCVCreation_Project = new FCVCreation_Project();
            fSkills = new FJobSKills();
            FCVCreation_Edu.btnAdd.Click += AddEdu_Click;
            FCVCreation_Exp.btnAdd.Click += AddExp_Click;
            FCVCreation_Project.btnAdd.Click += AddPro_Click;
            fSkills.btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            flpSkills.Controls.Clear();
            skilllist = fSkills.Skills;
            foreach (string item in fSkills.Skills)
            {
                if (item != "NULL")
                {
                    BtnSkill btnSkill = new BtnSkill();
                    btnSkill.Text = item;
                    btnSkill.Show();
                    flpSkills.Controls.Add(btnSkill);
                    flpSkills.Width += btnSkill.Width + 20;
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CreatePDFDocument();
                MessageBox.Show("Create Success, Please go to the desktop to get the file!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void CreatePDFDocument()
        {
            // Register the code pages encoding provider (if necessary)
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            // Set the custom font resolver
            MyFontResolver.Apply();
            // Create a new PDF document
            PdfDocument pdfDocument = new PdfDocument();

            pdfDocument.Info.Title = "CV";

            // Add a page to the PDF document
            PdfPage page = pdfDocument.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Portrait;
            page.Size = PdfSharp.PageSize.A4;
            // Create a graphics object for the page
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XImage image = XImage.FromFile("Resources/avatar.png");
            XImage imageSkills = XImage.FromFile("Resources/coding.png");
            XImage imageEdu = XImage.FromFile("Resources/mortarboard.png");
            XImage imageExp = XImage.FromFile("Resources/portfolio.png");
            XImage imagePro = XImage.FromFile("Resources/project.png");
            XImage imageSkill = XImage.FromFile("Resources/skills.png");
            // Create a font for drawing text
            XFont fontTitle = new XFont("Arial", 40);
            XFont fontSubTitle = new XFont("Arial", 18);
            XFont fontH1 = new XFont("Arial", 20);
            XFont fontInfo1 = new XFont("Arial", 15, XFontStyle.Regular);
            XFont fontInfo2 = new XFont("Arial", 17, XFontStyle.Regular);
            //gfx.DrawPath()
            // Draw text on the page

            double mLeft = 20;
            double mTop = 70;
            double heightRec = 20;
            double availableHeight = page.Height.Point - mTop - 30; // Convert page height to points
            gfx.DrawImage(image, mLeft, mTop - 35, 75, 100);
            gfx.DrawString(txtFullName.Text, fontTitle, XBrushes.MediumSlateBlue, new XPoint(mLeft + 90, mTop - 5));

            gfx.DrawString(txtJobName.Text, fontSubTitle, XBrushes.MediumSlateBlue, new XPoint(mLeft + 92, mTop + 25));
            mTop += 37;
            gfx.DrawRectangle(new XSolidBrush(XColors.SlateBlue), mLeft + 90, mTop, page.Width - mLeft - 120, heightRec + 8);
            mTop += 20;
            gfx.DrawString($"Phone: {txtPhoneNumber.Text}    -    Email: {txtEmail.Text}", fontInfo1, XBrushes.White, new XPoint(mLeft + 95, mTop));

            mTop += 30;
            // Define the rectangle coordinates and dimensions
            double width = page.Width - mLeft - 30; // Width of the rectangle
            double height = 30; // Height of the rectangle

            XColor borderColor = XColors.MediumSlateBlue;
            XPen borderPen = new XPen(borderColor);
            gfx.DrawRectangle(borderPen, mLeft, mTop, width, height);

            gfx.DrawImage(image, mLeft + 10, mTop + 5, 20, 20);
            gfx.DrawString("PROFILE ", fontH1, XBrushes.MediumSlateBlue, new XPoint(mLeft + 45, mTop + 22));


            mTop += 50;

            string text = rtxtProfessionalSum.Text;
            // Calculate the height of each line based on the font size
            double lineHeight = fontInfo1.GetHeight();

            // Split the text into lines that fit within the fixed width
            double size1 = page.Width - mLeft - 30;
            string[] lines = WrapTextToWidth(text, gfx, fontInfo1, size1);

            foreach (string line in lines)
            {
                gfx.DrawString(line, fontInfo1, XBrushes.Black, mLeft + 2, mTop);
                mTop += lineHeight; // Move to the next line
            }

            gfx.DrawRectangle(borderPen, mLeft, mTop, width, height);

            gfx.DrawImage(imageSkill, mLeft + 10, mTop + 5, 20, 20);
            gfx.DrawString("MAIN SKILLS ", fontH1, XBrushes.MediumSlateBlue, new XPoint(mLeft + 45, mTop + 22));

            mTop += 50;
            foreach(string s in skilllist)
            {
                lineHeight = fontInfo1.GetHeight();
                size1 = page.Width - mLeft - 150;
                lines = WrapTextToWidth(text, gfx, fontInfo1, size1);

                gfx.DrawImage(imageSkills, mLeft + 15, mTop - 3, 15, 15);
                gfx.DrawString(s, fontInfo2, XBrushes.MediumSlateBlue, new XPoint(mLeft + 40, mTop + 10));

                mTop += 30;
            }

            gfx.DrawRectangle(borderPen, mLeft, mTop, width, height);

            gfx.DrawImage(imageEdu, mLeft + 10, mTop + 5, 20, 20);
            gfx.DrawString("EDUCATION ", fontH1, XBrushes.MediumSlateBlue, new XPoint(mLeft + 45, mTop + 22));

            mTop += 60;
            foreach(Education edu in edulist)
            {
                text = edu.Description;
                lineHeight = fontInfo1.GetHeight();
                size1 = page.Width - mLeft - 150;
                lines = WrapTextToWidth(text, gfx, fontInfo1, size1);
                if (mTop + lineHeight > availableHeight + 20)
                {
                    // Add a new page
                    page = pdfDocument.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    mTop = 50; // Reset y position to the top margin of the new page
                }

                gfx.DrawString($"{edu.Datestart.ToString("yyyy")}-{edu.Dateend.ToString("yyyy")}:", fontInfo2, XBrushes.MediumSlateBlue, new XPoint(mLeft + 5, mTop + 10));

                gfx.DrawString($"{edu.School}    -    {edu.Degree}", fontInfo1, XBrushes.Black, mLeft + 130, mTop);
                mTop += lineHeight; // Move to the next line
                foreach (string line in lines)
                {
                    gfx.DrawString(line, fontInfo1, XBrushes.Black, mLeft + 130, mTop);
                    mTop += lineHeight; // Move to the next line
                }
                mTop += 20;
            }
            mTop -= 20;
            gfx.DrawRectangle(borderPen, mLeft, mTop, width, height);

            gfx.DrawImage(imageExp, mLeft + 10, mTop + 5, 20, 20);
            gfx.DrawString("EXPERIENCE ", fontH1, XBrushes.MediumSlateBlue, new XPoint(mLeft + 45, mTop + 22));
            mTop += 60;
            foreach(Experience exp in explist)
            {
                text = exp.Achieve;
                lineHeight = fontInfo1.GetHeight();
                size1 = page.Width - mLeft - 150;
                lines = WrapTextToWidth(text, gfx, fontInfo1, size1);

                if (mTop + lineHeight > availableHeight + 20)
                {
                    // Add a new page
                    page = pdfDocument.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    mTop = 50; // Reset y position to the top margin of the new page
                }

                gfx.DrawString($"{exp.Datestart.ToString("yyyy")}-{exp.Dateend.ToString("yyyy")}:", fontInfo2, XBrushes.MediumSlateBlue, new XPoint(mLeft + 5, mTop + 10));

                gfx.DrawString($"{exp.Title}    -    {exp.Company}", fontInfo1, XBrushes.Black, mLeft + 130, mTop);
                mTop += lineHeight; // Move to the next line
                foreach (string line in lines)
                {
                    gfx.DrawString(line, fontInfo1, XBrushes.Black, mLeft + 130, mTop);
                    mTop += lineHeight; // Move to the next line
                }
                mTop += 20;
            }
            mTop -= 20;

            gfx.DrawRectangle(borderPen, mLeft, mTop, width, height);

            gfx.DrawImage(imagePro, mLeft + 10, mTop + 5, 20, 20);
            gfx.DrawString("PROJECT ", fontH1, XBrushes.MediumSlateBlue, new XPoint(mLeft + 45, mTop + 22));
            mTop += 60;
            foreach (Project pro in prolist)
            {
                text = pro.Title;
                lineHeight = fontInfo1.GetHeight();
                size1 = page.Width - mLeft - 150;
                lines = WrapTextToWidth(text, gfx, fontInfo1, size1);
                if (mTop + lineHeight > availableHeight + 20)
                {
                    // Add a new page
                    page = pdfDocument.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    mTop = 50; // Reset y position to the top margin of the new page
                }
                gfx.DrawString($"{pro.Datestart.ToString("yyyy")}-{pro.Dateend.ToString("yyyy")}:", fontInfo2, XBrushes.MediumSlateBlue, new XPoint(mLeft + 5, mTop + 10));
                string skills = string.Empty;
                foreach (string s in pro.Skills)
                {
                    skills += s + ", ";
                }
                gfx.DrawString(skills, fontInfo1, XBrushes.Black, mLeft + 130, mTop);
                mTop += lineHeight; // Move to the next line
                foreach (string line in lines)
                {
                    gfx.DrawString(line, fontInfo1, XBrushes.Black, mLeft + 130, mTop);
                    mTop += lineHeight; // Move to the next line
                }
                mTop += 20;
            }
            mTop -= 20;

            string filePath = @"C:\Users\Canh\CV.pdf";

            pdfDocument.Save(filePath);
        }


        private string[] WrapTextToWidth(string text, XGraphics gfx, XFont font, double width)
        {
            List<string> lines = new List<string>();
            StringBuilder currentLine = new StringBuilder();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (gfx.MeasureString(currentLine.ToString() + word, font).Width > width)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                }
                currentLine.Append(word + " ");
            }

            if (currentLine.Length > 0)
                lines.Add(currentLine.ToString());

            return lines.ToArray();
        }

    }


    class MyFontResolver : IFontResolver
    {
        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            // Ignore case of font names.
            var name = familyName.ToLower().TrimEnd('#');

            // Deal with the fonts we know.
            switch (name)
            {
                case "arial":
                    if (isBold)
                    {
                        if (isItalic)
                            return new FontResolverInfo("Arial#bi");
                        return new FontResolverInfo("Arial#b");
                    }
                    if (isItalic)
                        return new FontResolverInfo("Arial#i");
                    return new FontResolverInfo("Arial#");
            }

            // We pass all other font requests to the default handler.
            // When running on a web server without sufficient permission, you can return a default font at this stage.
            return PlatformFontResolver.ResolveTypeface(familyName, isBold, isItalic);
        }

        /// <summary>
        /// Return the font data for the fonts.
        /// </summary>
        public byte[] GetFont(string faceName)
        {
            switch (faceName)
            {
                case "Arial#":
                    return FontHelper.Arial;

                case "Arial#b":
                    return FontHelper.ArialBold;

                case "Arial#i":
                    return FontHelper.ArialItalic;

                case "Arial#bi":
                    return FontHelper.ArialBoldItalic;
            }

            return null;
        }


        internal static MyFontResolver OurGlobalFontResolver = null;

        /// <summary>
        /// Ensure the font resolver is only applied once (or an exception is thrown)
        /// </summary>
        internal static void Apply()
        {
            if (OurGlobalFontResolver == null || GlobalFontSettings.FontResolver == null)
            {
                if (OurGlobalFontResolver == null)
                    OurGlobalFontResolver = new MyFontResolver();

                GlobalFontSettings.FontResolver = OurGlobalFontResolver;
            }
        }
    }


    /// <summary>
    /// Helper class that reads font data from embedded resources.
    /// </summary>
    public static class FontHelper
    {
        public static byte[] Arial
        {
            get { return LoadFontData("Entity.fonts.arial.arial.ttf"); }
        }

        public static byte[] ArialBold
        {
            get { return LoadFontData("Entity.fonts.arial.arialbd.ttf"); }
        }

        public static byte[] ArialItalic
        {
            get { return LoadFontData("Entity.fonts.arial.ariali.ttf"); }
        }

        public static byte[] ArialBoldItalic
        {
            get { return LoadFontData("Entity.fonts.arial.arialbi.ttf"); }
        }

        /// <summary>
        /// Returns the specified font from an embedded resource.
        /// </summary>
        static byte[] LoadFontData(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Test code to find the names of embedded fonts
            //var ourResources = assembly.GetManifestResourceNames();

            using (Stream stream = assembly.GetManifestResourceStream(name))
            {
                if (stream == null)
                    throw new ArgumentException("No resource with name " + name);

                int count = (int)stream.Length;
                byte[] data = new byte[count];
                stream.Read(data, 0, count);
                return data;
            }
        }
    }
}
