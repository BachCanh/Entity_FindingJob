using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnApplicant = new Guna.UI2.WinForms.Guna2Button();
            this.btnInterviewView = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostJob = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.metroControlBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 26);
            this.panel1.TabIndex = 2;
            // 
            // metroControlBox3
            // 
            this.metroControlBox3.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox3.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox3.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox3.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroControlBox3.IsDerivedStyle = true;
            this.metroControlBox3.Location = new System.Drawing.Point(1383, 0);
            this.metroControlBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.metroControlBox3.MaximizeBox = true;
            this.metroControlBox3.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox3.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MinimizeBox = true;
            this.metroControlBox3.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox3.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.Name = "metroControlBox3";
            this.metroControlBox3.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox3.StyleManager = null;
            this.metroControlBox3.TabIndex = 5;
            this.metroControlBox3.Text = "metroControlBox3";
            this.metroControlBox3.ThemeAuthor = "Taiizor";
            this.metroControlBox3.ThemeName = "MetroLight";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnApplicant);
            this.panel2.Controls.Add(this.btnInterviewView);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnHistory);
            this.panel2.Controls.Add(this.btnPostJob);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 719);
            this.panel2.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 20;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Cooper Black", 13.8F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLogOut.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogOut.Location = new System.Drawing.Point(0, 490);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnLogOut.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Size = new System.Drawing.Size(231, 76);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnApplicant
            // 
            this.btnApplicant.BorderRadius = 20;
            this.btnApplicant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApplicant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApplicant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplicant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApplicant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplicant.FillColor = System.Drawing.Color.Transparent;
            this.btnApplicant.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnApplicant.ForeColor = System.Drawing.Color.White;
            this.btnApplicant.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnApplicant.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnApplicant.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnApplicant.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnApplicant.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicant.Image")));
            this.btnApplicant.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplicant.ImageSize = new System.Drawing.Size(50, 50);
            this.btnApplicant.Location = new System.Drawing.Point(0, 414);
            this.btnApplicant.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnApplicant.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnApplicant.Size = new System.Drawing.Size(231, 76);
            this.btnApplicant.TabIndex = 2;
            this.btnApplicant.Text = "Applicants";
            this.btnApplicant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplicant.Click += new System.EventHandler(this.btnApplicant_Click);
            // 
            // btnInterviewView
            // 
            this.btnInterviewView.BorderRadius = 20;
            this.btnInterviewView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInterviewView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInterviewView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInterviewView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInterviewView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInterviewView.FillColor = System.Drawing.Color.Transparent;
            this.btnInterviewView.Font = new System.Drawing.Font("Cooper Black", 13.8F);
            this.btnInterviewView.ForeColor = System.Drawing.Color.White;
            this.btnInterviewView.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnInterviewView.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnInterviewView.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnInterviewView.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnInterviewView.Image = ((System.Drawing.Image)(resources.GetObject("btnInterviewView.Image")));
            this.btnInterviewView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInterviewView.ImageSize = new System.Drawing.Size(50, 50);
            this.btnInterviewView.Location = new System.Drawing.Point(0, 357);
            this.btnInterviewView.Margin = new System.Windows.Forms.Padding(4);
            this.btnInterviewView.Name = "btnInterviewView";
            this.btnInterviewView.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnInterviewView.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnInterviewView.Size = new System.Drawing.Size(231, 57);
            this.btnInterviewView.TabIndex = 4;
            this.btnInterviewView.Text = "Interviews";
            this.btnInterviewView.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInterviewView.Click += new System.EventHandler(this.btnInterviewView_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BorderRadius = 20;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("Cooper Black", 13.8F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnSetting.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnSetting.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSetting.Location = new System.Drawing.Point(0, 281);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSetting.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnSetting.Size = new System.Drawing.Size(231, 76);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Profile";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHistory
            // 
            this.btnHistory.BorderRadius = 20;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FillColor = System.Drawing.Color.Transparent;
            this.btnHistory.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHistory.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnHistory.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.ImageSize = new System.Drawing.Size(50, 50);
            this.btnHistory.Location = new System.Drawing.Point(0, 205);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnHistory.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnHistory.Size = new System.Drawing.Size(231, 76);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPostJob
            // 
            this.btnPostJob.BorderRadius = 20;
            this.btnPostJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostJob.FillColor = System.Drawing.Color.Transparent;
            this.btnPostJob.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnPostJob.ForeColor = System.Drawing.Color.White;
            this.btnPostJob.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPostJob.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnPostJob.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPostJob.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnPostJob.Image = ((System.Drawing.Image)(resources.GetObject("btnPostJob.Image")));
            this.btnPostJob.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPostJob.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPostJob.Location = new System.Drawing.Point(0, 129);
            this.btnPostJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostJob.Name = "btnPostJob";
            this.btnPostJob.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnPostJob.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnPostJob.Size = new System.Drawing.Size(231, 76);
            this.btnPostJob.TabIndex = 0;
            this.btnPostJob.Text = "List of Job";
            this.btnPostJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPostJob.Click += new System.EventHandler(this.btnPostJob_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(231, 26);
            this.pnBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1252, 719);
            this.pnBody.TabIndex = 4;
            // 
            // FCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1483, 745);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCompany";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel pnBody;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnPostJob;
        private Guna.UI2.WinForms.Guna2Button btnInterviewView;
        private Guna.UI2.WinForms.Guna2Button btnApplicant;
    }
}