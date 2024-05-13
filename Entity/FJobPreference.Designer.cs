using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Entity
{
    partial class FJobPreference
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
            this.flPBtnSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddSkills = new Guna.UI2.WinForms.Guna2Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbExperience = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbWorkingForm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new ReaLTaiizor.Controls.CyberButton();
            this.btnSave = new ReaLTaiizor.Controls.CyberButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.btnPost = new ReaLTaiizor.Controls.CyberButton();
            this.btnEdit = new ReaLTaiizor.Controls.CyberButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbCompanySize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbCompanyType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flPBtnSkills.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPBtnSkills
            // 
            this.flPBtnSkills.Controls.Add(this.flpSkills);
            this.flPBtnSkills.Controls.Add(this.btnAddSkills);
            this.flPBtnSkills.Location = new System.Drawing.Point(52, 486);
            this.flPBtnSkills.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flPBtnSkills.Name = "flPBtnSkills";
            this.flPBtnSkills.Size = new System.Drawing.Size(847, 36);
            this.flPBtnSkills.TabIndex = 76;
            // 
            // flpSkills
            // 
            this.flpSkills.AutoSize = true;
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSkills.Location = new System.Drawing.Point(2, 3);
            this.flpSkills.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(0, 32);
            this.flpSkills.TabIndex = 76;
            // 
            // btnAddSkills
            // 
            this.btnAddSkills.BorderRadius = 15;
            this.btnAddSkills.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSkills.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSkills.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSkills.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSkills.FillColor = System.Drawing.Color.Transparent;
            this.btnAddSkills.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnAddSkills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddSkills.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSkills.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnAddSkills.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddSkills.Location = new System.Drawing.Point(6, 2);
            this.btnAddSkills.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSkills.Name = "btnAddSkills";
            this.btnAddSkills.Size = new System.Drawing.Size(258, 34);
            this.btnAddSkills.TabIndex = 50;
            this.btnAddSkills.Text = "Click here to see some popular skills";
            this.btnAddSkills.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddSkills.Click += new System.EventHandler(this.btnAddSkills_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(70, 226);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(353, 21);
            this.label16.TabIndex = 75;
            this.label16.Text = "What is your expectation about your company?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(490, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(434, 21);
            this.label15.TabIndex = 74;
            this.label15.Text = "About the salary and the deadline of your finding job post";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(70, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 21);
            this.label14.TabIndex = 73;
            this.label14.Text = "Let\'s start with a strong title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(48, 466);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "Pick 3 main skills of yours.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(48, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 19);
            this.label11.TabIndex = 70;
            this.label11.Text = "Choose the suitable experience for your job.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(48, 242);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(482, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "The information help us to recommend to the right company you looking for.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(467, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Choose a deadline for your finding job post.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(467, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Enter your expectation salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(467, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "This will help the company know your expectation. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(48, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Choose the working form for your job.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(48, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Write a title for your finding job post";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "This help your finding jobs post stand out to the right company.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(467, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "2/3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "1/3";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.BorderRadius = 15;
            this.dtpDateEnd.Checked = true;
            this.dtpDateEnd.FillColor = System.Drawing.Color.White;
            this.dtpDateEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpDateEnd.ForeColor = System.Drawing.Color.Black;
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateEnd.Location = new System.Drawing.Point(467, 181);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(352, 29);
            this.dtpDateEnd.TabIndex = 57;
            this.dtpDateEnd.Value = new System.DateTime(2024, 4, 5, 19, 51, 38, 253);
            // 
            // txtSalary
            // 
            this.txtSalary.BorderRadius = 15;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtSalary.ForeColor = System.Drawing.Color.Black;
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(467, 116);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "Salary";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(352, 34);
            this.txtSalary.TabIndex = 56;
            // 
            // cbbExperience
            // 
            this.cbbExperience.BackColor = System.Drawing.Color.Transparent;
            this.cbbExperience.BorderRadius = 15;
            this.cbbExperience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExperience.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbExperience.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbExperience.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbbExperience.ForeColor = System.Drawing.Color.Black;
            this.cbbExperience.ItemHeight = 45;
            this.cbbExperience.Items.AddRange(new object[] {
            "Intern",
            "Fresher",
            "Junior",
            "Middle",
            "Senior",
            "Expert"});
            this.cbbExperience.Location = new System.Drawing.Point(48, 289);
            this.cbbExperience.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbExperience.Name = "cbbExperience";
            this.cbbExperience.Size = new System.Drawing.Size(353, 51);
            this.cbbExperience.TabIndex = 45;
            // 
            // cbbWorkingForm
            // 
            this.cbbWorkingForm.BackColor = System.Drawing.Color.Transparent;
            this.cbbWorkingForm.BorderRadius = 15;
            this.cbbWorkingForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbWorkingForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWorkingForm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWorkingForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWorkingForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbbWorkingForm.ForeColor = System.Drawing.Color.Black;
            this.cbbWorkingForm.ItemHeight = 45;
            this.cbbWorkingForm.Items.AddRange(new object[] {
            "Office",
            "Remote",
            "Hybrid"});
            this.cbbWorkingForm.Location = new System.Drawing.Point(48, 348);
            this.cbbWorkingForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbWorkingForm.Name = "cbbWorkingForm";
            this.cbbWorkingForm.Size = new System.Drawing.Size(353, 51);
            this.cbbWorkingForm.TabIndex = 42;
            // 
            // txtJobName
            // 
            this.txtJobName.BorderRadius = 15;
            this.txtJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobName.DefaultText = "";
            this.txtJobName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJobName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJobName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtJobName.ForeColor = System.Drawing.Color.Black;
            this.txtJobName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.Location = new System.Drawing.Point(48, 116);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.PlaceholderText = "Title";
            this.txtJobName.SelectedText = "";
            this.txtJobName.Size = new System.Drawing.Size(352, 34);
            this.txtJobName.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.Alpha = 20;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Background = true;
            this.btnCancel.Background_WidthPen = 4F;
            this.btnCancel.BackgroundPen = true;
            this.btnCancel.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnCancel.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnCancel.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnCancel.Effect_1 = true;
            this.btnCancel.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Effect_1_Transparency = 25;
            this.btnCancel.Effect_2 = true;
            this.btnCancel.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Effect_2_Transparency = 20;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnCancel.Lighting = true;
            this.btnCancel.LinearGradient_Background = false;
            this.btnCancel.LinearGradientPen = false;
            this.btnCancel.Location = new System.Drawing.Point(781, 603);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PenWidth = 15;
            this.btnCancel.Rounding = true;
            this.btnCancel.RoundingInt = 20;
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Tag = "Decline";
            this.btnCancel.TextButton = "Cancel";
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Timer_Effect_1 = 5;
            this.btnCancel.Timer_RGB = 300;
            // 
            // btnSave
            // 
            this.btnSave.Alpha = 20;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Background = true;
            this.btnSave.Background_WidthPen = 4F;
            this.btnSave.BackgroundPen = true;
            this.btnSave.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnSave.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnSave.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnSave.Effect_1 = true;
            this.btnSave.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Effect_1_Transparency = 25;
            this.btnSave.Effect_2 = true;
            this.btnSave.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Effect_2_Transparency = 20;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnSave.Lighting = true;
            this.btnSave.LinearGradient_Background = false;
            this.btnSave.LinearGradientPen = false;
            this.btnSave.Location = new System.Drawing.Point(656, 603);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.PenWidth = 15;
            this.btnSave.Rounding = true;
            this.btnSave.RoundingInt = 20;
            this.btnSave.Size = new System.Drawing.Size(112, 36);
            this.btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 27;
            this.btnSave.Tag = "Decline";
            this.btnSave.TextButton = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Timer_Effect_1 = 5;
            this.btnSave.Timer_RGB = 300;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(48, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "3/3";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(36, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 31);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Job Preferences";
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.btnPost);
            this.pnBody.Controls.Add(this.btnEdit);
            this.pnBody.Controls.Add(this.label13);
            this.pnBody.Controls.Add(this.txtLocation);
            this.pnBody.Controls.Add(this.label18);
            this.pnBody.Controls.Add(this.cbbCompanySize);
            this.pnBody.Controls.Add(this.label17);
            this.pnBody.Controls.Add(this.cbbCompanyType);
            this.pnBody.Controls.Add(this.flPBtnSkills);
            this.pnBody.Controls.Add(this.label16);
            this.pnBody.Controls.Add(this.label15);
            this.pnBody.Controls.Add(this.label14);
            this.pnBody.Controls.Add(this.label12);
            this.pnBody.Controls.Add(this.label11);
            this.pnBody.Controls.Add(this.label10);
            this.pnBody.Controls.Add(this.label9);
            this.pnBody.Controls.Add(this.label8);
            this.pnBody.Controls.Add(this.label7);
            this.pnBody.Controls.Add(this.label6);
            this.pnBody.Controls.Add(this.label5);
            this.pnBody.Controls.Add(this.label2);
            this.pnBody.Controls.Add(this.label4);
            this.pnBody.Controls.Add(this.label3);
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Controls.Add(this.dtpDateEnd);
            this.pnBody.Controls.Add(this.txtSalary);
            this.pnBody.Controls.Add(this.cbbExperience);
            this.pnBody.Controls.Add(this.cbbWorkingForm);
            this.pnBody.Controls.Add(this.txtJobName);
            this.pnBody.Controls.Add(this.lblTitle);
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Controls.Add(this.btnSave);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.pnBody.ForeColor = System.Drawing.Color.Gray;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(925, 648);
            this.pnBody.TabIndex = 18;
            // 
            // btnPost
            // 
            this.btnPost.Alpha = 20;
            this.btnPost.BackColor = System.Drawing.Color.Transparent;
            this.btnPost.Background = true;
            this.btnPost.Background_WidthPen = 4F;
            this.btnPost.BackgroundPen = true;
            this.btnPost.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnPost.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPost.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPost.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnPost.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPost.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPost.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnPost.Effect_1 = true;
            this.btnPost.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPost.Effect_1_Transparency = 25;
            this.btnPost.Effect_2 = true;
            this.btnPost.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPost.Effect_2_Transparency = 20;
            this.btnPost.Font = new System.Drawing.Font("Arial", 11F);
            this.btnPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnPost.Lighting = true;
            this.btnPost.LinearGradient_Background = false;
            this.btnPost.LinearGradientPen = false;
            this.btnPost.Location = new System.Drawing.Point(781, 603);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPost.Name = "btnPost";
            this.btnPost.PenWidth = 15;
            this.btnPost.Rounding = true;
            this.btnPost.RoundingInt = 20;
            this.btnPost.Size = new System.Drawing.Size(112, 36);
            this.btnPost.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPost.TabIndex = 84;
            this.btnPost.Tag = "Decline";
            this.btnPost.TextButton = "Post";
            this.btnPost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPost.Timer_Effect_1 = 5;
            this.btnPost.Timer_RGB = 300;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Alpha = 20;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Background = true;
            this.btnEdit.Background_WidthPen = 4F;
            this.btnEdit.BackgroundPen = true;
            this.btnEdit.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnEdit.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnEdit.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnEdit.Effect_1 = true;
            this.btnEdit.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.Effect_1_Transparency = 25;
            this.btnEdit.Effect_2 = true;
            this.btnEdit.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.Effect_2_Transparency = 20;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnEdit.Lighting = true;
            this.btnEdit.LinearGradient_Background = false;
            this.btnEdit.LinearGradientPen = false;
            this.btnEdit.Location = new System.Drawing.Point(656, 603);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PenWidth = 15;
            this.btnEdit.Rounding = true;
            this.btnEdit.RoundingInt = 20;
            this.btnEdit.Size = new System.Drawing.Size(112, 36);
            this.btnEdit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit.TabIndex = 83;
            this.btnEdit.Tag = "Decline";
            this.btnEdit.TextButton = "Edit";
            this.btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit.Timer_Effect_1 = 5;
            this.btnEdit.Timer_RGB = 300;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(48, 396);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 19);
            this.label13.TabIndex = 82;
            this.label13.Text = "Enter your expectation location";
            // 
            // txtLocation
            // 
            this.txtLocation.BorderRadius = 15;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Location = new System.Drawing.Point(48, 413);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderText = "Location";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(352, 34);
            this.txtLocation.TabIndex = 81;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(466, 332);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(295, 19);
            this.label18.TabIndex = 80;
            this.label18.Text = "Choose the suitable company size for your job.";
            // 
            // cbbCompanySize
            // 
            this.cbbCompanySize.BackColor = System.Drawing.Color.Transparent;
            this.cbbCompanySize.BorderRadius = 15;
            this.cbbCompanySize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCompanySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompanySize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCompanySize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCompanySize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbbCompanySize.ForeColor = System.Drawing.Color.Black;
            this.cbbCompanySize.ItemHeight = 45;
            this.cbbCompanySize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbbCompanySize.Location = new System.Drawing.Point(466, 348);
            this.cbbCompanySize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCompanySize.Name = "cbbCompanySize";
            this.cbbCompanySize.Size = new System.Drawing.Size(353, 51);
            this.cbbCompanySize.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(466, 272);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(300, 19);
            this.label17.TabIndex = 78;
            this.label17.Text = "Choose the suitable company type for your job.";
            // 
            // cbbCompanyType
            // 
            this.cbbCompanyType.BackColor = System.Drawing.Color.Transparent;
            this.cbbCompanyType.BorderRadius = 15;
            this.cbbCompanyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCompanyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompanyType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCompanyType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCompanyType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbbCompanyType.ForeColor = System.Drawing.Color.Black;
            this.cbbCompanyType.ItemHeight = 45;
            this.cbbCompanyType.Items.AddRange(new object[] {
            "Outsource",
            "Product",
            "HeadHunter",
            "Non - IT",
            "Services and Consulting"});
            this.cbbCompanyType.Location = new System.Drawing.Point(466, 289);
            this.cbbCompanyType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCompanyType.Name = "cbbCompanyType";
            this.cbbCompanyType.Size = new System.Drawing.Size(353, 51);
            this.cbbCompanyType.TabIndex = 77;
            // 
            // FJobPreference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 648);
            this.Controls.Add(this.pnBody);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FJobPreference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FJobPreference";
            this.flPBtnSkills.ResumeLayout(false);
            this.flPBtnSkills.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flPBtnSkills;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Button btnAddSkills;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateEnd;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2ComboBox cbbExperience;
        private Guna.UI2.WinForms.Guna2ComboBox cbbWorkingForm;
        private Guna.UI2.WinForms.Guna2TextBox txtJobName;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnSave;
        private Label label4;
        private Label lblTitle;
        private Panel pnBody;
        private Label label17;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCompanyType;
        private Label label18;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCompanySize;
        private Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private ReaLTaiizor.Controls.CyberButton btnEdit;
        private ReaLTaiizor.Controls.CyberButton btnPost;
    }
}