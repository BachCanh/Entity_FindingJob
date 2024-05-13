using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class UCCandidate
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCandidateName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptbCandidateAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDetails = new Guna.UI2.WinForms.Guna2Button();
            this.pnBody = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblWorkingType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnWrap = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCandidateAvatar)).BeginInit();
            this.pnBody.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.pnWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(29, 262);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblTitle);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(29, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(488, 64);
            this.guna2Panel3.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(488, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Location = new System.Drawing.Point(133, 0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(17, 96);
            this.guna2Panel6.TabIndex = 3;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lblCandidateName);
            this.guna2Panel4.Controls.Add(this.guna2Panel6);
            this.guna2Panel4.Controls.Add(this.ptbCandidateAvatar);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(29, 64);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(488, 96);
            this.guna2Panel4.TabIndex = 3;
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = false;
            this.lblCandidateName.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidateName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCandidateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.lblCandidateName.Location = new System.Drawing.Point(150, 0);
            this.lblCandidateName.Margin = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(335, 96);
            this.lblCandidateName.TabIndex = 3;
            this.lblCandidateName.Text = "Candidate Name";
            this.lblCandidateName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptbCandidateAvatar
            // 
            this.ptbCandidateAvatar.FillColor = System.Drawing.Color.Transparent;
            this.ptbCandidateAvatar.ImageRotate = 0F;
            this.ptbCandidateAvatar.Location = new System.Drawing.Point(0, 0);
            this.ptbCandidateAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 17, 2);
            this.ptbCandidateAvatar.Name = "ptbCandidateAvatar";
            this.ptbCandidateAvatar.Size = new System.Drawing.Size(133, 96);
            this.ptbCandidateAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCandidateAvatar.TabIndex = 2;
            this.ptbCandidateAvatar.TabStop = false;
            // 
            // flpSkills
            // 
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSkills.Location = new System.Drawing.Point(29, 212);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(488, 50);
            this.flpSkills.TabIndex = 53;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.BorderRadius = 15;
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnDetails.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetails.ForeColor = System.Drawing.Color.DimGray;
            this.btnDetails.Location = new System.Drawing.Point(390, 282);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ShadowDecoration.BorderRadius = 15;
            this.btnDetails.ShadowDecoration.Depth = 10;
            this.btnDetails.ShadowDecoration.Enabled = true;
            this.btnDetails.Size = new System.Drawing.Size(122, 42);
            this.btnDetails.TabIndex = 53;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseWaitCursor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.Transparent;
            this.pnBody.Controls.Add(this.lblWorkingType);
            this.pnBody.Controls.Add(this.flpSkills);
            this.pnBody.Controls.Add(this.guna2Panel4);
            this.pnBody.Controls.Add(this.guna2Panel3);
            this.pnBody.Controls.Add(this.guna2Panel1);
            this.pnBody.FillColor = System.Drawing.Color.MistyRose;
            this.pnBody.Location = new System.Drawing.Point(18, 13);
            this.pnBody.Name = "pnBody";
            this.pnBody.Radius = 15;
            this.pnBody.ShadowColor = System.Drawing.Color.Black;
            this.pnBody.Size = new System.Drawing.Size(517, 262);
            this.pnBody.TabIndex = 0;
            // 
            // lblWorkingType
            // 
            this.lblWorkingType.AutoSize = false;
            this.lblWorkingType.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkingType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblWorkingType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblWorkingType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.lblWorkingType.Location = new System.Drawing.Point(29, 166);
            this.lblWorkingType.Name = "lblWorkingType";
            this.lblWorkingType.Size = new System.Drawing.Size(488, 46);
            this.lblWorkingType.TabIndex = 54;
            this.lblWorkingType.Text = "Working Type";
            this.lblWorkingType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.lblLocation);
            this.guna2Panel7.Location = new System.Drawing.Point(47, 282);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(330, 42);
            this.guna2Panel7.TabIndex = 55;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = false;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.lblLocation.Location = new System.Drawing.Point(0, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(330, 42);
            this.lblLocation.TabIndex = 54;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnWrap
            // 
            this.pnWrap.BackColor = System.Drawing.Color.Transparent;
            this.pnWrap.Controls.Add(this.guna2Panel7);
            this.pnWrap.Controls.Add(this.btnDetails);
            this.pnWrap.Controls.Add(this.pnBody);
            this.pnWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnWrap.FillColor = System.Drawing.Color.White;
            this.pnWrap.Location = new System.Drawing.Point(0, 0);
            this.pnWrap.Name = "pnWrap";
            this.pnWrap.Radius = 15;
            this.pnWrap.ShadowColor = System.Drawing.Color.Black;
            this.pnWrap.ShadowDepth = 110;
            this.pnWrap.Size = new System.Drawing.Size(550, 337);
            this.pnWrap.TabIndex = 53;
            // 
            // UCCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnWrap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCCandidate";
            this.Size = new System.Drawing.Size(550, 337);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCandidateAvatar)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.pnWrap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2PictureBox ptbCandidateAvatar;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Button btnDetails;
        public Guna.UI2.WinForms.Guna2ShadowPanel pnBody;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnWrap;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCandidateName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWorkingType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLocation;
    }
}
