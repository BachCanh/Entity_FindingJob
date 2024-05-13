using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Entity
{
    partial class UCExperience
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCExperience));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            rtxtAchieve = new ReaLTaiizor.Controls.HopeRichTextBox();
            btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            lblLocationAndPeriod = new Label();
            lblTitleAndCompany = new Label();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(rtxtAchieve);
            guna2ShadowPanel1.Controls.Add(btnDelete);
            guna2ShadowPanel1.Controls.Add(lblLocationAndPeriod);
            guna2ShadowPanel1.Controls.Add(lblTitleAndCompany);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(695, 151);
            guna2ShadowPanel1.TabIndex = 0;
            guna2ShadowPanel1.Click += guna2ShadowPanel1_Click;
            // 
            // rtxtAchieve
            // 
            rtxtAchieve.BorderColor = Color.FromArgb(220, 223, 230);
            rtxtAchieve.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtAchieve.ForeColor = Color.FromArgb(48, 49, 51);
            rtxtAchieve.Hint = "";
            rtxtAchieve.HoverBorderColor = Color.FromArgb(64, 158, 255);
            rtxtAchieve.Location = new Point(19, 61);
            rtxtAchieve.MaxLength = 32767;
            rtxtAchieve.Multiline = true;
            rtxtAchieve.Name = "rtxtAchieve";
            rtxtAchieve.PasswordChar = '\0';
            rtxtAchieve.ScrollBars = ScrollBars.None;
            rtxtAchieve.SelectedText = "";
            rtxtAchieve.SelectionLength = 0;
            rtxtAchieve.SelectionStart = 0;
            rtxtAchieve.Size = new Size(656, 46);
            rtxtAchieve.TabIndex = 104;
            rtxtAchieve.TabStop = false;
            rtxtAchieve.UseSystemPasswordChar = false;
            rtxtAchieve.Click += guna2ShadowPanel1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(224, 224, 224);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageSize = new Size(24, 24);
            btnDelete.Location = new Point(640, 8);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDelete.Size = new Size(35, 30);
            btnDelete.TabIndex = 103;
            // 
            // lblLocationAndPeriod
            // 
            lblLocationAndPeriod.AutoSize = true;
            lblLocationAndPeriod.BackColor = Color.White;
            lblLocationAndPeriod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationAndPeriod.ForeColor = Color.Gray;
            lblLocationAndPeriod.Location = new Point(19, 39);
            lblLocationAndPeriod.Name = "lblLocationAndPeriod";
            lblLocationAndPeriod.Size = new Size(207, 19);
            lblLocationAndPeriod.TabIndex = 102;
            lblLocationAndPeriod.Text = "Location - (StartDate - EndDate)";
            lblLocationAndPeriod.Click += guna2ShadowPanel1_Click;
            // 
            // lblTitleAndCompany
            // 
            lblTitleAndCompany.AutoSize = true;
            lblTitleAndCompany.BackColor = Color.White;
            lblTitleAndCompany.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleAndCompany.ForeColor = SystemColors.ControlText;
            lblTitleAndCompany.Location = new Point(19, 8);
            lblTitleAndCompany.Name = "lblTitleAndCompany";
            lblTitleAndCompany.Size = new Size(196, 31);
            lblTitleAndCompany.TabIndex = 101;
            lblTitleAndCompany.Text = "Title, Company";
            lblTitleAndCompany.Click += guna2ShadowPanel1_Click;
            // 
            // UCExperience
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCExperience";
            Size = new Size(695, 151);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private ReaLTaiizor.Controls.HopeRichTextBox rtxtAchieve;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Label lblLocationAndPeriod;
        private Label lblTitleAndCompany;
    }
}
