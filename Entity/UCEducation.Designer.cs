using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Entity
{
    partial class UCEducation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEducation));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            rtxtDescription = new ReaLTaiizor.Controls.HopeRichTextBox();
            btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            lblLocationAndPeriod = new Label();
            lblDegreeAndSchool = new Label();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(rtxtDescription);
            guna2ShadowPanel1.Controls.Add(btnDelete);
            guna2ShadowPanel1.Controls.Add(lblLocationAndPeriod);
            guna2ShadowPanel1.Controls.Add(lblDegreeAndSchool);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Margin = new Padding(0);
            guna2ShadowPanel1.MaximumSize = new Size(695, 151);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(695, 151);
            guna2ShadowPanel1.TabIndex = 0;
            guna2ShadowPanel1.Click += guna2ShadowPanel1_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.BorderColor = Color.FromArgb(220, 223, 230);
            rtxtDescription.Enabled = false;
            rtxtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtDescription.ForeColor = Color.FromArgb(48, 49, 51);
            rtxtDescription.Hint = "";
            rtxtDescription.HoverBorderColor = Color.FromArgb(64, 158, 255);
            rtxtDescription.Location = new Point(19, 60);
            rtxtDescription.MaxLength = 32767;
            rtxtDescription.Multiline = true;
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.PasswordChar = '\0';
            rtxtDescription.ScrollBars = ScrollBars.None;
            rtxtDescription.SelectedText = "";
            rtxtDescription.SelectionLength = 0;
            rtxtDescription.SelectionStart = 0;
            rtxtDescription.Size = new Size(656, 46);
            rtxtDescription.TabIndex = 107;
            rtxtDescription.TabStop = false;
            rtxtDescription.UseSystemPasswordChar = false;
            rtxtDescription.Click += guna2ShadowPanel1_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(224, 224, 224);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageSize = new Size(24, 24);
            btnDelete.Location = new Point(640, 9);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDelete.Size = new Size(35, 30);
            btnDelete.TabIndex = 106;
            // 
            // lblLocationAndPeriod
            // 
            lblLocationAndPeriod.AutoSize = true;
            lblLocationAndPeriod.BackColor = Color.White;
            lblLocationAndPeriod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationAndPeriod.ForeColor = Color.Gray;
            lblLocationAndPeriod.Location = new Point(19, 38);
            lblLocationAndPeriod.Name = "lblLocationAndPeriod";
            lblLocationAndPeriod.Size = new Size(207, 19);
            lblLocationAndPeriod.TabIndex = 105;
            lblLocationAndPeriod.Text = "Location - (StartDate - EndDate)";
            lblLocationAndPeriod.Click += guna2ShadowPanel1_Click;
            // 
            // lblDegreeAndSchool
            // 
            lblDegreeAndSchool.AutoSize = true;
            lblDegreeAndSchool.BackColor = Color.White;
            lblDegreeAndSchool.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDegreeAndSchool.ForeColor = SystemColors.ControlText;
            lblDegreeAndSchool.Location = new Point(19, 6);
            lblDegreeAndSchool.Name = "lblDegreeAndSchool";
            lblDegreeAndSchool.Size = new Size(187, 31);
            lblDegreeAndSchool.TabIndex = 104;
            lblDegreeAndSchool.Text = "Degree, School";
            lblDegreeAndSchool.Click += guna2ShadowPanel1_Click;
            // 
            // UCEducation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(695, 151);
            Name = "UCEducation";
            Size = new Size(695, 151);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private ReaLTaiizor.Controls.HopeRichTextBox rtxtDescription;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Label lblLocationAndPeriod;
        private Label lblDegreeAndSchool;
    }
}
