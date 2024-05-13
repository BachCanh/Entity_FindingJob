using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class UCInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptbCompanyPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnWrap = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnBody = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWorkingType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCompany = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNameJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDatePuslish = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCompanyPicture)).BeginInit();
            this.pnWrap.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbCompanyPicture
            // 
            this.ptbCompanyPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbCompanyPicture.FillColor = System.Drawing.Color.Transparent;
            this.ptbCompanyPicture.ImageRotate = 0F;
            this.ptbCompanyPicture.Location = new System.Drawing.Point(0, 0);
            this.ptbCompanyPicture.Margin = new System.Windows.Forms.Padding(2, 2, 13, 2);
            this.ptbCompanyPicture.Name = "ptbCompanyPicture";
            this.ptbCompanyPicture.Size = new System.Drawing.Size(44, 45);
            this.ptbCompanyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCompanyPicture.TabIndex = 2;
            this.ptbCompanyPicture.TabStop = false;
            // 
            // pnWrap
            // 
            this.pnWrap.BackColor = System.Drawing.Color.Transparent;
            this.pnWrap.Controls.Add(this.guna2Panel7);
            this.pnWrap.Controls.Add(this.guna2Button1);
            this.pnWrap.Controls.Add(this.pnBody);
            this.pnWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnWrap.FillColor = System.Drawing.Color.White;
            this.pnWrap.Location = new System.Drawing.Point(0, 0);
            this.pnWrap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnWrap.Name = "pnWrap";
            this.pnWrap.Radius = 15;
            this.pnWrap.ShadowColor = System.Drawing.Color.Black;
            this.pnWrap.ShadowDepth = 110;
            this.pnWrap.Size = new System.Drawing.Size(412, 274);
            this.pnWrap.TabIndex = 52;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.lblAddress);
            this.guna2Panel7.Location = new System.Drawing.Point(35, 229);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(248, 34);
            this.guna2Panel7.TabIndex = 55;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = false;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(248, 34);
            this.lblAddress.TabIndex = 54;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Location = new System.Drawing.Point(292, 229);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 15;
            this.guna2Button1.ShadowDecoration.Depth = 10;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(92, 34);
            this.guna2Button1.TabIndex = 53;
            this.guna2Button1.Text = "Details";
            this.guna2Button1.UseWaitCursor = true;
            this.guna2Button1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.Transparent;
            this.pnBody.Controls.Add(this.flpSkills);
            this.pnBody.Controls.Add(this.guna2Panel5);
            this.pnBody.Controls.Add(this.guna2Panel4);
            this.pnBody.Controls.Add(this.guna2Panel3);
            this.pnBody.Controls.Add(this.guna2Panel2);
            this.pnBody.Controls.Add(this.guna2Panel1);
            this.pnBody.FillColor = System.Drawing.Color.MistyRose;
            this.pnBody.Location = new System.Drawing.Point(14, 10);
            this.pnBody.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnBody.Name = "pnBody";
            this.pnBody.Radius = 15;
            this.pnBody.ShadowColor = System.Drawing.Color.Black;
            this.pnBody.Size = new System.Drawing.Size(388, 213);
            this.pnBody.TabIndex = 0;
            // 
            // flpSkills
            // 
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSkills.Location = new System.Drawing.Point(22, 162);
            this.flpSkills.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(366, 51);
            this.flpSkills.TabIndex = 53;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.lblWorkingType);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(22, 128);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(366, 34);
            this.guna2Panel5.TabIndex = 4;
            // 
            // lblWorkingType
            // 
            this.lblWorkingType.AutoSize = false;
            this.lblWorkingType.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkingType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkingType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblWorkingType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.lblWorkingType.Location = new System.Drawing.Point(0, 0);
            this.lblWorkingType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblWorkingType.Name = "lblWorkingType";
            this.lblWorkingType.Size = new System.Drawing.Size(366, 34);
            this.lblWorkingType.TabIndex = 54;
            this.lblWorkingType.Text = "Working Type";
            this.lblWorkingType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lblCompany);
            this.guna2Panel4.Controls.Add(this.guna2Panel6);
            this.guna2Panel4.Controls.Add(this.ptbCompanyPicture);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(22, 83);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(366, 45);
            this.guna2Panel4.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = false;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompany.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.lblCompany.Location = new System.Drawing.Point(57, 0);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(13, 3, 2, 3);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(309, 45);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel6.Location = new System.Drawing.Point(44, 0);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(13, 45);
            this.guna2Panel6.TabIndex = 3;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblNameJob);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(22, 31);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(366, 52);
            this.guna2Panel3.TabIndex = 2;
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoSize = false;
            this.lblNameJob.BackColor = System.Drawing.Color.Transparent;
            this.lblNameJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameJob.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblNameJob.Location = new System.Drawing.Point(0, 0);
            this.lblNameJob.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(366, 52);
            this.lblNameJob.TabIndex = 0;
            this.lblNameJob.Text = "Name Job";
            this.lblNameJob.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lblDatePuslish);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(22, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(366, 31);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lblDatePuslish
            // 
            this.lblDatePuslish.AutoSize = false;
            this.lblDatePuslish.BackColor = System.Drawing.Color.Transparent;
            this.lblDatePuslish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePuslish.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDatePuslish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.lblDatePuslish.Location = new System.Drawing.Point(0, 0);
            this.lblDatePuslish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblDatePuslish.Name = "lblDatePuslish";
            this.lblDatePuslish.Size = new System.Drawing.Size(366, 31);
            this.lblDatePuslish.TabIndex = 54;
            this.lblDatePuslish.Text = "date publish";
            this.lblDatePuslish.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(22, 213);
            this.guna2Panel1.TabIndex = 0;
            // 
            // UCInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnWrap);
            this.Margin = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.Name = "UCInformation";
            this.Size = new System.Drawing.Size(412, 274);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCompanyPicture)).EndInit();
            this.pnWrap.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox ptbCompanyPicture;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnWrap;
        public Guna.UI2.WinForms.Guna2ShadowPanel pnBody;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWorkingType;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCompany;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameJob;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDatePuslish;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
    }
}
