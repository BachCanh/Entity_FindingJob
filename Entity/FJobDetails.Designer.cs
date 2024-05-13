using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FJobDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJobDetails));
            this.lblSalary = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtRequirement = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtxtBenefit = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new ReaLTaiizor.Controls.CyberButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnCarousel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblWorkingForm = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnRelatedJob = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblCompanyNameLeft = new ReaLTaiizor.Controls.MetroLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnRatings = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeeMore = new ReaLTaiizor.Controls.CyberButton();
            this.ptbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCompanyDetail = new ReaLTaiizor.Controls.CyberButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnTopCompany = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTopCompany = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCompanyTypeText = new ReaLTaiizor.Controls.MetroLabel();
            this.lblCompanyType = new ReaLTaiizor.Controls.MetroLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCompanySizeText = new ReaLTaiizor.Controls.MetroLabel();
            this.lblCompanySize = new ReaLTaiizor.Controls.MetroLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblAddressText = new ReaLTaiizor.Controls.MetroLabel();
            this.lblAddress = new ReaLTaiizor.Controls.MetroLabel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblWorkingTimeText = new ReaLTaiizor.Controls.MetroLabel();
            this.lblWorkingTime = new ReaLTaiizor.Controls.MetroLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnRelatedJob.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.pnTopCompany.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblSalary.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSalary.Location = new System.Drawing.Point(34, 70);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(70, 25);
            this.lblSalary.TabIndex = 19;
            this.lblSalary.Text = "Salary:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(3, 499);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 219);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxtRequirement);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Requirement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtRequirement
            // 
            this.rtxtRequirement.Enabled = false;
            this.rtxtRequirement.Location = new System.Drawing.Point(3, 3);
            this.rtxtRequirement.Name = "rtxtRequirement";
            this.rtxtRequirement.Size = new System.Drawing.Size(846, 177);
            this.rtxtRequirement.TabIndex = 0;
            this.rtxtRequirement.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxtDescription);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Description";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDescription.Enabled = false;
            this.rtxtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rtxtDescription.Location = new System.Drawing.Point(3, 3);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(835, 170);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtxtBenefit);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(841, 176);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Benefit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtxtBenefit
            // 
            this.rtxtBenefit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtBenefit.Enabled = false;
            this.rtxtBenefit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rtxtBenefit.Location = new System.Drawing.Point(3, 3);
            this.rtxtBenefit.Name = "rtxtBenefit";
            this.rtxtBenefit.Size = new System.Drawing.Size(835, 170);
            this.rtxtBenefit.TabIndex = 45;
            this.rtxtBenefit.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.pnRelatedJob);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(873, 835);
            this.flowLayoutPanel1.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.lblJobName);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Alpha = 20;
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Background = true;
            this.btnApply.Background_WidthPen = 4F;
            this.btnApply.BackgroundPen = true;
            this.btnApply.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.ColorBackground_Pen = System.Drawing.Color.LightCoral;
            this.btnApply.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnApply.Effect_1 = true;
            this.btnApply.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.Effect_1_Transparency = 25;
            this.btnApply.Effect_2 = true;
            this.btnApply.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnApply.Effect_2_Transparency = 20;
            this.btnApply.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Lighting = true;
            this.btnApply.LinearGradient_Background = false;
            this.btnApply.LinearGradientPen = false;
            this.btnApply.Location = new System.Drawing.Point(166, 101);
            this.btnApply.Name = "btnApply";
            this.btnApply.PenWidth = 15;
            this.btnApply.Rounding = true;
            this.btnApply.RoundingInt = 10;
            this.btnApply.Size = new System.Drawing.Size(596, 36);
            this.btnApply.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnApply.TabIndex = 47;
            this.btnApply.Tag = "Decline";
            this.btnApply.TextButton = "Apply";
            this.btnApply.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnApply.Timer_Effect_1 = 5;
            this.btnApply.Timer_RGB = 300;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 71);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompany.Location = new System.Drawing.Point(9, 45);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(80, 21);
            this.lblCompany.TabIndex = 13;
            this.lblCompany.Text = "Company:";
            // 
            // lblJobName
            // 
            this.lblJobName.AccessibleDescription = "";
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblJobName.Location = new System.Drawing.Point(0, 0);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(607, 45);
            this.lblJobName.TabIndex = 1;
            this.lblJobName.Text = "Job Name:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pnCarousel);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 146);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(849, 348);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pnCarousel
            // 
            this.pnCarousel.Location = new System.Drawing.Point(3, 2);
            this.pnCarousel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCarousel.Name = "pnCarousel";
            this.pnCarousel.Size = new System.Drawing.Size(847, 162);
            this.pnCarousel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.lbLocation);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(3, 168);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 40);
            this.panel4.TabIndex = 2;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoEllipsis = true;
            this.lbLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLocation.Location = new System.Drawing.Point(60, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(543, 40);
            this.lbLocation.TabIndex = 24;
            this.lbLocation.Text = "Location";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.lblDate);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Location = new System.Drawing.Point(3, 212);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(603, 38);
            this.panel7.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(60, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(543, 38);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date Publish:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 10);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(3, 254);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(603, 38);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.lblWorkingForm);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(603, 38);
            this.panel6.TabIndex = 3;
            // 
            // lblWorkingForm
            // 
            this.lblWorkingForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWorkingForm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblWorkingForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWorkingForm.Location = new System.Drawing.Point(60, 0);
            this.lblWorkingForm.Name = "lblWorkingForm";
            this.lblWorkingForm.Size = new System.Drawing.Size(543, 38);
            this.lblWorkingForm.TabIndex = 23;
            this.lblWorkingForm.Text = "Woking Form";
            this.lblWorkingForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.guna2HtmlLabel1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 296);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(847, 49);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(8, 7);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(81, 38);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Skill";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 724);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 33);
            this.panel3.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Related Job";
            // 
            // pnRelatedJob
            // 
            this.pnRelatedJob.Controls.Add(this.btnNext);
            this.pnRelatedJob.Controls.Add(this.btnBack);
            this.pnRelatedJob.Location = new System.Drawing.Point(3, 763);
            this.pnRelatedJob.Name = "pnRelatedJob";
            this.pnRelatedJob.Size = new System.Drawing.Size(851, 347);
            this.pnRelatedJob.TabIndex = 30;
            // 
            // btnNext
            // 
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BorderRadius = 13;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(755, 315);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 29);
            this.btnNext.TabIndex = 42;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 13;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(658, 315);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 29);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblCompanyNameLeft
            // 
            this.lblCompanyNameLeft.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyNameLeft.IsDerivedStyle = true;
            this.lblCompanyNameLeft.Location = new System.Drawing.Point(128, 16);
            this.lblCompanyNameLeft.Name = "lblCompanyNameLeft";
            this.lblCompanyNameLeft.Size = new System.Drawing.Size(208, 43);
            this.lblCompanyNameLeft.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCompanyNameLeft.StyleManager = null;
            this.lblCompanyNameLeft.TabIndex = 48;
            this.lblCompanyNameLeft.Text = "Company Name";
            this.lblCompanyNameLeft.ThemeAuthor = "Taiizor";
            this.lblCompanyNameLeft.ThemeName = "MetroLight";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnRatings);
            this.panel10.Controls.Add(this.btnSeeMore);
            this.panel10.Controls.Add(this.ptbAvatar);
            this.panel10.Controls.Add(this.btnCompanyDetail);
            this.panel10.Controls.Add(this.lblCompanyNameLeft);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 50);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(336, 135);
            this.panel10.TabIndex = 51;
            // 
            // btnRatings
            // 
            this.btnRatings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRatings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRatings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRatings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRatings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRatings.FillColor = System.Drawing.Color.Transparent;
            this.btnRatings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.btnRatings.ForeColor = System.Drawing.Color.Black;
            this.btnRatings.Location = new System.Drawing.Point(5, 100);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(121, 32);
            this.btnRatings.TabIndex = 54;
            this.btnRatings.Text = "View Ratings";
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnSeeMore
            // 
            this.btnSeeMore.Alpha = 20;
            this.btnSeeMore.BackColor = System.Drawing.Color.Transparent;
            this.btnSeeMore.Background = true;
            this.btnSeeMore.Background_WidthPen = 4F;
            this.btnSeeMore.BackgroundPen = true;
            this.btnSeeMore.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSeeMore.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeMore.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeMore.ColorBackground_Pen = System.Drawing.Color.LightCoral;
            this.btnSeeMore.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeMore.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeMore.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeMore.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnSeeMore.Effect_1 = true;
            this.btnSeeMore.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeMore.Effect_1_Transparency = 25;
            this.btnSeeMore.Effect_2 = true;
            this.btnSeeMore.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeMore.Effect_2_Transparency = 20;
            this.btnSeeMore.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSeeMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnSeeMore.Lighting = true;
            this.btnSeeMore.LinearGradient_Background = false;
            this.btnSeeMore.LinearGradientPen = false;
            this.btnSeeMore.Location = new System.Drawing.Point(123, 54);
            this.btnSeeMore.Name = "btnSeeMore";
            this.btnSeeMore.PenWidth = 15;
            this.btnSeeMore.Rounding = true;
            this.btnSeeMore.RoundingInt = 10;
            this.btnSeeMore.Size = new System.Drawing.Size(205, 36);
            this.btnSeeMore.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSeeMore.TabIndex = 52;
            this.btnSeeMore.Tag = "";
            this.btnSeeMore.TextButton = "See More Jobs";
            this.btnSeeMore.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnSeeMore.Timer_Effect_1 = 5;
            this.btnSeeMore.Timer_RGB = 300;
            this.btnSeeMore.Click += new System.EventHandler(this.btnSeeMore_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.Image")));
            this.ptbAvatar.ImageRotate = 0F;
            this.ptbAvatar.Location = new System.Drawing.Point(12, 16);
            this.ptbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(103, 80);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 51;
            this.ptbAvatar.TabStop = false;
            // 
            // btnCompanyDetail
            // 
            this.btnCompanyDetail.Alpha = 20;
            this.btnCompanyDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnCompanyDetail.Background = true;
            this.btnCompanyDetail.Background_WidthPen = 4F;
            this.btnCompanyDetail.BackgroundPen = true;
            this.btnCompanyDetail.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.ColorBackground_Pen = System.Drawing.Color.LightCoral;
            this.btnCompanyDetail.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompanyDetail.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnCompanyDetail.Effect_1 = true;
            this.btnCompanyDetail.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.Effect_1_Transparency = 25;
            this.btnCompanyDetail.Effect_2 = true;
            this.btnCompanyDetail.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompanyDetail.Effect_2_Transparency = 20;
            this.btnCompanyDetail.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCompanyDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnCompanyDetail.Lighting = true;
            this.btnCompanyDetail.LinearGradient_Background = false;
            this.btnCompanyDetail.LinearGradientPen = false;
            this.btnCompanyDetail.Location = new System.Drawing.Point(123, 96);
            this.btnCompanyDetail.Name = "btnCompanyDetail";
            this.btnCompanyDetail.PenWidth = 15;
            this.btnCompanyDetail.Rounding = true;
            this.btnCompanyDetail.RoundingInt = 10;
            this.btnCompanyDetail.Size = new System.Drawing.Size(205, 36);
            this.btnCompanyDetail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCompanyDetail.TabIndex = 50;
            this.btnCompanyDetail.Tag = "";
            this.btnCompanyDetail.TextButton = "Detail";
            this.btnCompanyDetail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCompanyDetail.Timer_Effect_1 = 5;
            this.btnCompanyDetail.Timer_RGB = 300;
            this.btnCompanyDetail.Click += new System.EventHandler(this.btnCompanyDetail_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblStatus);
            this.flowLayoutPanel3.Controls.Add(this.panel10);
            this.flowLayoutPanel3.Controls.Add(this.pnTopCompany);
            this.flowLayoutPanel3.Controls.Add(this.panel2);
            this.flowLayoutPanel3.Controls.Add(this.panel9);
            this.flowLayoutPanel3.Controls.Add(this.panel11);
            this.flowLayoutPanel3.Controls.Add(this.panel12);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(878, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(342, 835);
            this.flowLayoutPanel3.TabIndex = 52;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(336, 48);
            this.lblStatus.TabIndex = 56;
            this.lblStatus.Text = "This company is down-trend now!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTopCompany
            // 
            this.pnTopCompany.Controls.Add(this.lblTopCompany);
            this.pnTopCompany.Enabled = false;
            this.pnTopCompany.ForeColor = System.Drawing.Color.Red;
            this.pnTopCompany.Location = new System.Drawing.Point(3, 190);
            this.pnTopCompany.Name = "pnTopCompany";
            this.pnTopCompany.Size = new System.Drawing.Size(336, 71);
            this.pnTopCompany.TabIndex = 56;
            this.pnTopCompany.Visible = false;
            // 
            // lblTopCompany
            // 
            this.lblTopCompany.AutoSize = false;
            this.lblTopCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblTopCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTopCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTopCompany.Location = new System.Drawing.Point(0, 0);
            this.lblTopCompany.Name = "lblTopCompany";
            this.lblTopCompany.Size = new System.Drawing.Size(336, 71);
            this.lblTopCompany.TabIndex = 0;
            this.lblTopCompany.Text = "*The company recruited the most candidates of the year";
            this.lblTopCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblCompanyTypeText);
            this.panel2.Controls.Add(this.lblCompanyType);
            this.panel2.Location = new System.Drawing.Point(3, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 69);
            this.panel2.TabIndex = 52;
            // 
            // lblCompanyTypeText
            // 
            this.lblCompanyTypeText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCompanyTypeText.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblCompanyTypeText.IsDerivedStyle = true;
            this.lblCompanyTypeText.Location = new System.Drawing.Point(130, 0);
            this.lblCompanyTypeText.Name = "lblCompanyTypeText";
            this.lblCompanyTypeText.Size = new System.Drawing.Size(206, 69);
            this.lblCompanyTypeText.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCompanyTypeText.StyleManager = null;
            this.lblCompanyTypeText.TabIndex = 1;
            this.lblCompanyTypeText.Text = "Companytype Text";
            this.lblCompanyTypeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompanyTypeText.ThemeAuthor = "Taiizor";
            this.lblCompanyTypeText.ThemeName = "MetroLight";
            // 
            // lblCompanyType
            // 
            this.lblCompanyType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCompanyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblCompanyType.IsDerivedStyle = true;
            this.lblCompanyType.Location = new System.Drawing.Point(0, 0);
            this.lblCompanyType.Name = "lblCompanyType";
            this.lblCompanyType.Size = new System.Drawing.Size(117, 69);
            this.lblCompanyType.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCompanyType.StyleManager = null;
            this.lblCompanyType.TabIndex = 0;
            this.lblCompanyType.Text = "CompanyType";
            this.lblCompanyType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompanyType.ThemeAuthor = "Taiizor";
            this.lblCompanyType.ThemeName = "MetroLight";
            // 
            // panel9
            // 
            this.panel9.AutoScroll = true;
            this.panel9.Controls.Add(this.lblCompanySizeText);
            this.panel9.Controls.Add(this.lblCompanySize);
            this.panel9.Location = new System.Drawing.Point(3, 339);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(336, 69);
            this.panel9.TabIndex = 53;
            // 
            // lblCompanySizeText
            // 
            this.lblCompanySizeText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCompanySizeText.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanySizeText.IsDerivedStyle = true;
            this.lblCompanySizeText.Location = new System.Drawing.Point(130, 0);
            this.lblCompanySizeText.Name = "lblCompanySizeText";
            this.lblCompanySizeText.Size = new System.Drawing.Size(206, 69);
            this.lblCompanySizeText.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCompanySizeText.StyleManager = null;
            this.lblCompanySizeText.TabIndex = 1;
            this.lblCompanySizeText.Text = "CompanySize Text";
            this.lblCompanySizeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompanySizeText.ThemeAuthor = "Taiizor";
            this.lblCompanySizeText.ThemeName = "MetroLight";
            // 
            // lblCompanySize
            // 
            this.lblCompanySize.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCompanySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblCompanySize.IsDerivedStyle = true;
            this.lblCompanySize.Location = new System.Drawing.Point(0, 0);
            this.lblCompanySize.Name = "lblCompanySize";
            this.lblCompanySize.Size = new System.Drawing.Size(117, 69);
            this.lblCompanySize.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCompanySize.StyleManager = null;
            this.lblCompanySize.TabIndex = 0;
            this.lblCompanySize.Text = "CompanySize";
            this.lblCompanySize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompanySize.ThemeAuthor = "Taiizor";
            this.lblCompanySize.ThemeName = "MetroLight";
            // 
            // panel11
            // 
            this.panel11.AutoScroll = true;
            this.panel11.Controls.Add(this.lblAddressText);
            this.panel11.Controls.Add(this.lblAddress);
            this.panel11.Location = new System.Drawing.Point(3, 412);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(336, 69);
            this.panel11.TabIndex = 54;
            // 
            // lblAddressText
            // 
            this.lblAddressText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAddressText.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAddressText.IsDerivedStyle = true;
            this.lblAddressText.Location = new System.Drawing.Point(130, 0);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(206, 69);
            this.lblAddressText.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblAddressText.StyleManager = null;
            this.lblAddressText.TabIndex = 1;
            this.lblAddressText.Text = "Address Text";
            this.lblAddressText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddressText.ThemeAuthor = "Taiizor";
            this.lblAddressText.ThemeName = "MetroLight";
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAddress.IsDerivedStyle = true;
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(117, 69);
            this.lblAddress.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblAddress.StyleManager = null;
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.ThemeAuthor = "Taiizor";
            this.lblAddress.ThemeName = "MetroLight";
            // 
            // panel12
            // 
            this.panel12.AutoScroll = true;
            this.panel12.Controls.Add(this.lblWorkingTimeText);
            this.panel12.Controls.Add(this.lblWorkingTime);
            this.panel12.Location = new System.Drawing.Point(3, 485);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(336, 69);
            this.panel12.TabIndex = 55;
            // 
            // lblWorkingTimeText
            // 
            this.lblWorkingTimeText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWorkingTimeText.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblWorkingTimeText.IsDerivedStyle = true;
            this.lblWorkingTimeText.Location = new System.Drawing.Point(130, 0);
            this.lblWorkingTimeText.Name = "lblWorkingTimeText";
            this.lblWorkingTimeText.Size = new System.Drawing.Size(206, 69);
            this.lblWorkingTimeText.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblWorkingTimeText.StyleManager = null;
            this.lblWorkingTimeText.TabIndex = 1;
            this.lblWorkingTimeText.Text = "Working Time Text";
            this.lblWorkingTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWorkingTimeText.ThemeAuthor = "Taiizor";
            this.lblWorkingTimeText.ThemeName = "MetroLight";
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWorkingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblWorkingTime.IsDerivedStyle = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(0, 0);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(117, 69);
            this.lblWorkingTime.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblWorkingTime.StyleManager = null;
            this.lblWorkingTime.TabIndex = 0;
            this.lblWorkingTime.Text = "Working Time";
            this.lblWorkingTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWorkingTime.ThemeAuthor = "Taiizor";
            this.lblWorkingTime.ThemeName = "MetroLight";
            // 
            // FJobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 835);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FJobDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FJobDetails";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnRelatedJob.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.pnTopCompany.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblSalary;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox rtxtRequirement;
        private TabPage tabPage2;
        private RichTextBox rtxtDescription;
        private TabPage tabPage3;
        private RichTextBox rtxtBenefit;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblCompany;
        private Label lblJobName;
        private ReaLTaiizor.Controls.CyberButton btnApply;
        private ReaLTaiizor.Controls.MetroLabel lblCompanyNameLeft;
        private ReaLTaiizor.Controls.MetroLabel lblCompanyNameDown;
        private Panel panel10;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel2;
        private ReaLTaiizor.Controls.MetroLabel lblCompanyTypeText;
        private ReaLTaiizor.Controls.MetroLabel lblCompanyType;
        private Panel panel9;
        private ReaLTaiizor.Controls.MetroLabel lblCompanySizeText;
        private ReaLTaiizor.Controls.MetroLabel lblCompanySize;
        private Panel panel11;
        private ReaLTaiizor.Controls.MetroLabel lblAddressText;
        private ReaLTaiizor.Controls.MetroLabel lblAddress;
        private Panel panel12;
        private ReaLTaiizor.Controls.MetroLabel lblWorkingTimeText;
        private ReaLTaiizor.Controls.MetroLabel lblWorkingTime;
        private ReaLTaiizor.Controls.CyberButton btnCompanyDetail;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnCarousel;
        private Panel panel4;
        private Label lbLocation;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel6;
        private Label lblWorkingForm;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel7;
        private Label lblDate;
        private PictureBox pictureBox5;
        private FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbAvatar;
        private Label lblStatus;
        private ReaLTaiizor.Controls.CyberButton btnSeeMore;
        private Guna.UI2.WinForms.Guna2Panel pnTopCompany;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTopCompany;
        private Panel panel3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnRelatedJob;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnRatings;
    }
}