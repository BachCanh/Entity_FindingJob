using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Entity
{
    partial class FCVCreation_Exp
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            label18 = new Label();
            label17 = new Label();
            txtCompany = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            label5 = new Label();
            txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            rtxtAchieve = new RichTextBox();
            label1 = new Label();
            btnAdd = new ReaLTaiizor.Controls.CyberButton();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.BorderRadius = 15;
            txtLocation.CustomizableEdges = customizableEdges1;
            txtLocation.DefaultText = "";
            txtLocation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLocation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLocation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocation.ForeColor = Color.Black;
            txtLocation.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Location = new Point(438, 158);
            txtLocation.Margin = new Padding(4, 3, 4, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.PasswordChar = '\0';
            txtLocation.PlaceholderText = "";
            txtLocation.SelectedText = "";
            txtLocation.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtLocation.Size = new Size(378, 39);
            txtLocation.TabIndex = 89;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(438, 137);
            label18.Name = "label18";
            label18.Size = new Size(61, 19);
            label18.TabIndex = 88;
            label18.Text = "Location";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(28, 137);
            label17.Name = "label17";
            label17.Size = new Size(108, 19);
            label17.TabIndex = 86;
            label17.Text = "Start - End Date";
            // 
            // txtCompany
            // 
            txtCompany.BorderRadius = 15;
            txtCompany.CustomizableEdges = customizableEdges3;
            txtCompany.DefaultText = "";
            txtCompany.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCompany.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCompany.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCompany.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCompany.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCompany.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCompany.ForeColor = Color.Black;
            txtCompany.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCompany.Location = new Point(438, 78);
            txtCompany.Margin = new Padding(4, 3, 4, 3);
            txtCompany.Name = "txtCompany";
            txtCompany.PasswordChar = '\0';
            txtCompany.PlaceholderText = "";
            txtCompany.SelectedText = "";
            txtCompany.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCompany.Size = new Size(378, 39);
            txtCompany.TabIndex = 85;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(438, 58);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 84;
            label6.Text = "Company";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(28, 58);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 83;
            label5.Text = "Job Title";
            // 
            // txtJobName
            // 
            txtJobName.BorderRadius = 15;
            txtJobName.CustomizableEdges = customizableEdges5;
            txtJobName.DefaultText = "";
            txtJobName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtJobName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtJobName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtJobName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtJobName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtJobName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtJobName.ForeColor = Color.Black;
            txtJobName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtJobName.Location = new Point(24, 78);
            txtJobName.Margin = new Padding(4, 3, 4, 3);
            txtJobName.Name = "txtJobName";
            txtJobName.PasswordChar = '\0';
            txtJobName.PlaceholderText = "e.g. UI/UX Designer";
            txtJobName.SelectedText = "";
            txtJobName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtJobName.Size = new Size(378, 39);
            txtJobName.TabIndex = 82;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 31);
            lblTitle.TabIndex = 90;
            lblTitle.Text = "Add Experience";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Checked = true;
            dtpStartDate.CustomizableEdges = customizableEdges7;
            dtpStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Format = DateTimePickerFormat.Long;
            dtpStartDate.Location = new Point(24, 163);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpStartDate.Size = new Size(180, 34);
            dtpStartDate.TabIndex = 91;
            dtpStartDate.Value = new DateTime(2024, 5, 2, 15, 20, 19, 342);
            // 
            // dtpEndDate
            // 
            dtpEndDate.Checked = true;
            dtpEndDate.CustomizableEdges = customizableEdges9;
            dtpEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Long;
            dtpEndDate.Location = new Point(221, 163);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtpEndDate.Size = new Size(180, 34);
            dtpEndDate.TabIndex = 92;
            dtpEndDate.Value = new DateTime(2024, 5, 2, 15, 20, 19, 342);
            // 
            // rtxtAchieve
            // 
            rtxtAchieve.BorderStyle = BorderStyle.FixedSingle;
            rtxtAchieve.Location = new Point(24, 250);
            rtxtAchieve.Margin = new Padding(3, 2, 3, 2);
            rtxtAchieve.Name = "rtxtAchieve";
            rtxtAchieve.Size = new Size(792, 119);
            rtxtAchieve.TabIndex = 93;
            rtxtAchieve.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(28, 230);
            label1.Name = "label1";
            label1.Size = new Size(195, 19);
            label1.TabIndex = 94;
            label1.Text = "Your Impressive Achievements";
            // 
            // btnAdd
            // 
            btnAdd.Alpha = 20;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Background = true;
            btnAdd.Background_WidthPen = 4F;
            btnAdd.BackgroundPen = true;
            btnAdd.ColorBackground = Color.FromArgb(176, 226, 243);
            btnAdd.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnAdd.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnAdd.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnAdd.ColorLighting = Color.FromArgb(128, 128, 255);
            btnAdd.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnAdd.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAdd.Effect_1 = true;
            btnAdd.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnAdd.Effect_1_Transparency = 25;
            btnAdd.Effect_2 = true;
            btnAdd.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnAdd.Effect_2_Transparency = 20;
            btnAdd.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(46, 54, 71);
            btnAdd.Lighting = true;
            btnAdd.LinearGradient_Background = false;
            btnAdd.LinearGradientPen = false;
            btnAdd.Location = new Point(684, 374);
            btnAdd.Name = "btnAdd";
            btnAdd.PenWidth = 15;
            btnAdd.Rounding = true;
            btnAdd.RoundingInt = 20;
            btnAdd.Size = new Size(131, 42);
            btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 95;
            btnAdd.Tag = "Decline";
            btnAdd.TextButton = "Add";
            btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Timer_Effect_1 = 5;
            btnAdd.Timer_RGB = 300;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Alpha = 20;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Background = true;
            btnCancel.Background_WidthPen = 4F;
            btnCancel.BackgroundPen = true;
            btnCancel.ColorBackground = Color.FromArgb(176, 226, 243);
            btnCancel.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnCancel.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnCancel.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnCancel.ColorLighting = Color.FromArgb(128, 128, 255);
            btnCancel.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnCancel.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancel.Effect_1 = true;
            btnCancel.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCancel.Effect_1_Transparency = 25;
            btnCancel.Effect_2 = true;
            btnCancel.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCancel.Effect_2_Transparency = 20;
            btnCancel.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(46, 54, 71);
            btnCancel.Lighting = true;
            btnCancel.LinearGradient_Background = false;
            btnCancel.LinearGradientPen = false;
            btnCancel.Location = new Point(538, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(131, 42);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 96;
            btnCancel.Tag = "Decline";
            btnCancel.TextButton = "Cancel";
            btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Timer_Effect_1 = 5;
            btnCancel.Timer_RGB = 300;
            btnCancel.Click += btnCancel_Click;
            // 
            // FCVCreation_Exp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(841, 426);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(rtxtAchieve);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblTitle);
            Controls.Add(txtLocation);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(txtCompany);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtJobName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCVCreation_Exp";
            Text = "FCVCreation_Exp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Label label18;
        private Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtCompany;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtJobName;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private RichTextBox rtxtAchieve;
        private Label label1;
        public ReaLTaiizor.Controls.CyberButton btnAdd;
        public ReaLTaiizor.Controls.CyberButton btnCancel;
    }
}