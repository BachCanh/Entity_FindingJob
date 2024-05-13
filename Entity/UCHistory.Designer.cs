using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Drawing;

namespace Entity
{
    partial class UCHistory
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnApplicants = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            lblStatus = new Label();
            label1 = new Label();
            pnBody = new Guna.UI2.WinForms.Guna2ShadowPanel();
            flpSkills = new FlowLayoutPanel();
            guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            lblWorkingType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            lblNameJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            lblDateEnd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblDatePuslish = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            pnWrap = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblCountApplicants = new Label();
            guna2Panel7.SuspendLayout();
            pnBody.SuspendLayout();
            guna2Panel9.SuspendLayout();
            guna2Panel6.SuspendLayout();
            guna2Panel4.SuspendLayout();
            pnWrap.SuspendLayout();
            SuspendLayout();
            // 
            // btnApplicants
            // 
            btnApplicants.BorderRadius = 10;
            btnApplicants.Cursor = Cursors.Hand;
            btnApplicants.CustomizableEdges = customizableEdges13;
            btnApplicants.DisabledState.BorderColor = Color.DarkGray;
            btnApplicants.DisabledState.CustomBorderColor = Color.DarkGray;
            btnApplicants.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnApplicants.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnApplicants.FillColor = Color.FromArgb(176, 226, 243);
            btnApplicants.Font = new Font("Arial", 11F);
            btnApplicants.ForeColor = Color.Black;
            btnApplicants.Location = new Point(191, 266);
            btnApplicants.Name = "btnApplicants";
            btnApplicants.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnApplicants.Size = new Size(107, 36);
            btnApplicants.TabIndex = 13;
            btnApplicants.Text = "Applicants";
            btnApplicants.Click += btnApplicants_Click;
            // 
            // guna2Panel7
            // 
            guna2Panel7.Controls.Add(lblStatus);
            guna2Panel7.Controls.Add(label1);
            guna2Panel7.CustomizableEdges = customizableEdges15;
            guna2Panel7.Dock = DockStyle.Top;
            guna2Panel7.Location = new Point(25, 134);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel7.Size = new Size(427, 34);
            guna2Panel7.TabIndex = 54;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Right;
            lblStatus.Font = new Font("Verdana", 13.8F);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(82, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(345, 34);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Verdana", 13.8F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 34);
            label1.TabIndex = 2;
            label1.Text = "Status:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnBody
            // 
            pnBody.BackColor = Color.Transparent;
            pnBody.Controls.Add(guna2Panel7);
            pnBody.Controls.Add(flpSkills);
            pnBody.Controls.Add(guna2Panel9);
            pnBody.Controls.Add(guna2Panel6);
            pnBody.Controls.Add(guna2Panel4);
            pnBody.Controls.Add(guna2Panel5);
            pnBody.FillColor = Color.MistyRose;
            pnBody.Location = new Point(16, 12);
            pnBody.Name = "pnBody";
            pnBody.Radius = 15;
            pnBody.ShadowColor = Color.Black;
            pnBody.Size = new Size(452, 246);
            pnBody.TabIndex = 0;
            // 
            // flpSkills
            // 
            flpSkills.Location = new Point(25, 188);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(427, 58);
            flpSkills.TabIndex = 53;
            // 
            // guna2Panel9
            // 
            guna2Panel9.Controls.Add(lblWorkingType);
            guna2Panel9.CustomizableEdges = customizableEdges17;
            guna2Panel9.Dock = DockStyle.Top;
            guna2Panel9.Location = new Point(25, 100);
            guna2Panel9.Name = "guna2Panel9";
            guna2Panel9.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel9.Size = new Size(427, 34);
            guna2Panel9.TabIndex = 4;
            // 
            // lblWorkingType
            // 
            lblWorkingType.AutoSize = false;
            lblWorkingType.BackColor = Color.Transparent;
            lblWorkingType.Font = new Font("Verdana", 13.8F);
            lblWorkingType.ForeColor = Color.Gray;
            lblWorkingType.Location = new Point(2, 0);
            lblWorkingType.Name = "lblWorkingType";
            lblWorkingType.Size = new Size(424, 40);
            lblWorkingType.TabIndex = 55;
            lblWorkingType.Text = "Working Type";
            lblWorkingType.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel6
            // 
            guna2Panel6.Controls.Add(lblNameJob);
            guna2Panel6.CustomizableEdges = customizableEdges19;
            guna2Panel6.Dock = DockStyle.Top;
            guna2Panel6.Location = new Point(25, 46);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel6.Size = new Size(427, 54);
            guna2Panel6.TabIndex = 2;
            // 
            // lblNameJob
            // 
            lblNameJob.AutoSize = false;
            lblNameJob.BackColor = Color.Transparent;
            lblNameJob.Dock = DockStyle.Fill;
            lblNameJob.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
            lblNameJob.Location = new Point(0, 0);
            lblNameJob.Name = "lblNameJob";
            lblNameJob.Size = new Size(427, 54);
            lblNameJob.TabIndex = 0;
            lblNameJob.Text = "Name Job";
            lblNameJob.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel4
            // 
            guna2Panel4.Controls.Add(lblDateEnd);
            guna2Panel4.Controls.Add(lblDatePuslish);
            guna2Panel4.CustomizableEdges = customizableEdges21;
            guna2Panel4.Dock = DockStyle.Top;
            guna2Panel4.Location = new Point(25, 0);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Panel4.Size = new Size(427, 46);
            guna2Panel4.TabIndex = 1;
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = false;
            lblDateEnd.BackColor = Color.Transparent;
            lblDateEnd.Dock = DockStyle.Right;
            lblDateEnd.Font = new Font("Verdana", 9F);
            lblDateEnd.ForeColor = Color.DarkGray;
            lblDateEnd.Location = new Point(207, 0);
            lblDateEnd.Margin = new Padding(3, 3, 50, 3);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(220, 46);
            lblDateEnd.TabIndex = 54;
            lblDateEnd.Text = "Date End";
            lblDateEnd.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblDatePuslish
            // 
            lblDatePuslish.AutoSize = false;
            lblDatePuslish.BackColor = Color.Transparent;
            lblDatePuslish.Dock = DockStyle.Left;
            lblDatePuslish.Font = new Font("Verdana", 9F);
            lblDatePuslish.ForeColor = Color.DarkGray;
            lblDatePuslish.Location = new Point(0, 0);
            lblDatePuslish.Name = "lblDatePuslish";
            lblDatePuslish.Size = new Size(201, 46);
            lblDatePuslish.TabIndex = 54;
            lblDatePuslish.Text = "date publish";
            lblDatePuslish.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel5
            // 
            guna2Panel5.CustomizableEdges = customizableEdges23;
            guna2Panel5.Dock = DockStyle.Left;
            guna2Panel5.Location = new Point(0, 0);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2Panel5.Size = new Size(25, 246);
            guna2Panel5.TabIndex = 0;
            // 
            // pnWrap
            // 
            pnWrap.BackColor = Color.Transparent;
            pnWrap.Controls.Add(lblCountApplicants);
            pnWrap.Controls.Add(pnBody);
            pnWrap.Controls.Add(btnApplicants);
            pnWrap.Dock = DockStyle.Fill;
            pnWrap.FillColor = Color.White;
            pnWrap.Location = new Point(0, 0);
            pnWrap.Name = "pnWrap";
            pnWrap.Radius = 15;
            pnWrap.ShadowColor = Color.Black;
            pnWrap.ShadowDepth = 110;
            pnWrap.Size = new Size(481, 316);
            pnWrap.TabIndex = 54;
            // 
            // lblCountApplicants
            // 
            lblCountApplicants.AutoSize = true;
            lblCountApplicants.BackColor = Color.IndianRed;
            lblCountApplicants.Location = new Point(287, 261);
            lblCountApplicants.Name = "lblCountApplicants";
            lblCountApplicants.Size = new Size(13, 15);
            lblCountApplicants.TabIndex = 12;
            lblCountApplicants.Text = "0";
            // 
            // UCHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnWrap);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCHistory";
            Size = new Size(481, 316);
            Load += UCHistory_Load;
            guna2Panel7.ResumeLayout(false);
            pnBody.ResumeLayout(false);
            guna2Panel9.ResumeLayout(false);
            guna2Panel6.ResumeLayout(false);
            guna2Panel4.ResumeLayout(false);
            pnWrap.ResumeLayout(false);
            pnWrap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnApplicants;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        public Guna.UI2.WinForms.Guna2ShadowPanel pnBody;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameJob;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateEnd;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDatePuslish;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnWrap;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWorkingType;
        private Label lblStatus;
        private Label label1;
        private Label lblCountApplicants;
    }
}
