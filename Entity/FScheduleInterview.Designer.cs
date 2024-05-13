using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FScheduleInterview
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            this.mcpSchdule = new System.Windows.Forms.MonthCalendar();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblDateTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbbTimeIv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpBody = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTimeAdd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblJSeeker = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.flpBody.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.metroControlBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 26);
            this.panel1.TabIndex = 3;
            // 
            // metroControlBox3
            // 
            this.metroControlBox3.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox3.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox3.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox3.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroControlBox3.IsDerivedStyle = true;
            this.metroControlBox3.Location = new System.Drawing.Point(1153, 0);
            this.metroControlBox3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.metroControlBox3.MaximizeBox = true;
            this.metroControlBox3.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox3.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MinimizeBox = true;
            this.metroControlBox3.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox3.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.Name = "metroControlBox3";
            this.metroControlBox3.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox3.StyleManager = null;
            this.metroControlBox3.TabIndex = 5;
            this.metroControlBox3.Text = "metroControlBox3";
            this.metroControlBox3.ThemeAuthor = "Taiizor";
            this.metroControlBox3.ThemeName = "MetroLight";
            // 
            // mcpSchdule
            // 
            this.mcpSchdule.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mcpSchdule.Location = new System.Drawing.Point(474, 89);
            this.mcpSchdule.Margin = new System.Windows.Forms.Padding(10);
            this.mcpSchdule.MaxSelectionCount = 1;
            this.mcpSchdule.Name = "mcpSchdule";
            this.mcpSchdule.TabIndex = 6;
            this.mcpSchdule.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcpSchdule_DateSelected);
            this.mcpSchdule.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcpSchdule_DateSelected);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 30;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.lblDateTime);
            this.guna2ShadowPanel2.Controls.Add(this.btnAdd);
            this.guna2ShadowPanel2.Controls.Add(this.cbbTimeIv);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(155, 269);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 10;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 50;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(939, 67);
            this.guna2ShadowPanel2.TabIndex = 7;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblDateTime.Location = new System.Drawing.Point(55, 17);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(406, 37);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Choose a date to Schedule Interview";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(738, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.BorderRadius = 10;
            this.btnAdd.ShadowDecoration.Depth = 10;
            this.btnAdd.ShadowDecoration.Enabled = true;
            this.btnAdd.Size = new System.Drawing.Size(149, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbTimeIv
            // 
            this.cbbTimeIv.BackColor = System.Drawing.Color.Transparent;
            this.cbbTimeIv.BorderRadius = 10;
            this.cbbTimeIv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTimeIv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTimeIv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimeIv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTimeIv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTimeIv.Font = new System.Drawing.Font("Segoe UI", 14.5F);
            this.cbbTimeIv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTimeIv.ItemHeight = 30;
            this.cbbTimeIv.Items.AddRange(new object[] {
            "8:00 - 10:00",
            "10:00 - 12:00",
            "13:00 - 15:00",
            "15:00 - 17:00"});
            this.cbbTimeIv.Location = new System.Drawing.Point(503, 15);
            this.cbbTimeIv.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbbTimeIv.Name = "cbbTimeIv";
            this.cbbTimeIv.ShadowDecoration.BorderRadius = 10;
            this.cbbTimeIv.ShadowDecoration.Depth = 10;
            this.cbbTimeIv.ShadowDecoration.Enabled = true;
            this.cbbTimeIv.Size = new System.Drawing.Size(202, 36);
            this.cbbTimeIv.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 342);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1253, 377);
            this.guna2Panel1.TabIndex = 8;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoScroll = true;
            this.guna2Panel3.Controls.Add(this.flpBody);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1253, 377);
            this.guna2Panel3.TabIndex = 1;
            // 
            // flpBody
            // 
            this.flpBody.BackColor = System.Drawing.Color.Transparent;
            this.flpBody.Controls.Add(this.guna2Panel4);
            this.flpBody.Location = new System.Drawing.Point(38, 23);
            this.flpBody.Name = "flpBody";
            this.flpBody.Size = new System.Drawing.Size(1184, 249);
            this.flpBody.TabIndex = 3;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.panel8);
            this.guna2Panel4.Controls.Add(this.panel5);
            this.guna2Panel4.Controls.Add(this.panel6);
            this.guna2Panel4.Controls.Add(this.panel4);
            this.guna2Panel4.Controls.Add(this.panel2);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Depth = 15;
            this.guna2Panel4.Size = new System.Drawing.Size(1184, 36);
            this.guna2Panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.guna2HtmlLabel3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(1062, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(121, 36);
            this.panel8.TabIndex = 7;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(147, 36);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Status";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(925, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 36);
            this.panel5.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = false;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(147, 36);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Interview";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTimeAdd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(794, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(131, 36);
            this.panel6.TabIndex = 6;
            // 
            // lblTimeAdd
            // 
            this.lblTimeAdd.AutoSize = false;
            this.lblTimeAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeAdd.Location = new System.Drawing.Point(0, 0);
            this.lblTimeAdd.Name = "lblTimeAdd";
            this.lblTimeAdd.Size = new System.Drawing.Size(131, 36);
            this.lblTimeAdd.TabIndex = 0;
            this.lblTimeAdd.Text = "Date Add";
            this.lblTimeAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblJob);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(431, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 36);
            this.panel4.TabIndex = 4;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = false;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJob.Location = new System.Drawing.Point(0, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(363, 36);
            this.lblJob.TabIndex = 0;
            this.lblJob.Text = "Name Job";
            this.lblJob.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2HtmlLabel2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 36);
            this.panel2.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(33, 0);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(116, 36);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Avatar";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblJSeeker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(149, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 36);
            this.panel3.TabIndex = 2;
            // 
            // lblJSeeker
            // 
            this.lblJSeeker.AutoSize = false;
            this.lblJSeeker.BackColor = System.Drawing.Color.Transparent;
            this.lblJSeeker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJSeeker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJSeeker.Location = new System.Drawing.Point(0, 0);
            this.lblJSeeker.Name = "lblJSeeker";
            this.lblJSeeker.Size = new System.Drawing.Size(282, 36);
            this.lblJSeeker.TabIndex = 0;
            this.lblJSeeker.Text = "Name Jobseeker";
            this.lblJSeeker.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(33, 36);
            this.panel7.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(439, 31);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(363, 59);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "Schedule Interview";
            // 
            // FScheduleInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 719);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.mcpSchdule);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FScheduleInterview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FScheduleInterview";
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.flpBody.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private MonthCalendar mcpSchdule;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateTime;
        public Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTimeIv;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FlowLayoutPanel flpBody;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        public Panel panel8;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public Panel panel5;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        public Panel panel6;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTimeAdd;
        public Panel panel4;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJob;
        public Panel panel2;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Panel panel3;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJSeeker;
        public Panel panel7;
    }
}