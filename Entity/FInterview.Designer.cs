using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FInterview
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            pnInterview = new Guna.UI2.WinForms.Guna2Panel();
            lblTimeInterview = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblDateInterview = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnDone = new ReaLTaiizor.Controls.CyberButton();
            pnInterview.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 30;
            guna2ShadowForm1.TargetForm = this;
            // 
            // pnInterview
            // 
            pnInterview.BackColor = Color.Transparent;
            pnInterview.Controls.Add(lblTimeInterview);
            pnInterview.Controls.Add(lblDateInterview);
            pnInterview.Controls.Add(guna2HtmlLabel1);
            pnInterview.CustomizableEdges = customizableEdges13;
            pnInterview.Dock = DockStyle.Fill;
            pnInterview.Enabled = false;
            pnInterview.FillColor = Color.White;
            pnInterview.Location = new Point(0, 0);
            pnInterview.Name = "pnInterview";
            pnInterview.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnInterview.Size = new Size(456, 155);
            pnInterview.TabIndex = 46;
            // 
            // lblTimeInterview
            // 
            lblTimeInterview.AutoSize = false;
            lblTimeInterview.BackColor = Color.Transparent;
            lblTimeInterview.Dock = DockStyle.Fill;
            lblTimeInterview.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeInterview.Location = new Point(228, 48);
            lblTimeInterview.Name = "lblTimeInterview";
            lblTimeInterview.Size = new Size(228, 107);
            lblTimeInterview.TabIndex = 3;
            lblTimeInterview.Text = "Time Interview";
            lblTimeInterview.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblDateInterview
            // 
            lblDateInterview.AutoSize = false;
            lblDateInterview.BackColor = Color.Transparent;
            lblDateInterview.Dock = DockStyle.Left;
            lblDateInterview.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateInterview.Location = new Point(0, 48);
            lblDateInterview.Name = "lblDateInterview";
            lblDateInterview.Size = new Size(228, 107);
            lblDateInterview.TabIndex = 1;
            lblDateInterview.Text = "Date Interview";
            lblDateInterview.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Gainsboro;
            guna2HtmlLabel1.Dock = DockStyle.Top;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(0, 0);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(456, 48);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Schedule Interview";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.Controls.Add(btnDone);
            guna2Panel1.CustomizableEdges = customizableEdges15;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.FillColor = Color.MistyRose;
            guna2Panel1.Location = new Point(0, 155);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.BorderRadius = 0;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel1.ShadowDecoration.Depth = 15;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.Size = new Size(456, 66);
            guna2Panel1.TabIndex = 47;
            // 
            // btnDone
            // 
            btnDone.Alpha = 20;
            btnDone.BackColor = Color.Transparent;
            btnDone.Background = true;
            btnDone.Background_WidthPen = 4F;
            btnDone.BackgroundPen = true;
            btnDone.ColorBackground = Color.FromArgb(176, 226, 243);
            btnDone.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnDone.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnDone.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnDone.ColorLighting = Color.FromArgb(128, 128, 255);
            btnDone.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnDone.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnDone.Cursor = Cursors.Hand;
            btnDone.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnDone.Effect_1 = true;
            btnDone.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDone.Effect_1_Transparency = 25;
            btnDone.Effect_2 = true;
            btnDone.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDone.Effect_2_Transparency = 20;
            btnDone.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = Color.FromArgb(46, 54, 71);
            btnDone.Lighting = true;
            btnDone.LinearGradient_Background = false;
            btnDone.LinearGradientPen = false;
            btnDone.Location = new Point(324, 14);
            btnDone.Name = "btnDone";
            btnDone.PenWidth = 15;
            btnDone.Rounding = true;
            btnDone.RoundingInt = 20;
            btnDone.Size = new Size(120, 40);
            btnDone.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDone.TabIndex = 45;
            btnDone.Tag = "Decline";
            btnDone.TextButton = "Done";
            btnDone.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDone.Timer_Effect_1 = 5;
            btnDone.Timer_RGB = 300;
            btnDone.Click += btnDone_Click;
            // 
            // FInterview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(456, 221);
            Controls.Add(pnInterview);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FInterview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FInterview";
            pnInterview.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel pnInterview;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateInterview;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimeInterview;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ReaLTaiizor.Controls.CyberButton btnDone;
    }
}