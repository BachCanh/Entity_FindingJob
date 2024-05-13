using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Entity
{
    partial class FCVCreation_Edu
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
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            btnAdd = new ReaLTaiizor.Controls.CyberButton();
            label1 = new Label();
            rtxtDecription = new RichTextBox();
            dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblTitle = new Label();
            txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            label18 = new Label();
            label17 = new Label();
            txtDegree = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            label5 = new Label();
            txtSchool = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
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
            btnCancel.Location = new Point(542, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(131, 42);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 110;
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
            btnAdd.Location = new Point(689, 371);
            btnAdd.Name = "btnAdd";
            btnAdd.PenWidth = 15;
            btnAdd.Rounding = true;
            btnAdd.RoundingInt = 20;
            btnAdd.Size = new Size(131, 42);
            btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 109;
            btnAdd.Tag = "Decline";
            btnAdd.TextButton = "Add";
            btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Timer_Effect_1 = 5;
            btnAdd.Timer_RGB = 300;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(32, 227);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 108;
            label1.Text = "Description";
            // 
            // rtxtDecription
            // 
            rtxtDecription.BorderStyle = BorderStyle.FixedSingle;
            rtxtDecription.Location = new Point(28, 247);
            rtxtDecription.Margin = new Padding(3, 2, 3, 2);
            rtxtDecription.Name = "rtxtDecription";
            rtxtDecription.Size = new Size(792, 119);
            rtxtDecription.TabIndex = 107;
            rtxtDecription.Text = "";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Checked = true;
            dtpEndDate.CustomizableEdges = customizableEdges1;
            dtpEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Long;
            dtpEndDate.Location = new Point(226, 160);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpEndDate.Size = new Size(180, 34);
            dtpEndDate.TabIndex = 106;
            dtpEndDate.Value = new DateTime(2024, 5, 2, 15, 20, 19, 342);
            // 
            // dtpStartDate
            // 
            dtpStartDate.Checked = true;
            dtpStartDate.CustomizableEdges = customizableEdges3;
            dtpStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Format = DateTimePickerFormat.Long;
            dtpStartDate.Location = new Point(28, 160);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpStartDate.Size = new Size(180, 34);
            dtpStartDate.TabIndex = 105;
            dtpStartDate.Value = new DateTime(2024, 5, 2, 15, 20, 19, 342);
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(20, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 31);
            lblTitle.TabIndex = 104;
            lblTitle.Text = "Add Education";
            // 
            // txtLocation
            // 
            txtLocation.BorderRadius = 15;
            txtLocation.CustomizableEdges = customizableEdges5;
            txtLocation.DefaultText = "";
            txtLocation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLocation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLocation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocation.ForeColor = Color.Black;
            txtLocation.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Location = new Point(442, 154);
            txtLocation.Margin = new Padding(4, 3, 4, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.PasswordChar = '\0';
            txtLocation.PlaceholderText = "";
            txtLocation.SelectedText = "";
            txtLocation.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtLocation.Size = new Size(378, 39);
            txtLocation.TabIndex = 103;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(442, 134);
            label18.Name = "label18";
            label18.Size = new Size(61, 19);
            label18.TabIndex = 102;
            label18.Text = "Location";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(32, 134);
            label17.Name = "label17";
            label17.Size = new Size(108, 19);
            label17.TabIndex = 101;
            label17.Text = "Start - End Date";
            // 
            // txtDegree
            // 
            txtDegree.BorderRadius = 15;
            txtDegree.CustomizableEdges = customizableEdges7;
            txtDegree.DefaultText = "";
            txtDegree.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDegree.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDegree.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDegree.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDegree.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDegree.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDegree.ForeColor = Color.Black;
            txtDegree.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDegree.Location = new Point(442, 75);
            txtDegree.Margin = new Padding(4, 3, 4, 3);
            txtDegree.Name = "txtDegree";
            txtDegree.PasswordChar = '\0';
            txtDegree.PlaceholderText = "";
            txtDegree.SelectedText = "";
            txtDegree.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtDegree.Size = new Size(378, 39);
            txtDegree.TabIndex = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(442, 55);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 99;
            label6.Text = "Degree";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(32, 55);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 98;
            label5.Text = "School";
            // 
            // txtSchool
            // 
            txtSchool.BorderRadius = 15;
            txtSchool.CustomizableEdges = customizableEdges9;
            txtSchool.DefaultText = "";
            txtSchool.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSchool.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSchool.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSchool.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSchool.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSchool.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSchool.ForeColor = Color.Black;
            txtSchool.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSchool.Location = new Point(28, 75);
            txtSchool.Margin = new Padding(4, 3, 4, 3);
            txtSchool.Name = "txtSchool";
            txtSchool.PasswordChar = '\0';
            txtSchool.PlaceholderText = "";
            txtSchool.SelectedText = "";
            txtSchool.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSchool.Size = new Size(378, 39);
            txtSchool.TabIndex = 97;
            // 
            // FCVCreation_Edu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(841, 426);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(rtxtDecription);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblTitle);
            Controls.Add(txtLocation);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(txtDegree);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSchool);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCVCreation_Edu";
            Text = "FCVCreation_Edu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ReaLTaiizor.Controls.CyberButton btnCancel;
        public ReaLTaiizor.Controls.CyberButton btnAdd;
        private Label label1;
        private RichTextBox rtxtDecription;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Label label18;
        private Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtDegree;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSchool;
    }
}