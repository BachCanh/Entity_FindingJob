using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FRatings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRatings));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel10 = new Panel();
            btnRate = new Guna.UI2.WinForms.Guna2Button();
            btnRatings = new Guna.UI2.WinForms.Guna2Button();
            lblRate = new Guna.UI2.WinForms.Guna2Button();
            ptbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            lblCompanyNameLeft = new ReaLTaiizor.Controls.MetroLabel();
            flpRatings = new FlowLayoutPanel();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.Controls.Add(btnRate);
            panel10.Controls.Add(btnRatings);
            panel10.Controls.Add(lblRate);
            panel10.Controls.Add(ptbAvatar);
            panel10.Controls.Add(lblCompanyNameLeft);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(498, 121);
            panel10.TabIndex = 52;
            // 
            // btnRate
            // 
            btnRate.BackColor = Color.Transparent;
            btnRate.BorderRadius = 10;
            btnRate.CustomizableEdges = customizableEdges1;
            btnRate.DisabledState.BorderColor = Color.DarkGray;
            btnRate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRate.FillColor = Color.MistyRose;
            btnRate.Font = new Font("Segoe UI", 15F, FontStyle.Underline);
            btnRate.ForeColor = Color.Black;
            btnRate.Location = new Point(380, 76);
            btnRate.Name = "btnRate";
            btnRate.ShadowDecoration.BorderRadius = 10;
            btnRate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRate.ShadowDecoration.Depth = 10;
            btnRate.ShadowDecoration.Enabled = true;
            btnRate.Size = new Size(106, 37);
            btnRate.TabIndex = 55;
            btnRate.Text = "RATE";
            btnRate.Click += btnRate_Click;
            // 
            // btnRatings
            // 
            btnRatings.CustomizableEdges = customizableEdges3;
            btnRatings.DisabledState.BorderColor = Color.DarkGray;
            btnRatings.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRatings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRatings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRatings.FillColor = Color.Transparent;
            btnRatings.Font = new Font("Segoe UI", 15F, FontStyle.Underline);
            btnRatings.ForeColor = Color.Black;
            btnRatings.Location = new Point(233, 78);
            btnRatings.Name = "btnRatings";
            btnRatings.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRatings.Size = new Size(141, 37);
            btnRatings.TabIndex = 55;
            btnRatings.Text = "117 ratings";
            btnRatings.TextAlign = HorizontalAlignment.Left;
            // 
            // lblRate
            // 
            lblRate.CustomizableEdges = customizableEdges5;
            lblRate.DisabledState.BorderColor = Color.DarkGray;
            lblRate.DisabledState.CustomBorderColor = Color.DarkGray;
            lblRate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblRate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblRate.FillColor = Color.Transparent;
            lblRate.Font = new Font("Segoe UI", 15F);
            lblRate.ForeColor = Color.Black;
            lblRate.Image = (Image)resources.GetObject("lblRate.Image");
            lblRate.Location = new Point(140, 78);
            lblRate.Name = "lblRate";
            lblRate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            lblRate.Size = new Size(87, 37);
            lblRate.TabIndex = 56;
            lblRate.Text = "4.5/5";
            // 
            // ptbAvatar
            // 
            ptbAvatar.CustomizableEdges = customizableEdges7;
            ptbAvatar.Image = (Image)resources.GetObject("ptbAvatar.Image");
            ptbAvatar.ImageRotate = 0F;
            ptbAvatar.Location = new Point(14, 19);
            ptbAvatar.Margin = new Padding(3, 2, 3, 2);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ptbAvatar.Size = new Size(120, 92);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 51;
            ptbAvatar.TabStop = false;
            // 
            // lblCompanyNameLeft
            // 
            lblCompanyNameLeft.Font = new Font("Segoe UI Variable Text Semibold", 15F, FontStyle.Bold);
            lblCompanyNameLeft.IsDerivedStyle = true;
            lblCompanyNameLeft.Location = new Point(199, 16);
            lblCompanyNameLeft.Name = "lblCompanyNameLeft";
            lblCompanyNameLeft.Size = new Size(243, 62);
            lblCompanyNameLeft.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lblCompanyNameLeft.StyleManager = null;
            lblCompanyNameLeft.TabIndex = 48;
            lblCompanyNameLeft.Text = "ABC Company ";
            lblCompanyNameLeft.TextAlign = ContentAlignment.MiddleCenter;
            lblCompanyNameLeft.ThemeAuthor = "Taiizor";
            lblCompanyNameLeft.ThemeName = "MetroLight";
            // 
            // flpRatings
            // 
            flpRatings.AutoScroll = true;
            flpRatings.Dock = DockStyle.Fill;
            flpRatings.Location = new Point(0, 121);
            flpRatings.Name = "flpRatings";
            flpRatings.Size = new Size(498, 481);
            flpRatings.TabIndex = 53;
            // 
            // FRatings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 602);
            Controls.Add(flpRatings);
            Controls.Add(panel10);
            Name = "FRatings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRatings";
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Guna.UI2.WinForms.Guna2PictureBox ptbAvatar;
        private ReaLTaiizor.Controls.MetroLabel lblCompanyNameLeft;
        private Guna.UI2.WinForms.Guna2Button btnRatings;
        private Guna.UI2.WinForms.Guna2Button lblRate;
        private FlowLayoutPanel flpRatings;
        private Guna.UI2.WinForms.Guna2Button btnRate;
    }
}