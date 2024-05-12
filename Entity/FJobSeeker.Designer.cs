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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJobSeeker));
            panel1 = new Panel();
            metroControlBox4 = new ReaLTaiizor.Controls.MetroControlBox();
            metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            panel2 = new Panel();
            btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            btnSetting = new Guna.UI2.WinForms.Guna2Button();
            btnSearchJob = new Guna.UI2.WinForms.Guna2Button();
            btnJobAlert = new Guna.UI2.WinForms.Guna2Button();
            pictureBox2 = new PictureBox();
            pnBody = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(metroControlBox4);
            panel1.Controls.Add(metroControlBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 18);
            panel1.TabIndex = 5;
            // 
            // metroControlBox4
            // 
            metroControlBox4.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox4.CloseHoverForeColor = Color.White;
            metroControlBox4.CloseNormalForeColor = Color.Gray;
            metroControlBox4.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox4.DisabledForeColor = Color.DimGray;
            metroControlBox4.Dock = DockStyle.Right;
            metroControlBox4.IsDerivedStyle = true;
            metroControlBox4.Location = new Point(1197, 0);
            metroControlBox4.Margin = new Padding(3, 2, 3, 2);
            metroControlBox4.MaximizeBox = true;
            metroControlBox4.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox4.MaximizeHoverForeColor = Color.Gray;
            metroControlBox4.MaximizeNormalForeColor = Color.Gray;
            metroControlBox4.MinimizeBox = true;
            metroControlBox4.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox4.MinimizeHoverForeColor = Color.Gray;
            metroControlBox4.MinimizeNormalForeColor = Color.Gray;
            metroControlBox4.Name = "metroControlBox4";
            metroControlBox4.Size = new Size(100, 25);
            metroControlBox4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox4.StyleManager = null;
            metroControlBox4.TabIndex = 6;
            metroControlBox4.Text = "metroControlBox4";
            metroControlBox4.ThemeAuthor = "Taiizor";
            metroControlBox4.ThemeName = "MetroLight";
            // 
            // metroControlBox3
            // 
            metroControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox3.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox3.CloseHoverForeColor = Color.White;
            metroControlBox3.CloseNormalForeColor = Color.Gray;
            metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox3.DisabledForeColor = Color.DimGray;
            metroControlBox3.IsDerivedStyle = true;
            metroControlBox3.Location = new Point(2352, -2);
            metroControlBox3.Margin = new Padding(3, 2, 3, 2);
            metroControlBox3.MaximizeBox = true;
            metroControlBox3.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MaximizeHoverForeColor = Color.Gray;
            metroControlBox3.MaximizeNormalForeColor = Color.Gray;
            metroControlBox3.MinimizeBox = true;
            metroControlBox3.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MinimizeHoverForeColor = Color.Gray;
            metroControlBox3.MinimizeNormalForeColor = Color.Gray;
            metroControlBox3.Name = "metroControlBox3";
            metroControlBox3.Size = new Size(100, 25);
            metroControlBox3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox3.StyleManager = null;
            metroControlBox3.TabIndex = 5;
            metroControlBox3.Text = "metroControlBox3";
            metroControlBox3.ThemeAuthor = "Taiizor";
            metroControlBox3.ThemeName = "MetroLight";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 59, 96);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(btnSearchJob);
            panel2.Controls.Add(btnJobAlert);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 18);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 680);
            panel2.TabIndex = 6;
            // 
            // btnLogOut
            // 
            btnLogOut.BorderRadius = 20;
            btnLogOut.CustomizableEdges = customizableEdges1;
            btnLogOut.DisabledState.BorderColor = Color.DarkGray;
            btnLogOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FillColor = Color.Transparent;
            btnLogOut.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.HoverState.FillColor = Color.FromArgb(220, 251, 251);
            btnLogOut.HoverState.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.HoverState.ForeColor = Color.Black;
            btnLogOut.HoverState.Image = Properties.Resources.icons8_log_out_50__2_;
            btnLogOut.Image = Properties.Resources.icons8_log_out_50__1_;
            btnLogOut.ImageAlign = HorizontalAlignment.Left;
            btnLogOut.ImageSize = new Size(50, 50);
            btnLogOut.Location = new Point(0, 304);
            btnLogOut.Margin = new Padding(4, 4, 4, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.ShadowDecoration.Color = Color.White;
            btnLogOut.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogOut.ShadowDecoration.Shadow = new Padding(2);
            btnLogOut.Size = new Size(202, 71);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextAlign = HorizontalAlignment.Left;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.BorderRadius = 20;
            btnSetting.CustomizableEdges = customizableEdges3;
            btnSetting.DisabledState.BorderColor = Color.DarkGray;
            btnSetting.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSetting.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSetting.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FillColor = Color.Transparent;
            btnSetting.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = Color.White;
            btnSetting.HoverState.FillColor = Color.FromArgb(220, 251, 251);
            btnSetting.HoverState.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.HoverState.ForeColor = Color.Black;
            btnSetting.HoverState.Image = Properties.Resources.icons8_test_account_32__1_;
            btnSetting.Image = Properties.Resources.icons8_test_account_32;
            btnSetting.ImageAlign = HorizontalAlignment.Left;
            btnSetting.ImageSize = new Size(50, 50);
            btnSetting.Location = new Point(0, 233);
            btnSetting.Margin = new Padding(4, 4, 4, 4);
            btnSetting.Name = "btnSetting";
            btnSetting.ShadowDecoration.Color = Color.White;
            btnSetting.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSetting.ShadowDecoration.Shadow = new Padding(2);
            btnSetting.Size = new Size(202, 71);
            btnSetting.TabIndex = 16;
            btnSetting.Text = "Profile";
            btnSetting.TextAlign = HorizontalAlignment.Left;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnSearchJob
            // 
            btnSearchJob.BackColor = Color.Transparent;
            btnSearchJob.BorderRadius = 20;
            btnSearchJob.CustomizableEdges = customizableEdges5;
            btnSearchJob.DisabledState.BorderColor = Color.DarkGray;
            btnSearchJob.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchJob.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchJob.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchJob.Dock = DockStyle.Top;
            btnSearchJob.FillColor = Color.Transparent;
            btnSearchJob.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchJob.ForeColor = Color.White;
            btnSearchJob.HoverState.FillColor = Color.FromArgb(220, 251, 251);
            btnSearchJob.HoverState.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchJob.HoverState.ForeColor = Color.Black;
            btnSearchJob.HoverState.Image = Properties.Resources.icons8_job_seeker_50__1_;
            btnSearchJob.Image = Properties.Resources.icons8_job_seeker_50;
            btnSearchJob.ImageAlign = HorizontalAlignment.Left;
            btnSearchJob.ImageSize = new Size(50, 50);
            btnSearchJob.Location = new Point(0, 162);
            btnSearchJob.Margin = new Padding(4, 4, 4, 4);
            btnSearchJob.Name = "btnSearchJob";
            btnSearchJob.ShadowDecoration.Color = Color.White;
            btnSearchJob.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearchJob.ShadowDecoration.Shadow = new Padding(2);
            btnSearchJob.Size = new Size(202, 71);
            btnSearchJob.TabIndex = 14;
            btnSearchJob.Text = "Search Job";
            btnSearchJob.TextAlign = HorizontalAlignment.Left;
            btnSearchJob.Click += btnSearchJob_Click;
            // 
            // btnJobAlert
            // 
            btnJobAlert.BackColor = Color.Transparent;
            btnJobAlert.BorderRadius = 20;
            btnJobAlert.CustomizableEdges = customizableEdges7;
            btnJobAlert.DisabledState.BorderColor = Color.DarkGray;
            btnJobAlert.DisabledState.CustomBorderColor = Color.DarkGray;
            btnJobAlert.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnJobAlert.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnJobAlert.Dock = DockStyle.Top;
            btnJobAlert.FillColor = Color.Transparent;
            btnJobAlert.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnJobAlert.ForeColor = Color.White;
            btnJobAlert.HoverState.FillColor = Color.FromArgb(220, 251, 251);
            btnJobAlert.HoverState.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnJobAlert.HoverState.ForeColor = Color.Black;
            btnJobAlert.HoverState.Image = Properties.Resources.icons8_job_alert_66__1_;
            btnJobAlert.Image = Properties.Resources.icons8_job_alert_66;
            btnJobAlert.ImageAlign = HorizontalAlignment.Left;
            btnJobAlert.ImageSize = new Size(50, 50);
            btnJobAlert.Location = new Point(0, 91);
            btnJobAlert.Margin = new Padding(4, 4, 4, 4);
            btnJobAlert.Name = "btnJobAlert";
            btnJobAlert.ShadowDecoration.Color = Color.White;
            btnJobAlert.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnJobAlert.ShadowDecoration.Shadow = new Padding(2);
            btnJobAlert.Size = new Size(202, 71);
            btnJobAlert.TabIndex = 15;
            btnJobAlert.Text = "Job Alert";
            btnJobAlert.TextAlign = HorizontalAlignment.Left;
            btnJobAlert.Click += btnJobAlert_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnBody
            // 
            pnBody.BorderStyle = BorderStyle.FixedSingle;
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(202, 18);
            pnBody.Margin = new Padding(3, 2, 3, 2);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1095, 680);
            pnBody.TabIndex = 7;
            // 
            // FJobSeeker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1297, 698);
            Controls.Add(pnBody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FJobSeeker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "d";
            Load += FJobSeeker_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
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