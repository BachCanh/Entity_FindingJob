using System.Windows.Forms;
using System.Drawing;
using System;

namespace Entity
{
    partial class FJobEdit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            epCbb = new ErrorProvider(components);
            epTextbox = new ErrorProvider(components);
            btnSave = new ReaLTaiizor.Controls.CyberButton();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            lblTitle = new Label();
            txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            cbbWorkingForm = new Guna.UI2.WinForms.Guna2ComboBox();
            cbbExperience = new Guna.UI2.WinForms.Guna2ComboBox();
            txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            dtpDateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label12 = new Label();
            flPBtnSkills = new FlowLayoutPanel();
            flpSkills = new FlowLayoutPanel();
            btnAddSkills = new Guna.UI2.WinForms.Guna2Button();
            pnBody = new Panel();
            tabpage = new TabControl();
            tbprequirement = new TabPage();
            rtxtjobrequirement = new RichTextBox();
            tbpdescription = new TabPage();
            rtxtdescription = new RichTextBox();
            tbpbenefit = new TabPage();
            rtxtBenefit = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)epCbb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epTextbox).BeginInit();
            flPBtnSkills.SuspendLayout();
            pnBody.SuspendLayout();
            tabpage.SuspendLayout();
            tbprequirement.SuspendLayout();
            tbpdescription.SuspendLayout();
            tbpbenefit.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            guna2Button1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2Button1.HoverState.BorderColor = Color.Transparent;
            guna2Button1.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            guna2Button1.HoverState.ForeColor = Color.Black;
            guna2Button1.Location = new Point(9, 2);
            guna2Button1.Margin = new Padding(3, 2, 3, 2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(293, 39);
            guna2Button1.TabIndex = 50;
            guna2Button1.Text = "Click here to see some popular skills";
            guna2Button1.TextAlign = HorizontalAlignment.Left;
            // 
            // epCbb
            // 
            epCbb.ContainerControl = this;
            // 
            // epTextbox
            // 
            epTextbox.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.Alpha = 20;
            btnSave.BackColor = Color.Transparent;
            btnSave.Background = true;
            btnSave.Background_WidthPen = 4F;
            btnSave.BackgroundPen = true;
            btnSave.ColorBackground = Color.FromArgb(176, 226, 243);
            btnSave.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnSave.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnSave.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnSave.ColorLighting = Color.FromArgb(128, 128, 255);
            btnSave.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnSave.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnSave.Cursor = Cursors.Hand;
            btnSave.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSave.Effect_1 = true;
            btnSave.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnSave.Effect_1_Transparency = 25;
            btnSave.Effect_2 = true;
            btnSave.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnSave.Effect_2_Transparency = 20;
            btnSave.Font = new Font("Arial", 11F);
            btnSave.ForeColor = Color.FromArgb(46, 54, 71);
            btnSave.Lighting = true;
            btnSave.LinearGradient_Background = false;
            btnSave.LinearGradientPen = false;
            btnSave.Location = new Point(786, 694);
            btnSave.Name = "btnSave";
            btnSave.PenWidth = 15;
            btnSave.Rounding = true;
            btnSave.RoundingInt = 20;
            btnSave.Size = new Size(131, 42);
            btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSave.TabIndex = 28;
            btnSave.Tag = "Decline";
            btnSave.TextButton = "Save";
            btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Timer_Effect_1 = 5;
            btnSave.Timer_RGB = 300;
            btnSave.Click += btnSave_Click_Error;
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
            btnCancel.Font = new Font("Arial", 11F);
            btnCancel.ForeColor = Color.FromArgb(46, 54, 71);
            btnCancel.Lighting = true;
            btnCancel.LinearGradient_Background = false;
            btnCancel.LinearGradientPen = false;
            btnCancel.Location = new Point(923, 694);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(131, 42);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 29;
            btnCancel.Tag = "Decline";
            btnCancel.TextButton = "Cancel";
            btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Timer_Effect_1 = 5;
            btnCancel.Timer_RGB = 300;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(42, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 31);
            lblTitle.TabIndex = 76;
            lblTitle.Text = "Editing your Job";
            // 
            // txtJobName
            // 
            txtJobName.BorderRadius = 15;
            txtJobName.CustomizableEdges = customizableEdges13;
            txtJobName.DefaultText = "";
            txtJobName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtJobName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtJobName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtJobName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtJobName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtJobName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtJobName.ForeColor = Color.Black;
            txtJobName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtJobName.Location = new Point(46, 131);
            txtJobName.Margin = new Padding(4, 3, 4, 3);
            txtJobName.Name = "txtJobName";
            txtJobName.PasswordChar = '\0';
            txtJobName.PlaceholderText = "Job's Name";
            txtJobName.SelectedText = "";
            txtJobName.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtJobName.Size = new Size(410, 39);
            txtJobName.TabIndex = 78;
            txtJobName.Leave += txtJobName_Leave;
            // 
            // cbbWorkingForm
            // 
            cbbWorkingForm.BackColor = Color.Transparent;
            cbbWorkingForm.BorderRadius = 15;
            cbbWorkingForm.CustomizableEdges = customizableEdges11;
            cbbWorkingForm.DrawMode = DrawMode.OwnerDrawFixed;
            cbbWorkingForm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbWorkingForm.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbWorkingForm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbWorkingForm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cbbWorkingForm.ForeColor = Color.Black;
            cbbWorkingForm.ItemHeight = 45;
            cbbWorkingForm.Items.AddRange(new object[] { "Office", "Remote", "Hybrid" });
            cbbWorkingForm.Location = new Point(46, 206);
            cbbWorkingForm.Margin = new Padding(3, 2, 3, 2);
            cbbWorkingForm.Name = "cbbWorkingForm";
            cbbWorkingForm.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbbWorkingForm.Size = new Size(411, 51);
            cbbWorkingForm.TabIndex = 79;
            // 
            // cbbExperience
            // 
            cbbExperience.BackColor = Color.Transparent;
            cbbExperience.BorderRadius = 15;
            cbbExperience.CustomizableEdges = customizableEdges9;
            cbbExperience.DrawMode = DrawMode.OwnerDrawFixed;
            cbbExperience.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbExperience.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbExperience.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbExperience.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cbbExperience.ForeColor = Color.Black;
            cbbExperience.ItemHeight = 45;
            cbbExperience.Items.AddRange(new object[] { "Intern", "Fresher", "Junior", "Middle", "Senior", "Expert" });
            cbbExperience.Location = new Point(46, 330);
            cbbExperience.Margin = new Padding(3, 2, 3, 2);
            cbbExperience.Name = "cbbExperience";
            cbbExperience.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbbExperience.Size = new Size(411, 51);
            cbbExperience.TabIndex = 80;
            // 
            // txtSalary
            // 
            txtSalary.BorderRadius = 15;
            txtSalary.CustomizableEdges = customizableEdges7;
            txtSalary.DefaultText = "";
            txtSalary.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSalary.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSalary.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSalary.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSalary.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSalary.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSalary.ForeColor = Color.Black;
            txtSalary.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSalary.Location = new Point(535, 131);
            txtSalary.Margin = new Padding(4, 3, 4, 3);
            txtSalary.Name = "txtSalary";
            txtSalary.PasswordChar = '\0';
            txtSalary.PlaceholderText = "Salary";
            txtSalary.SelectedText = "";
            txtSalary.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSalary.Size = new Size(410, 39);
            txtSalary.TabIndex = 85;
            txtSalary.Leave += txtSalary_Leave;
            // 
            // dtpDateEnd
            // 
            dtpDateEnd.BorderRadius = 15;
            dtpDateEnd.Checked = true;
            dtpDateEnd.CustomizableEdges = customizableEdges5;
            dtpDateEnd.FillColor = Color.White;
            dtpDateEnd.Font = new Font("Segoe UI", 10.2F);
            dtpDateEnd.ForeColor = Color.Black;
            dtpDateEnd.Format = DateTimePickerFormat.Long;
            dtpDateEnd.Location = new Point(535, 206);
            dtpDateEnd.Margin = new Padding(3, 2, 3, 2);
            dtpDateEnd.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDateEnd.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDateEnd.Name = "dtpDateEnd";
            dtpDateEnd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpDateEnd.Size = new Size(410, 34);
            dtpDateEnd.TabIndex = 86;
            dtpDateEnd.Value = new DateTime(2024, 4, 5, 19, 51, 38, 253);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(46, 65);
            label1.Name = "label1";
            label1.Size = new Size(30, 19);
            label1.TabIndex = 87;
            label1.Text = "1/3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(535, 60);
            label3.Name = "label3";
            label3.Size = new Size(30, 19);
            label3.TabIndex = 88;
            label3.Text = "2/3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(46, 260);
            label4.Name = "label4";
            label4.Size = new Size(30, 19);
            label4.TabIndex = 89;
            label4.Text = "3/3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(46, 83);
            label2.Name = "label2";
            label2.Size = new Size(360, 19);
            label2.TabIndex = 90;
            label2.Text = "This help your jobs post stand out to the right applicants.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(46, 112);
            label5.Name = "label5";
            label5.Size = new Size(198, 19);
            label5.TabIndex = 91;
            label5.Text = "Write a name for your job post";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(46, 187);
            label6.Name = "label6";
            label6.Size = new Size(228, 19);
            label6.TabIndex = 92;
            label6.Text = "Choose a working form for your job";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(535, 83);
            label7.Name = "label7";
            label7.Size = new Size(350, 19);
            label7.TabIndex = 93;
            label7.Text = "This will help us match the applicants within your range.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(535, 112);
            label8.Name = "label8";
            label8.Size = new Size(167, 19);
            label8.TabIndex = 94;
            label8.Text = "Enter a salary for your job";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(535, 187);
            label9.Name = "label9";
            label9.Size = new Size(228, 19);
            label9.TabIndex = 95;
            label9.Text = "Choose a deadline for your job post";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(46, 278);
            label10.Name = "label10";
            label10.Size = new Size(451, 19);
            label10.TabIndex = 96;
            label10.Text = "The information help us to recommend to the right applicants you need.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(46, 310);
            label11.Name = "label11";
            label11.Size = new Size(274, 19);
            label11.TabIndex = 97;
            label11.Text = "Choose the suitable experience for your job";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10.2F);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(46, 446);
            label13.Name = "label13";
            label13.Size = new Size(175, 19);
            label13.TabIndex = 99;
            label13.Text = "Some detail about your job";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(72, 62);
            label14.Name = "label14";
            label14.Size = new Size(171, 21);
            label14.TabIndex = 100;
            label14.Text = "Let's start with a name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(561, 56);
            label15.Name = "label15";
            label15.Size = new Size(378, 21);
            label15.TabIndex = 101;
            label15.Text = "About the salary and the deadline of your job post";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(72, 256);
            label16.Name = "label16";
            label16.Size = new Size(394, 21);
            label16.TabIndex = 102;
            label16.Text = "What are the main description required for your job?";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(46, 381);
            label12.Name = "label12";
            label12.Size = new Size(153, 19);
            label12.TabIndex = 104;
            label12.Text = "Pick 3 skills for your job";
            // 
            // flPBtnSkills
            // 
            flPBtnSkills.Controls.Add(flpSkills);
            flPBtnSkills.Controls.Add(btnAddSkills);
            flPBtnSkills.Location = new Point(49, 401);
            flPBtnSkills.Name = "flPBtnSkills";
            flPBtnSkills.Size = new Size(988, 42);
            flPBtnSkills.TabIndex = 106;
            // 
            // flpSkills
            // 
            flpSkills.AutoSize = true;
            flpSkills.Dock = DockStyle.Left;
            flpSkills.Location = new Point(3, 3);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(0, 35);
            flpSkills.TabIndex = 76;
            // 
            // btnAddSkills
            // 
            btnAddSkills.BorderRadius = 15;
            btnAddSkills.Cursor = Cursors.Hand;
            btnAddSkills.CustomizableEdges = customizableEdges3;
            btnAddSkills.DefaultAutoSize = true;
            btnAddSkills.DisabledState.BorderColor = Color.DarkGray;
            btnAddSkills.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddSkills.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddSkills.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddSkills.Dock = DockStyle.Left;
            btnAddSkills.FillColor = Color.Transparent;
            btnAddSkills.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline);
            btnAddSkills.ForeColor = Color.FromArgb(64, 64, 64);
            btnAddSkills.HoverState.BorderColor = Color.Transparent;
            btnAddSkills.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddSkills.HoverState.ForeColor = Color.Black;
            btnAddSkills.Location = new Point(9, 2);
            btnAddSkills.Margin = new Padding(3, 2, 3, 2);
            btnAddSkills.Name = "btnAddSkills";
            btnAddSkills.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddSkills.Size = new Size(222, 37);
            btnAddSkills.TabIndex = 50;
            btnAddSkills.Text = "Click here to see skills";
            btnAddSkills.TextAlign = HorizontalAlignment.Left;
            btnAddSkills.Click += btnAddSkills_Click;
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(tabpage);
            pnBody.Controls.Add(flPBtnSkills);
            pnBody.Controls.Add(label12);
            pnBody.Controls.Add(label16);
            pnBody.Controls.Add(label15);
            pnBody.Controls.Add(label14);
            pnBody.Controls.Add(label13);
            pnBody.Controls.Add(label11);
            pnBody.Controls.Add(label10);
            pnBody.Controls.Add(label9);
            pnBody.Controls.Add(label8);
            pnBody.Controls.Add(label7);
            pnBody.Controls.Add(label6);
            pnBody.Controls.Add(label5);
            pnBody.Controls.Add(label2);
            pnBody.Controls.Add(label4);
            pnBody.Controls.Add(label3);
            pnBody.Controls.Add(label1);
            pnBody.Controls.Add(dtpDateEnd);
            pnBody.Controls.Add(txtSalary);
            pnBody.Controls.Add(cbbExperience);
            pnBody.Controls.Add(cbbWorkingForm);
            pnBody.Controls.Add(txtJobName);
            pnBody.Controls.Add(lblTitle);
            pnBody.Controls.Add(btnCancel);
            pnBody.Controls.Add(btnSave);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1079, 748);
            pnBody.TabIndex = 19;
            // 
            // tabpage
            // 
            tabpage.Controls.Add(tbprequirement);
            tabpage.Controls.Add(tbpdescription);
            tabpage.Controls.Add(tbpbenefit);
            tabpage.Font = new Font("Segoe UI", 12F);
            tabpage.Location = new Point(42, 471);
            tabpage.Margin = new Padding(3, 2, 3, 2);
            tabpage.Name = "tabpage";
            tabpage.SelectedIndex = 0;
            tabpage.Size = new Size(969, 215);
            tabpage.TabIndex = 20;
            // 
            // tbprequirement
            // 
            tbprequirement.AutoScroll = true;
            tbprequirement.BackColor = Color.White;
            tbprequirement.Controls.Add(rtxtjobrequirement);
            tbprequirement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            tbprequirement.Location = new Point(4, 30);
            tbprequirement.Margin = new Padding(3, 2, 3, 2);
            tbprequirement.Name = "tbprequirement";
            tbprequirement.Padding = new Padding(3, 2, 3, 2);
            tbprequirement.Size = new Size(961, 181);
            tbprequirement.TabIndex = 0;
            tbprequirement.Text = "Job's Requirement";
            // 
            // rtxtjobrequirement
            // 
            rtxtjobrequirement.BackColor = Color.FromArgb(248, 212, 187);
            rtxtjobrequirement.BorderStyle = BorderStyle.None;
            rtxtjobrequirement.Font = new Font("Segoe UI", 10.2F);
            rtxtjobrequirement.Location = new Point(3, 2);
            rtxtjobrequirement.Margin = new Padding(3, 2, 3, 2);
            rtxtjobrequirement.Name = "rtxtjobrequirement";
            rtxtjobrequirement.Size = new Size(929, 173);
            rtxtjobrequirement.TabIndex = 1;
            rtxtjobrequirement.Text = "";
            // 
            // tbpdescription
            // 
            tbpdescription.AutoScroll = true;
            tbpdescription.BackColor = Color.White;
            tbpdescription.Controls.Add(rtxtdescription);
            tbpdescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            tbpdescription.Location = new Point(4, 30);
            tbpdescription.Margin = new Padding(3, 2, 3, 2);
            tbpdescription.Name = "tbpdescription";
            tbpdescription.Padding = new Padding(3, 2, 3, 2);
            tbpdescription.Size = new Size(961, 181);
            tbpdescription.TabIndex = 1;
            tbpdescription.Text = "Job's Description";
            // 
            // rtxtdescription
            // 
            rtxtdescription.BackColor = Color.FromArgb(248, 212, 187);
            rtxtdescription.BorderStyle = BorderStyle.None;
            rtxtdescription.Font = new Font("Segoe UI", 10.2F);
            rtxtdescription.Location = new Point(3, 2);
            rtxtdescription.Margin = new Padding(3, 2, 3, 2);
            rtxtdescription.Name = "rtxtdescription";
            rtxtdescription.Size = new Size(929, 173);
            rtxtdescription.TabIndex = 0;
            rtxtdescription.Text = "";
            // 
            // tbpbenefit
            // 
            tbpbenefit.AutoScroll = true;
            tbpbenefit.BackColor = Color.White;
            tbpbenefit.Controls.Add(rtxtBenefit);
            tbpbenefit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            tbpbenefit.Location = new Point(4, 30);
            tbpbenefit.Margin = new Padding(3, 2, 3, 2);
            tbpbenefit.Name = "tbpbenefit";
            tbpbenefit.Padding = new Padding(3, 2, 3, 2);
            tbpbenefit.Size = new Size(961, 181);
            tbpbenefit.TabIndex = 2;
            tbpbenefit.Text = "Benefit";
            // 
            // rtxtBenefit
            // 
            rtxtBenefit.BackColor = Color.FromArgb(248, 212, 187);
            rtxtBenefit.BorderStyle = BorderStyle.None;
            rtxtBenefit.Font = new Font("Segoe UI", 10.2F);
            rtxtBenefit.Location = new Point(3, 2);
            rtxtBenefit.Margin = new Padding(3, 2, 3, 2);
            rtxtBenefit.Name = "rtxtBenefit";
            rtxtBenefit.Size = new Size(929, 173);
            rtxtBenefit.TabIndex = 0;
            rtxtBenefit.Text = "";
            // 
            // FJobEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 748);
            Controls.Add(pnBody);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FJobEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FJobEdit";
            ((System.ComponentModel.ISupportInitialize)epCbb).EndInit();
            ((System.ComponentModel.ISupportInitialize)epTextbox).EndInit();
            flPBtnSkills.ResumeLayout(false);
            flPBtnSkills.PerformLayout();
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            tabpage.ResumeLayout(false);
            tbprequirement.ResumeLayout(false);
            tbpdescription.ResumeLayout(false);
            tbpbenefit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ErrorProvider epCbb;
        private ErrorProvider epTextbox;
        private Panel pnBody;
        private FlowLayoutPanel flPBtnSkills;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Button btnAddSkills;
        private Label label12;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateEnd;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2ComboBox cbbExperience;
        private Guna.UI2.WinForms.Guna2ComboBox cbbWorkingForm;
        private Guna.UI2.WinForms.Guna2TextBox txtJobName;
        private Label lblTitle;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnSave;
        private TabControl tabpage;
        private TabPage tbprequirement;
        private RichTextBox rtxtjobrequirement;
        private TabPage tbpdescription;
        private RichTextBox rtxtdescription;
        private TabPage tbpbenefit;
        private RichTextBox rtxtBenefit;
    }
}