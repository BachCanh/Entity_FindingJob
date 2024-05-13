using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Entity
{
    partial class FCVCreation_Project
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label17 = new Label();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            btnAdd = new ReaLTaiizor.Controls.CyberButton();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            flPBtnSkills = new FlowLayoutPanel();
            flpSkills = new FlowLayoutPanel();
            btnAddSkills = new Guna.UI2.WinForms.Guna2Button();
            label16 = new Label();
            label5 = new Label();
            txtProjectName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel3.SuspendLayout();
            flPBtnSkills.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(38, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 31);
            lblTitle.TabIndex = 91;
            lblTitle.Text = "Add Projects";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Checked = true;
            dtpEndDate.CustomizableEdges = customizableEdges1;
            dtpEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Long;
            dtpEndDate.Location = new Point(686, 81);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpEndDate.Size = new Size(180, 34);
            dtpEndDate.TabIndex = 95;
            dtpEndDate.Value = new DateTime(2024, 5, 2, 15, 20, 19, 342);
            // 
            // dtpStartDate
            // 
            dtpStartDate.Checked = true;
            dtpStartDate.CustomizableEdges = customizableEdges3;
            dtpStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Format = DateTimePickerFormat.Long;
            dtpStartDate.Location = new Point(489, 81);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpStartDate.Size = new Size(180, 34);
            dtpStartDate.TabIndex = 94;
            dtpStartDate.Value = new DateTime(2024, 5, 2, 15, 20, 19, 342);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(493, 55);
            label17.Name = "label17";
            label17.Size = new Size(108, 19);
            label17.TabIndex = 93;
            label17.Text = "Start - End Date";
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
            btnCancel.Location = new Point(589, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(131, 42);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 98;
            btnCancel.Tag = "Decline";
            btnCancel.TextButton = "Cancel";
            btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Timer_Effect_1 = 5;
            btnCancel.Timer_RGB = 300;
            btnCancel.Click += btnCancel_Click;
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
            btnAdd.Location = new Point(735, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.PenWidth = 15;
            btnAdd.Rounding = true;
            btnAdd.RoundingInt = 20;
            btnAdd.Size = new Size(131, 42);
            btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 97;
            btnAdd.Tag = "Decline";
            btnAdd.TextButton = "Add";
            btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Timer_Effect_1 = 5;
            btnAdd.Timer_RGB = 300;
            btnAdd.Click += btnAdd_Click;
            // 
            // guna2Panel3
            // 
            guna2Panel3.AutoSize = true;
            guna2Panel3.Controls.Add(flPBtnSkills);
            guna2Panel3.Controls.Add(label16);
            guna2Panel3.CustomizableEdges = customizableEdges7;
            guna2Panel3.Location = new Point(12, 126);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel3.Size = new Size(854, 70);
            guna2Panel3.TabIndex = 130;
            // 
            // flPBtnSkills
            // 
            flPBtnSkills.AutoSize = true;
            flPBtnSkills.Controls.Add(flpSkills);
            flPBtnSkills.Controls.Add(btnAddSkills);
            flPBtnSkills.Location = new Point(8, 28);
            flPBtnSkills.Name = "flPBtnSkills";
            flPBtnSkills.Size = new Size(358, 39);
            flPBtnSkills.TabIndex = 121;
            // 
            // flpSkills
            // 
            flpSkills.AutoSize = true;
            flpSkills.Dock = DockStyle.Left;
            flpSkills.Location = new Point(3, 3);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(0, 33);
            flpSkills.TabIndex = 76;
            // 
            // btnAddSkills
            // 
            btnAddSkills.BorderRadius = 15;
            btnAddSkills.Cursor = Cursors.Hand;
            btnAddSkills.CustomizableEdges = customizableEdges5;
            btnAddSkills.DisabledState.BorderColor = Color.DarkGray;
            btnAddSkills.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddSkills.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddSkills.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddSkills.FillColor = Color.Transparent;
            btnAddSkills.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnAddSkills.ForeColor = Color.FromArgb(64, 64, 64);
            btnAddSkills.HoverState.BorderColor = Color.Transparent;
            btnAddSkills.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnAddSkills.HoverState.ForeColor = Color.Black;
            btnAddSkills.Location = new Point(6, 0);
            btnAddSkills.Margin = new Padding(0);
            btnAddSkills.Name = "btnAddSkills";
            btnAddSkills.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddSkills.Size = new Size(298, 39);
            btnAddSkills.TabIndex = 50;
            btnAddSkills.Text = "Click here to see some popular skills.";
            btnAddSkills.TextAlign = HorizontalAlignment.Left;
            btnAddSkills.Click += btnAddSkills_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(3, 8);
            label16.Name = "label16";
            label16.Size = new Size(251, 19);
            label16.TabIndex = 120;
            label16.Text = "Pick 3 main skills you use in the project.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(42, 61);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 132;
            label5.Text = "Project Title";
            // 
            // txtProjectName
            // 
            txtProjectName.BorderRadius = 15;
            txtProjectName.CustomizableEdges = customizableEdges9;
            txtProjectName.DefaultText = "";
            txtProjectName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProjectName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProjectName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProjectName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProjectName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProjectName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProjectName.ForeColor = Color.Black;
            txtProjectName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProjectName.Location = new Point(38, 81);
            txtProjectName.Margin = new Padding(4, 3, 4, 3);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.PasswordChar = '\0';
            txtProjectName.PlaceholderText = "e.g. UI/UX Designer";
            txtProjectName.SelectedText = "";
            txtProjectName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtProjectName.Size = new Size(378, 39);
            txtProjectName.TabIndex = 131;
            // 
            // FCVCreation_Project
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 276);
            Controls.Add(label5);
            Controls.Add(txtProjectName);
            Controls.Add(guna2Panel3);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label17);
            Controls.Add(lblTitle);
            Name = "FCVCreation_Project";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCVCreation_Project";
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            flPBtnSkills.ResumeLayout(false);
            flPBtnSkills.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Label label17;
        public ReaLTaiizor.Controls.CyberButton btnCancel;
        public ReaLTaiizor.Controls.CyberButton btnAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FlowLayoutPanel flPBtnSkills;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Button btnAddSkills;
        private Label label16;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtProjectName;
    }
}