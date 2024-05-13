using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class UCApplicant
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblDateT = new Label();
            ptbApplicantPicture = new PictureBox();
            lblApplicantNameT = new Label();
            lblEmailT = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnAnswer = new Guna.UI2.WinForms.Guna2Button();
            btnProfile = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            guna2ShadowPanel2.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = Color.FromArgb(64, 64, 64);
            lblDateT.Location = new Point(17, 14);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(45, 19);
            lblDateT.TabIndex = 7;
            lblDateT.Text = "Date: ";
            // 
            // ptbApplicantPicture
            // 
            ptbApplicantPicture.Location = new Point(99, 37);
            ptbApplicantPicture.Margin = new Padding(3, 2, 3, 2);
            ptbApplicantPicture.Name = "ptbApplicantPicture";
            ptbApplicantPicture.Size = new Size(192, 192);
            ptbApplicantPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbApplicantPicture.TabIndex = 10;
            ptbApplicantPicture.TabStop = false;
            // 
            // lblApplicantNameT
            // 
            lblApplicantNameT.Dock = DockStyle.Fill;
            lblApplicantNameT.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblApplicantNameT.ForeColor = SystemColors.ControlText;
            lblApplicantNameT.Location = new Point(0, 0);
            lblApplicantNameT.Name = "lblApplicantNameT";
            lblApplicantNameT.Size = new Size(387, 60);
            lblApplicantNameT.TabIndex = 5;
            lblApplicantNameT.Text = "Applicant's Name:";
            lblApplicantNameT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailT
            // 
            lblEmailT.Dock = DockStyle.Fill;
            lblEmailT.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailT.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmailT.Location = new Point(0, 0);
            lblEmailT.Name = "lblEmailT";
            lblEmailT.Size = new Size(387, 42);
            lblEmailT.TabIndex = 1;
            lblEmailT.Text = "Email";
            lblEmailT.TextAlign = ContentAlignment.TopCenter;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnAnswer);
            guna2ShadowPanel1.Controls.Add(btnProfile);
            guna2ShadowPanel1.Controls.Add(guna2ShadowPanel2);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(410, 407);
            guna2ShadowPanel1.TabIndex = 4;
            // 
            // btnAnswer
            // 
            btnAnswer.BorderRadius = 10;
            btnAnswer.Cursor = Cursors.Hand;
            btnAnswer.CustomizableEdges = customizableEdges1;
            btnAnswer.DisabledState.BorderColor = Color.DarkGray;
            btnAnswer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAnswer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAnswer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAnswer.FillColor = Color.FromArgb(176, 226, 243);
            btnAnswer.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer.ForeColor = Color.Black;
            btnAnswer.Location = new Point(54, 354);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAnswer.Size = new Size(107, 36);
            btnAnswer.TabIndex = 14;
            btnAnswer.Text = "Answer";
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnProfile
            // 
            btnProfile.BorderRadius = 10;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.CustomizableEdges = customizableEdges3;
            btnProfile.DisabledState.BorderColor = Color.DarkGray;
            btnProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProfile.FillColor = Color.FromArgb(176, 226, 243);
            btnProfile.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.Black;
            btnProfile.Location = new Point(247, 354);
            btnProfile.Name = "btnProfile";
            btnProfile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnProfile.Size = new Size(107, 36);
            btnProfile.TabIndex = 14;
            btnProfile.Text = "Profile";
            btnProfile.Click += btnProfile_Click;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(guna2Panel2);
            guna2ShadowPanel2.Controls.Add(guna2Panel1);
            guna2ShadowPanel2.Controls.Add(ptbApplicantPicture);
            guna2ShadowPanel2.Controls.Add(lblDateT);
            guna2ShadowPanel2.FillColor = Color.FromArgb(254, 232, 223);
            guna2ShadowPanel2.Location = new Point(11, 12);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 10;
            guna2ShadowPanel2.ShadowColor = Color.Black;
            guna2ShadowPanel2.Size = new Size(387, 334);
            guna2ShadowPanel2.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(lblApplicantNameT);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.Location = new Point(0, 232);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(387, 60);
            guna2Panel2.TabIndex = 12;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblEmailT);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 292);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(387, 42);
            guna2Panel1.TabIndex = 11;
            // 
            // UCApplicant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCApplicant";
            Size = new Size(410, 407);
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblEmailT;
        private Label lblDateT;
        private Label lblApplicantNameT;
        private PictureBox ptbApplicantPicture;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAnswer;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
    }
}
