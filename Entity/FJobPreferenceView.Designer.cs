using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FJobPreferenceView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCV = new ReaLTaiizor.Controls.CyberButton();
            txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            cbbCompanySize = new Guna.UI2.WinForms.Guna2ComboBox();
            cbbCompanyType = new Guna.UI2.WinForms.Guna2ComboBox();
            pnBody = new Panel();
            btnOffer = new ReaLTaiizor.Controls.CyberButton();
            label13 = new Label();
            label18 = new Label();
            label17 = new Label();
            flPBtnSkills = new FlowLayoutPanel();
            flpSkills = new FlowLayoutPanel();
            label16 = new Label();
            label15 = new Label();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            cbbExperience = new Guna.UI2.WinForms.Guna2ComboBox();
            cbbWorkingForm = new Guna.UI2.WinForms.Guna2ComboBox();
            lblTitle = new Label();
            pnBody.SuspendLayout();
            flPBtnSkills.SuspendLayout();
            SuspendLayout();
            // 
            // btnCV
            // 
            btnCV.Alpha = 20;
            btnCV.BackColor = Color.Transparent;
            btnCV.Background = true;
            btnCV.Background_WidthPen = 4F;
            btnCV.BackgroundPen = true;
            btnCV.ColorBackground = Color.FromArgb(176, 226, 243);
            btnCV.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnCV.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnCV.ColorBackground_Pen = Color.FromArgb(237, 27, 47);
            btnCV.ColorLighting = Color.FromArgb(128, 128, 255);
            btnCV.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnCV.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnCV.Cursor = Cursors.Hand;
            btnCV.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCV.Effect_1 = true;
            btnCV.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCV.Effect_1_Transparency = 25;
            btnCV.Effect_2 = true;
            btnCV.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCV.Effect_2_Transparency = 20;
            btnCV.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCV.ForeColor = Color.FromArgb(46, 54, 71);
            btnCV.Lighting = true;
            btnCV.LinearGradient_Background = false;
            btnCV.LinearGradientPen = false;
            btnCV.Location = new Point(892, 726);
            btnCV.Margin = new Padding(3, 4, 3, 4);
            btnCV.Name = "btnCV";
            btnCV.PenWidth = 15;
            btnCV.Rounding = true;
            btnCV.RoundingInt = 20;
            btnCV.Size = new Size(150, 56);
            btnCV.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCV.TabIndex = 84;
            btnCV.Tag = "Decline";
            btnCV.TextButton = "CV";
            btnCV.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCV.Timer_Effect_1 = 5;
            btnCV.Timer_RGB = 300;
            btnCV.Click += btnCV_Click;
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
            txtLocation.Location = new Point(48, 493);
            txtLocation.Margin = new Padding(5, 4, 5, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.PasswordChar = '\0';
            txtLocation.PlaceholderText = "Location";
            txtLocation.SelectedText = "";
            txtLocation.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtLocation.Size = new Size(469, 52);
            txtLocation.TabIndex = 81;
            // 
            // cbbCompanySize
            // 
            cbbCompanySize.BackColor = Color.Transparent;
            cbbCompanySize.BorderRadius = 15;
            cbbCompanySize.CustomizableEdges = customizableEdges3;
            cbbCompanySize.DrawMode = DrawMode.OwnerDrawFixed;
            cbbCompanySize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCompanySize.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbCompanySize.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbCompanySize.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbbCompanySize.ForeColor = Color.Black;
            cbbCompanySize.ItemHeight = 45;
            cbbCompanySize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cbbCompanySize.Location = new Point(606, 392);
            cbbCompanySize.Name = "cbbCompanySize";
            cbbCompanySize.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbbCompanySize.Size = new Size(469, 51);
            cbbCompanySize.TabIndex = 79;
            // 
            // cbbCompanyType
            // 
            cbbCompanyType.BackColor = Color.Transparent;
            cbbCompanyType.BorderRadius = 15;
            cbbCompanyType.CustomizableEdges = customizableEdges5;
            cbbCompanyType.DrawMode = DrawMode.OwnerDrawFixed;
            cbbCompanyType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCompanyType.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbCompanyType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbCompanyType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbbCompanyType.ForeColor = Color.Black;
            cbbCompanyType.ItemHeight = 45;
            cbbCompanyType.Items.AddRange(new object[] { "Outsource", "Product", "HeadHunter", "Non - IT", "Services and Consulting" });
            cbbCompanyType.Location = new Point(606, 301);
            cbbCompanyType.Name = "cbbCompanyType";
            cbbCompanyType.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbbCompanyType.Size = new Size(469, 51);
            cbbCompanyType.TabIndex = 77;
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(btnCV);
            pnBody.Controls.Add(btnOffer);
            pnBody.Controls.Add(label13);
            pnBody.Controls.Add(txtLocation);
            pnBody.Controls.Add(label18);
            pnBody.Controls.Add(cbbCompanySize);
            pnBody.Controls.Add(label17);
            pnBody.Controls.Add(cbbCompanyType);
            pnBody.Controls.Add(flPBtnSkills);
            pnBody.Controls.Add(label16);
            pnBody.Controls.Add(label15);
            pnBody.Controls.Add(label12);
            pnBody.Controls.Add(label11);
            pnBody.Controls.Add(label6);
            pnBody.Controls.Add(txtSalary);
            pnBody.Controls.Add(cbbExperience);
            pnBody.Controls.Add(cbbWorkingForm);
            pnBody.Controls.Add(lblTitle);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pnBody.ForeColor = Color.Gray;
            pnBody.Location = new Point(0, 0);
            pnBody.Margin = new Padding(3, 4, 3, 4);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1233, 805);
            pnBody.TabIndex = 19;
            pnBody.Paint += pnBody_Paint;
            // 
            // btnOffer
            // 
            btnOffer.Alpha = 20;
            btnOffer.BackColor = Color.Transparent;
            btnOffer.Background = true;
            btnOffer.Background_WidthPen = 4F;
            btnOffer.BackgroundPen = true;
            btnOffer.ColorBackground = Color.FromArgb(176, 226, 243);
            btnOffer.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnOffer.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnOffer.ColorBackground_Pen = Color.FromArgb(237, 27, 47);
            btnOffer.ColorLighting = Color.FromArgb(128, 128, 255);
            btnOffer.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnOffer.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnOffer.Cursor = Cursors.Hand;
            btnOffer.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnOffer.Effect_1 = true;
            btnOffer.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnOffer.Effect_1_Transparency = 25;
            btnOffer.Effect_2 = true;
            btnOffer.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnOffer.Effect_2_Transparency = 20;
            btnOffer.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOffer.ForeColor = Color.FromArgb(46, 54, 71);
            btnOffer.Lighting = true;
            btnOffer.LinearGradient_Background = false;
            btnOffer.LinearGradientPen = false;
            btnOffer.Location = new Point(1048, 726);
            btnOffer.Margin = new Padding(3, 4, 3, 4);
            btnOffer.Name = "btnOffer";
            btnOffer.PenWidth = 15;
            btnOffer.Rounding = true;
            btnOffer.RoundingInt = 20;
            btnOffer.Size = new Size(150, 56);
            btnOffer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnOffer.TabIndex = 83;
            btnOffer.Tag = "Decline";
            btnOffer.TextButton = "Offer a Job";
            btnOffer.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnOffer.Timer_Effect_1 = 5;
            btnOffer.Timer_RGB = 300;
            btnOffer.Click += btnOffer_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(48, 467);
            label13.Name = "label13";
            label13.Size = new Size(169, 23);
            label13.TabIndex = 82;
            label13.Text = "Expectation location.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(606, 368);
            label18.Name = "label18";
            label18.Size = new Size(214, 23);
            label18.TabIndex = 80;
            label18.Text = "The suitable company size.";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(606, 276);
            label17.Name = "label17";
            label17.Size = new Size(219, 23);
            label17.TabIndex = 78;
            label17.Text = "The suitable company type.";
            // 
            // flPBtnSkills
            // 
            flPBtnSkills.Controls.Add(flpSkills);
            flPBtnSkills.Location = new Point(53, 611);
            flPBtnSkills.Margin = new Padding(3, 4, 3, 4);
            flPBtnSkills.Name = "flPBtnSkills";
            flPBtnSkills.Size = new Size(1129, 55);
            flPBtnSkills.TabIndex = 76;
            // 
            // flpSkills
            // 
            flpSkills.Dock = DockStyle.Left;
            flpSkills.Location = new Point(3, 4);
            flpSkills.Margin = new Padding(3, 4, 3, 4);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(41, 0);
            flpSkills.TabIndex = 76;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(48, 236);
            label16.Name = "label16";
            label16.Size = new Size(306, 28);
            label16.TabIndex = 75;
            label16.Text = "Expectation about the company:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(48, 104);
            label15.Name = "label15";
            label15.Size = new Size(221, 28);
            label15.TabIndex = 74;
            label15.Text = "The salary expectation:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(48, 580);
            label12.Name = "label12";
            label12.Size = new Size(129, 28);
            label12.TabIndex = 71;
            label12.Text = "3 main skills:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(48, 276);
            label11.Name = "label11";
            label11.Size = new Size(304, 23);
            label11.TabIndex = 70;
            label11.Text = "Expectation job experience for the job.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(48, 368);
            label6.Name = "label6";
            label6.Size = new Size(212, 23);
            label6.TabIndex = 65;
            label6.Text = "The suitable working form.";
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
            txtSalary.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalary.ForeColor = Color.Black;
            txtSalary.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSalary.Location = new Point(48, 136);
            txtSalary.Margin = new Padding(5, 4, 5, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.PasswordChar = '\0';
            txtSalary.PlaceholderText = "Salary";
            txtSalary.SelectedText = "";
            txtSalary.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSalary.Size = new Size(469, 52);
            txtSalary.TabIndex = 56;
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
            cbbExperience.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbbExperience.ForeColor = Color.Black;
            cbbExperience.ItemHeight = 45;
            cbbExperience.Items.AddRange(new object[] { "Intern", "Fresher", "Junior", "Middle", "Senior", "Expert" });
            cbbExperience.Location = new Point(48, 301);
            cbbExperience.Name = "cbbExperience";
            cbbExperience.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbbExperience.Size = new Size(469, 51);
            cbbExperience.TabIndex = 45;
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
            cbbWorkingForm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbbWorkingForm.ForeColor = Color.Black;
            cbbWorkingForm.ItemHeight = 45;
            cbbWorkingForm.Items.AddRange(new object[] { "Office", "Remote", "Hybrid" });
            cbbWorkingForm.Location = new Point(48, 392);
            cbbWorkingForm.Name = "cbbWorkingForm";
            cbbWorkingForm.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbbWorkingForm.Size = new Size(469, 51);
            cbbWorkingForm.TabIndex = 42;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(48, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 37);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Title";
            // 
            // FJobPreferenceView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 805);
            Controls.Add(pnBody);
            Name = "FJobPreferenceView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FJobPreferenceView";
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            flPBtnSkills.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnCV;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCompanySize;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCompanyType;
        private Panel pnBody;
        private ReaLTaiizor.Controls.CyberButton btnOffer;
        private FlowLayoutPanel flPBtnSkills;
        private FlowLayoutPanel flpSkills;
        private Label label16;
        private Label label15;
        private Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2ComboBox cbbExperience;
        private Guna.UI2.WinForms.Guna2ComboBox cbbWorkingForm;
        private Label lblTitle;
        private Label label13;
        private Label label18;
        private Label label17;
        private Label label11;
        private Label label6;
    }
}