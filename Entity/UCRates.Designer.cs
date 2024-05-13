using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class UCRates
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRates));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            lblContents = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblTimeRates = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnStars = new Guna.UI2.WinForms.Guna2Panel();
            lblNames = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ptbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            rtStars = new Guna.UI2.WinForms.Guna2RatingStar();
            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            guna2Panel2.SuspendLayout();
            pnStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoSize = true;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(guna2Panel3);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(ptbAvatar);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.FillColor = Color.SeaShell;
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.BorderRadius = 15;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.ShadowDecoration.Depth = 15;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.Size = new Size(458, 104);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            guna2Panel3.AutoSize = true;
            guna2Panel3.Controls.Add(lblContents);
            guna2Panel3.CustomizableEdges = customizableEdges1;
            guna2Panel3.Location = new Point(86, 85);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel3.Size = new Size(355, 16);
            guna2Panel3.TabIndex = 54;
            // 
            // lblContents
            // 
            lblContents.AutoSize = false;
            lblContents.AutoSizeHeightOnly = true;
            lblContents.BackColor = Color.Transparent;
            lblContents.Dock = DockStyle.Top;
            lblContents.Location = new Point(0, 0);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(355, 16);
            lblContents.TabIndex = 0;
            lblContents.Text = "content";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(lblTimeRates);
            guna2Panel2.Controls.Add(pnStars);
            guna2Panel2.Controls.Add(lblNames);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Location = new Point(86, 11);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(355, 68);
            guna2Panel2.TabIndex = 53;
            // 
            // lblTimeRates
            // 
            lblTimeRates.AutoSize = false;
            lblTimeRates.BackColor = Color.Transparent;
            lblTimeRates.Dock = DockStyle.Fill;
            lblTimeRates.Location = new Point(0, 46);
            lblTimeRates.Name = "lblTimeRates";
            lblTimeRates.Size = new Size(355, 22);
            lblTimeRates.TabIndex = 2;
            lblTimeRates.Text = "guna2HtmlLabel2";
            lblTimeRates.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // pnStars
            // 
            pnStars.Controls.Add(rtStars);
            pnStars.CustomizableEdges = customizableEdges3;
            pnStars.Dock = DockStyle.Top;
            pnStars.Location = new Point(0, 25);
            pnStars.Name = "pnStars";
            pnStars.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnStars.Size = new Size(355, 21);
            pnStars.TabIndex = 1;
            // 
            // lblNames
            // 
            lblNames.AutoSize = false;
            lblNames.BackColor = Color.Transparent;
            lblNames.Dock = DockStyle.Top;
            lblNames.Location = new Point(0, 0);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(355, 25);
            lblNames.TabIndex = 0;
            lblNames.Text = "guna2HtmlLabel1";
            lblNames.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // ptbAvatar
            // 
            ptbAvatar.BorderRadius = 10;
            ptbAvatar.CustomizableEdges = customizableEdges7;
            ptbAvatar.Image = (Image)resources.GetObject("ptbAvatar.Image");
            ptbAvatar.ImageRotate = 0F;
            ptbAvatar.Location = new Point(12, 11);
            ptbAvatar.Margin = new Padding(3, 2, 3, 2);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ptbAvatar.Size = new Size(68, 68);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 52;
            ptbAvatar.TabStop = false;
            // 
            // rtStars
            // 
            rtStars.Location = new Point(6, -3);
            rtStars.Name = "rtStars";
            rtStars.Size = new Size(120, 28);
            rtStars.TabIndex = 0;
            // 
            // UCRates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Margin = new Padding(10, 5, 5, 5);
            Name = "UCRates";
            Size = new Size(464, 110);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel3.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            pnStars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbAvatar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNames;
        private Guna.UI2.WinForms.Guna2Panel pnStars;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimeRates;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContents;
        private Guna.UI2.WinForms.Guna2RatingStar rtStars;
    }
}
