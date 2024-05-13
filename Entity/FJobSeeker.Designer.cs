using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FJobSeeker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJobSeeker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroControlBox4 = new ReaLTaiizor.Controls.MetroControlBox();
            this.metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchJob = new Guna.UI2.WinForms.Guna2Button();
            this.btnJobAlert = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.Controls.Add(this.metroControlBox4);
            this.panel1.Controls.Add(this.metroControlBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 16);
            this.panel1.TabIndex = 5;
            // 
            // metroControlBox4
            // 
            this.metroControlBox4.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox4.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox4.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox4.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox4.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroControlBox4.IsDerivedStyle = true;
            this.metroControlBox4.Location = new System.Drawing.Point(1012, 0);
            this.metroControlBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroControlBox4.MaximizeBox = true;
            this.metroControlBox4.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox4.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox4.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox4.MinimizeBox = true;
            this.metroControlBox4.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox4.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox4.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox4.Name = "metroControlBox4";
            this.metroControlBox4.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox4.StyleManager = null;
            this.metroControlBox4.TabIndex = 6;
            this.metroControlBox4.Text = "metroControlBox4";
            this.metroControlBox4.ThemeAuthor = "Taiizor";
            this.metroControlBox4.ThemeName = "MetroLight";
            // 
            // metroControlBox3
            // 
            this.metroControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox3.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox3.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox3.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox3.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox3.IsDerivedStyle = true;
            this.metroControlBox3.Location = new System.Drawing.Point(2016, -2);
            this.metroControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnSearchJob);
            this.panel2.Controls.Add(this.btnJobAlert);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 589);
            this.panel2.TabIndex = 6;
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
            this.btnLogOut.HoverState.Image = global::Entity.Properties.Resources.icons8_log_out_50__2_;
            this.btnLogOut.Image = global::Entity.Properties.Resources.icons8_log_out_50__1_;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogOut.Location = new System.Drawing.Point(0, 265);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnLogOut.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Size = new System.Drawing.Size(173, 62);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderRadius = 20;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnSetting.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnSetting.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.HoverState.Image = global::Entity.Properties.Resources.icons8_test_account_32__1_;
            this.btnSetting.Image = global::Entity.Properties.Resources.icons8_test_account_32;
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSetting.Location = new System.Drawing.Point(0, 203);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSetting.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnSetting.Size = new System.Drawing.Size(173, 62);
            this.btnSetting.TabIndex = 16;
            this.btnSetting.Text = "Profile";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchJob.BorderRadius = 20;
            this.btnSearchJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchJob.FillColor = System.Drawing.Color.Transparent;
            this.btnSearchJob.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnSearchJob.ForeColor = System.Drawing.Color.White;
            this.btnSearchJob.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnSearchJob.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnSearchJob.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSearchJob.HoverState.Image = global::Entity.Properties.Resources.icons8_job_seeker_50__1_;
            this.btnSearchJob.Image = global::Entity.Properties.Resources.icons8_job_seeker_50;
            this.btnSearchJob.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearchJob.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchJob.Location = new System.Drawing.Point(0, 141);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSearchJob.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnSearchJob.Size = new System.Drawing.Size(173, 62);
            this.btnSearchJob.TabIndex = 14;
            this.btnSearchJob.Text = "Search Job";
            this.btnSearchJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearchJob.Click += new System.EventHandler(this.btnSearchJob_Click);
            // 
            // btnJobAlert
            // 
            this.btnJobAlert.BackColor = System.Drawing.Color.Transparent;
            this.btnJobAlert.BorderRadius = 20;
            this.btnJobAlert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJobAlert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJobAlert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJobAlert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJobAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobAlert.FillColor = System.Drawing.Color.Transparent;
            this.btnJobAlert.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnJobAlert.ForeColor = System.Drawing.Color.White;
            this.btnJobAlert.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnJobAlert.HoverState.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.btnJobAlert.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnJobAlert.HoverState.Image = global::Entity.Properties.Resources.icons8_job_alert_66__1_;
            this.btnJobAlert.Image = global::Entity.Properties.Resources.icons8_job_alert_66;
            this.btnJobAlert.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJobAlert.ImageSize = new System.Drawing.Size(50, 50);
            this.btnJobAlert.Location = new System.Drawing.Point(0, 79);
            this.btnJobAlert.Name = "btnJobAlert";
            this.btnJobAlert.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnJobAlert.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnJobAlert.Size = new System.Drawing.Size(173, 62);
            this.btnJobAlert.TabIndex = 15;
            this.btnJobAlert.Text = "Job Alert";
            this.btnJobAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJobAlert.Click += new System.EventHandler(this.btnJobAlert_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnBody
            // 
            this.pnBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(173, 16);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(939, 589);
            this.pnBody.TabIndex = 7;
            // 
            // FJobSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 605);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FJobSeeker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.Load += new System.EventHandler(this.FJobSeeker_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox4;
        private Panel pnBody;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button btnJobAlert;
        private Guna.UI2.WinForms.Guna2Button btnSearchJob;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
    }
}