using System.Drawing;
using System.Windows.Forms;
namespace Entity
{
    partial class FPostJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPostJob));
            this.pnBody = new System.Windows.Forms.Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnPostingJob = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.pnSubBody = new System.Windows.Forms.FlowLayoutPanel();
            this.lblListJobs = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.AutoSize = true;
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.btnReload);
            this.pnBody.Controls.Add(this.btnPostingJob);
            this.pnBody.Controls.Add(this.btnFilter);
            this.pnBody.Controls.Add(this.pnSubBody);
            this.pnBody.Controls.Add(this.lblListJobs);
            this.pnBody.Controls.Add(this.txtSearch);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1233, 677);
            this.pnBody.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageRotate = 0F;
            this.btnReload.Location = new System.Drawing.Point(1138, 84);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.Size = new System.Drawing.Size(46, 43);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload.TabIndex = 47;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnPostingJob
            // 
            this.btnPostingJob.BackColor = System.Drawing.Color.Transparent;
            this.btnPostingJob.BorderRadius = 23;
            this.btnPostingJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostingJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostingJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostingJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostingJob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnPostingJob.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPostingJob.ForeColor = System.Drawing.Color.Black;
            this.btnPostingJob.HoverState.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPostingJob.Location = new System.Drawing.Point(1003, 31);
            this.btnPostingJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostingJob.Name = "btnPostingJob";
            this.btnPostingJob.Size = new System.Drawing.Size(197, 41);
            this.btnPostingJob.TabIndex = 46;
            this.btnPostingJob.Text = "Posting a Job";
            this.btnPostingJob.Click += new System.EventHandler(this.btnPostingJob_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderRadius = 15;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnFilter.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.HoverState.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(999, 89);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(121, 38);
            this.btnFilter.TabIndex = 45;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pnSubBody
            // 
            this.pnSubBody.Location = new System.Drawing.Point(69, 145);
            this.pnSubBody.Name = "pnSubBody";
            this.pnSubBody.Size = new System.Drawing.Size(1143, 221);
            this.pnSubBody.TabIndex = 4;
            // 
            // lblListJobs
            // 
            this.lblListJobs.AutoSize = true;
            this.lblListJobs.BackColor = System.Drawing.Color.White;
            this.lblListJobs.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblListJobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListJobs.Location = new System.Drawing.Point(53, 31);
            this.lblListJobs.Name = "lblListJobs";
            this.lblListJobs.Size = new System.Drawing.Size(348, 42);
            this.lblListJobs.TabIndex = 3;
            this.lblListJobs.Text = "List Of Current Jobs";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 18;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(69, 89);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search for jobs";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(922, 38);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // FPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1233, 677);
            this.Controls.Add(this.pnBody);
            this.Name = "FPostJob";
            this.Text = "PostJob";
            this.Load += new System.EventHandler(this.PostJob_Load);
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnBody;
        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnPostingJob;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnReload;
    }
}