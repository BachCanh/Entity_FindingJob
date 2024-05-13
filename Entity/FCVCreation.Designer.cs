using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FCVCreation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label15 = new Label();
            label14 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            pnBody = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flpProjects = new FlowLayoutPanel();
            btnAddProjects = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            flpExpWrap = new FlowLayoutPanel();
            flpExp = new FlowLayoutPanel();
            btnAddExperience = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            flpEduWrap = new FlowLayoutPanel();
            flpEdu = new FlowLayoutPanel();
            btnAddEducation = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            flPBtnSkills = new FlowLayoutPanel();
            flpSkills = new FlowLayoutPanel();
            btnAddSkills = new Guna.UI2.WinForms.Guna2Button();
            label16 = new Label();
            label21 = new Label();
            label20 = new Label();
            label4 = new Label();
            rtxtProfessionalSum = new ReaLTaiizor.Controls.HopeRichTextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label19 = new Label();
            txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            label18 = new Label();
            txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            label17 = new Label();
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            btnCreate = new ReaLTaiizor.Controls.CyberButton();
            pnBody.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            guna2Panel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            flpExpWrap.SuspendLayout();
            guna2Panel2.SuspendLayout();
            flpEduWrap.SuspendLayout();
            guna2Panel3.SuspendLayout();
            flPBtnSkills.SuspendLayout();
            guna2Panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(73, 347);
            label15.Name = "label15";
            label15.Size = new Size(172, 21);
            label15.TabIndex = 74;
            label15.Text = "Professional Summary";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(73, 64);
            label14.Name = "label14";
            label14.Size = new Size(124, 21);
            label14.TabIndex = 73;
            label14.Text = "Personal Details";
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(46, 368);
            label7.Name = "label7";
            label7.Size = new Size(732, 41);
            label7.TabIndex = 66;
            label7.Text = "Write 2-4 short and energetic sentences to interest the reader! \r\nMention your role, experience and most importantly - your biggest achievements, best qualities and skills.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(555, 115);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 65;
            label6.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(54, 115);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 64;
            label5.Text = "Wanted Job Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(50, 86);
            label2.Name = "label2";
            label2.Size = new Size(401, 19);
            label2.TabIndex = 63;
            label2.Text = "This help your finding jobs post stand out to the right company.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(46, 351);
            label3.Name = "label3";
            label3.Size = new Size(30, 19);
            label3.TabIndex = 61;
            label3.Text = "2/6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(46, 68);
            label1.Name = "label1";
            label1.Size = new Size(30, 19);
            label1.TabIndex = 59;
            label1.Text = "1/6";
            // 
            // txtJobName
            // 
            txtJobName.BorderRadius = 15;
            txtJobName.CustomizableEdges = customizableEdges1;
            txtJobName.DefaultText = "";
            txtJobName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtJobName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtJobName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtJobName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtJobName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtJobName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtJobName.ForeColor = Color.Black;
            txtJobName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtJobName.Location = new Point(50, 135);
            txtJobName.Margin = new Padding(4, 3, 4, 3);
            txtJobName.Name = "txtJobName";
            txtJobName.PasswordChar = '\0';
            txtJobName.PlaceholderText = "e.g. UI/UX Designer";
            txtJobName.SelectedText = "";
            txtJobName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtJobName.Size = new Size(410, 39);
            txtJobName.TabIndex = 37;
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(flowLayoutPanel1);
            pnBody.Controls.Add(label4);
            pnBody.Controls.Add(rtxtProfessionalSum);
            pnBody.Controls.Add(txtEmail);
            pnBody.Controls.Add(label19);
            pnBody.Controls.Add(txtPhoneNumber);
            pnBody.Controls.Add(label18);
            pnBody.Controls.Add(txtAddress);
            pnBody.Controls.Add(label17);
            pnBody.Controls.Add(txtFullName);
            pnBody.Controls.Add(label15);
            pnBody.Controls.Add(label14);
            pnBody.Controls.Add(label7);
            pnBody.Controls.Add(label6);
            pnBody.Controls.Add(label5);
            pnBody.Controls.Add(label2);
            pnBody.Controls.Add(label3);
            pnBody.Controls.Add(label1);
            pnBody.Controls.Add(txtJobName);
            pnBody.Controls.Add(lblTitle);
            pnBody.Dock = DockStyle.Top;
            pnBody.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            pnBody.ForeColor = Color.Gray;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1079, 905);
            pnBody.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(guna2Panel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(guna2Panel1);
            flowLayoutPanel1.Controls.Add(flpExpWrap);
            flowLayoutPanel1.Controls.Add(guna2Panel2);
            flowLayoutPanel1.Controls.Add(flpEduWrap);
            flowLayoutPanel1.Controls.Add(guna2Panel3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(46, 582);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(992, 387);
            flowLayoutPanel1.TabIndex = 126;
            // 
            // guna2Panel5
            // 
            guna2Panel5.Controls.Add(label22);
            guna2Panel5.Controls.Add(label23);
            guna2Panel5.Controls.Add(label24);
            guna2Panel5.CustomizableEdges = customizableEdges3;
            guna2Panel5.Location = new Point(0, 0);
            guna2Panel5.Margin = new Padding(0);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel5.Size = new Size(334, 49);
            guna2Panel5.TabIndex = 130;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.White;
            label22.Font = new Font("Segoe UI", 10.2F);
            label22.ForeColor = Color.Gray;
            label22.Location = new Point(1, 25);
            label22.Name = "label22";
            label22.Size = new Size(159, 19);
            label22.TabIndex = 113;
            label22.Text = "Show your best projects.";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.White;
            label23.Font = new Font("Segoe UI", 10.2F);
            label23.ForeColor = Color.Gray;
            label23.Location = new Point(3, 3);
            label23.Name = "label23";
            label23.Size = new Size(30, 19);
            label23.TabIndex = 112;
            label23.Text = "3/6";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.White;
            label24.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(39, 3);
            label24.Name = "label24";
            label24.Size = new Size(69, 21);
            label24.TabIndex = 114;
            label24.Text = "Projects";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(flpProjects);
            flowLayoutPanel2.Controls.Add(btnAddProjects);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 52);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(176, 39);
            flowLayoutPanel2.TabIndex = 131;
            // 
            // flpProjects
            // 
            flpProjects.AutoSize = true;
            flpProjects.FlowDirection = FlowDirection.TopDown;
            flpProjects.Location = new Point(3, 0);
            flpProjects.Margin = new Padding(3, 0, 3, 3);
            flpProjects.Name = "flpProjects";
            flpProjects.Size = new Size(0, 0);
            flpProjects.TabIndex = 0;
            // 
            // btnAddProjects
            // 
            btnAddProjects.BorderRadius = 15;
            btnAddProjects.Cursor = Cursors.Hand;
            btnAddProjects.CustomizableEdges = customizableEdges5;
            btnAddProjects.DisabledState.BorderColor = Color.DarkGray;
            btnAddProjects.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddProjects.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddProjects.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddProjects.FillColor = Color.Transparent;
            btnAddProjects.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddProjects.ForeColor = Color.FromArgb(64, 64, 64);
            btnAddProjects.HoverState.BorderColor = Color.Transparent;
            btnAddProjects.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddProjects.HoverState.ForeColor = Color.Black;
            btnAddProjects.Image = Properties.Resources.plus;
            btnAddProjects.Location = new Point(3, 5);
            btnAddProjects.Margin = new Padding(3, 2, 3, 2);
            btnAddProjects.Name = "btnAddProjects";
            btnAddProjects.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddProjects.Size = new Size(170, 32);
            btnAddProjects.TabIndex = 115;
            btnAddProjects.Text = "Add Projects.";
            btnAddProjects.Click += btnAddProjects_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label9);
            guna2Panel1.Controls.Add(label10);
            guna2Panel1.Controls.Add(label8);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(0, 94);
            guna2Panel1.Margin = new Padding(0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(210, 49);
            guna2Panel1.TabIndex = 127;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(1, 25);
            label9.Name = "label9";
            label9.Size = new Size(198, 19);
            label9.TabIndex = 113;
            label9.Text = "Show your relevant experience.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(3, 3);
            label10.Name = "label10";
            label10.Size = new Size(30, 19);
            label10.TabIndex = 112;
            label10.Text = "4/6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(39, 3);
            label8.Name = "label8";
            label8.Size = new Size(160, 21);
            label8.TabIndex = 114;
            label8.Text = "Employment History";
            // 
            // flpExpWrap
            // 
            flpExpWrap.AutoSize = true;
            flpExpWrap.Controls.Add(flpExp);
            flpExpWrap.Controls.Add(btnAddExperience);
            flpExpWrap.FlowDirection = FlowDirection.TopDown;
            flpExpWrap.Location = new Point(3, 146);
            flpExpWrap.Name = "flpExpWrap";
            flpExpWrap.Size = new Size(176, 39);
            flpExpWrap.TabIndex = 128;
            // 
            // flpExp
            // 
            flpExp.AutoSize = true;
            flpExp.FlowDirection = FlowDirection.TopDown;
            flpExp.Location = new Point(3, 0);
            flpExp.Margin = new Padding(3, 0, 3, 3);
            flpExp.Name = "flpExp";
            flpExp.Size = new Size(0, 0);
            flpExp.TabIndex = 0;
            // 
            // btnAddExperience
            // 
            btnAddExperience.BorderRadius = 15;
            btnAddExperience.Cursor = Cursors.Hand;
            btnAddExperience.CustomizableEdges = customizableEdges9;
            btnAddExperience.DisabledState.BorderColor = Color.DarkGray;
            btnAddExperience.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddExperience.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddExperience.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddExperience.FillColor = Color.Transparent;
            btnAddExperience.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddExperience.ForeColor = Color.FromArgb(64, 64, 64);
            btnAddExperience.HoverState.BorderColor = Color.Transparent;
            btnAddExperience.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddExperience.HoverState.ForeColor = Color.Black;
            btnAddExperience.Image = Properties.Resources.plus;
            btnAddExperience.Location = new Point(3, 5);
            btnAddExperience.Margin = new Padding(3, 2, 3, 2);
            btnAddExperience.Name = "btnAddExperience";
            btnAddExperience.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAddExperience.Size = new Size(170, 32);
            btnAddExperience.TabIndex = 115;
            btnAddExperience.Text = "Add Experience.";
            btnAddExperience.Click += btnAddExperience_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(label12);
            guna2Panel2.Controls.Add(label13);
            guna2Panel2.Controls.Add(label11);
            guna2Panel2.CustomizableEdges = customizableEdges11;
            guna2Panel2.Location = new Point(0, 188);
            guna2Panel2.Margin = new Padding(0);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel2.Size = new Size(672, 48);
            guna2Panel2.TabIndex = 128;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(3, 25);
            label12.Name = "label12";
            label12.Size = new Size(666, 19);
            label12.TabIndex = 117;
            label12.Text = "A varied education on your resume sums up the value that your learnings and background will bring to job.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10.2F);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(3, 6);
            label13.Name = "label13";
            label13.Size = new Size(30, 19);
            label13.TabIndex = 116;
            label13.Text = "5/6";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(36, 4);
            label11.Name = "label11";
            label11.Size = new Size(82, 21);
            label11.TabIndex = 118;
            label11.Text = "Education";
            // 
            // flpEduWrap
            // 
            flpEduWrap.AutoSize = true;
            flpEduWrap.Controls.Add(flpEdu);
            flpEduWrap.Controls.Add(btnAddEducation);
            flpEduWrap.FlowDirection = FlowDirection.TopDown;
            flpEduWrap.Location = new Point(3, 239);
            flpEduWrap.Name = "flpEduWrap";
            flpEduWrap.Size = new Size(134, 39);
            flpEduWrap.TabIndex = 129;
            // 
            // flpEdu
            // 
            flpEdu.AutoSize = true;
            flpEdu.FlowDirection = FlowDirection.TopDown;
            flpEdu.Location = new Point(3, 0);
            flpEdu.Margin = new Padding(3, 0, 3, 3);
            flpEdu.Name = "flpEdu";
            flpEdu.Size = new Size(0, 0);
            flpEdu.TabIndex = 0;
            // 
            // btnAddEducation
            // 
            btnAddEducation.BorderRadius = 15;
            btnAddEducation.Cursor = Cursors.Hand;
            btnAddEducation.CustomizableEdges = customizableEdges13;
            btnAddEducation.DisabledState.BorderColor = Color.DarkGray;
            btnAddEducation.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEducation.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEducation.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEducation.FillColor = Color.Transparent;
            btnAddEducation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddEducation.ForeColor = Color.FromArgb(64, 64, 64);
            btnAddEducation.HoverState.BorderColor = Color.Transparent;
            btnAddEducation.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddEducation.HoverState.ForeColor = Color.Black;
            btnAddEducation.Image = Properties.Resources.plus;
            btnAddEducation.Location = new Point(3, 5);
            btnAddEducation.Margin = new Padding(3, 2, 3, 2);
            btnAddEducation.Name = "btnAddEducation";
            btnAddEducation.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAddEducation.Size = new Size(128, 32);
            btnAddEducation.TabIndex = 119;
            btnAddEducation.Text = "Education.";
            btnAddEducation.Click += btnAddEducation_Click;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Controls.Add(flPBtnSkills);
            guna2Panel3.Controls.Add(label16);
            guna2Panel3.Controls.Add(label21);
            guna2Panel3.Controls.Add(label20);
            guna2Panel3.CustomizableEdges = customizableEdges17;
            guna2Panel3.Location = new Point(3, 284);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel3.Size = new Size(969, 100);
            guna2Panel3.TabIndex = 129;
            // 
            // flPBtnSkills
            // 
            flPBtnSkills.Controls.Add(flpSkills);
            flPBtnSkills.Controls.Add(btnAddSkills);
            flPBtnSkills.Location = new Point(8, 47);
            flPBtnSkills.Name = "flPBtnSkills";
            flPBtnSkills.Size = new Size(988, 41);
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
            btnAddSkills.CustomizableEdges = customizableEdges15;
            btnAddSkills.DisabledState.BorderColor = Color.DarkGray;
            btnAddSkills.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddSkills.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddSkills.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddSkills.FillColor = Color.Transparent;
            btnAddSkills.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddSkills.ForeColor = Color.FromArgb(64, 64, 64);
            btnAddSkills.HoverState.BorderColor = Color.Transparent;
            btnAddSkills.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnAddSkills.HoverState.ForeColor = Color.Black;
            btnAddSkills.Location = new Point(6, 0);
            btnAddSkills.Margin = new Padding(0);
            btnAddSkills.Name = "btnAddSkills";
            btnAddSkills.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnAddSkills.Size = new Size(331, 39);
            btnAddSkills.TabIndex = 50;
            btnAddSkills.Text = "Click here to see some popular skills.";
            btnAddSkills.TextAlign = HorizontalAlignment.Left;
            btnAddSkills.Click += btnAddSkills_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 10.2F);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(3, 27);
            label16.Name = "label16";
            label16.Size = new Size(168, 19);
            label16.TabIndex = 120;
            label16.Text = "Pick 3 main skills of yours.";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.White;
            label21.Font = new Font("Segoe UI", 10.2F);
            label21.ForeColor = Color.Gray;
            label21.Location = new Point(3, 7);
            label21.Name = "label21";
            label21.Size = new Size(30, 19);
            label21.TabIndex = 122;
            label21.Text = "6/6";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.White;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(30, 3);
            label20.Name = "label20";
            label20.Size = new Size(46, 21);
            label20.TabIndex = 123;
            label20.Text = "Skills";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(46, 614);
            label4.Name = "label4";
            label4.Size = new Size(420, 19);
            label4.TabIndex = 85;
            label4.Text = "Recruiter tip: write 50-200 characters to increase interview chances.";
            // 
            // rtxtProfessionalSum
            // 
            rtxtProfessionalSum.BorderColor = Color.FromArgb(220, 223, 230);
            rtxtProfessionalSum.Font = new Font("Segoe UI", 12F);
            rtxtProfessionalSum.ForeColor = Color.FromArgb(48, 49, 51);
            rtxtProfessionalSum.Hint = "";
            rtxtProfessionalSum.HoverBorderColor = Color.FromArgb(64, 158, 255);
            rtxtProfessionalSum.Location = new Point(46, 412);
            rtxtProfessionalSum.Margin = new Padding(3, 2, 3, 2);
            rtxtProfessionalSum.MaxLength = 32767;
            rtxtProfessionalSum.Multiline = true;
            rtxtProfessionalSum.Name = "rtxtProfessionalSum";
            rtxtProfessionalSum.PasswordChar = '\0';
            rtxtProfessionalSum.ScrollBars = ScrollBars.None;
            rtxtProfessionalSum.SelectedText = "";
            rtxtProfessionalSum.SelectionLength = 0;
            rtxtProfessionalSum.SelectionStart = 0;
            rtxtProfessionalSum.Size = new Size(992, 152);
            rtxtProfessionalSum.TabIndex = 84;
            rtxtProfessionalSum.TabStop = false;
            rtxtProfessionalSum.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 15;
            txtEmail.CustomizableEdges = customizableEdges19;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(50, 290);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtEmail.Size = new Size(410, 39);
            txtEmail.TabIndex = 83;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI", 10.2F);
            label19.ForeColor = Color.Gray;
            label19.Location = new Point(54, 269);
            label19.Name = "label19";
            label19.Size = new Size(41, 19);
            label19.TabIndex = 82;
            label19.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderRadius = 15;
            txtPhoneNumber.CustomizableEdges = customizableEdges21;
            txtPhoneNumber.DefaultText = "";
            txtPhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNumber.Location = new Point(555, 214);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PasswordChar = '\0';
            txtPhoneNumber.PlaceholderText = "";
            txtPhoneNumber.SelectedText = "";
            txtPhoneNumber.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtPhoneNumber.Size = new Size(410, 39);
            txtPhoneNumber.TabIndex = 81;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 10.2F);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(555, 194);
            label18.Name = "label18";
            label18.Size = new Size(102, 19);
            label18.TabIndex = 80;
            label18.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.BorderRadius = 15;
            txtAddress.CustomizableEdges = customizableEdges23;
            txtAddress.DefaultText = "";
            txtAddress.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAddress.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAddress.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAddress.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtAddress.ForeColor = Color.Black;
            txtAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAddress.Location = new Point(50, 214);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PlaceholderText = "";
            txtAddress.SelectedText = "";
            txtAddress.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtAddress.Size = new Size(410, 39);
            txtAddress.TabIndex = 79;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 10.2F);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(54, 194);
            label17.Name = "label17";
            label17.Size = new Size(58, 19);
            label17.TabIndex = 78;
            label17.Text = "Address";
            // 
            // txtFullName
            // 
            txtFullName.BorderRadius = 15;
            txtFullName.CustomizableEdges = customizableEdges25;
            txtFullName.DefaultText = "";
            txtFullName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFullName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFullName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFullName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFullName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFullName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtFullName.ForeColor = Color.Black;
            txtFullName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFullName.Location = new Point(555, 135);
            txtFullName.Margin = new Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.PasswordChar = '\0';
            txtFullName.PlaceholderText = "";
            txtFullName.SelectedText = "";
            txtFullName.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txtFullName.Size = new Size(410, 39);
            txtFullName.TabIndex = 77;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(47, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 31);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "CV Builder";
            // 
            // guna2Panel4
            // 
            guna2Panel4.Controls.Add(btnCancel);
            guna2Panel4.Controls.Add(btnCreate);
            guna2Panel4.CustomizableEdges = customizableEdges27;
            guna2Panel4.Dock = DockStyle.Bottom;
            guna2Panel4.Location = new Point(0, 909);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Panel4.Size = new Size(1079, 56);
            guna2Panel4.TabIndex = 1;
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
            btnCancel.Location = new Point(907, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(131, 42);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 127;
            btnCancel.Tag = "Decline";
            btnCancel.TextButton = "Cancel";
            btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Timer_Effect_1 = 5;
            btnCancel.Timer_RGB = 300;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Alpha = 20;
            btnCreate.BackColor = Color.Transparent;
            btnCreate.Background = true;
            btnCreate.Background_WidthPen = 4F;
            btnCreate.BackgroundPen = true;
            btnCreate.ColorBackground = Color.FromArgb(176, 226, 243);
            btnCreate.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnCreate.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnCreate.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnCreate.ColorLighting = Color.FromArgb(128, 128, 255);
            btnCreate.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnCreate.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCreate.Effect_1 = true;
            btnCreate.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCreate.Effect_1_Transparency = 25;
            btnCreate.Effect_2 = true;
            btnCreate.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCreate.Effect_2_Transparency = 20;
            btnCreate.Font = new Font("Arial", 11F);
            btnCreate.ForeColor = Color.FromArgb(46, 54, 71);
            btnCreate.Lighting = true;
            btnCreate.LinearGradient_Background = false;
            btnCreate.LinearGradientPen = false;
            btnCreate.Location = new Point(762, 7);
            btnCreate.Name = "btnCreate";
            btnCreate.PenWidth = 15;
            btnCreate.Rounding = true;
            btnCreate.RoundingInt = 20;
            btnCreate.Size = new Size(131, 42);
            btnCreate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCreate.TabIndex = 126;
            btnCreate.Tag = "Decline";
            btnCreate.TextButton = "Create";
            btnCreate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCreate.Timer_Effect_1 = 5;
            btnCreate.Timer_RGB = 300;
            btnCreate.Click += btnCreate_Click;
            // 
            // FCVCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 965);
            Controls.Add(pnBody);
            Controls.Add(guna2Panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCVCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCVCreation";
            Load += FCVCreation_Load;
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            guna2Panel5.ResumeLayout(false);
            guna2Panel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            flpExpWrap.ResumeLayout(false);
            flpExpWrap.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            flpEduWrap.ResumeLayout(false);
            flpEduWrap.PerformLayout();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            flPBtnSkills.ResumeLayout(false);
            flPBtnSkills.PerformLayout();
            guna2Panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label15;
        private Label label14;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtJobName;
        private Panel pnBody;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Label label19;
        private Label label4;
        private ReaLTaiizor.Controls.HopeRichTextBox rtxtProfessionalSum;
        private Label label20;
        private Label label21;
        private FlowLayoutPanel flPBtnSkills;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Button btnAddSkills;
        private Label label16;
        private Guna.UI2.WinForms.Guna2Button btnAddEducation;
        private Label label11;
        private Label label12;
        private Label label13;
        private Guna.UI2.WinForms.Guna2Button btnAddExperience;
        private Label label8;
        private Label label9;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FlowLayoutPanel flpExpWrap;
        private FlowLayoutPanel flpExp;
        private FlowLayoutPanel flpEduWrap;
        private FlowLayoutPanel flpEdu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnCreate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Label label22;
        private Label label23;
        private Label label24;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flpProjects;
        private Guna.UI2.WinForms.Guna2Button btnAddProjects;
    }
}