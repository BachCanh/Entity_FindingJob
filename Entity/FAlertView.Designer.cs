using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FAlertView
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
            lblContent = new Label();
            lblSubject = new Label();
            lblDateT = new Label();
            lblDate = new Label();
            llFromT = new Label();
            lblFrom = new Label();
            lblSubjectT = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblContentT = new Label();
            btnDone = new ReaLTaiizor.Controls.CyberButton();
            lblTitle = new Label();
            lblJobT = new Label();
            btnInterview = new ReaLTaiizor.Controls.CyberButton();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            btnAccept = new ReaLTaiizor.Controls.CyberButton();
            btnReject = new ReaLTaiizor.Controls.CyberButton();
            lblResponseT = new Label();
            lblResponse = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblContent.Location = new Point(10, 229);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(106, 31);
            lblContent.TabIndex = 35;
            lblContent.Text = "Content:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubject.Location = new Point(10, 168);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(100, 31);
            lblSubject.TabIndex = 34;
            lblSubject.Text = "Subject:";
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(121, 116);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(69, 32);
            lblDateT.TabIndex = 33;
            lblDateT.Text = "Date:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(10, 116);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(70, 31);
            lblDate.TabIndex = 32;
            lblDate.Text = "Date:";
            // 
            // llFromT
            // 
            llFromT.AutoSize = true;
            llFromT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            llFromT.Location = new Point(121, 65);
            llFromT.Name = "llFromT";
            llFromT.Size = new Size(74, 32);
            llFromT.TabIndex = 31;
            llFromT.Text = "From:";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrom.Location = new Point(10, 65);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(76, 31);
            lblFrom.TabIndex = 30;
            lblFrom.Text = "From:";
            // 
            // lblSubjectT
            // 
            lblSubjectT.AutoSize = true;
            lblSubjectT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubjectT.Location = new Point(121, 168);
            lblSubjectT.Name = "lblSubjectT";
            lblSubjectT.Size = new Size(98, 32);
            lblSubjectT.TabIndex = 40;
            lblSubjectT.Text = "Subject:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(lblContentT);
            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel1.Location = new Point(121, 229);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(857, 235);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // lblContentT
            // 
            lblContentT.AutoSize = true;
            lblContentT.BackColor = Color.White;
            lblContentT.Dock = DockStyle.Fill;
            lblContentT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContentT.Location = new Point(3, 0);
            lblContentT.Name = "lblContentT";
            lblContentT.Size = new Size(82, 28);
            lblContentT.TabIndex = 0;
            lblContentT.Text = "Content";
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
            btnDone.ColorBackground_Pen = Color.LightCoral;
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
            btnDone.Location = new Point(841, 529);
            btnDone.Margin = new Padding(3, 4, 3, 4);
            btnDone.Name = "btnDone";
            btnDone.PenWidth = 15;
            btnDone.Rounding = true;
            btnDone.RoundingInt = 20;
            btnDone.Size = new Size(137, 53);
            btnDone.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDone.TabIndex = 44;
            btnDone.Tag = "Decline";
            btnDone.TextButton = "Done";
            btnDone.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDone.Timer_Effect_1 = 5;
            btnDone.Timer_RGB = 300;
            btnDone.Click += btnDone_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(14, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(74, 31);
            lblTitle.TabIndex = 34;
            lblTitle.Text = "Title: ";
            // 
            // lblJobT
            // 
            lblJobT.AutoSize = true;
            lblJobT.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblJobT.Location = new Point(121, 7);
            lblJobT.Name = "lblJobT";
            lblJobT.Size = new Size(84, 45);
            lblJobT.TabIndex = 40;
            lblJobT.Text = "Job:";
            // 
            // btnInterview
            // 
            btnInterview.Alpha = 20;
            btnInterview.BackColor = Color.Transparent;
            btnInterview.Background = true;
            btnInterview.Background_WidthPen = 4F;
            btnInterview.BackgroundPen = true;
            btnInterview.ColorBackground = Color.FromArgb(176, 226, 243);
            btnInterview.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnInterview.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnInterview.ColorBackground_Pen = Color.LightCoral;
            btnInterview.ColorLighting = Color.FromArgb(128, 128, 255);
            btnInterview.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnInterview.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnInterview.Cursor = Cursors.Hand;
            btnInterview.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnInterview.Effect_1 = true;
            btnInterview.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnInterview.Effect_1_Transparency = 25;
            btnInterview.Effect_2 = true;
            btnInterview.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnInterview.Effect_2_Transparency = 20;
            btnInterview.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnInterview.ForeColor = Color.FromArgb(46, 54, 71);
            btnInterview.Lighting = true;
            btnInterview.LinearGradient_Background = false;
            btnInterview.LinearGradientPen = false;
            btnInterview.Location = new Point(683, 529);
            btnInterview.Margin = new Padding(3, 4, 3, 4);
            btnInterview.Name = "btnInterview";
            btnInterview.PenWidth = 15;
            btnInterview.Rounding = true;
            btnInterview.RoundingInt = 20;
            btnInterview.Size = new Size(137, 53);
            btnInterview.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnInterview.TabIndex = 44;
            btnInterview.Tag = "Decline";
            btnInterview.TextButton = "Interview";
            btnInterview.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnInterview.Timer_Effect_1 = 5;
            btnInterview.Timer_RGB = 300;
            btnInterview.Visible = false;
            btnInterview.Click += btnInterview_Click;
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
            // btnAccept
            // 
            btnAccept.Alpha = 20;
            btnAccept.BackColor = Color.Transparent;
            btnAccept.Background = true;
            btnAccept.Background_WidthPen = 4F;
            btnAccept.BackgroundPen = true;
            btnAccept.ColorBackground = Color.FromArgb(176, 226, 243);
            btnAccept.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnAccept.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnAccept.ColorBackground_Pen = Color.LightCoral;
            btnAccept.ColorLighting = Color.FromArgb(128, 128, 255);
            btnAccept.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnAccept.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAccept.Effect_1 = true;
            btnAccept.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnAccept.Effect_1_Transparency = 25;
            btnAccept.Effect_2 = true;
            btnAccept.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnAccept.Effect_2_Transparency = 20;
            btnAccept.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccept.ForeColor = Color.FromArgb(46, 54, 71);
            btnAccept.Lighting = true;
            btnAccept.LinearGradient_Background = false;
            btnAccept.LinearGradientPen = false;
            btnAccept.Location = new Point(26, 529);
            btnAccept.Margin = new Padding(3, 4, 3, 4);
            btnAccept.Name = "btnAccept";
            btnAccept.PenWidth = 15;
            btnAccept.Rounding = true;
            btnAccept.RoundingInt = 20;
            btnAccept.Size = new Size(137, 53);
            btnAccept.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAccept.TabIndex = 45;
            btnAccept.Tag = "Decline";
            btnAccept.TextButton = "Accept";
            btnAccept.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAccept.Timer_Effect_1 = 5;
            btnAccept.Timer_RGB = 300;
            btnAccept.Visible = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.Alpha = 20;
            btnReject.BackColor = Color.Transparent;
            btnReject.Background = true;
            btnReject.Background_WidthPen = 4F;
            btnReject.BackgroundPen = true;
            btnReject.ColorBackground = Color.Salmon;
            btnReject.ColorBackground_1 = Color.Salmon;
            btnReject.ColorBackground_2 = Color.Salmon;
            btnReject.ColorBackground_Pen = Color.LightCoral;
            btnReject.ColorLighting = Color.FromArgb(128, 128, 255);
            btnReject.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnReject.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnReject.Cursor = Cursors.Hand;
            btnReject.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnReject.Effect_1 = true;
            btnReject.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnReject.Effect_1_Transparency = 25;
            btnReject.Effect_2 = true;
            btnReject.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnReject.Effect_2_Transparency = 20;
            btnReject.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnReject.ForeColor = Color.FromArgb(46, 54, 71);
            btnReject.Lighting = true;
            btnReject.LinearGradient_Background = false;
            btnReject.LinearGradientPen = false;
            btnReject.Location = new Point(185, 529);
            btnReject.Margin = new Padding(3, 4, 3, 4);
            btnReject.Name = "btnReject";
            btnReject.PenWidth = 15;
            btnReject.Rounding = true;
            btnReject.RoundingInt = 20;
            btnReject.Size = new Size(137, 53);
            btnReject.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnReject.TabIndex = 46;
            btnReject.Tag = "Decline";
            btnReject.TextButton = "Reject";
            btnReject.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnReject.Timer_Effect_1 = 5;
            btnReject.Timer_RGB = 300;
            btnReject.Visible = false;
            btnReject.Click += btnReject_Click;
            // 
            // lblResponseT
            // 
            lblResponseT.AutoSize = true;
            lblResponseT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResponseT.Location = new Point(195, 479);
            lblResponseT.Name = "lblResponseT";
            lblResponseT.Size = new Size(169, 32);
            lblResponseT.TabIndex = 48;
            lblResponseT.Text = "Your Response";
            lblResponseT.Visible = false;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblResponse.Location = new Point(15, 479);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(175, 31);
            lblResponse.TabIndex = 47;
            lblResponse.Text = "Your Response:";
            lblResponse.Visible = false;
            // 
            // FAlertView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(997, 600);
            Controls.Add(lblResponseT);
            Controls.Add(lblResponse);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            Controls.Add(btnInterview);
            Controls.Add(btnDone);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblJobT);
            Controls.Add(lblSubjectT);
            Controls.Add(lblTitle);
            Controls.Add(lblContent);
            Controls.Add(lblSubject);
            Controls.Add(lblDateT);
            Controls.Add(lblDate);
            Controls.Add(llFromT);
            Controls.Add(lblFrom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FAlertView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAlertView";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblContent;
        private Label lblSubject;
        private Label lblDateT;
        private Label lblDate;
        private Label llFromT;
        private Label lblFrom;
        private Label lblSubjectT;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblContentT;
        private ReaLTaiizor.Controls.CyberButton btnDone;
        private Label lblTitle;
        private Label lblJobT;
        private ReaLTaiizor.Controls.CyberButton btnInterview;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private ReaLTaiizor.Controls.CyberButton btnReject;
        private ReaLTaiizor.Controls.CyberButton btnAccept;
        private Label lblResponseT;
        private Label lblResponse;
    }
}