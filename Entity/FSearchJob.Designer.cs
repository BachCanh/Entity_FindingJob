using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Entity
{
    partial class FSearchJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSearchJob));
            this.flpJob = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnReload = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.SuspendLayout();
            // 
            // flpJob
            // 
            this.flpJob.Location = new System.Drawing.Point(42, 119);
            this.flpJob.Name = "flpJob";
            this.flpJob.Size = new System.Drawing.Size(861, 10);
            this.flpJob.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnFilter.ButtonImage = null;
            this.btnFilter.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(180)))));
            this.btnFilter.ClickTextColor = System.Drawing.Color.Black;
            this.btnFilter.CornerRadius = 6;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFilter.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.btnFilter.HoverTextColor = System.Drawing.Color.Black;
            this.btnFilter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnFilter.Location = new System.Drawing.Point(709, 23);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(83, 31);
            this.btnFilter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFilter.TabIndex = 36;
            this.btnFilter.TextColor = System.Drawing.Color.Black;
            this.btnFilter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnFilter.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 14;
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
            this.txtSearch.Location = new System.Drawing.Point(84, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search for jobs";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(609, 31);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 17;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(18, 504);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 36);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            // 
            // btnNext
            // 
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BorderRadius = 17;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(160, 504);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 36);
            this.btnNext.TabIndex = 40;
            this.btnNext.Text = "Next";
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageRotate = 0F;
            this.btnReload.Location = new System.Drawing.Point(806, 19);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.Size = new System.Drawing.Size(34, 35);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload.TabIndex = 48;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FSearchJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 550);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.flpJob);
            this.Name = "FSearchJob";
            this.Text = "FSearchJob";
            this.Load += new System.EventHandler(this.FSearchJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flpJob;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnReload;
    }
}