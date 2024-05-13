using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class UCInterview
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblJSeeker = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTimeAdd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.panel7);
            this.guna2Panel1.Controls.Add(this.panel5);
            this.guna2Panel1.Controls.Add(this.panel6);
            this.guna2Panel1.Controls.Add(this.panel4);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1184, 87);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblStatus);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(959, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 87);
            this.panel7.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(822, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 87);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTimeAdd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(644, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 87);
            this.panel6.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.lblJob);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(341, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 87);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 87);
            this.panel1.TabIndex = 2;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.ImageRotate = 0F;
            this.ptbAvatar.Location = new System.Drawing.Point(40, 6);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(79, 74);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 2;
            this.ptbAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblJSeeker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(127, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 87);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 87);
            this.panel2.TabIndex = 1;
            // 
            // lblJSeeker
            // 
            this.lblJSeeker.AutoSize = false;
            this.lblJSeeker.BackColor = System.Drawing.Color.Transparent;
            this.lblJSeeker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJSeeker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJSeeker.Location = new System.Drawing.Point(0, 0);
            this.lblJSeeker.Name = "lblJSeeker";
            this.lblJSeeker.Size = new System.Drawing.Size(214, 87);
            this.lblJSeeker.TabIndex = 0;
            this.lblJSeeker.Text = "Name Jobseeker";
            this.lblJSeeker.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = false;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJob.Location = new System.Drawing.Point(0, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(303, 87);
            this.lblJob.TabIndex = 0;
            this.lblJob.Text = "Name Job";
            this.lblJob.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeAdd
            // 
            this.lblTimeAdd.AutoSize = false;
            this.lblTimeAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblTimeAdd.Location = new System.Drawing.Point(0, 0);
            this.lblTimeAdd.Name = "lblTimeAdd";
            this.lblTimeAdd.Size = new System.Drawing.Size(178, 87);
            this.lblTimeAdd.TabIndex = 0;
            this.lblTimeAdd.Text = "28/11/2004";
            this.lblTimeAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = false;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(137, 87);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "15:00 - 17:00";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(225, 87);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "15:00 - 17:00";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.Name = "UCInterview";
            this.Size = new System.Drawing.Size(1184, 87);
            this.guna2Panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Panel panel6;
        public Panel panel5;
        public Panel panel4;
        public Panel panel1;
        public Guna.UI2.WinForms.Guna2PictureBox ptbAvatar;
        public Panel panel3;
        public Panel panel2;
        public Panel panel7;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJSeeker;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTimeAdd;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJob;
    }
}
