using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FViewInterview
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblJSeeker = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            lblJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel4 = new Panel();
            lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel5 = new Panel();
            lblTimeAdd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel6 = new Panel();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            panel8 = new Panel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            flpBody = new FlowLayoutPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            mcpSchdule = new MonthCalendar();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            guna2Panel4.SuspendLayout();
            panel8.SuspendLayout();
            guna2Panel3.SuspendLayout();
            flpBody.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(461, 16);
            guna2HtmlLabel1.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(143, 47);
            guna2HtmlLabel1.TabIndex = 14;
            guna2HtmlLabel1.Text = "Interview";
            // 
            // lblJSeeker
            // 
            lblJSeeker.AutoSize = false;
            lblJSeeker.BackColor = Color.Transparent;
            lblJSeeker.Dock = DockStyle.Fill;
            lblJSeeker.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblJSeeker.Location = new Point(0, 0);
            lblJSeeker.Name = "lblJSeeker";
            lblJSeeker.Size = new Size(247, 34);
            lblJSeeker.TabIndex = 0;
            lblJSeeker.Text = "Name Jobseeker";
            lblJSeeker.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Dock = DockStyle.Fill;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(29, 0);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(101, 34);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Avatar";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblJSeeker);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(130, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 34);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2HtmlLabel2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 34);
            panel2.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(29, 34);
            panel7.TabIndex = 1;
            // 
            // lblJob
            // 
            lblJob.AutoSize = false;
            lblJob.BackColor = Color.Transparent;
            lblJob.Dock = DockStyle.Fill;
            lblJob.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblJob.Location = new Point(0, 0);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(318, 34);
            lblJob.TabIndex = 0;
            lblJob.Text = "Name Job";
            lblJob.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblJob);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(377, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 34);
            panel4.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.AutoSize = false;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(0, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(129, 34);
            lblTime.TabIndex = 0;
            lblTime.Text = "Interview";
            lblTime.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblTime);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(810, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(120, 34);
            panel5.TabIndex = 5;
            // 
            // lblTimeAdd
            // 
            lblTimeAdd.AutoSize = false;
            lblTimeAdd.BackColor = Color.Transparent;
            lblTimeAdd.Dock = DockStyle.Fill;
            lblTimeAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimeAdd.Location = new Point(0, 0);
            lblTimeAdd.Name = "lblTimeAdd";
            lblTimeAdd.Size = new Size(115, 34);
            lblTimeAdd.TabIndex = 0;
            lblTimeAdd.Text = "Date Add";
            lblTimeAdd.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblTimeAdd);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(695, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(115, 34);
            panel6.TabIndex = 6;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BackColor = Color.Transparent;
            guna2Panel4.BorderColor = Color.Black;
            guna2Panel4.BorderThickness = 1;
            guna2Panel4.Controls.Add(panel8);
            guna2Panel4.Controls.Add(panel5);
            guna2Panel4.Controls.Add(panel6);
            guna2Panel4.Controls.Add(panel4);
            guna2Panel4.Controls.Add(panel2);
            guna2Panel4.CustomizableEdges = customizableEdges1;
            guna2Panel4.Dock = DockStyle.Top;
            guna2Panel4.FillColor = Color.FromArgb(248, 212, 187);
            guna2Panel4.Location = new Point(0, 0);
            guna2Panel4.Margin = new Padding(0);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel4.ShadowDecoration.Depth = 15;
            guna2Panel4.Size = new Size(1036, 34);
            guna2Panel4.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(guna2HtmlLabel3);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(930, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(106, 34);
            panel8.TabIndex = 7;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.AutoSize = false;
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(0, 0);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(129, 34);
            guna2HtmlLabel3.TabIndex = 0;
            guna2HtmlLabel3.Text = "Status";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            guna2Panel3.AutoScroll = true;
            guna2Panel3.Controls.Add(flpBody);
            guna2Panel3.CustomizableEdges = customizableEdges3;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel3.Size = new Size(1095, 417);
            guna2Panel3.TabIndex = 1;
            // 
            // flpBody
            // 
            flpBody.BackColor = Color.Transparent;
            flpBody.Controls.Add(guna2Panel4);
            flpBody.Location = new Point(35, 31);
            flpBody.Name = "flpBody";
            flpBody.Size = new Size(1036, 47);
            flpBody.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.Controls.Add(guna2Panel3);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.FillColor = Color.MistyRose;
            guna2Panel1.Location = new Point(0, 257);
            guna2Panel1.Margin = new Padding(4, 3, 4, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.ShadowDecoration.Depth = 10;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.Size = new Size(1095, 417);
            guna2Panel1.TabIndex = 13;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 30;
            // 
            // mcpSchdule
            // 
            mcpSchdule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mcpSchdule.Location = new Point(415, 70);
            mcpSchdule.MaxSelectionCount = 1;
            mcpSchdule.Name = "mcpSchdule";
            mcpSchdule.TabIndex = 11;
            mcpSchdule.DateChanged += mcpSchdule_DateChanged;
            // 
            // FViewInterview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1095, 674);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2Panel1);
            Controls.Add(mcpSchdule);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FViewInterview";
            Text = "FViewInterview";
            Load += FViewInterview_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            guna2Panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            flpBody.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJSeeker;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Panel panel3;
        public Panel panel2;
        public Panel panel7;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJob;
        public Panel panel4;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        public Panel panel5;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTimeAdd;
        public Panel panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FlowLayoutPanel flpBody;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private MonthCalendar mcpSchdule;
        public Panel panel8;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}